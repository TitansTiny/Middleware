using Datos.DTO;
using Datos.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MiddlewareProductos
    {
        // Referencia a los servicios SOAP de cada base de datos
        localhost.WebServiceVentas webTiendaMil = new localhost.WebServiceVentas();
        ServiceVentasBD.WebServiceVentas2 webSuperX = new ServiceVentasBD.WebServiceVentas2();
        // Listado de la base de datos servicios
        public List<localhost.Producto> ListaTiendaMil()
        {
            return webTiendaMil.ListarProducto().ToList();
        }
        //Listado de la base de datos VentasBD
        public List<ServiceVentasBD.Productos> ListarSuperX()
        {
            return webSuperX.ListarProductos().ToList();
        }
        //Integramos los datos de cada una de las listas
        public List<DTOProductos> ListaProductosSOAP()
        {
            List<DTOProductos> lista = new List<DTOProductos>();
            foreach (var item in ListaTiendaMil())
            {
                DTOProductos datoProducto = new DTOProductos();
                datoProducto.Id = item.id;
                datoProducto.Name = item.nombre;
                datoProducto.Price = (double) item.precio_unitario;
                datoProducto.Iva = item.iva;
                datoProducto.Tienda = "Tienda Mil";
                lista.Add(datoProducto);
            }
            foreach(var item in ListarSuperX())
            {
                DTOProductos datoProducto = new DTOProductos();
                datoProducto.Id = item.idproducto;
                datoProducto.Name = item.name;
                datoProducto.Price = (double)item.pvp;
                if (item.impuesto == "1")
                    datoProducto.Iva = true;
                else datoProducto.Iva = false;
                datoProducto.Tienda = "SuperX";
                lista.Add(datoProducto);
            }
            return lista;
        }
        // Listado de productos de la base de datos ventas REST
        public List<ProductosSuperX> ListarProductosSuperX()
        {
            string url = "http://localhost:51382/api/Productos";
            WebClient respuesta = new WebClient();
            string get = respuesta.DownloadString(new Uri(url));
            List<ProductosSuperX> listaSuperX = JsonConvert.DeserializeObject<List<ProductosSuperX>>(get);
            return listaSuperX;
        }
        // Listado de productos de la base de datos servicios REST
        public List<ProductosTiendaMil> ListarProductosTiendaMil()
        {
            string url = "http://localhost:53277/api/Productos";
            WebClient respuesta = new WebClient();
            string get = respuesta.DownloadString(new Uri(url));
            List<ProductosTiendaMil> listaTiendaMil = JsonConvert.DeserializeObject<List<ProductosTiendaMil>>(get);
            return listaTiendaMil;
        }
        public List<DTOProductos> ListaProductosREST()
        {
            List<DTOProductos> listaproductos = new List<DTOProductos>();
            foreach(var item in ListarProductosSuperX())
            {
                DTOProductos producto = new DTOProductos();
                producto.Id = item.id;
                producto.Name = item.name;
                producto.Price = item.pvp;
                if (item.impuesto == "1")
                    producto.Iva = true;
                else producto.Iva = false;
                producto.Tienda = "Super X";
                listaproductos.Add(producto);
            }
            foreach (var item in ListarProductosTiendaMil())
            {
                DTOProductos producto = new DTOProductos();
                producto.Id = item.id;
                producto.Name = item.nombre;
                producto.Price = item.precio_unitario;
                producto.Iva = item.iva;
                producto.Tienda = "Tienda Mil";
                listaproductos.Add(producto);
            }
            return listaproductos;
        }
        public List<DTOProductos> FindByNombre(string nombre)
        {
            // Obtén la lista completa de productos REST
            List<DTOProductos> lista = ListaProductosREST();

            // Filtra la lista utilizando LINQ para encontrar productos cuyo nombre contenga la cadena de búsqueda, ignorando mayúsculas y minúsculas
            var productosFiltrados = lista.Where(p => p.Name.IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0).ToList();

            return productosFiltrados;
        }
    }
}
