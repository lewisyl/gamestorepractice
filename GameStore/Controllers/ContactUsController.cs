using System;
using GameStore.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class ContactUsController : Controller
    {
      

        public ViewResult Index() => View(new ContactUs());

        [HttpPost]
        public IActionResult Index(ContactUs contactUS)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Submitted));
            }

            return View(contactUS);
        }

        public ViewResult Submitted()
        {
            return View();
        }
    }
}
