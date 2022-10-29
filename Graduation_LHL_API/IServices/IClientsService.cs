using Graduation_LHL_API.Entity;

namespace Graduation_LHL_API.IServices
{
    public interface IClientsService
    {
        Clients HasClientsPassword(string ConnName,string password);  
        Task<Clients> HasClientsPasswordAsync(string ConnName,string password);

        Clients GetClients(int id);
        Task<Clients> GetClientsAsync(int id);



    }
}
