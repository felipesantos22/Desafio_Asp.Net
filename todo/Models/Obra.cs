using System.ComponentModel.DataAnnotations;

namespace todo.Models;

public class Obra
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}