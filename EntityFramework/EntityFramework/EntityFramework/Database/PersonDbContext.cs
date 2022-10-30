using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Database
{
    internal class PersonDbContext: DbContext
    {
        public DbSet<Person> Persons => Set<Person>();
        public DbSet<Pet> Pets => Set<Pet>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./PersonDatabase.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
