using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CadClient.Domain.Entities;

public class Endereço : Notifiable
{
    public Endereço(Cliente cliente, int id, string zipCode, string street, int number, string neighborhood, string city, string state)
    {
        Cliente = cliente;
        Id = id;
        ZipCode = zipCode;
        Street = street;
        Number = number;
        Neighborhood = neighborhood;
        City = city;
        State = state;

        new AddNotifications<Endereço>(this)
            .IfNullOrEmpty(x => x.Street, "Favor informar o logradouro")
            .IfNullOrEmpty(x => x.City, "Favor informar a cidade")
            .IfNullOrEmpty(x => x.State, "Favor informar o estado")
            .IfNullOrEmpty(x => x.ZipCode, "Favor informar o CEP")
            .IfNullOrEmpty(x => x.Neighborhood, "Favor informar o bairro")
            .IfEqualsZero(x => x.Number, "Favor informar o Número");
    }

    public Cliente Cliente { get; set; }
    public int Id { get; private set; }
    public string ZipCode { get; private set; }
    public string Street { get; private set; }
    public int Number { get; private set; }
    public string Neighborhood { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }

}
