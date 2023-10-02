using CadClient.Domain.Entities;
using CadClient.Domain.Interfaces.Repositories.Base;

namespace CadClient.Domain.Interfaces.Repositories;

public interface IClienteRepository: IRepositoryBase<Cliente>
{
    Task<Cliente> GetById(Guid Id);
    Task<IEnumerable<Cliente>> GetAll();
    Task Save(Cliente cliente);
}
