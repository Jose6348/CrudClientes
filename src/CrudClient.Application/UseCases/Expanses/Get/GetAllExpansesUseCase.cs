using CrudClient.Comunication.Responses;
using CrudClient.Domain.Repositories;

namespace CrudClient.Application.UseCases.Expanses.Get
{
    public class GetAllExpansesUseCase
    {

        public readonly IClientRepository _clientRespository;

        public GetAllExpansesUseCase(IClientRepository clientRespository)
        {
            _clientRespository = clientRespository;
        }

        public IList<ResponseClient> Execute()
        {
            var clientes = _clientRespository.GetAll();

            return clientes.Select(static client => new ResponseClient
            {
                Id = client.Id,
                Name = client.Name
            }).ToList();
        }
    }
}
