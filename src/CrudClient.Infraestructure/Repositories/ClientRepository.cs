using CrudClient.Domain.Entities;
using CrudClient.Domain.Repositories;

namespace CrudClient.Infrastructure.Persistence.Repositories 
{
  
    public class ClientRepository : IClientRepository
    {
     
        private static readonly List<Client> _clientes = new List<Client>();

    
        public void Add(Client cliente)
        {
            _clientes.Add(cliente);
        }

        // Implementação do método GetAll exigido pela interface IClientRepository
        public IList<Client> GetAll()
        {
            return _clientes.ToList();
        }
    }
}
