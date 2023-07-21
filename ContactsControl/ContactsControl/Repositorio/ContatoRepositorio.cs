using ContactsControl.Data;
using ContactsControl.Models;

namespace ContactsControl.Repositorio
{
    public class ContatoRepositorio
    {
        public class ContaRepositorio : InterfaceContatoRepositorio
        {
            private readonly BancoContext _bancoContext;

            public ContatoRepositorio(BancoContext bancoContext)
            {
                _bancoContext = bancoContext;
            }


            public ContatoModel Adicionar(ContatoModel contato)
            {
                _bancoContext.Contatos.Add(contato);
                _bancoContext.SaveChanges();
                return contato;

            }
        }
    }
}
