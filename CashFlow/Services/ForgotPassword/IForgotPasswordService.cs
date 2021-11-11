using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CashFlow.Services.ForgotPassword
{
    public interface IForgotPasswordService
    {
        bool HaveEmail(string email);
        DataCashFlow.Models.Accounts Get(string email);
        void Edit(DataCashFlow.Models.Accounts account);
    }
}