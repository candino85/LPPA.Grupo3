using System.Web.Mvc;
using Marketplace.Data.Models;
using Marketplace.Data.Services;

namespace Marketplace.Website.Controllers
{   
    public class HomeController : Controller
    {
        private readonly IProductData _db;
        public HomeController(IProductData productData)
        {
            _db = productData;
        }

        [HttpGet]
        public ActionResult Index()
        {
            // build
            var model = _db.GetAll();

            // render
            return View(model); // => html
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product model)
        {
            return View();
        }
    }
}