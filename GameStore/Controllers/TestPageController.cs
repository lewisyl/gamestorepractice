using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class TestPageController : Controller
    {
        [Route("/testpage")]
        [Route("/testpage/index")]
        public IActionResult Index()
        {
            return Content("Hi I'm Hein. Routing is successful.");
        }
    }
}