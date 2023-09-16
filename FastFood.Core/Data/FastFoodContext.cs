using Microsoft.EntityFrameworkCore;

namespace FastFood.Core.Data
{
    public partial class FastFoodContext : DbContext
    {
        public FastFoodContext()
        {
            
        }

        public FastFoodContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                var connectionString = "Server=.\\SQLEXPRESS;Database=JustBlogDB;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true";
                optionsBuilder.UseSqlServer(connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Set Entities's relationship 

            //Seeding Data for models
            SeedingDataForModel(modelBuilder);

            //Seeding Data for Users
            SeedingDataForUser(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
