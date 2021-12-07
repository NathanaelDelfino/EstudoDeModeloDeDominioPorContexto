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

        public Document(string number)
        {
            Number = Regex.Replace(number, "[0-9]","");
        } 


        private EDocumentType GetDocumentTypeByNumberLength(string number){
            if(Regex.Replace(number, "[0-9]","").Length == 11)
                return EDocumentType.CPF ;
            if(Regex.Replace(number, "[0-9]","").Length == 14)
                return EDocumentType.CNPJ;
            
            return EDocumentType.Desconhecido;
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
                    return false;
                    break;
            }
            return retorno;
        }

        private bool ValidarCPF(){ return true;}
        private bool ValidarCNPJ(){return true;}

    }
}