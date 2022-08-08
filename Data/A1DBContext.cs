using Microsoft.EntityFrameworkCore;

class A1DBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=A1Database.sqlite");
    }
}
