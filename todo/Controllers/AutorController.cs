using Microsoft.AspNetCore.Mvc;
using todo.Models;
using todo.Repository;

namespace todo.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AutorController : ControllerBase
{
    private readonly AutorRepository _autorRepository;

    public AutorController(AutorRepository autorRepository)
    {
        this._autorRepository = autorRepository;
    }
    
    [HttpGet]
    public async Task<ActionResult<List<Autor>>> Index()
    {
        var user = await _autorRepository.FindAll();
        return Ok(user);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<bool>> GetById(int id)
    {
        var user = await _autorRepository.Details(id);
        return Ok(true);
    }

    [HttpPost]
    public async Task<ActionResult<Autor>> Create([FromBody] Autor autor)
    {
        var newUser = await _autorRepository.Create(autor);
        return Ok(newUser);
    }
}