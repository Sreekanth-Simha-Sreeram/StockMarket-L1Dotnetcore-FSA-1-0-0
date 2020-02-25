using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Entities
{
   public class StockPrice
   {
        public virtual int Id { get; set; }
        public virtual string CompanyCode { get; set; }
        public virtual string StockExchange { get; set; }
        public virtual float CurrentPrice { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual DateTime Time { get; set; }
   }
}
