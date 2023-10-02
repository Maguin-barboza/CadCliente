using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CadClient.Domain.Entities;

public class Cliente: Notifiable
{
    public Cliente(Guid id, string name, string cPF, string email)
    {
        Id = id;
        Name = name;
        CPF = cPF;
        Email = email;

        new AddNotifications<Cliente>(this)
            .IfNullOrInvalidLength(x => x.Name, 5, 100, "Nome deve ter entre 5 e 100 caracteres")
            .IfNotCpf(x => x.CPF, "Cpf inválido")
            .IfNotEmail(x => x.Email, "Favor informar e-mail válido");
    }

    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public string CPF { get; private set; }
    public string Email { get; private set; }
    public int UpdateCount { get; set; }

    public IEnumerable<Endereço> Endereços { get; set; }
}
