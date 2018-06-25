using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Entidades;
using WebApplication2.Servicios;

namespace WebApplication2.Controllers
{
    public class ProductoController : Controller
    {
        ProductoServices productoServices = new ProductoServices();
        ProveedorServices proovedorServices = new ProveedorServices();
        // GET: Producto

        public ActionResult Listar()
        {
            return View(productoServices.ListarProductos());
        }

        [HttpPost]
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Listar");
            }
            else
            {

                productoServices.EliminarProducto(id);
            }

            return RedirectToAction("Listar");
        }

        public ActionResult Modificar(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Listar");
            }
            else
            {

                return View(productoServices.ObtenerProducto(id));
            }
        }


        [HttpPost]
        public ActionResult Modificar(Producto p)
        {
            ViewBag.proveedores = proovedorServices.ListarProveedores();

            productoServices.ModificarProducto(p);

            return RedirectToAction("Listar");
        }

        public ActionResult Nuevo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Nuevo(Producto p)
        {
            productoServices.crearProducto(p);

            return View();
        }
    }
}