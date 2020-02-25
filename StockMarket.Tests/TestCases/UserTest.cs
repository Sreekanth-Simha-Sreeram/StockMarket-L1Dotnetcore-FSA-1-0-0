

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
   
   public class UserTest
    {

        private readonly UserServices _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();


        public UserTest()
        {
            _service = new UserServices(_session);
        }

        [Fact]
        public void TestForSearchCompany()
        {

            //Arrange
            Company company = new Company() { CompanyName = "MS" };
            

            //Action
            Company companydetails = _service.SearchCompany(company.CompanyName);

            //Assert
            Assert.Equal(company, companydetails);
        }


        [Fact]
        public void UpdateProfile()
        {
            //Arrange
            User user = new User{Id = 10, UserName = "john", PassWord = "1234", UserType = "1", Email = "jphn@gmail.com", MobileNumber = 9923568547};

            //Action
            var updtedUser = _service.UpdateProfile(user.UserName);
            var DbUpdatedUser = _service.GetUserById(user.Id);
            //Assert
            Assert.Equal(DbUpdatedUser, updtedUser);

        }



    }
}

