using AutoMapper;
using CashFlow.Models;
using CashFlow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashFlow.Mappers
{
    public class AccountProfile : Profile
    {
        public AccountProfile()
        {
            CreateMap<Account, AccountViewModel>();
            CreateMap<AccountViewModel, Account>();

            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AccountProfile>();
            });
        }

    }
}