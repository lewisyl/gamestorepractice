using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace GameStore.Controllers
{
    public class AboutUsController : Controller
    {
        public ViewResult AboutUsResult() => View();
    }
}
