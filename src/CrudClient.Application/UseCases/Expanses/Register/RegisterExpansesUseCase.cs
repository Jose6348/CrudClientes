using CrudClient.Comunication.Request;
using CrudClient.Comunication.Responses;
using CrudClient.Domain.Entities;
using CrudClient.Domain.Repositories;
using CrudClient.Exceptions;


namespace CrudClient.Application.UseCases.Expanses.Register
{
    public class RegisterExpansesUseCase
    {
        private readonly IClientRepository _clientRepository;

        public RegisterExpansesUseCase(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public ResponseClient Execute(RequestRegisterClient request)
        {
            if (string.IsNullOrWhiteSpace(request.Name))

                throw new ValidacaoException("O nome não pode ser vazio");

            var client = new Client(request.Name, request.Email, request.Birthday);

            _clientRepository.Add(client);

            return new ResponseClient { Id = client.Id, Name = client.Name };
        }
    }
}
