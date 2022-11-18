using SomeonesToDoListApp.Domain.Aggregates;
using SomonesToDoListApp.Services.ToDos.Dtos;
using SomonesToDoListApp.Services.ToDos.Features.CreateToDo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomonesToDoListApp.Services.ToDos.Features.GetToDos
{
    public static class Mappings
    {
        public static GetToDoDto ToDto(this ToDo entity)
        {
            return new GetToDoDto
            {
                Id = entity.Id,
                ToDoItemName = entity?.ToDoItem ?? ""

            };
        }
    }
}
