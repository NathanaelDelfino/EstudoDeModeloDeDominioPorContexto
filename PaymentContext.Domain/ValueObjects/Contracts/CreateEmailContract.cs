using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Validations;

namespace PaymentContext.Domain.ValueObjects.Contracts
{
    public class CreateEmailContract : Contract<Email>
    {
       public CreateEmailContract(Email email)
       {
            Requires()
                .IsNullOrEmpty(email.Address, "Address", "O email não pode ser vazio")
                .IsEmail(email.Address, "Address", "O email digitado não é valido");
       }
    }
}