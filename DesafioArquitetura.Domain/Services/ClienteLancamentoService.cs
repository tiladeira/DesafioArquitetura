using DesafioArquitetura.Domain.Entities;
using DesafioArquitetura.Domain.Interfaces.Repositories;
using DesafioArquitetura.Domain.Interfaces.Services;

namespace DesafioArquitetura.Domain.Services
{
    public class ClienteLancamentoService : IClienteLancamentoService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public ClienteLancamentoService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(ClienteLancamento entity)
        {
            if (entity != null)
            {
                await _unitOfWork.ClienteLancamento.CreateAsync(entity);
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
                var entity = await _unitOfWork.ClienteLancamento.GetByIdAsync(id);

                if (entity != null)
                {
                    await _unitOfWork.ClienteLancamento.DeleteByAsync(entity).ConfigureAwait(false);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }

            return false;
        }

        public async Task<IEnumerable<ClienteLancamento>> GetAllAsync()
        {
            return await _unitOfWork.ClienteLancamento.GetAllAsync();
        }

        public async Task<ClienteLancamento> GetByIdAsync(int id)
        {
            if (id > 0)
            {
                var entity = await _unitOfWork.ClienteLancamento.GetByIdAsync(id);

                if (entity != null)
                    return entity;
            }

            return null;
        }

        public async Task<bool> UpdateAsync(ClienteLancamento entity)
        {
            if (entity != null)
            {
                await _unitOfWork.ClienteLancamento.UpdateAsync(entity);
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