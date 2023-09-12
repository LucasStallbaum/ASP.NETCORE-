using ContactsControl.Models;

namespace ContactsControl.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel ListarPorId(int id);

        List<UsuarioModel> BuscarTodos();

        UsuarioModel Adicionar(UsuarioModel usuario);

        UsuarioModel Atualizar(UsuarioModel usuario);

        bool Delet(int id);
    }
}
