using DesafioArquitetura.Domain.Interfaces.Repositories;
using DesafioArquitetura.Infra.Data.Context;

namespace DesafioArquitetura.UnitOfWork
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        private readonly AppDbContext _dbContext;

        public IClienteRepository Cliente { get; }
        public IClienteLancamentoRepository ClienteLancamento { get; }
        public ILancamentoRepository Lancamento { get; }


        public UnitOfWorkRepository(AppDbContext dbContext,
                                    IClienteRepository cliente,
                                    IClienteLancamentoRepository clienteLancamento,
                                    ILancamentoRepository lancamento)
        {
            _dbContext = dbContext;
            Cliente = cliente;
            ClienteLancamento = clienteLancamento;
            Lancamento = lancamento;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                _dbContext.Dispose();
        }
    }
}
