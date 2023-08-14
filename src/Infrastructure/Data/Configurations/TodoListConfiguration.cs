using Dotnet8Template.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dotnet8Template.Infrastructure.Data.Configurations;

public class TodoListConfiguration : IEntityTypeConfiguration<TodoList>
{
    public void Configure(EntityTypeBuilder<TodoList> builder)
    {
        builder.Property(t => t.Title)
            .HasMaxLength(200)
            .IsRequired();

        builder
            .OwnsOne(b => b.Colour);
    }
}
