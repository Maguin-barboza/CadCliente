using CadClient.Domain.Interfaces.Services.Response;

namespace CadClient.Domain.Interfaces.Services;

public interface IZipCodeService
{
    Task<EndereçoResponse> GetAddressByZipCode(string zipCode);
}
