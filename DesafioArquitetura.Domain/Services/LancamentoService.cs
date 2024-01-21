using DesafioArquitetura.Domain.Entities;
using DesafioArquitetura.Domain.Interfaces.Repositories;
using DesafioArquitetura.Domain.Interfaces.Services;

namespace DesafioArquitetura.Domain.Services
{
    public class LancamentoService : ILancamentoService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public LancamentoService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(Lancamento entity)
        {
            if (entity != null)
            {
                await _unitOfWork.Lancamento.CreateAsync(entity);
                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }

            return false;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            if (id > 0)
            {
                var entity = await _unitOfWork.Lancamento.GetByIdAsync(id);

                if (entity != null)
                {
                    await _unitOfWork.Lancamento.DeleteByAsync(entity).ConfigureAwait(false);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }

            return false;
        }

        public async Task<IEnumerable<Lancamento>> GetAllAsync()
        {
            return await _unitOfWork.Lancamento.GetAllAsync();
        }

        public async Task<Lancamento> GetByIdAsync(int id)
        {
            if (id > 0)
            {
                var entity = await _unitOfWork.Lancamento.GetByIdAsync(id);

                if (entity != null)
                    return entity;
            }

            return null;
        }

        public async Task<bool> UpdateAsync(Lancamento entity)
        {
            if (entity != null)
            {
                await _unitOfWork.Lancamento.UpdateAsync(entity);
                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }

            return false;
        }
    }
}