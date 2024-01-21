using System.ComponentModel.DataAnnotations;

namespace DesafioArquitetura.API.DTO
{
    public class ClienteDto 
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Descricao { get; set; }
    }
}
