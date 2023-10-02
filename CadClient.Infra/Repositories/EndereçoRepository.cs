using CadClient.Domain.Entities;
using CadClient.Domain.Interfaces.Repositories;
using CadClient.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CadClient.Infra.Repositories;

public class EndereçoRepository : IEndereçoRepository
{
    private readonly CadClienteCotext _context;

    public EndereçoRepository(CadClienteCotext context)
    {
        _context = context;
    }

    public async Task Delete(Endereço entity)
    {
        _context.Remove(entity);
    }

    public async Task<IEnumerable<Endereço>> GetByClienteId(Guid custumerId)
    {
        return await _context.Endereços.Where(x => x.Cliente.Id == custumerId).ToListAsync();
    }

    public async Task<Endereço> GetById(int Id)
    {
        return await _context.Endereços.FirstOrDefaultAsync(x => x.Id == Id);
    }

    public async Task Save(Endereço address)
    {
        _context.Add(address);
        await _context.SaveChangesAsync();
    }

    public async Task Update(Endereço entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }
}
