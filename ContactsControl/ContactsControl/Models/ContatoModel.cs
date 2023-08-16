using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ContactsControl.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        [EmailAddress(ErrorMessage = "E-Mail Inválido*")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório*")]
        [Phone(ErrorMessage = "Número Inválido*")]
        public string Celular { get; set; }
    }
}
