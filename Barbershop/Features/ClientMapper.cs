using AutoMapper;
using BarbershopStorage.Model;

namespace Barbershop.Features
{
    public class ClientMapper : Profile 
    {
        public ClientMapper() 
        {
            CreateMap<Client, EditClient>().ReverseMap();
        }
    }
}
