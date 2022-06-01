using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentContext.Shared.Repositories
{
    public interface IRepository
    {
       bool Update(string comand); 
       bool Insert(string comand); 
       bool Open(string conection);
    }
}