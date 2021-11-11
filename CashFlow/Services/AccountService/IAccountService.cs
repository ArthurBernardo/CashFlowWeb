using DataCashFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Services.AccountService
{
    public interface IAccountService
    {
        void Save(Accounts account);

        void Edit(Accounts account);
    }
}
