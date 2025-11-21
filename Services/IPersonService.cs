using WebApplication1.Models;

namespace WebApplication1.Services;

public interface IPersonService
{
    Task<IEnumerable<Person>> GetAllAsync();
    Task<Person?> GetByIdAsync(int id);
    Task<Person> CreateAsync(Person p);
    Task<Person> UpdateAsync(Person p);
    Task DeleteAsync(int id);
}