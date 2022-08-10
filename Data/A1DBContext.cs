using Microsoft.EntityFrameworkCore;


class A1DBContext : DbContext
{
    //why? - look into this
    public A1DBContext(DbContextOptions<A1DBContext>options):base(options) {}
    // look into this products cant be null
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=A1Database.sqlite");
    }
}
