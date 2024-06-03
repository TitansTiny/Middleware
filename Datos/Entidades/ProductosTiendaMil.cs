using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Datos.Entidades
{
    public class ProductosTiendaMil
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public double precio_unitario { get; set; }
        public bool iva {  get; set; }
        public ProductosTiendaMil() { }
        public ProductosTiendaMil(string datoJson)
        {
            JObject data = JObject.Parse(datoJson);
            id = (int)data["id"];
            nombre = (string)data["nombre"];
            precio_unitario = (double)data["precio_unitario"];
            iva = (bool)data["iva"];
        }
    }
}
