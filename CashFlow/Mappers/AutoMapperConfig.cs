using AutoMapper;
using CashFlow.Models;
using CashFlow.ViewModels;

namespace CashFlow.Mappers
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Account, AccountViewModel>();
                cfg.CreateMap<AccountViewModel, Account>();
            });

            var mapper = configuration.CreateMapper();

            //var accountViewModel = mapper.Map<AccountViewModel>(account);

        }

    }
}