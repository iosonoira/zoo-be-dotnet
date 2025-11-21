using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Services;

public class PersonService : IPersonService
{
    private readonly IPersonRepository _repository;

    public PersonService(IPersonRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<Person>> GetAllAsync()
        => _repository.GetAllAsync();

    public Task<Person?> GetByIdAsync(int id)
        => _repository.GetByIdAsync(id);

    public Task<Person> CreateAsync(Person p)
        => _repository.AddAsync(p);

    public Task<Person> UpdateAsync(Person p)
        => _repository.UpdateAsync(p);

    public Task DeleteAsync(int id)
        => _repository.DeleteAsync(id);
}