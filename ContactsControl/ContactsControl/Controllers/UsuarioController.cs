using ContactsControl.Models;
using ContactsControl.Repositorio;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Repostorio;

namespace ContactsControl.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepositorio.BuscarTodos();
            return View(usuarios);
        }
        public IActionResult Add()
        {    
            return View();
        }
    }
}
