using SAPbobsCOM;
using System;
using System.Windows.Forms;

namespace UserFieldCreate
{
    public partial class Form1 : Form
    {
        private Company _conSap;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cboVersaoSql.Text))
                    throw new Exception("selecionar o tipo do banco de dados");

                BoDataServerTypes serverType;
                if (cboVersaoSql.Text.Trim() == "HANA")
                    serverType = BoDataServerTypes.dst_HANADB;
                else
                    serverType = GetServerType(Convert.ToInt32(cboVersaoSql.Text));

                _conSap = new SAPbobsCOM.Company
                {
                    Server = txtServidor.Text.Trim(),
                    LicenseServer = txtServidorLicenca.Text.Trim(),
                    CompanyDB = txtCompanyDb.Text.Trim(),
                    DbUserName = txtUsuarioBanco.Text.Trim(),
                    DbPassword = txtSenhaBanco.Text,
                    DbServerType = serverType,
                    UseTrusted = false,
                    UserName = txtUsuarioSap.Text.Trim(),
                    Password = txtSenhaSap.Text,
                    language = BoSuppLangs.ln_Portuguese_Br
                };

                if (_conSap.Connect() != 0)
                {
                    var errorMsg = "Erro ao efetuar conexão com o SAP: " + _conSap.GetLastErrorDescription();
                    throw new Exception(errorMsg);
                }
                else
                    btnConectar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private BoDataServerTypes GetServerType(int sqlVersion)
        {
            switch (sqlVersion)
            {
                case 2005: return BoDataServerTypes.dst_MSSQL2005;
                case 2008: return BoDataServerTypes.dst_MSSQL2008;
                case 2012: return BoDataServerTypes.dst_MSSQL2012;
                case 2014: return BoDataServerTypes.dst_MSSQL2014;
                case 2016: return BoDataServerTypes.dst_MSSQL2016;
                case 2017: return BoDataServerTypes.dst_MSSQL2017;
                case 2019: return BoDataServerTypes.dst_MSSQL2019;
                default:
                    return BoDataServerTypes.dst_MSSQL2014;
            }
        }

        private void btnCriarCampo_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConectar.Enabled)
                    throw new Exception("Conectar na empresa.");

                long retVal;

                UserFieldsMD userfield = (UserFieldsMD)_conSap.GetBusinessObject(BoObjectTypes.oUserFields);
                userfield.TableName = txtTabelaSap.Text.Trim();

                userfield.Name = txtNomeDoCampo.Text.Trim(); // sem o U_
                userfield.Description = txtDescricao.Text.Trim();

                if (string.IsNullOrWhiteSpace(cboTipo.Text))
                    throw new Exception("selecionar o tipo do campo de usuário.");

                var tipo = cboTipo.Text.Substring(0, 1);
                var type = (BoFieldTypes)Convert.ToInt32(tipo);

                userfield.Type = type;

                if (!string.IsNullOrWhiteSpace(cboSubTipo.Text))
                {
                    var subTipo = cboSubTipo.Text.Substring(0, 2).Trim();

                    var subType = (BoFldSubTypes)Convert.ToInt32(subTipo);
                    if (subType != BoFldSubTypes.st_None)
                        userfield.SubType = subType;
                }

                int size;
                int.TryParse(txtTamanhoDoCampo.Text, out size);

                if (size > 0)
                    userfield.Size = size;

                if (chkValorValido.Checked)
                {
                    userfield.ValidValues.Value = "N";
                    userfield.ValidValues.Description = "Não";
                    userfield.ValidValues.Add();

                    userfield.ValidValues.Value = "S";
                    userfield.ValidValues.Description = "Sim";

                    if (string.IsNullOrWhiteSpace(cboValorValido.Text))
                        throw new Exception("selecionar o valor padrão para o campo de usuário");

                    userfield.DefaultValue = cboValorValido.Text;
                }

                // adiciona o campo
                retVal = userfield.Add();

                if (retVal != 0)
                {
                    MessageBox.Show(_conSap.GetLastErrorCode() + " - " + _conSap.GetLastErrorDescription(), "Aviso");
                }
                else
                {
                    MessageBox.Show($"Campo {userfield.Name} criado com sucesso na tabela {userfield.TableName} na empresa {_conSap.CompanyDB}.", "Aviso");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnRemoverCampo_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConectar.Enabled)
                    throw new Exception("Conectar na empresa.");

                long retVal;

                UserFieldsMD userfield = (UserFieldsMD)_conSap.GetBusinessObject(BoObjectTypes.oUserFields);
                var tableName = txtTabelaSap.Text.Trim();
                var fieldName = txtNomeDoCampo.Text.Trim(); // sem o U_

                if (string.IsNullOrWhiteSpace(tableName))
                    throw new Exception("Informe o nome da tabela.");

                if (string.IsNullOrWhiteSpace(fieldName))
                    throw new Exception("Informe o nome do campo sem U_.");

                var fieldId = GetFieldId(tableName, fieldName);

                if (userfield.GetByKey(tableName, fieldId))
                {
                    retVal = userfield.Remove();

                    if (retVal != 0)
                    {
                        MessageBox.Show(_conSap.GetLastErrorCode() + " - " + _conSap.GetLastErrorDescription(), "Aviso");
                    }
                    else
                    {
                        MessageBox.Show($"Campo {userfield.Name} removido com sucesso na tabela {userfield.TableName} na empresa {_conSap.CompanyDB}.", "Aviso");
                    }
                }
                else
                {
                    throw new Exception("Campo não encontrado.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private int GetFieldId(string tableName, string fieldName)
        {
            var querySQL = $"Select top 1 FieldID from CUFD where TableId = '{tableName}' and AliasId = '{fieldName}'";
            var queryHANA = $"SELECT TOP 1 \"FieldID\" FROM CUFD WHERE \"TableId\" = '{tableName}' AND \"AliasId\" = '{fieldName}';";

            string query;
            if (cboVersaoSql.Text.Trim() == "HANA")
                query = queryHANA;
            else
                query = querySQL;

            string result = string.Empty;

            var rs = (SAPbobsCOM.Recordset)_conSap.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);

            rs.DoQuery(query);

            result = rs.Fields.Item(0).Value.ToString();

            System.Runtime.InteropServices.Marshal.ReleaseComObject(rs);
            rs = null;
            GC.Collect();

            if (string.IsNullOrWhiteSpace(result))
                throw new Exception("Campo não existe na tabela.");

            return Convert.ToInt32(result);
        }
    }
}
