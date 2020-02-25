using FluentNHibernate.Mapping;
using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockMarket.DataLayer.Mapping
{
    class CompanyMap : ClassMap<Company>
    {

        public CompanyMap()
        {
            Id(x => x.Id);

            Map(x => x.CompanyName);

            Map(x => x.CEO);
            Map(x => x.BoardDirectors);
            Map(x => x.TurnOver);
            Map(x => x.CompanyStockCode);
            Table("Company");

        }

    }
}
