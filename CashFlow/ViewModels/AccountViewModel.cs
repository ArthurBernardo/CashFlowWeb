using System;
using System.ComponentModel.DataAnnotations;

namespace CashFlow.ViewModels
{
    public class AccountViewModel
    {
        public Guid AccountId { get; set; }

        [Required(ErrorMessage = "Digite seu o nome da sua empresa")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Digite seu nome completo")]
        public string NameUser { get; set; }

        [Required(ErrorMessage = "Digite o CNPJ da sua empresa")]
        public int Cnpj { get; set; }

        [Required(ErrorMessage = "Digite o CEP da sua empresa")]
        public int Cep { get; set; }
        public string Address { get; set; }
        public string AddressCity { get; set; }
        public string AddressState { get; set; }
        public int AddressNumber { get; set; }

        [Required(ErrorMessage = "Digite o seu e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite sua senha")]
        public int Passoword { get; set; }
    }
}