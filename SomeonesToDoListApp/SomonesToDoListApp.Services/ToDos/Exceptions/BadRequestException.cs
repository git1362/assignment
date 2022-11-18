using System;

namespace SomonesToDoListApp.Services.ToDos.Exceptions
{
    public class BadRequestException: ApplicationException
    {
        public BadRequestException(string message): base(message)
        {

        }
    }
}
