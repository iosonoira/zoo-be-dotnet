using WebApplication1.Models;

namespace WebApplication1.Services;

public interface IAnimalService
{
    Task<IEnumerable<Animal>> GetAllAsync();
    Task<Animal?> GetByIdAsync(int id);
    Task<Animal> CreateAsync(Animal a);
    Task<Animal> UpdateAsync(Animal a);
    Task DeleteAsync(int id);
}