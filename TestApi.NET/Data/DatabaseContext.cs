using Microsoft.EntityFrameworkCore;

using TestApi.NET.Models;

namespace TestApi.NET.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        
    }
    
    public DbSet<Test> Test { get; set; }
}