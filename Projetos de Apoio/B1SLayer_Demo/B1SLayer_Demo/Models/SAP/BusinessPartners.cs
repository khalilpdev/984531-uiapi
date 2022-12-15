using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1SLayer_Demo.Models.SAP
{
    class BusinessPartners
    {
        public string CardCode { get; set; }    
        public string CardType { get; set; }    
        public string CardName { get; set; }    
        public string CardForeignName { get; set; }
        public Nullable<int> GroupCode { get; set; }
        public string Phone1 { get; set; }  // Telefone 
        public string Phone2 { get; set; }  // Telefone
        public string Cellular { get; set; } // Celular
        public string EmailAddress { get; set; } // Email
        public string Valid { get; set; } // Fixo tYES
        public string Frozen { get; set; }  // Fixo tNO
        public string ZipCode { get; set; } // CEP
        public string MailZipCode { get; set; } // CEP
        public List<modelBPAddresses> BPAddresses { get; set; } // Lista de endereços
        public List<modelContactEmployees> ContactEmployees { get; set; }   // Dados de Contato
        public List<modelBPFiscalTaxIDCollection> BPFiscalTaxIDCollection { get; set; } // Dados fiscais
        public List<modelBPBankAccounts> BPBankAccounts { get; set; }
        public string ShipToDefault { get; set; }
        public string BilltoDefault { get; set; }


        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Nullable<int> CreditCardCode { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string CreditCardNum { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Nullable<DateTime> CreditCardExpiration { get; set; }



        public Nullable<DateTime> RelationshipDateFrom { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Nullable<DateTime> RelationshipDateTill { get; set; }

        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public string U_SBZ_CodCart { get; set; }
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public string U_SBZ_DACliEmp { get; set; }
        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        //public string U_SBZ_DACliBco { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultAccount { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBranch { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultBankCode { get; set; }
    }

    public class modelBPAddresses // Equivale aos dados de endereço
    {
        public string AddressName { get; set; }  // "Cobrança" ou "Correspondência"
        public string Street { get; set; }  // Logradouro
        public string Block { get; set; }   // Bairro
        public string ZipCode { get; set; } // CEP
        public string City { get; set; }    // Cidade
        public Nullable<int> County { get; set; }  // Municipio
        public string Country { get; set; } // Fixo "BR"
        public string State { get; set; }   // UF
        public string BuildingFloorRoom { get; set; }   // Complemento do Endereço
        public string AddressType { get; set; }     // bo_BillTo ou bo_ShipTo
        public string AddressName2 { get; set; }    // Não atribuido
        public string AddressName3 { get; set; }    // Não atribuido
        public string TypeOfAddress { get; set; }   // Não atribuido
        public string StreetNo { get; set; }        // Não atribuido
        public string BPCode { get; set; }          // Mesmo código do CardCode
        public int RowNum { get; set; }             // 1
        public string U_SKILL_indIEDest { get; set; } // 2
    }

    public class modelBPFiscalTaxIDCollection // Equivale aos dados de CPF e CNPJ
    {
        public string Address { get; set; }     // "Cobrança"
        public string BPCode { get; set; }      // Mesmo código do CardCode
        public string TaxId0 { get; set; }      // CNPJ
        public string TaxId4 { get; set; }      // CPF
        public string TaxId1 { get; set; }
    }

    public class modelContactEmployees // Equivale aos contatos da pessoa física ou jurídica - Preenchido apenas para Hotéis
    {
        public string CardCode { get; set; }    // Chave do Bussiness Partnet
        public string Name { get; set; }        // Cargo do contato na Montreal
        public string FirstName { get; set; }   // Primeiro nome do contato
        public string MiddleName { get; set; }  // Não atribuido
        public string LastName { get; set; }    // Último nome do contato
        public string PlaceOfBirth { get; set; }    // Não atribuido
        public string DateOfBirth { get; set; }     // Não atribuido
        public string Gender { get; set; }          // Não atribuido
        public string Profession { get; set; }      // Não atribuido
        public string CityOfBirth { get; set; }     // Não atribuido
        public string Phone1 { get; set; }          // Telefone do contato
        public string Phone2 { get; set; }          // Telefone do contato
        public string E_Mail { get; set; }          // Email
        public string Position { get; set; }        // Cargo do contato
        public string MobilePhone { get; set; }     // Não atribuido
        public string Active { get; set; }          // Fixo tYES
        public int InternalCode { get; set; }       // Não atribuido
    }

    public class modelBPBankAccounts // Equivale às contas correntes da pessoa física ou jurídica
    {
        public string BPCode { get; set; }      // Código do cliente ou hotel
        public string BankCode { get; set; }    // Código do Banco (verificar em Banks)
        public string AccountNo { get; set; }   // Número da conta corrente

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ControlKey { get; set; }  // Dígito Verificador da conta corrente
        public string Branch { get; set; }      // Agência

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string BranchChk { get; set; }   // Dígito verificador da agência
        public string AccountName { get; set; } // Nome da conta para identificação

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }
    }

}
