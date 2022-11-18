using SomonesToDoListApp.Services.Common;
using SomonesToDoListApp.Services.ToDos.Dtos;

namespace SomonesToDoListApp.Services.ToDos.Features.CreateToDo
{
    public class CreateToDoCommandResponse : BaseResponse
    {
        public CreateToDoCommandResponse() : base()
        {

        }

        public CreateToDoDto CreateToDoDto { get; set; }
    }
}
