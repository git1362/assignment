using SomeonesToDoListApp.Domain.Aggregates;

namespace SomonesToDoListApp.Services.Contracts
{
    public interface ITodoRepository: IAsyncRepository<ToDo>
    {
    }
}
