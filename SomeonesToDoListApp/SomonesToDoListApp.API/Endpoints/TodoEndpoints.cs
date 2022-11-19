using SomonesToDoListApp.Services.ToDos.Features.CreateToDo;
using FluentValidation;
using FluentValidation.Results;
using SomonesToDoListApp.Services.ToDos.Dtos;
using SomonesToDoListApp.Services.ToDos.Features.UpdateToDo;
using MediatR;
using SomonesToDoListApp.Services.ToDos.Features.GetToDos;
using SomonesToDoListApp.Services.ToDos.Features.GetToDo;

namespace SomonesToDoListApp.API.Endpoints
{
    public class TodoEndpoints : IEndpoints
    {
        private const string ContentType = "application/json";
        private const string Tag = "ToDo";
        private const string BaseRoute = "todos";

        public static void DefineEndpoints(IEndpointRouteBuilder app)
        {
            app.MapPost(BaseRoute, CreateTodoAsync)
                .WithName("CreateTodo")
                .Accepts<CreateToDoCommand>(ContentType)
                .Produces<CreateToDoCommandResponse>(201).Produces<IEnumerable<ValidationFailure>>(400)
                .WithTags(Tag);

            app.MapGet(BaseRoute, GetAllTodosAsync)
                .WithName("GetToDos")
                .Produces<IEnumerable<GetToDoDto>>(200)
                .WithTags(Tag);

            app.MapGet($"{BaseRoute}/{{id}}", GetTodoAsync)
                .WithName("GetTodo")
                .Produces<GetToDoDto>(200).Produces(404)
                .WithTags(Tag);

            app.MapPut($"{BaseRoute}", UpdateTodoAsync)
                .WithName("UpdateTodo")
                .Accepts<UpdateToDoCommand>(ContentType)
                .Produces<UpdateToDoCommandResponse>(204).Produces<IEnumerable<ValidationFailure>>(400)
                .WithTags(Tag);

        }

        internal static async Task<IResult> CreateTodoAsync(
            CreateToDoCommand createToDoCommand, IMediator mediator)
        {
            var createResponse = await mediator.Send(createToDoCommand);      

            return Results.Created($"/{BaseRoute}/{createResponse.CreateToDoDto.Id}", createToDoCommand);
        }

        internal static async Task<IResult> GetAllTodosAsync(IMediator mediator)
        {
         
            var todos = await mediator.Send(new GetToDosQuery());
            return Results.Ok(todos);
        }

        internal static async Task<IResult> GetTodoAsync(
            int id, IMediator mediator)
        {
            var todo = await mediator.Send(new GetToDoQuery() { Id = id});
            return todo is not null ? Results.Ok(todo) : Results.NotFound();
        }

        internal static async Task<IResult> UpdateTodoAsync(
            UpdateToDoCommand updateToDoCommand, IMediator mediator)
        {
            await mediator.Send(updateToDoCommand);
            return Results.NoContent();
        }

        public static void AddServices(IServiceCollection services, IConfiguration configuration)
        {

        }

    }
}
