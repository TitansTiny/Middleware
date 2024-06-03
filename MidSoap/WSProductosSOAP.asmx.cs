using Datos.DTO;
using Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MidSoap
{
    /// <summary>
    /// Summary description for WSProductosSOAP
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WSProductosSOAP : System.Web.Services.WebService
    {
        MiddlewareProductos mdSOAP = new MiddlewareProductos();

        [WebMethod]
        public List<DTOProductos> AllProductos()
        {
            return mdSOAP.ListaProductosSOAP();
        }
    }
}
