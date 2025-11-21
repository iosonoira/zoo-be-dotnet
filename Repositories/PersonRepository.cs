using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repositories;

public class PersonRepository : IPersonRepository
{
    private readonly AppDbContext _context;

    public PersonRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Person>> GetAllAsync()
        => await _context.Persons.ToListAsync();

    public async Task<Person?> GetByIdAsync(int id)
        => await _context.Persons.FindAsync(id);

    public async Task<Person> AddAsync(Person p)
    {
        _context.Persons.Add(p);
        await _context.SaveChangesAsync();
        return p;
    }

    public async Task<Person> UpdateAsync(Person p)
    {
        _context.Persons.Update(p);
        await _context.SaveChangesAsync();
        return p;
    }

    public async Task DeleteAsync(int id)
    {
        var person = await _context.Persons.FindAsync(id);
        if (person != null)
        {
            _context.Persons.Remove(person);
            await _context.SaveChangesAsync();
        }
    }
}