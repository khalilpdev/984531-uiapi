using B1SLayer_Demo;
using B1SLayer_Demo.Models.VTEX;
using Flurl;
using Flurl.Http;
using System;
using System.Threading.Tasks;
using Xunit;

namespace B1SLayer.DI
{
    
    public class TestaCodigos
    {
        [Fact]
        private static async Task RunVtex()
        {
            InvoiceAddClass invoice =  await GetInvoice();

            Assert.Equal("teste", nameof(InvoiceAddClass));

        }

        private static async Task<InvoiceAddClass> GetInvoice()
        {
            var result = await AppRoutes.BasePath
                            .AppendPathSegment(AppRoutes.Invoices.GetInvoiceByDoc)
                            .WithHeader("Token", AppRoutes.Token)
                            //.SetQueryParams(new { api_key = "xyz" })
                            //.WithOAuthBearerToken("my_oauth_token")
                            .PostJsonAsync(new { docentry = 520496, idbilling = "D0AF75F529244C299E12A1BBB9718F6F" })
                            .ReceiveJson<InvoiceAddClass>();

            return result;
        }
    }
}
