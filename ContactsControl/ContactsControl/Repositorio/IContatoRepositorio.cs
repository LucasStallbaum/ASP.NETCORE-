using ContactsControl.Models;

namespace ContactsControl.Repositorio
{
    public interface IUsuarioRepositorio
    {
        ContatoModel ListarPorId(int id);

        List<ContatoModel> BuscarTodos();

        ContatoModel Adicionar(ContatoModel contato);

        ContatoModel Atualizar(ContatoModel contato);

        bool Delet(int id);
    }
}
