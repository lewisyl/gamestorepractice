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
        // Content Return Type
        [Route("/testpage")]
        [Route("/testpage/index")]
        public IActionResult Index()
        {
            return Content("Hi, Lewis and Hein here. Routing is successful.");
        }


        /*-----------------------------------------------------------------*/


        // Fetching data from DB and returning JSON
        private readonly IProductRepository _repo;
        public TestPageController(IProductRepository repo)
        {
            _repo = repo;
        }

        public JsonResult TestJsonResult()
        {
            var sth = new ProductsListViewModel
            {
                Products = _repo.Products
            };
            return Json(sth);
        }


        /*-----------------------------------------------------------------*/


        // Testing ModelState Context Type. Entering /testpage/1 will return OK content,
        // If the number at the end is not 1, it throws err msg using ModelState.
        [HttpGet("/testpage/{testInt:int}", Name = "testInt")]
        public IActionResult TestModelState(int testInt)
        {
            if (testInt == 1) return Ok("You entered 1! Bingo!");

            ModelState.AddModelError(testInt.ToString(), "ModelState showed with int other than 1");
            return BadRequest(ModelState);

        }
    }
}