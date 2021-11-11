using CashFlow.Services.AccountService;
using CashFlow.Services.ForgotPassword;
using DataCashFlow.UnitOfWork;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CashFlow.Ninject
{
    public class NinjectDependencies
    {
        public static void ConfigureDependencies()
        {
            IKernel kernel = new StandardKernel();
            kernel.Bind<IBaseUnitOfWork>().ToConstructor(b => new BaseUnitOfWork());
            kernel.Bind<IAccountService>().To<AccountService>();
            kernel.Bind<IForgotPasswordService>().To<ForgotPasswordService>();

            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}