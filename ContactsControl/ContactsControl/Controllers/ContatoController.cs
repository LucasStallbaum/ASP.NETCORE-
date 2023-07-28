using ContactsControl.Models;
using ContactsControl.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ContactsControl.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio) 
        {
            _contatoRepositorio = contatoRepositorio; 
        }
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
        [HttpPost]
        public IActionResult Criar(ContatoModel contato) 
        {
            _contatoRepositorio.Adicionar(contato); 
            return RedirectToAction("Index");
        }
    }
}
