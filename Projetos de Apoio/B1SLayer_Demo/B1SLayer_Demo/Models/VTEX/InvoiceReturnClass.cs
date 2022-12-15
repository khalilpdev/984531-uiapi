using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1SLayer_Demo.Models.VTEX
{
    // InvoiceReturn myDeserializedClass = JsonConvert.DeserializeObject<InvoiceReturn>(myJsonResponse); 
    public class InvoiceReturnClass
    {
        [JsonProperty("docentry")]
        public int Docentry { get; set; }

        [JsonProperty("idExterno")]
        public string IdExterno { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }


}
