using CadClient.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using prmToolkit.NotificationPattern;

namespace CadClient.Infra.Context;

public class CadClienteCotext: DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Endereço> Endereços { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=CadastroClientes;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Ignore<Notification>();

        base.OnModelCreating(modelBuilder);
    }


}
