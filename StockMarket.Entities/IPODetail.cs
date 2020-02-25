using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Entities
{
   public class IPODetail
   {
        public virtual int Id { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string StockExchange { get; set; }
        public virtual float PricePerShare { get; set; }
        public virtual int TotalNoOfShares { get; set; }
        public virtual DateTime OpenDateTime { get; set; }
        public virtual string Remarks { get; set; }
   }
}
