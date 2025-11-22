

using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers;


[ApiController]
[Route("api/[controller]")]
public class AnimalController : Controller
{
    private readonly IAnimalService _service;

    public AnimalController(IAnimalService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _service.GetAllAsync());

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        var Animal = await _service.GetByIdAsync(id);
        if (Animal == null) return NotFound();
        return Ok(Animal);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Animal a)
    {
        var created = await _service.CreateAsync(a);
        return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, Animal a)
    {
        if (id != a.Id) return BadRequest();
        return Ok(await _service.UpdateAsync(a));
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }
}