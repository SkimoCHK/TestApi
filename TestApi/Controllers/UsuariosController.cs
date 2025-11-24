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
    public UsuariosController(UsuariosService service)
    {
      _service = service;
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

  }

}
