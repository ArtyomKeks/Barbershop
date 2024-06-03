using AutoMapper;
using Barbershop.Features;
using BarbershopLogic;
using BarbershopStorage;
using BarbershopStorage.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Barbershop.Controllers
{
    [Route (Registr)]
    public class ClientController : Controller
    {
        public const string Registr = "Client"; 
        
        private readonly IClientManager _clientManager;
        public ClientController(IClientManager clientManager) 
        {
            _clientManager = clientManager;
        }

        [HttpGet(nameof(Reg), Name = nameof(Reg))]
        public async Task<ActionResult> Reg()
        {
            return View(new EditClient()); 
        }

        [HttpGet(nameof(Check), Name = nameof(Check))]
        public async Task<ActionResult> Check()
        {
            return View(new EditDelete());
        }

        [HttpGet(nameof(SuperSuccess), Name = nameof(SuperSuccess))]
        public async Task<ActionResult> SuperSuccess()
        {
            return View(new EditDelete());
        }


        [HttpPost(nameof(DeleteClientView), Name = nameof(DeleteClientView))]
        public async Task<ActionResult> DeleteClientView(EditDelete delete)
        {
            if (!ModelState.IsValid)
                return View(nameof(SuperSuccess), delete);
            if(delete.command != null)
            {
                var temp = await _clientManager.GetUserByMail(delete.Email);
                _clientManager.Delete(temp.ClientID);
            }
            return View("GiperSuccess");
        }

        [HttpPost(nameof(CreateClientView), Name = nameof(CreateClientView))]
        public async Task<ActionResult> CreateClientView(EditClient client)
        {
            if (!ModelState.IsValid)
                return View(nameof(Reg), client);
            var temp = await _clientManager.GetUserByMail(client.Email);
            if (temp != null)
            {
                ModelState.AddModelError("Email", "Клиент с таким email уже существует");
                return View(nameof(Reg), client);
            }
            try
            {
                _clientManager.Create(client);
                return View("Success"); 
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(nameof(Reg), client);
            }
        }

        [HttpPost(nameof(FindClientView), Name = nameof(FindClientView))]
        public async Task<ActionResult> FindClientView(EditDelete client)
        {
            if (!ModelState.IsValid)
                return View(nameof(Check), client);
            var temp = await _clientManager.GetUserByMail(client.Email);
            if (temp == null)
            {
                ModelState.AddModelError("Email", "Запись клиента с таким email не найдена. Обратитесь к администратору.");
                return View(nameof(Check), client);
            }
            try {
                return View("SuperSuccess", new EditDelete { Day = temp.Day});
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(nameof(Check), client);
            }
        }


    }
}
