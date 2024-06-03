using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class ProductosSuperX
    {
        public int id { get; set; }
        public string name { get; set; }
        public double pvp { get; set; }
        public string impuesto { get; set; }
        public bool estado { get; set; }
        public string marca { get; set; }
        public ProductosSuperX() { }
        public ProductosSuperX(string datoJson) 
        {
            JObject data = JObject.Parse(datoJson);
            id = (int)data["id"];
            name = (string)data["name"];
            pvp = (double)data["pvp"];
            impuesto = (string)data["impuesto"];
            estado = (bool)data["estado"];
            marca = (string)data["marca"];
        }
    }
}
