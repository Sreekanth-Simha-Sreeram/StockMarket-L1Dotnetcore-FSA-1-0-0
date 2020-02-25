using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Entities
{
   public class Company
   { 
        public virtual int Id { get; set; }
        public virtual string CompanyName { get; set; }
        public virtual string CEO { get; set; }
        public virtual string BoardDirectors { get; set; }
        public virtual double TurnOver { get; set; }
        public virtual string CompanyStockCode { get; set; }
   }
}
