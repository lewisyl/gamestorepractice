using Microsoft.AspNetCore.Mvc;
using GameStore.Models;

namespace GameStore.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}