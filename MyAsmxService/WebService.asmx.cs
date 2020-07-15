using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyAsmxService
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod(MessageName = "twoparameter", Description = "addition of two integers")]
        public int add(int a, int b)
        {
            return (a + b);
        }
        [WebMethod(MessageName = "threeparameter", Description = "addition of three integers")]
        public int add(int a, int b, int c)
        {
            return (a + b + c);
        }
        //[System.Web.Script.Services.ScriptService]
    }
}
