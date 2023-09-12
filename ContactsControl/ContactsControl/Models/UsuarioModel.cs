using ContactsControl.Enums;

namespace ContactsControl.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login  { get; set; }
        public PerfilEnum Perfil { get; set; }
        public string Senha { get; set; }

        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
