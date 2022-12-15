using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1SLayer_Demo.Models.VTEX
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class InvoiceGetClass
    {
        [JsonProperty("docentry")]
        public int DocEntry { get; set; }

        [JsonProperty("rps")]
        public int Rps { get; set; }

        [JsonProperty("seriestr")]
        public string Seriestr { get; set; }

        [JsonProperty("docdate")]
        public DateTime DocDate { get; set; }

        [JsonProperty("nfdate")]
        public object NfDate { get; set; }

        [JsonProperty("cardcode")]
        public string CardCode { get; set; }

        [JsonProperty("bplid")]
        public string Bplid { get; set; }

        [JsonProperty("doctotal")]
        public double DocTotal { get; set; }

        [JsonProperty("totalRet")]
        public double TotalRet { get; set; }

        [JsonProperty("vlrLiq")]
        public double VlrLiq { get; set; }

        [JsonProperty("statusnfe")]
        public string StatusNfe { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("keynfe")]
        public string KeyNfe { get; set; }

        [JsonProperty("nf")]
        public string Nf { get; set; }

        [JsonProperty("docstatus")]
        public string DocStatus { get; set; }

        [JsonProperty("hist")]
        public string Hist { get; set; }

        [JsonProperty("pis")]
        public double Pis { get; set; }

        [JsonProperty("cofins")]
        public double Cofins { get; set; }

        [JsonProperty("irrf")]
        public double Irrf { get; set; }

        [JsonProperty("csll")]
        public double Csll { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("msg")]
        public object Msg { get; set; }

        [JsonProperty("emitida")]
        public string Emitida { get; set; }

        [JsonProperty("idbilling")]
        public string IdBilling { get; set; }

        [JsonProperty("totpag")]
        public double TotPag { get; set; }
    }


}
