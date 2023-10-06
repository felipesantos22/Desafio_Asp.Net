using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using todo.Models;

namespace todo.Controllers;

[Route("api/[controller]")]
public class TaskController: ControllerBase
{
    private readonly DataContext _dataContext;

    public TaskController(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    
    [HttpGet]
    [Route("/tasks")]
    public async Task<ActionResult> GetTasks()
    {
        var todo = await _dataContext.tarefas.ToListAsync();
        return Ok(todo);

    }

    [HttpPost]
    [Route("/tasks")]
    public async Task<ActionResult> CreateTask(Obra obra)
    {
        await _dataContext.tarefas.AddAsync(obra);
        await _dataContext.SaveChangesAsync();
        return Ok(obra);
    }
}