using DesafioArquitetura.Domain.Entities;
using DesafioArquitetura.Domain.Interfaces.Repositories;
using DesafioArquitetura.Domain.Interfaces.Services;

namespace DesafioArquitetura.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IUnitOfWorkRepository _unitOfWork;

        public ClienteService(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateAsync(Cliente entity)
        {
            if (entity != null)
            {
                await _unitOfWork.Cliente.CreateAsync(entity);
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
                var entity = await _unitOfWork.Cliente.GetByIdAsync(id);

                if (entity != null)
                {
                    await _unitOfWork.Cliente.DeleteByAsync(entity).ConfigureAwait(false);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }

            return false;
        }

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return await _unitOfWork.Cliente.GetAllAsync();
        }

        public async Task<Cliente> GetByIdAsync(int id)
        {
            if (id > 0)
            {
                var entity = await _unitOfWork.Cliente.GetByIdAsync(id);

                if (entity != null)
                    return entity;
            }

            return null;
        }

        public async Task<bool> UpdateAsync(Cliente entity)
        {
            if (entity != null)
            {
                await _unitOfWork.Cliente.UpdateAsync(entity);
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