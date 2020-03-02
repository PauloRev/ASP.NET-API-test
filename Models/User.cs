using System.ComponentModel.DataAnnotations;

namespace testeef.Models
{
  public class User
  {
    [Key]

    public int Id { get; set; }

    [Required(ErrorMessage = "Este campo é obrigatório!")]

    public string Name { get; set; }

    [Required(ErrorMessage = "Este campo é obrigatório!")]

    public string Biography { get; set; }

    [Required(ErrorMessage = "Este campo é obrigatório!")]
    public int Age { get; set; }

  }
}