using WebApplication1.Models;

namespace WebApplication1.Repositories;

public interface IPersonRepository
{
    Task<IEnumerable<Person>> GetAllAsync();
    Task<Person?> GetByIdAsync(int id);
    Task<Person> AddAsync(Person p);
    Task<Person> UpdateAsync(Person p);
    Task DeleteAsync(int id);
}