using BirdsBank.Models.Bird;
using Microsoft.EntityFrameworkCore;

namespace BirdsBank.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(){}
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    
    public DbSet<Bird> Birds { get; set; }
}