using CadClient.Controller.Controllers;
using CadClient.Domain.Entities;
using CadClient.Domain.Interfaces.Repositories;
using CadClient.Domain.Interfaces.Services;
using CadClient.Infra.Context;
using CadClient.Infra.Repositories;
using CadClient.Infra.Services;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using System.Diagnostics;

namespace CadClient.View;

public partial class Main : Form
{
    
    private readonly IClienteRepository _repository;
    private readonly CadClienteCotext _context;
    private readonly ClienteController _controller;
    private readonly IZipCodeService _service;
    public Main()
    {
        InitializeComponent();
        _context = new CadClienteCotext();
        _repository = new ClienteRepository(_context);
        _service = new ZipCodeService();
        _controller = new ClienteController(_repository, _service);
    }

    private void Excluir_Click(object sender, EventArgs e)
    {

    }

    private void Main_Load(object sender, EventArgs e)
    {
    }
}