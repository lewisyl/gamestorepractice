using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStore.Models;
using GameStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace GameStore.Controllers
{
    public class AboutUsController : Controller
    {
        public ViewResult Index() => View();

        // Below are the test codes for 
        public JsonResult TestJsonResult()
        {
            var sth = new ProductsListViewModel{
                Products = _repo.Products
            };
            return Json(sth);
        }
    }
}
