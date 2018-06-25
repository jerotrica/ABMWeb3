using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Entidades;

namespace WebApplication2.Servicios
{
    public class ProveedorServices
    {
        Model1Entities bd = new Model1Entities();

        public List<Proveedor> ListarProveedores()
        {
            return bd.Proveedor.OrderBy(c => c.nombre).ToList(); //muestra por orden ascendente
        }

        public Proveedor ObtenerProveedor(int? id)
        {
            return bd.Proveedor.FirstOrDefault(c => c.idProveedor == id);

        }
    }
}