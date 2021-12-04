using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document : ValueObject
    {
        public string Number { get; private set; }
        public EDocumentType Type { get; private set; }

        public Document(string number, EDocumentType type)
        {
            Number = Regex.Replace(number, "[0-9]","");
            Type = type;
        } 

        
        private bool Valid(){
           
            var retorno = false;
            switch (Type)
            {
                case EDocumentType.CPF:
                    retorno = ValidarCPF();
                    break;
                case EDocumentType.CNPJ:
                    retorno = ValidarCNPJ();
                    break;
                default:
                    break;
            }
            return retorno;
        }

        private bool ValidarCPF(){ return true;}
        private bool ValidarCNPJ(){return true;}

    }
}