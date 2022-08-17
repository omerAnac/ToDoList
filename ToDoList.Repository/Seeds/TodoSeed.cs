using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToDoList.Core.Models;

namespace NLayer.Repository.Seeds
{
    internal class TodoSeed : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {

            builder.HasData(
                new Todo
                {
                    Id = 1,
                    AddedDate = DateTime.Now,
                    Content = "falan filanda zımpırtı yapılacak",
                    Title = "Yapılacak 2",
                    DuetoDateTime = DateTime.Now.AddDays(10),
                    IsDone = false,
                    UserId = 1,
                    CreatedDate=DateTime.Now
                },
                new Todo
                {
                    Id = 2,
                    AddedDate = DateTime.Now,
                    Content = "falan filanda zımpırtı yapılacak",
                    Title = "Yapılacak 2",
                    DuetoDateTime = DateTime.Now.AddDays(20),
                    IsDone = false,
                    UserId = 1,
                    CreatedDate= DateTime.Now
                });
        }
    }
}
