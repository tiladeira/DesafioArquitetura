using DesafioArquitetura.Domain.Entities;
using DesafioArquitetura.Domain.Interfaces.Repositories;
using DesafioArquitetura.Infra.Data.Context;

using DesafioArquitetura.Infra.Data.Repository.Base;

namespace DesafioArquitetura.Infra.Data.Repository
{
    public class ClienteLancamentoRepository : RepositoryBase<ClienteLancamento>, IClienteLancamentoRepository
    {
        public ClienteLancamentoRepository(AppDbContext appContext) : base(appContext)
        {

        }
    }
}