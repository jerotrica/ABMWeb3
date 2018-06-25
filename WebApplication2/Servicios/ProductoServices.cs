using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Entidades;

namespace WebApplication2.Servicios
{
    public class ProductoServices
    {
        Model1Entities bd = new Model1Entities();

        public List<Producto> ListarProductos()
        {
            return bd.Producto.OrderBy(c => c.nombre).ToList(); //muestra por orden ascendente
        }

        public Producto ObtenerProducto(int? id)
        {
            return bd.Producto.FirstOrDefault(c => c.idProducto == id);

        }
        internal void EliminarProducto(int? id)
        {
            Producto miProducto = ObtenerProducto(id);
            var productos = bd.Producto;

            foreach (Producto p in productos)
            {

                bd.Producto.Remove(miProducto);
            }

            bd.SaveChanges();
        }

        public void crearProducto(Producto p)
        {
            Producto nuevoProducto = new Producto();

            nuevoProducto.nombre = p.nombre;
            nuevoProducto.idProveedor = p.idProveedor;

            bd.Producto.Add(nuevoProducto);
            bd.SaveChanges();
        }

        internal void ModificarProducto(Producto p)
        {
            Producto miProducto = ObtenerProducto(p.idProducto);

            miProducto.nombre = p.nombre;
            miProducto.idProveedor = p.idProveedor;
            bd.SaveChanges();
        }
    }
}