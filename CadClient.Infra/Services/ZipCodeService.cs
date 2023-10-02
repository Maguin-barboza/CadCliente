using CadClient.Domain.Interfaces.Services;
using CadClient.Domain.Interfaces.Services.Response;
using Newtonsoft.Json;

namespace CadClient.Infra.Services;

public class ZipCodeService : IZipCodeService
{
    public async Task<EndereçoResponse> GetAddressByZipCode(string zipCode)
    {
        EndereçoResponse endereçoApi;
        using (var client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync($"https://viacep.com.br/ws/{zipCode}/json/");
            if(response.IsSuccessStatusCode)
            {
                var endereçoJsonString = await response.Content.ReadAsStringAsync();
                endereçoApi = JsonConvert.DeserializeObject<EndereçoResponse>(endereçoJsonString);
            }
        }
        
        return await Task<EndereçoResponse>.FromResult(endereçoApi);
    }
}
