using Microsoft.EntityFrameworkCore;

using DesafioArquitetura.Domain.Entities.Base;
using DesafioArquitetura.Domain.Interfaces.Base;
using DesafioArquitetura.Infra.Data.Context;

namespace DesafioArquitetura.Infra.Data.Repository.Base
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        public readonly AppDbContext _appDbContext;

        public RepositoryBase(AppDbContext appContext)
        {
            _appDbContext = appContext;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _appDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _appDbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _appDbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task DeleteByAsync(TEntity entity)
        {
            _appDbContext.Set<TEntity>().Remove(entity);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _appDbContext.Set<TEntity>().Update(entity);
        }
    }
}
