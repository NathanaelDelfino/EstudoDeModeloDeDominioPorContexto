using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Validations;

namespace PaymentContext.Domain.ValueObjects.Contracts
{
    public class CreateAddressContract : Contract<Address>
    {
        public CreateAddressContract(Address address)
        {
            Requires()
                //City
                .IsNullOrEmpty(address.City, "City", "Uma cidade deve ser informada.")
                .IsGreaterThan(address.City, 3, "City", "Nome da cidade é muito pequeno")
                .IsLowerOrEqualsThan(address.City, 30, "City", "O nome deve ter até 30 caracteres")
                //Country
                .IsNullOrEmpty(address.Country, "Country", "Uma PAIS deve ser informada.")
                .IsGreaterThan(address.Country, 3, "Country", "Nome do pais é muito pequeno")
                .IsLowerOrEqualsThan(address.Country, 30, "Country", "O nome do pais deve ter até 30 caracteres")
                //Street
                .IsNullOrEmpty(address.Street, "Street", "Uma rua deve ser informada.")
                .IsGreaterThan(address.Street, 3, "Street", "O nome da rua é muito pequeno")
                .IsLowerOrEqualsThan(address.Street, 30, "Street", "O nome da rua deve ter até 30 caracteres");
            
        }   
    }
}