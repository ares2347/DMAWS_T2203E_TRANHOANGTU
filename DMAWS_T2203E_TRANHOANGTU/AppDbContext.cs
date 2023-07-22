using DMAWS_T2203E_TRANHOANGTU.Models;
using Microsoft.EntityFrameworkCore;

namespace DMAWS_T2203E_TRANHOANGTU;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Employee> Employees { get; set; }
    
}