using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SomeonesToDoListApp.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SomonesToDoListApp.Infrastrcuture.Persistence.Configurations
{
    public class ToDoEntityConfiguration : IEntityTypeConfiguration<ToDo>
    {
        public void Configure(EntityTypeBuilder<ToDo> builder)
        {
            // Sets the default the database schema
            builder.ToTable("ToDo");

            builder.Property(t => t.ToDoItem)
            .IsRequired();
        }
    }
}
