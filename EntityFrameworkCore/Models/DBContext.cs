using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore.Models
{
    public class DBContext: DbContext
    {
        // Dbset can coummnicate with DB an lambda function:
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=PC-T;Database=CodeFirstDB;Integrated Security=true;TrustServerCertificate=true;");
        }
    }
}
