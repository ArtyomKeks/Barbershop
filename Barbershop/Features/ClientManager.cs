using AutoMapper;
using BarbershopLogic;
using BarbershopStorage;
using BarbershopStorage.Model;
using System.ComponentModel.DataAnnotations;

namespace Barbershop.Features
{
    public class ClientManager : IClientManager
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;
        private readonly DataContext _dataContext;

        public ClientManager(IMapper mapper, IClientRepository clientRepository, DataContext dataContext)
        {
            _mapper = mapper;
            _clientRepository = clientRepository;
            _dataContext = dataContext;
        }

        public Client Create(EditClient editClient) 
        {
            var client = new Client()
            {
                ClientID = Guid.NewGuid(),
                Name = editClient.Name,
                Surname = editClient.Surname,
                LastName = editClient.LastName,
                Email = editClient.Email,
                Day = editClient.Day,
            };
            _clientRepository.Create(_dataContext, client);
            _dataContext.SaveChanges();
            return client; 
        }

        public void Delete(Guid isnNode)
        {
            _clientRepository.Delete(_dataContext, isnNode);
           _dataContext.SaveChanges();
        }

        public async Task<Client> GetUserByMail(string mail)
        {
            var client = await _clientRepository.GetByMail(_dataContext, mail);
            return client;
        }


    }
}
