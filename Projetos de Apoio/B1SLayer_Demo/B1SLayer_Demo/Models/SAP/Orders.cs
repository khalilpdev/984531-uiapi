using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1SLayer_Demo.Models.SAP
{
    public class Orders // Estrutura de retorno que vem em value
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Nullable<int> DocEntry { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int DocNum { get; set; }
        public string CardCode { get; set; }
        public Nullable<int> BPL_IDAssignedToInvoice { get; set; }
        public string DocType { get; set; }
        public DateTime DocDate { get; set; }
        public Nullable<DateTime> DocDueDate { get; set; }  /* Data de vencimento da parcela de adiantamento. Documentos de adiantamento possuem apenas uma parcela, portanto, um vencimento. */
        public string NumAtCard { get; set; }
        // public string Comments { get; set; } // Se paga, informar (PAGA + YYYY-MM-DD da data do pagamento)
        // public int GroupNum { get; set; }   // From PaymentTermsTypes, informar -2
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ControlAccount { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Decimal DocTotal { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Comments { get; set; }

        public List<modelOrdersItemsLines> DocumentLines { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public DateTime UpdateTime { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentStatus { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string JournalMemo { get; set; }

    }
    public class modelOrdersItemsLines
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Nullable<int> DocEntry { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public Nullable<int> LineNum { get; set; }
        public string ItemCode { get; set; }            // Código do Ítem, o mesmo que foi utilizado no Contrato Guarda-chuva

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string ItemDescription { get; set; }     // Pode não ser o mesmo do ItemCode

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string FreeText { get; set; }
        public double Quantity { get; set; }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Decimal Price { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Decimal UnitPrice { get; set; }
        // public double DiscountPercent { get; set; }
        // public double LineTotal { get; set; }

        public int Usage { get; set; }
        // public string WarehouseCode { get; set; }

        //[JsonProperty(NullValueHandling = NullValueHandling.Ignore)] // removido  temporariamente.
        public Nullable<int> AgreementNo { get; set; }
        public Nullable<int> AgreementRowNumber { get; set; }
        public Nullable<int> U_BookingId { get; set; }

        // Equivale ao campo Price
        // Preço antes do desconto. O SAP trabalha com até 6 casa decimais em valores tipo Numeric. 
        // Porém o comportamento do campo depende de como a base de dados foi configuração nas “Configurações Gerais”.
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Decimal PriceBefDi { get; set; }


        // Equivale o campo DiscountPercent
        // Percentual de desconto da linha. O SAP trabalha com até 6 casa decimais em valores tipo Numeric. 
        // Porém o comportamento do campo depende de como a base de dados foi configuração nas “Configurações Gerais”.
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Decimal DiscPrcnt { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Decimal LineTotal { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string WarehouseCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Nullable<int> BaseLine { get; set; }


        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string U_TypeId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CostingCode { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string LineStatus { get; set; }

    }

}

