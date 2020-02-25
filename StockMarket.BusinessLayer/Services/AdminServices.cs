using StockMarket.DataLayer.NHibernateConfigurations;
using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.BusinessLayer.Services
{
   public class AdminServices:IAdminServices
    {
        private readonly IMapperSession _session;

        public AdminServices(IMapperSession session)
        {
            _session = session;
        }


        public bool AddCompany(List<Company> company)
        {
            if (company != null)
            {
                _session.Save(company);
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool DeleteCompany(int Id)
        {
            return true;
        }


        public Company EditCompany(int Id)
        {
            Company Company = new Company();
            return Company;
        }


        public Company GetCompanyById(int Id)
        {
            Company Company = new Company();
            return Company;
        }


        public IPODetail GetIPOById(int Id)
        {
            IPODetail IPOdetail = new IPODetail();
            return IPOdetail;
        }


        public bool ImportData(object file)
        {
            return true;
        }


        public IPODetail UpdateIPODetail(int Id)
        {
            IPODetail IPOdetail= new IPODetail();
            return IPOdetail;
        }


        public Company ViewCompany(int  Id)
        {
           Company CompanyList = new Company();
            return CompanyList;
        }
    }
}
