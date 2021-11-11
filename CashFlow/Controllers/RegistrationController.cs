using CashFlow.Models;
using CashFlow.Services.AccountService;
using DataCashFlow.Models;
using System;
using System.Web.Mvc;

namespace CashFlow.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IAccountService _accountService;

        public RegistrationController(IAccountService accountService)
        {
            _accountService = DependencyResolver.Current.GetService<IAccountService>();
        }

        public RegistrationController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateNewUser()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CreateNewUser(Accounts account)
        {
            var newRegister = new Accounts
            {
                AccountId = Guid.NewGuid(),
                Name = account.Name,
                Cnpj = account.Cnpj,
                Address = account.Address,
                AddressNumber = account.AddressNumber,
                AddressCity = account.AddressCity,
                AddressNeighborhood = account.AddressNeighborhood,
                AddressState = account.AddressState,
                AddressCep = account.AddressCep,
                NameUser = account.NameUser,
                Email = account.Email,
                Password1 = account.Password1,
                Password2 = account.Password2,
                UserId = Guid.NewGuid()
            };

            _accountService.Save(newRegister);

            return RedirectToAction("Index", "Home");
        }

    }
}




