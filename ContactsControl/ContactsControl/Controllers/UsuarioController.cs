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
            List<UsuarioModel> Usuarios = _usuarioRepositorio.BuscarTodos();
            return View(Usuarios);
        } 
        public IActionResult DeletConfirm(int id)
        {
            UsuarioModel Usuarios = _usuarioRepositorio.ListarPorId(id);
            return View(Usuarios);
        }

        public IActionResult Delet(int id)
        {
            _usuarioRepositorio.Delet(id);
            return RedirectToAction("Index");
        }
        public IActionResult Add()
        {    
            return View();
        }
        [HttpPost]
        public IActionResult Add(UsuarioModel usuario)
        {
            if (ModelState.IsValid)
            {
                _usuarioRepositorio.Adicionar(usuario);
                return RedirectToAction("Index");
            }

            return View(usuario);

        }
        public IActionResult Edit(int id)
        {
            UsuarioModel usuario = _usuarioRepositorio.ListarPorId(id);
            return View(usuario);
        }
        [HttpPost]
        public IActionResult Edit(UsuarioSemSenhaModel usuarioSemSenhaModel)
        {
            try
            {
                UsuarioModel usuario = null;
                if (ModelState.IsValid)
                {
                    usuario = new UsuarioModel()
                    {
                        Id = usuarioSemSenhaModel.Id,
                        Name = usuarioSemSenhaModel.Name,
                        Login = usuarioSemSenhaModel.Login,
                        Email = usuarioSemSenhaModel.Email,
                        Perfil = usuarioSemSenhaModel.Perfil
                    };
                    usuario = _usuarioRepositorio.Atualizar(usuario);
                    TempData["MensagemSucesso"] = "Contato alterado com sucesso";
                    return RedirectToAction("Index");
                }
                return View(usuario);
            }
            catch (System.Exception error)
            {
                TempData["MensagemError"] = $"ERROR ({error.Message}) Erro ao tentar alterar o usuario, tente novamente ";
                return RedirectToAction("Index");
            }
        }
    }
}
