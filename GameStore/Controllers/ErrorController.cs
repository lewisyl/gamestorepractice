using Microsoft.AspNetCore.Mvc;

namespace GameStore.Controllers
{
    public class ErrorController : Controller
    {
        public ViewResult Error() => View();
    }
}
