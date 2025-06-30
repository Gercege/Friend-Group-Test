using Microsoft.EntityFrameworkCore;

namespace Friend_Group_Test.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base (options)
    {
        
    }

    public DbSet<SelectedOptions> SelectedOptionsDb { get; set; }
}