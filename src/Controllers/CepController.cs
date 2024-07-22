using Microsoft.AspNetCore.Mvc;
using ViaCepApi.Models;
using ViaCepApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ViaCepApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CepController(IViaCepService viaCepService) : ControllerBase
{
    private readonly IViaCepService _viaCepService = viaCepService;

    // GET: api/<CepController>
    [HttpGet("{cep}")]
    public async Task<IActionResult> Get(string cep)
    {
        var endereco = await _viaCepService.ObterEnderecoPorCep(cep);

        if (endereco == null)
            return NotFound();

        return Ok(endereco);
    }
}