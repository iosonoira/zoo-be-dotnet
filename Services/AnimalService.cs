using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services;

public class AnimalService : IAnimalService
{
    private readonly IAnimalRepository _repository;

    public AnimalService(IAnimalRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<Animal>> GetAllAsync()
        => _repository.GetAllAsync();

    public Task<Animal?> GetByIdAsync(int id)
        => _repository.GetByIdAsync(id);

    public Task<Animal> CreateAsync(Animal a)
        => _repository.AddAsync(a);

    public Task<Animal> UpdateAsync(Animal a)
        => _repository.UpdateAsync(a);

    public Task DeleteAsync(int id)
        => _repository.DeleteAsync(id);
}