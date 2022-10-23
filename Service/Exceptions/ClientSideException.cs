using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Service.Exceptions
{
    public class ClientSideException : Exception
    {
        public ClientSideException(string message):base(message)
        {

        } 
    }
}
