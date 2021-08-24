using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dev.Application.ViewModels
{
    public class ContatoViewModel 
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [DisplayName("Telefone")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "O campo {0} precisa ter 9 caracteres")]
        public string TelefoneResidencial { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(10, MinimumLength = 9, ErrorMessage = "O campo {0} precisa ter {1} caracteres")]
        public string Celular { get; set; }

    }
}
