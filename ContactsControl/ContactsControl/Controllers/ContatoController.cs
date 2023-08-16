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
            List <ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Edit(int id)
        {
           ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }
        
        public IActionResult DeletConfirm(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Delet(int id)
        {
            _contatoRepositorio.Delet(id);
            return  RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(ContatoModel contato) 
        {
            if(ModelState.IsValid)
            {
                _contatoRepositorio.Adicionar(contato); 
                return RedirectToAction("Index");   
            }

            return View(contato);
            
        }
        [HttpPost]
        public IActionResult Edit(ContatoModel contato)
        {
            if (ModelState.IsValid)
            {
                _contatoRepositorio.Atualizar(contato);
                return RedirectToAction("Index");
            }

            return View("Edit", contato);
        }
    }
}
