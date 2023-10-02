namespace CadClient.Domain.Interfaces.Services.Response;

public struct EndereçoResponse
{
    public string logradouro { get; set; }
    public string bairro { get; set; }
    public string localidade { get; set; }
    public string uf { get; set; }
}
