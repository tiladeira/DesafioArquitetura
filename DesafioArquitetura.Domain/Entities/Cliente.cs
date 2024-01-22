using DesafioArquitetura.Domain.Entities.Base;

namespace DesafioArquitetura.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
    }
}
