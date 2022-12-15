using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1SLayer_Demo.Models.VTEX
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    public class InvoiceAddClass
    {
        [JsonProperty("Invoice")]
        public Invoice Invoice { get; set; }
    }

    public class Invoice
    {
        [JsonProperty("InvoiceInfo")]
        public List<InvoiceInfo> InvoiceInfo { get; set; }
    }

    public class InvoiceIten
    {
        [JsonProperty("ItemCode")]
        public string ItemCode { get; set; }

        [JsonProperty("Quantity")]
        public int Quantity { get; set; }

        [JsonProperty("Price")]
        public int Price { get; set; }

        [JsonProperty("LineTotal")]
        public int LineTotal { get; set; }

        [JsonProperty("utilizacao")]
        public string Utilizacao { get; set; }
    }

    public class Payments
    {
        [JsonProperty("GroupNum")]
        public int GroupNum { get; set; }

        [JsonProperty("PaymentsMethod")]
        public string PaymentsMethod { get; set; }
    }

    public class InvoiceInfo
    {
        [JsonProperty("DocumentType")]
        public string DocumentType { get; set; }

        [JsonProperty("DocDate")]
        public DateTime DocDate { get; set; }

        [JsonProperty("docduedate")]
        public DateTime DocDueDate { get; set; }

        [JsonProperty("Note")]
        public string Note { get; set; }

        [JsonProperty("Emitida")]
        public string Emitida { get; set; }

        [JsonProperty("idexterno")]
        public string Idexterno { get; set; }

        [JsonProperty("bplid")]
        public int Bplid { get; set; }

        [JsonProperty("Projeto")]
        public string Projeto { get; set; }

        [JsonProperty("InvoiceItens")]
        public List<InvoiceIten> InvoiceItens { get; set; }

        [JsonProperty("Payments")]
        public Payments Payments { get; set; }
    }

    


}
