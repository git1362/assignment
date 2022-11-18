using SomeonesToDoListApp.Domain.Common;
using SomeonesToDoListApp.Domain.Interfaces;

namespace SomeonesToDoListApp.Domain.Aggregates
{
    public class ToDo : EntityBase, IAggregateRoot
    {
        public string? ToDoItem { get; set; }

    }
}