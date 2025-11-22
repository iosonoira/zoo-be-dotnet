using WebApplication1.Models;

namespace WebApplication1.Repositories;

public interface IAnimalRepository
{
    Task<IEnumerable<Animal>> GetAllAsync();
    Task<Animal?> GetByIdAsync(int id);
    Task<Animal> AddAsync(Animal a);
    Task<Animal> UpdateAsync(Animal a);
    Task DeleteAsync(int id);
}