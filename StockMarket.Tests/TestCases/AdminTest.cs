
using NSubstitute;
using StockMarket.BusinessLayer.Services;
using StockMarket.DataLayer.NHibernateConfigurations;
using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Stock.Tests.TestCases
{
    
   public class AdminTest
    {

        private readonly AdminServices _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();


        public AdminTest()
        {
            _service = new AdminServices(_session);
        }

        // bool AddCompany(Company company);
        [Fact]
        public void TestForAddCompany()
        {
            
              Company company = new Company()
            {
                Id = 1,
                CompanyName = "Mobile",
                CEO = "2",
                BoardDirectors = "400",
                TurnOver = 2,
                CompanyStockCode = "2"


            };

            List<Company> itemlist = new List<Company>();
            itemlist.Add(company);

            //Action
            var IsAdded = _service.AddCompany(itemlist);

            //Assert
             Assert.Equal(true, IsAdded);
 
        }

       
        [Fact]
        public void TestForDeleteCompany()
        {
            //Arrange
            Company company = new Company();
            var id = company.Id;
           
            //Action
            var isDeleted = _service.DeleteCompany(id);

            //Assert
            Assert.Equal(true, isDeleted);
        }


        [Fact] 
        public void EditCompany()
        {
            //Company EditCompany(int Id)
            Company company = new Company();
            var id = company.Id;
          

            //Action
            Company editedcompany = _service.EditCompany(id);
            Company editsCompany = _service.GetCompanyById(id);


            //Assert
            Assert.Equal(editsCompany, editedcompany);


        }


        [Fact]
        public void EditIPODetails()
        {
            //Company EditCompany(int Id)
            IPODetail ipoDetails = new IPODetail() { Id = 11, CompanyName = "MS" };
            var id = ipoDetails.Id;

           //Action
            IPODetail editedIPODetails = _service.UpdateIPODetail(id);
            IPODetail editedIpoFromDb = _service.GetIPOById(id);

            //Assert
            Assert.Equal(editedIpoFromDb, editedIPODetails);
        }


        [Fact]
        public void ViewTasksForUserTest()
        {
            Company company = new Company()
            {
                Id = 1,
                CompanyName = "Mobile",
                CEO = "2",
                BoardDirectors = "400",
                TurnOver = 2,
                CompanyStockCode = "2"
            };

            //Action
            var viewedCompany =_service.ViewCompany(company.Id);

            //Assert
            Assert.Equal(company.Id,viewedCompany.Id);
        }


    }
}