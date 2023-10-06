using Microsoft.EntityFrameworkCore;
using todo.Interfaces;
using todo.Models;

namespace todo.Repository;

public class AutorRepository : IAutor
{
    private readonly DataContext _dataContext;

    public AutorRepository(DataContext context)
    {
        _dataContext = context;
    }

    public async Task<Autor> Create(Autor autor)
    {
        await _dataContext.autor.AddAsync(autor);
        await _dataContext.SaveChangesAsync();
        return autor;
    }

    public async Task<List<Autor>> FindAll()
    {
        return await _dataContext.autor.ToListAsync();
    }

    public async Task<Autor> Details(int id)
    {
        var userId = await _dataContext.autor.FirstOrDefaultAsync(x => x.Id == id);
        if (userId == null)
        {
            throw new Exception("Usuário não existe");
        }
        return userId;
    }

    public async Task<Autor> Update(int id, Autor autor)
    {
        var userId = await _dataContext.autor.FirstOrDefaultAsync(x => x.Id == id);
        if (userId == null)
        {
            throw new Exception("Usuário não existe");
        }

        userId.Nome = autor.Nome;
        _dataContext.autor.Update(userId);
        await _dataContext.SaveChangesAsync();
        return userId;
    }

    public async Task<bool> Delete(int id)
    {
        var userId = await _dataContext.autor.FirstOrDefaultAsync(x => x.Id == id);
        if (userId == null)
        {
            throw new Exception("Usuário não existe");
        }
        _dataContext.autor.Remove(userId);
        await _dataContext.SaveChangesAsync();
        return true;
    }
}