using Microsoft.AspNetCore.Mvc;

namespace ContactsControl.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult DeletConfirm()
        {
            return View();
        }
    }
}
