using Newtonsoft.Json;
using ViaCepApi.Models;

namespace ViaCepApi.Services;

public class ViaCepService(HttpClient httpClient) : IViaCepService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<Endereco> ObterEnderecoPorCep(string cep)
    {
        var response = await _httpClient.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");

        return JsonConvert.DeserializeObject<Endereco>(response)!;
    }
}