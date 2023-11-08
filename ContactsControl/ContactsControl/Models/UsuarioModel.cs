using ContactsControl.Enums;
using System.ComponentModel.DataAnnotations;

namespace ContactsControl.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string ?Name { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string ?Login { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório*")]
        [EmailAddress(ErrorMessage = "E-Mail Inválido*")]
        public string ?Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório*")]
        public PerfilEnum? Perfil { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string ?Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
    }
}
