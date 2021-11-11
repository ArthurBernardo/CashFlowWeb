using CashFlow.Models;
using DataCashFlow.Models;
using DataCashFlow.UnitOfWork;

namespace CashFlow.Services.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly IBaseUnitOfWork _baseUnitOfWork;

        public AccountService(IBaseUnitOfWork baseUnitOfWork)
        {
            _baseUnitOfWork = baseUnitOfWork;
        }

        public void Save(Accounts account)
        {
            _baseUnitOfWork.RepositoryBase.Add<Accounts>(account);
            _baseUnitOfWork.Commit();
        }

        public void Edit(Accounts account)
        {
            _baseUnitOfWork.RepositoryBase.Edit<Accounts>(account);
            _baseUnitOfWork.Commit();
        }
    }
}