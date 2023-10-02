using CadClient.Domain.Entities;
using CadClient.Domain.Interfaces.Repositories;
using CadClient.Domain.Interfaces.Services;

namespace CadClient.Controller.Controllers;

public class ClienteController
{
    private readonly IClienteRepository _repository;
    private readonly IZipCodeService _service;

    public ClienteController(IClienteRepository repository, IZipCodeService service)
    {
        _repository = repository;
        _service = service;
    }

    public async Task<Cliente> GetCliente(Guid Id)
    {
        return await _repository.GetById(Id);
    }

    public async Task<IEnumerable<Cliente>> GetClientes()
    {
        return await _repository.GetAll();
    }

    public async Task Add(string name, string cpf, string email)
    {
        Cliente cliente = new Cliente(new Guid(), name, cpf, email);

        _repository.Save(cliente);
    }
}
