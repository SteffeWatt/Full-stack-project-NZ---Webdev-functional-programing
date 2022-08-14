using Microsoft.EntityFrameworkCore;
using A1.Models;



namespace A1.Data
{
    public class A1DBContext : DbContext
    {
        public A1DBContext(DbContextOptions<A1DBContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }

        public DbSet<Comment> Comments { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=A1Database.sqlite");
        }
        //5341529830



    }
}

