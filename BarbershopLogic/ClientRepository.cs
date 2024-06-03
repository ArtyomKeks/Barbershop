using BarbershopStorage;
using BarbershopStorage.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbershopLogic
{
    public class ClientRepository : IClientRepository
    {   
        public Client Create(DataContext dataContext, Client client)
        {
            dataContext.Clients.Add(client);
            return client;
        }

        public void Delete(DataContext context, Guid isnNode)
        {
            var clientDb = context.Clients.FirstOrDefault(x => x.ClientID == isnNode)
               ?? throw new Exception($"Пользователь с идентификатором {isnNode} не найден");

            context.Clients.Remove(clientDb);
        }

        public async Task<Client> GetByMail(DataContext context, string mail)
        {
            var clientDb = await context.Clients.AsNoTracking().FirstOrDefaultAsync(x => x.Email == mail);
            return clientDb;
        }
    }
}
