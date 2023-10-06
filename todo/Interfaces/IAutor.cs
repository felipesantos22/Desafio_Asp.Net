using Microsoft.AspNetCore.Mvc;
using todo.Models;

namespace todo.Interfaces;

public interface IAutor
{
    public Task<Autor> Create(Autor autor);
    public Task<List<Autor>> FindAll();
    public Task<Autor> Details(int id);
    public Task<Autor> Update(int id, Autor autor);
    public Task<bool> Delete(int id);
    
}