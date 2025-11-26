namespace TestApi.Services
{
  public class OtroService
  {
    private readonly UsuariosService _services;

    public OtroService(UsuariosService services)
    {
      _services = services;
    }

    public int ObtenerNumero()
    {
      return _services.ObtenerNumero();
    }
  }
}
