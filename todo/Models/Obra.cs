using System.ComponentModel.DataAnnotations;

namespace todo.Models;

public class Obra
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Descricao { get; set; }
    public string Publicacao { get; set; }
    public string Exposicao { get; set; }
}