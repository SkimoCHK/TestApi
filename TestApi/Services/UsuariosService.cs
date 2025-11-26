using TestApi.Models;

namespace TestApi.Services
{
  public class UsuariosService
  {
    private int numeroRandom;

    public UsuariosService()
    {
      Random random = new Random();
      numeroRandom = random.Next(1, 1500);
    }

    public int ObtenerNumero()
    {
      return numeroRandom;
    }

    public List<Usuario> ObtenerUsuarios()
    {
      var listUsers = new List<Usuario>()
      {
        new Usuario()
        {
          Nombre = "Everardo",
          Apellido = "Valenzuela",
          Edad = 21
        },
        new Usuario()
        {
          Nombre = "Jose",
          Apellido = "Santos",
          Edad = 24,
        },
        new Usuario()
        {
          Nombre = "Ivan",
          Apellido = "Soto",
          Edad = 23
        }
      };
      return listUsers;
    }

  }
}
