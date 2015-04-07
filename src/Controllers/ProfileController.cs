using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Authorization;

namespace MyNamespace
{
    public class ProfileController : Controller
    {
        // GET: /<controller>/
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
