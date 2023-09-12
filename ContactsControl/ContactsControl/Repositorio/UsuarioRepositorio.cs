using ContactsControl.Data;
using ContactsControl.Models;
using ContactsControl.Repositorio;

namespace WebApplication3.Repostorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _context;
        public UsuarioRepositorio(BancoContext bancoContext)
        {
           this._context = bancoContext;
        }
        public UsuarioModel ListarPorId(int id)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Id == id);
        }
        public List<UsuarioModel> BuscarTodos()
        {
            return _context.Usuarios.ToList();
        }
        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            // Gravar no banco de dados
            usuario.DataCadastro = DateTime.Now;
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return usuario; 
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            UsuarioModel usuarioDB = ListarPorId(usuario.Id);

            if (usuarioDB == null) throw new System.Exception("<span class=\"material-symbols-outlined\">\r\nwarning\r\n</span> <span>Houve um erro na gravação das novas informações.</span>");

            usuarioDB.Name = usuario.Name;
            usuarioDB.Email = usuario.Email;
            usuarioDB.Login = usuario.Login;
            usuarioDB.Perfil = usuario.Perfil;
            usuarioDB.DataAtualizacao = DateTime.Now;

            _context.Usuarios.Update(usuario);
            _context.SaveChanges();

            return usuarioDB;
        }

        public bool Delet(int id)
        {
            UsuarioModel usuarioDB = ListarPorId(id);

            if (usuarioDB == null) throw new System.Exception("<span class=\"material-symbols-outlined\">\r\nwarning\r\n</span> <span>Houve um ERRO na Exclusão.</span>");

            _context.Usuarios.Remove(usuarioDB);
            _context.SaveChanges();

            return true;
        }

        UsuarioModel IUsuarioRepositorio.ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        List<UsuarioModel> IUsuarioRepositorio.BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public UsuarioModel Adicionar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        public UsuarioModel Atualizar(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        ContatoModel IUsuarioRepositorio.ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        List<ContatoModel> IUsuarioRepositorio.BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            throw new NotImplementedException();
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            throw new NotImplementedException();
        }
    }
}