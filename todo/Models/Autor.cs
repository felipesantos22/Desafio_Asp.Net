using System.ComponentModel.DataAnnotations;

namespace todo.Models;

public class Autor
{
    [Key]
    public int Id { get; set; }
    public string Nome { get; set; }
    
    public string Sexo { get; set; }
    
    public string Email { get; set; }
    
    public DateTime Date { get; set; }
    
    public string Pais { get; set; }
    
    public string Cpf { get; set; }
    
    
}