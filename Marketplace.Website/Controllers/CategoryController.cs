using Marketplace.Business;
using Marketplace.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Marketplace.Website.Controllers
{
    public class CategoryController : Controller
    {
        /// <summary>
        /// Instancio CategoryBiz y llamo al método Listar para generar el modelo que luego 
        /// se lo paso a la vista para que la muestre
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var biz = new CategoryBiz();
            var model = biz.Listar();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category model)
        {
            if (!ModelState.IsValid) // Para controlar si el modelo es válido 
                return View();
            
            // TODO: implementar para bitacore
            try
            {
                var biz = new CategoryBiz();
                biz.Agregar(model);
                return RedirectToAction("Index");// Para redireccionar al index de Categorias
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View(model);
            }            
        }
    }
}