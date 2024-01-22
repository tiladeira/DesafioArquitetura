using DesafioArquitetura.Domain.Entities.Base;

using Dominio.Enum;

namespace DesafioArquitetura.Domain.Entities
{
    public class ClienteLancamento : BaseEntity
    {
        public Guid ClienteId { get; set; }
        public Guid LanlamentoId { get; set; }
        public DateTime DataLancamento { get; set; }
        public TipoLancamento TipoLancamento { get; set; }
        public decimal Valor { get; set; }
        public string? Descricao { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Lancamento Lancamento { get; set; }
    }
}
