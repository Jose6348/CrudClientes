using CrudClient.Domain.Entities;

namespace CrudClient.Domain.Repositories
{
    public interface IClientRepository
    {
        void Add(Client client);    

        IList<Client> GetAll();
    }
}
