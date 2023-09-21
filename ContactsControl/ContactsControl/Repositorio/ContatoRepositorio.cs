using ContactsControl.Data;
using ContactsControl.Models;
using ContactsControl.Repositorio;

namespace WebApplication3.Repostorio
{
    public class ContatoRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _context;
        public ContatoRepositorio(BancoContext bancoContext)
        {
           this._context = bancoContext;
        }
        public ContatoModel ListarPorId(int id)
        {
            return _context.Contatos.FirstOrDefault(x => x.Id == id);
        }
        public List<ContatoModel> BuscarTodos()
        {
            return _context.Contatos.ToList();
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
            // Gravar no banco de dados
            _context.Contatos.Add(contato);
            _context.SaveChanges();

            return contato; 
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);

            if (contatoDB == null) throw new System.Exception("<span class=\"material-symbols-outlined\">\r\nwarning\r\n</span> <span>Houve um erro na gravação das novas informações.</span>");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _context.Contatos.Update(contatoDB);
            _context.SaveChanges();

            return contatoDB;
        }

        public bool Delet(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);

            if (contatoDB == null) throw new System.Exception("<span class=\"material-symbols-outlined\">\r\nwarning\r\n</span> <span>Houve um ERRO na Exclusão.</span>");

            _context.Contatos.Remove(contatoDB);
            _context.SaveChanges();

            return true;
        }
    }
}