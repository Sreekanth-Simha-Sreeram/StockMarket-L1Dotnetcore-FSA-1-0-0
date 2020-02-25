using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Entities
{
     public class Chart
     {
        public virtual StockPrice StockPrice { get; set; }
        public virtual DateTime  FromDate { get; set; }
        public virtual DateTime ToDate { get; set; }
     }
}
