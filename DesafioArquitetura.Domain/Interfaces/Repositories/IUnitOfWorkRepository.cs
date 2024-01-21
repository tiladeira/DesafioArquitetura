namespace DesafioArquitetura.Domain.Interfaces.Repositories
{
    public interface IUnitOfWorkRepository : IDisposable
    {
        public IClienteRepository Cliente { get; }
        public ILancamentoRepository Lancamento { get; }
        public IClienteLancamentoRepository ClienteLancamento { get; }

        int Save();
    }
}
