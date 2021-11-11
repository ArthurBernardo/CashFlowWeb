using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CashFlow.Models
{
    public class Account
    {
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Address { get; set; }
        public int AddressNumber { get; set; }
        public string AddressNeighborhood { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public string AddressCep { get; set; }
        public string NameUser { get; set; }
        public string Email { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
    }
}