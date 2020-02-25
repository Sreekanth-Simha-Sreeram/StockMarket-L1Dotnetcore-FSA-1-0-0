using NSubstitute;
using StockMarket.BusinessLayer.Services;
using StockMarket.DataLayer.NHibernateConfigurations;
using StockMarket.Entities;
using StockMarket.Tests.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace StockMarket.Tests.TestCases
{
    public class ExceptionTest
    {
        private readonly UserServices _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();


        public ExceptionTest()
        {
            _service = new UserServices(_session);
        }

        [Fact]
        public void ExceptionTestForCompanyNotFound()
        {

            //Arrange
            Company company = new Company()
            {
                Id = 1,
                CompanyName = "Mobile",
                CEO = "2",
                BoardDirectors = "400",
                TurnOver = 2,
                CompanyStockCode = "2"
            };
            User user = new User { Id = 10, UserName = "john", PassWord = "1234", UserType = "1", Email = "jphn@gmail.com", MobileNumber = 9923568547 };

            var SerchedCompoany = _service.SearchCompany("IBM");
            var DbUpdatedUser = _service.GetUserById(user.Id);


            //Assert
            var ex = Assert.Throws<CompanyNotFoundException>(() => _service.SearchCompany("IBM"));
            Assert.Equal("Company Not Found in Tasks List", ex.Messages);
        }


        [Fact]
        public void BoundaryTestForPassword()
        {
            User user = new User { Id = 10, UserName = "john", PassWord = "1234567890", UserType = "1", Email = "jphn@gmail.com", MobileNumber = 9923568547 };
            var MaxLenghthRequired = 10;

            //Action
           var actualLenghth = user.PassWord.Length;

            //Assert
            Assert.Equal(MaxLenghthRequired, actualLenghth);


        }
    }
}
