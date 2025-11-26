using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;
using TestApi.Services;

namespace TestApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsuariosController : ControllerBase
  {
    private readonly UsuariosService _service;

    private readonly OtroService _troService;

    public UsuariosController(UsuariosService service, OtroService troService)
    {
      _service = service;
      _troService = troService;
    }

    [HttpGet("ObtenerUsuarios")]
    public IActionResult GetUsers()
    {
      var listUsarios = _service.ObtenerUsuarios();
      return Ok(listUsarios);
    }

    [HttpGet("ObtenerNumero")]
    public IActionResult ObtenerNumero()
    {
      int numero = _service.ObtenerNumero();
      return Ok(numero);
    }

    [HttpGet("ObtenerNumeros")]
    public IActionResult ObtenerNumeros()
    {
      var numInstanciaControlador = _service.ObtenerNumero();
      var numInstanciaOtroService = _troService.ObtenerNumero();

      return Ok(
        new
        {
          numInstanciaControlador,
          numInstanciaOtroService
        }
        );
    }

  }

}
