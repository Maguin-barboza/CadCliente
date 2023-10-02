using CadClient.Domain.Entities;
using CadClient.Domain.Interfaces.Repositories.Base;

namespace CadClient.Domain.Interfaces.Repositories;

public interface IEndereçoRepository: IRepositoryBase<Endereço>
{
    Task<IEnumerable<Endereço>> GetByClienteId(Guid custumerId);
    Task Save(Endereço address);
}
