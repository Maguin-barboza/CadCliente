namespace CadClient.Domain.Interfaces.Repositories.Base;

public interface IRepositoryBase<T>
    where T : class
{
    
    Task Update(T entity);
    Task Delete(T entity);
}
