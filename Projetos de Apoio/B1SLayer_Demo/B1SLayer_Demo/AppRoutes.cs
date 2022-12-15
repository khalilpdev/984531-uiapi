using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B1SLayer_Demo
{
    public static class AppRoutes
    {
        public static readonly string BasePath = @"http://sap-app.vtex.com.br/WebApiSAPTESTE";
        public static readonly string Token = @"nEzhR+F2iiGU+4+O7HMUQpP3EwUKQG0UcR0dDqjkmedL8Od84IJp2bE1xhqBhcVlfTniLGKRN+EOtwmUZTFQ3Q==";

        public struct Orders
        {
            public static readonly string Add = $"{BasePath}/order/add";
        }

        public struct Invoices
        {
            public static readonly string GetInvoiceByDoc = "invoice/GetInvoiceByDoc";
        }
    }
}
