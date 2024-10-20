using Microsoft.EntityFrameworkCore;

public class PatikaSecondDbContext : DbContext
{
    public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=PatikaCodeFirstDb2;Trusted_Connection=True;");
    }
}
