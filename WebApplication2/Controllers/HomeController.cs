using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Entidades;
using WebApplication2.Servicios;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        ProductoServices productoServices = new ProductoServices();
        ProveedorServices proovedorServices = new ProveedorServices();
        
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}