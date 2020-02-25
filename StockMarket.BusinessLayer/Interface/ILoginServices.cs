using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.BusinessLayer.Interfaces
{
   public interface ILoginServices
    {
        bool Login(String UserName,String Password,string UserType);
        bool SignUp(User user);
    }
}
