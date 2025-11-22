using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repositories;

public class AnimalRepository : IAnimalRepository
{
    private readonly AppDbContext _context;

    public AnimalRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Animal>> GetAllAsync()
        => await _context.Animals.ToListAsync();

    public async Task<Animal?> GetByIdAsync(int id)
        => await _context.Animals.FindAsync(id);

    public async Task<Animal> AddAsync(Animal a)
    {
        _context.Animals.Add(a);
        await _context.SaveChangesAsync();
        return a;
    }

    public async Task<Animal> UpdateAsync(Animal a)
    {
        _context.Animals.Update(a);
        await _context.SaveChangesAsync();
        return a;
    }

    public async Task DeleteAsync(int id)
    {
        var animal = await _context.Animals.FindAsync(id);
        if (animal != null)
        {
            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();
        }
    }
}