using CashFlow.Services.ForgotPassword;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CashFlow.Controllers
{
    public class ForgotPasswordController : Controller
    {
        private readonly IForgotPasswordService _forgotPasswordService;

        public ForgotPasswordController(IForgotPasswordService accountService)
        {
            _forgotPasswordService = DependencyResolver.Current.GetService<IForgotPasswordService>();
        }

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Edit(string email, string password1, string password2)
        {
            var haveEmail= _forgotPasswordService.HaveEmail(email);
            if (haveEmail)
            {
                var account = _forgotPasswordService.Get(email);

                account.Password1 = password1;
                account.Password1 = password2;

                _forgotPasswordService.Edit(account);
            }
                
            return RedirectToAction("Index", "Home");
        }
    }
}