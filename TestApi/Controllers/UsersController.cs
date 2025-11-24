using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApi.Services;

namespace TestApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private readonly UsuariosService _service;
    public UsersController(UsuariosService service)
    {
      _service = service;
    }


    [HttpGet("GetNumber")]
    public IActionResult GetNumber()
    {
      int numero = _service.ObtenerNumero();
      return Ok(numero);
    }

    [HttpGet]
    public IActionResult GetAllUsers()
    {
      var users = _service.ObtenerUsuarios();
      return Ok(users);
    }

  }
}
