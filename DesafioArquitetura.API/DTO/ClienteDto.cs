using System.ComponentModel.DataAnnotations;

namespace DesafioArquitetura.API.DTO
{
    public class ClienteDto 
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string CPF { get; set; }
    }
}
