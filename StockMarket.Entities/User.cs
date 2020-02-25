using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Entities
{
   public class User
   {
        public virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string PassWord { get; set; }
        public virtual string UserType { get; set; }
        public virtual string Email { get; set; }
        public virtual long MobileNumber { get; set; }
   }
}
