using Dominio.Enum;

using System.ComponentModel.DataAnnotations;

namespace DesafioArquitetura.API.DTO
{
    public class ClienteLancamentoDto 
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Guid LanlamentoId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public TipoLancamento TipoLancamento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public decimal Valor { get; set; }
        public string? Descricao { get; set; }
    }
}
