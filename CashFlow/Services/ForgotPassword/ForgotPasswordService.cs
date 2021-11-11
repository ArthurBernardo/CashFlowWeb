using CashFlow.Models;
using DataCashFlow.Models;
using DataCashFlow.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashFlow.Services.ForgotPassword
{
    public class ForgotPasswordService : IForgotPasswordService
    {
        private readonly IBaseUnitOfWork _baseUnitOfWork;

        public ForgotPasswordService(IBaseUnitOfWork baseUnitOfWork)
        {
            _baseUnitOfWork = baseUnitOfWork;
        }

        public bool HaveEmail(string email)
        {
            var haveEmail = _baseUnitOfWork.RepositoryBase.Get<DataCashFlow.Models.Accounts>(a => a.Email == email);
            if (haveEmail.Any())
                return true;
            
            return false;
        }

        public DataCashFlow.Models.Accounts Get(string email)
        {
           return _baseUnitOfWork.RepositoryBase.Get<DataCashFlow.Models.Accounts>(a => a.Email == email).FirstOrDefault();
        }

        public void Edit(DataCashFlow.Models.Accounts account)
        {
            _baseUnitOfWork.RepositoryBase.Edit<Accounts>(account);
            _baseUnitOfWork.Commit();
        }
    }
}