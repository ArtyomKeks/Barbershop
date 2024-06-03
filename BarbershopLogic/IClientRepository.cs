using BarbershopStorage.Model;
using BarbershopStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbershopLogic
{
    public interface IClientRepository
    {
        Client Create(DataContext dataContext, Client client);

        void Delete(DataContext context, Guid isnNode);

        Task<Client> GetByMail(DataContext context, string mail);
    }
}
