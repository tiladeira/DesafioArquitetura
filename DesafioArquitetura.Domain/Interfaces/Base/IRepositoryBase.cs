using DesafioArquitetura.Domain.Entities.Base;

namespace DesafioArquitetura.Domain.Interfaces.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        Task CreateAsync(TEntity entity);
        Task DeleteByAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
    }
}
