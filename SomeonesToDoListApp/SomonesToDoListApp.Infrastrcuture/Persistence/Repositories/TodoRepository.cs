using SomeonesToDoListApp.Domain.Aggregates;
using SomonesToDoListApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomonesToDoListApp.Infrastrcuture.Persistence.Repositories
{
    public class TodoRepository: Repository<ToDo>, ITodoRepository
    {
        public TodoRepository(SomeonesToDoListContext dbContext) : base(dbContext)
        {

        }
    }
}
