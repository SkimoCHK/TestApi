using System.ComponentModel.DataAnnotations;

namespace TestApi.Models
{
  public class Usuario
  {
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
  }
}
