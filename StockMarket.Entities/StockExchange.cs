using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Entities
{
   public class StockExchange
   {
        public virtual int Id { get; set; }
        public virtual string Stockexchange { get; set; }
        public virtual string ContactAdress { get; set; }
        public virtual string Brief { get; set; }
        public virtual string Remarks { get; set; }
   }
}
