namespace UserFieldCreate
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnCriarCampo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboVersaoSql = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtServidorLicenca = new System.Windows.Forms.TextBox();
            this.txtCompanyDb = new System.Windows.Forms.TextBox();
            this.txtUsuarioBanco = new System.Windows.Forms.TextBox();
            this.txtSenhaBanco = new System.Windows.Forms.TextBox();
            this.txtSenhaSap = new System.Windows.Forms.TextBox();
            this.txtUsuarioSap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTabelaSap = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeDoCampo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtTamanhoDoCampo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboSubTipo = new System.Windows.Forms.ComboBox();
            this.chkValorValido = new System.Windows.Forms.CheckBox();
            this.cboValorValido = new System.Windows.Forms.ComboBox();
            this.btnRemoverCampo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConectar.Location = new System.Drawing.Point(12, 258);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnCriarCampo
            // 
            this.btnCriarCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCriarCampo.Location = new System.Drawing.Point(574, 258);
            this.btnCriarCampo.Name = "btnCriarCampo";
            this.btnCriarCampo.Size = new System.Drawing.Size(100, 23);
            this.btnCriarCampo.TabIndex = 1;
            this.btnCriarCampo.Text = "Criar Campo";
            this.btnCriarCampo.UseVisualStyleBackColor = true;
            this.btnCriarCampo.Click += new System.EventHandler(this.btnCriarCampo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Servidor de Licença";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Banco SAP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Usuario Banco";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Senha Banco";
            // 
            // cboVersaoSql
            // 
            this.cboVersaoSql.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVersaoSql.FormattingEnabled = true;
            this.cboVersaoSql.Items.AddRange(new object[] {
            "2005",
            "2008",
            "2012",
            "2014",
            "2016",
            "2017",
            "2019",
            "HANA"});
            this.cboVersaoSql.Location = new System.Drawing.Point(126, 111);
            this.cboVersaoSql.Name = "cboVersaoSql";
            this.cboVersaoSql.Size = new System.Drawing.Size(176, 21);
            this.cboVersaoSql.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Versão do SQL";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(126, 29);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(176, 20);
            this.txtServidor.TabIndex = 9;
            this.txtServidor.Text = "LEANDROKHALIL";
            // 
            // txtServidorLicenca
            // 
            this.txtServidorLicenca.Location = new System.Drawing.Point(126, 55);
            this.txtServidorLicenca.Name = "txtServidorLicenca";
            this.txtServidorLicenca.Size = new System.Drawing.Size(176, 20);
            this.txtServidorLicenca.TabIndex = 10;
            this.txtServidorLicenca.Text = "LEANDROKHALIL:30000";
            // 
            // txtCompanyDb
            // 
            this.txtCompanyDb.Location = new System.Drawing.Point(126, 83);
            this.txtCompanyDb.Name = "txtCompanyDb";
            this.txtCompanyDb.Size = new System.Drawing.Size(176, 20);
            this.txtCompanyDb.TabIndex = 11;
            this.txtCompanyDb.Text = "DEMOBR";
            // 
            // txtUsuarioBanco
            // 
            this.txtUsuarioBanco.Location = new System.Drawing.Point(126, 140);
            this.txtUsuarioBanco.Name = "txtUsuarioBanco";
            this.txtUsuarioBanco.Size = new System.Drawing.Size(176, 20);
            this.txtUsuarioBanco.TabIndex = 12;
            this.txtUsuarioBanco.Text = "sa";
            // 
            // txtSenhaBanco
            // 
            this.txtSenhaBanco.Location = new System.Drawing.Point(126, 168);
            this.txtSenhaBanco.Name = "txtSenhaBanco";
            this.txtSenhaBanco.PasswordChar = '*';
            this.txtSenhaBanco.Size = new System.Drawing.Size(176, 20);
            this.txtSenhaBanco.TabIndex = 13;
            this.txtSenhaBanco.Text = "sap@123";
            // 
            // txtSenhaSap
            // 
            this.txtSenhaSap.Location = new System.Drawing.Point(126, 222);
            this.txtSenhaSap.Name = "txtSenhaSap";
            this.txtSenhaSap.PasswordChar = '*';
            this.txtSenhaSap.Size = new System.Drawing.Size(176, 20);
            this.txtSenhaSap.TabIndex = 17;
            this.txtSenhaSap.Text = "mana";
            // 
            // txtUsuarioSap
            // 
            this.txtUsuarioSap.Location = new System.Drawing.Point(126, 194);
            this.txtUsuarioSap.Name = "txtUsuarioSap";
            this.txtUsuarioSap.Size = new System.Drawing.Size(176, 20);
            this.txtUsuarioSap.TabIndex = 16;
            this.txtUsuarioSap.Text = "manager";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Senha SAP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Usuario SAP\r\n";
            // 
            // txtTabelaSap
            // 
            this.txtTabelaSap.Location = new System.Drawing.Point(498, 29);
            this.txtTabelaSap.Name = "txtTabelaSap";
            this.txtTabelaSap.Size = new System.Drawing.Size(176, 20);
            this.txtTabelaSap.TabIndex = 19;
            this.txtTabelaSap.Text = "OSTC";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(361, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tabela SAP";
            // 
            // txtNomeDoCampo
            // 
            this.txtNomeDoCampo.Location = new System.Drawing.Point(498, 58);
            this.txtNomeDoCampo.Name = "txtNomeDoCampo";
            this.txtNomeDoCampo.Size = new System.Drawing.Size(176, 20);
            this.txtNomeDoCampo.TabIndex = 21;
            this.txtNomeDoCampo.Text = "Tipo_Frete";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nome do Campo (sem U_)";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(498, 86);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(176, 20);
            this.txtDescricao.TabIndex = 23;
            this.txtDescricao.Text = "Tipo de Frete";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Descrição";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Tipo";
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "0=db_Alpha",
            "1=db_Memo",
            "2=db_Numeric",
            "3=db_Date",
            "4=db_Float"});
            this.cboTipo.Location = new System.Drawing.Point(498, 111);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(176, 21);
            this.cboTipo.TabIndex = 24;
            // 
            // txtTamanhoDoCampo
            // 
            this.txtTamanhoDoCampo.Location = new System.Drawing.Point(498, 165);
            this.txtTamanhoDoCampo.Name = "txtTamanhoDoCampo";
            this.txtTamanhoDoCampo.Size = new System.Drawing.Size(176, 20);
            this.txtTamanhoDoCampo.TabIndex = 27;
            this.txtTamanhoDoCampo.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(325, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Tamanho do Campo (se for alpha)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(361, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Sub-Tipo";
            // 
            // cboSubTipo
            // 
            this.cboSubTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubTipo.FormattingEnabled = true;
            this.cboSubTipo.Items.AddRange(new object[] {
            "0  = st_None",
            "35 = st_Phone",
            "37 = st_Percentage",
            "63 = st_Address",
            "66 = st_Link",
            "73 = st_Image",
            "77 = st_Measurement",
            "80 = st_Price",
            "81 = st_Quantity",
            "82 = st_Rate",
            "83 = st_Sum",
            "84 = st_Time"});
            this.cboSubTipo.Location = new System.Drawing.Point(498, 138);
            this.cboSubTipo.Name = "cboSubTipo";
            this.cboSubTipo.Size = new System.Drawing.Size(176, 21);
            this.cboSubTipo.TabIndex = 28;
            // 
            // chkValorValido
            // 
            this.chkValorValido.AutoSize = true;
            this.chkValorValido.Checked = true;
            this.chkValorValido.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkValorValido.Location = new System.Drawing.Point(364, 221);
            this.chkValorValido.Name = "chkValorValido";
            this.chkValorValido.Size = new System.Drawing.Size(152, 17);
            this.chkValorValido.TabIndex = 30;
            this.chkValorValido.Text = "Valor Valido (S-Sim,N-Não)";
            this.chkValorValido.UseVisualStyleBackColor = true;
            // 
            // cboValorValido
            // 
            this.cboValorValido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboValorValido.FormattingEnabled = true;
            this.cboValorValido.Items.AddRange(new object[] {
            "N",
            "S"});
            this.cboValorValido.Location = new System.Drawing.Point(522, 217);
            this.cboValorValido.Name = "cboValorValido";
            this.cboValorValido.Size = new System.Drawing.Size(152, 21);
            this.cboValorValido.TabIndex = 31;
            // 
            // btnRemoverCampo
            // 
            this.btnRemoverCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoverCampo.Location = new System.Drawing.Point(364, 258);
            this.btnRemoverCampo.Name = "btnRemoverCampo";
            this.btnRemoverCampo.Size = new System.Drawing.Size(100, 23);
            this.btnRemoverCampo.TabIndex = 32;
            this.btnRemoverCampo.Text = "Remover Campo";
            this.btnRemoverCampo.UseVisualStyleBackColor = true;
            this.btnRemoverCampo.Click += new System.EventHandler(this.btnRemoverCampo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 293);
            this.Controls.Add(this.btnRemoverCampo);
            this.Controls.Add(this.cboValorValido);
            this.Controls.Add(this.chkValorValido);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cboSubTipo);
            this.Controls.Add(this.txtTamanhoDoCampo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNomeDoCampo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTabelaSap);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSenhaSap);
            this.Controls.Add(this.txtUsuarioSap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSenhaBanco);
            this.Controls.Add(this.txtUsuarioBanco);
            this.Controls.Add(this.txtCompanyDb);
            this.Controls.Add(this.txtServidorLicenca);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboVersaoSql);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriarCampo);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar campo de Usuário no SAP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnCriarCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboVersaoSql;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtServidorLicenca;
        private System.Windows.Forms.TextBox txtCompanyDb;
        private System.Windows.Forms.TextBox txtUsuarioBanco;
        private System.Windows.Forms.TextBox txtSenhaBanco;
        private System.Windows.Forms.TextBox txtSenhaSap;
        private System.Windows.Forms.TextBox txtUsuarioSap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTabelaSap;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeDoCampo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.TextBox txtTamanhoDoCampo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboSubTipo;
        private System.Windows.Forms.CheckBox chkValorValido;
        private System.Windows.Forms.ComboBox cboValorValido;
        private System.Windows.Forms.Button btnRemoverCampo;
    }
}

