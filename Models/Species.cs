namespace WebApplication1.Models;

public class Species
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Classe { get; set; }
    public ICollection<Animal> Animals { get; set; }
}