using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Validations;

namespace PaymentContext.Domain.ValueObjects.Contracts
{
    public class CreateNameContract : Contract<Name>
    {
        public CreateNameContract(Name name)
        {
            Requires()
                .IsNotNullOrEmpty(name.FirstName, "FirstName", "O campo Nome é obrigatorio.")
                .IsGreaterThan(name.FirstName, 3,"FirstName", "O Nome tem de ter mais de 3 caracteres" )                
                .IsLowerOrEqualsThan(name.FirstName, 30,"FirstName", "O Nome não pode ter mais de 30 caracteres")
                .IsNotNullOrEmpty(name.LastName, "LastaName", "O campo Sobrenome é obrigatorio.")
                .IsGreaterThan(name.LastName, 3,"LastName", "O Nome tem de ter mais de 3 caracteres" )
                .IsLowerOrEqualsThan(name.LastName, 30, "LastName", "O sobre nome não pode ter mais de 30 caracteres");
        }   
    }
}