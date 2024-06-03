using BarbershopStorage.Model;

namespace Barbershop.Features
{
    public interface IClientManager
    {
        Client Create(EditClient editClient);

        void Delete(Guid isnNode);

        Task<Client> GetUserByMail(string mail);
    }
}
