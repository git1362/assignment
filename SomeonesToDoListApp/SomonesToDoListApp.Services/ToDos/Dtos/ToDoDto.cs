using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomonesToDoListApp.Services.ToDos.Dtos
{
    public class ToDoDto
    {
        public int Id { get; set; }
    }

    public class UpdateToDoDto : ToDoDto
    {
        public string ToDoItemName { get; set; } = string.Empty;
    }

    public class CreateToDoDto: ToDoDto
    {

    }

    public class GetToDoDto: ToDoDto
    {
        public string ToDoItemName { get; set; } = string.Empty;
    }
}
