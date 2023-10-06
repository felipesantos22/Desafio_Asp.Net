using Microsoft.EntityFrameworkCore;

namespace todo.Models;

public class DataContext:DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to mysql with connection string from app settings
        // var connectionString = Configuration.GetConnectionString("WebApiDatabase");
        options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
    }

    public DbSet<Obra> tarefas { get; set; }
    public DbSet<Autor> autor { get; set; }
}