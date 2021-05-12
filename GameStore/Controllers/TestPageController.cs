using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Models;
using GameStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class TestPageController : Controller
    {

        private IProductRepository _repo;
        public TestPageController(IProductRepository repo)
        {
            _repo = repo;
        }

        [Route("/testpage")]
        [Route("/testpage/index")]
        public IActionResult Index()
        {
            return Content("Hi, Lewis and Hein here. Routing is successful.");
        }

        public JsonResult TestJsonResult()
        {
            var sth = new ProductsListViewModel
            {
                Products = _repo.Products
            };
            return Json(sth);
        }
    }
}