using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Data;

public class DatabaseContext : DbContext
{
    private readonly IConfiguration _configuration;
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options, IConfiguration configuration) : base(options)
    {
        _configuration = configuration;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection"));
    }
    
    public DbSet<Note> Notes { get; set; }
}