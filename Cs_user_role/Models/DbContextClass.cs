using Microsoft.EntityFrameworkCore;

namespace Cs_Assignment.Models
{
    public class DbContextClass : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Citius;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                 .HasOne(v => v.Roles)
                 .WithMany(p => p.Users)
                 .HasForeignKey(p => p.RoleId);

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasIndex(c => c.RoleId).IsUnique();

            });
        }

    }
}
