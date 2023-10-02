using CadClient.Domain.Entities;
using CadClient.Domain.Interfaces.Repositories;
using CadClient.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace CadClient.Infra.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly CadClienteCotext _context;
    public ClienteRepository(CadClienteCotext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Cliente>> GetAll()
    {
        return await _context.Clientes.AsNoTracking().ToListAsync();
    }

    public async Task<Cliente> GetById(Guid Id)
    {
        return await _context.Clientes.FirstOrDefaultAsync(x => x.Id == Id);
    }

    public async Task Save(Cliente cliente)
    {
        _context.Add(cliente);
        await _context.SaveChangesAsync();

    }

    public async Task Update(Cliente entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Cliente entity)
    {
        _context.Remove(entity);
        await _context.SaveChangesAsync();
    }
}
