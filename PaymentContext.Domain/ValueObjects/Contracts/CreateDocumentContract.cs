using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flunt.Validations;
using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.ValueObjects.Contracts
{
    public class CreateDocumentContract : Contract<Document>
    {
        public CreateDocumentContract(Document document)
        {
            Requires()
                .IsNullOrEmpty(document.Number, "Number", "É necessário indormar um documento");

            if(document.Type == EDocumentType.CPF)
                    Requires()
                        .AreEquals(document.Number, 11,"Number","Um CPF deve possuir 11 digitos");                        

            if(document.Type == EDocumentType.CNPJ)
                    Requires()
                        .AreEquals(document.Number, 14,"Number","Um CNPJ deve possuir 14 digitos");
                        
        }

    }
}