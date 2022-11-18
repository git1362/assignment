using Microsoft.EntityFrameworkCore;
using SomeonesToDoListApp.Domain.Aggregates;
using SomonesToDoListApp.Infrastrcuture.Persistence.Configurations;
using SomonesToDoListApp.Services.Contracts;

namespace SomonesToDoListApp.Infrastrcuture.Persistence
{
    public class SomeonesToDoListContext : DbContext
    {
        public SomeonesToDoListContext(DbContextOptions<SomeonesToDoListContext> options) : base(options)
        {
        }

        public DbSet<ToDo> ToDos => Set<ToDo>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ToDoEntityConfiguration());
        }

    }
}