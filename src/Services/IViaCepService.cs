using ViaCepApi.Models;

namespace ViaCepApi.Services;

public interface IViaCepService
{
    Task<Endereco> ObterEnderecoPorCep(string cep);
}
