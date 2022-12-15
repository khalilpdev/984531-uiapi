using B1SLayer;
using B1SLayer_Demo.Models.VTEX;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace B1SLayer_Demo
{
    class MainTest
    {
        //static void Main(string[] args)
        //{
        //    var invoiceAddJson = File.ReadAllText(@"C:\Users\leand\Documents\Projetos\B1SLayer_Demo\B1SLayer_Demo\Data\InvoiceAdd.json");
        //    InvoiceClass invoiceAdd = JsonConvert.DeserializeObject<InvoiceClass>(invoiceAddJson);

        //    var invoiceReturnJson = File.ReadAllText(@"C:\Users\leand\Documents\Projetos\B1SLayer_Demo\B1SLayer_Demo\Data\InvoiceReturn.json");
        //    InvoiceReturnClass invoiceReturn = JsonConvert.DeserializeObject<InvoiceReturnClass>(invoiceReturnJson);


        //}

        static async Task Main(string[] args)
        {
            await RunSL();
            //await RunVtex();
        }

        private static async Task RunSL()
        {
            /* The connection object. All Service Layer requests and the session management are handled by this object
                * and therefore only one instance per company/user should be used across the entire application.
                * There's no need to manually Login! The session is managed automatically and renewed whenever necessary.
            */
            //var serviceLayer = new SLConnection("https://LEANDROKHALIL:50000/b1s/v1", "SBODemoBR", "manager", "mana");
            var serviceLayer = new SLConnection("https://b1.ativy.com:50361/b1s/v1/", "SBOMONTREAL", "Jarvis", "J@rv15@GM");

            // Request monitoring/logging available through the methods BeforeCall, AfterCall and OnError.
            // The FlurlCall object provides various details about the request and the response.
            serviceLayer.AfterCall(async call =>
            {
                Console.WriteLine($"Request: {call.HttpRequestMessage.Method} {call.HttpRequestMessage.RequestUri}");
                Console.WriteLine($"Body sent: {call.RequestBody}");
                Console.WriteLine($"Response: {call.HttpResponseMessage?.StatusCode}");
                Console.WriteLine(await call.HttpResponseMessage?.Content?.ReadAsStringAsync());
                Console.WriteLine($"Call duration: {call.Duration.Value.TotalSeconds} seconds");
            });

            // Performs a GET on /Orders(185) and deserializes the result in a custom model class
            var order = await serviceLayer.Request("Orders", 185).GetAsync<Models.SAP.Orders>();

            // Performs a GET on /BusinessPartners with query string and header parameters supported by Service Layer
            // The result is deserialized in a List of a custom model class
            var bpList = await serviceLayer.Request("BusinessPartners")
                .Filter("startswith(CardCode, 'C')")
                .Select("CardCode, CardName")
                .OrderBy("CardName")
                .WithPageSize(50)
                .WithCaseInsensitive()
                .GetAsync<List<Models.SAP.BusinessPartners>>();

            // Performs a POST on /Orders with the provided object as the JSON body, 
            // creating a new order and deserializing the created order in a custom model class
            //var myNewOrderObject = new Models.SAP.Orders
            //{
            //    CardCode = "C00001",
            //    DocDate = DateTime.Today,
            //    DocDueDate = DateTime.Today,
            //    Comments = "Teste B1SLayer",
            //    DocType = "dDocument_Items",
            //    DocumentLines = new List<Models.SAP.modelOrdersItemsLines>
            //    {
            //        new Models.SAP.modelOrdersItemsLines()
            //        {
            //            LineNum = 0,
            //            ItemCode = "I0001",
            //            Quantity = 1,
            //            UnitPrice = 98.2M,
            //            Usage = 9,
            //        }
            //    }
            //};

            //var createdOrder = await serviceLayer.Request("Orders").PostAsync<Models.SAP.Orders>(myNewOrderObject); // TODO: ver erro

            //// Performs a PATCH on /BusinessPartners('C00001'), updating the CardName of the Business Partner
            //await serviceLayer.Request("BusinessPartners", "C00001").PatchAsync(new { CardName = "Updated BP name" });

            //// Performs a PATCH on /ItemImages('A00001'), adding or updating the item image
            //await serviceLayer.Request("ItemImages", "A00001").PatchWithFileAsync(@"C:\ItemImages\A00001.jpg");

            //// Performs a POST on /Attachments2 with the provided file as the attachment (other overloads available)
            //var attachmentEntry = await serviceLayer.PostAttachmentAsync(@"C:\files\myfile.pdf");

            // Batch requests! Performs multiple operations in SAP in a single HTTP request
            var batchRequests = new SLBatchRequest[]
            {
                new SLBatchRequest(HttpMethod.Post, // HTTP method
                    "BusinessPartners", // resource
                    new { CardCode = "C00001", CardName = "I'm a new BP" } // object to be sent as the JSON body
                ),
                new SLBatchRequest(HttpMethod.Put,
                    "BusinessPartners('C00001')",
                    new { CardName = "This is my updated name" }
                ),
                new SLBatchRequest(HttpMethod.Delete,
                    "BusinessPartners('C00001')"
                )
            };

            //HttpResponseMessage[] batchResult = await serviceLayer.PostBatchAsync(batchRequests);

            // Performs a POST on /Logout, ending the current session
            await serviceLayer.LogoutAsync();
        }

        private static async Task RunVtex()
        {
            var result = await AppRoutes.BasePath
                .AppendPathSegment(AppRoutes.Invoices.GetInvoiceByDoc)
                .WithHeader("Token", AppRoutes.Token)
                //.SetQueryParams(new { api_key = "xyz" })
                //.WithOAuthBearerToken("my_oauth_token")
                .PostJsonAsync(new { docentry = 520496, idbilling = "D0AF75F529244C299E12A1BBB9718F6F" })
                //.ReceiveJson<InvoiceClass>();
                .ReceiveString();

            Console.WriteLine(result);

            var invoice = JsonConvert.DeserializeObject<InvoiceGetClass>(result);
            Console.WriteLine($"{invoice.DocEntry} - {invoice.Rps}");

            Console.ReadLine();
        }
    }
}
