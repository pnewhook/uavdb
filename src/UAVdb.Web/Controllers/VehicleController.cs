using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MyNamespace
{
    public class VehicleController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
