using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lykke.Service.Dictionaries.Domain.Entities;
using Lykke.Service.Dictionaries.Domain.Repositories;
using Lykke.Service.Dictionaries.DomainServices;
using Lykke.Service.Dictionaries.MsSqlRepositories.Repositories;
using Moq;
using Xunit;

namespace Lykke.Service.Dictionaries.Tests
{
    public class SalesforceServiceTests
    {
        private SalesforceService _service;

        private readonly Mock<ICountryOfResidenceRepository> _countryOfResidenceRepositoryMock =
            new Mock<ICountryOfResidenceRepository>();

        private readonly Mock<ICountryPhoneCodeRepository> _countryPhoneCodeRepositoryMock =
            new Mock<ICountryPhoneCodeRepository>();

        public SalesforceServiceTests()
        {
            _service = new SalesforceService(_countryOfResidenceRepositoryMock.Object,
                _countryPhoneCodeRepositoryMock.Object);
        }
        
        [Fact]
        public async Task When_GetCountriesOfResidenceAsync_Called_Expect_FilteredAndOrderedResult()
        {
            //Arrange
            var dbResult = new List<CountryOfResidence>
            {
                new CountryOfResidence {IsAvailable = true, Id = 1, Name = "Bulgaria", Order = 1},
                new CountryOfResidence {IsAvailable = false, Id = 2, Name = "Japan", Order = 2},
                new CountryOfResidence {IsAvailable = true, Id = 3, Name = "Brazil", Order = 3},
            };

            _countryOfResidenceRepositoryMock.Setup(x => x.GetAllAsync())
                .ReturnsAsync(dbResult);

            //Act
            var response = await _service.GetCountriesOfResidenceAsync();

            //Assert
            var expectedResult = dbResult
                .Where(o => o.IsAvailable)
                .OrderBy(o => o.Order)
                .ToList();

            _countryOfResidenceRepositoryMock.Verify(x => x.GetAllAsync(), Times.Once);
            Assert.Equal(expectedResult.Count, response.Count);
            Assert.Equal(expectedResult[0].Order, response[0].Order);
        }

        [Fact]
        public async Task When_GetCountryPhoneCodesAsync_Called_Expect_FilteredAndOrderedResult()
        {
            //Arrange
            var dbResult = new List<CountryPhoneCode>
            {
                new CountryPhoneCode
                {
                    Id = 1,
                    Order = 1,
                    IsAvailable = true,
                    Code = "en",
                    CountryName = "England",
                    IsoCode = "iso"
                },
                new CountryPhoneCode
                {
                    Id = 2,
                    Order = 2,
                    IsAvailable = false,
                    Code = "gb",
                    CountryName = "Albion",
                    IsoCode = "iso2"
                },
                new CountryPhoneCode
                {
                    Id = 3,
                    Order = 3,
                    IsAvailable = true,
                    Code = "bg",
                    CountryName = "Bulgaria",
                    IsoCode = "iso3"
                },
            };

            _countryPhoneCodeRepositoryMock.Setup(x => x.GetAllAsync())
                .ReturnsAsync(dbResult);

            //Act
            var response = await _service.GetCountryPhoneCodesAsync();

            //Assert
            var expectedResult = dbResult
                .Where(o => o.IsAvailable)
                .OrderBy(o => o.Order)
                .ToList();

            _countryPhoneCodeRepositoryMock.Verify(x => x.GetAllAsync(), Times.Once);
            Assert.Equal(expectedResult.Count, response.Count);
            Assert.Equal(expectedResult[0].Order, response[0].Order);
        }

        [Fact]
        public async Task When_GetCountryOfResidenceByIdAsync_Called_Expect_DbCalled()
        {
            //Arrange
            var id = 1;
            _countryOfResidenceRepositoryMock.Setup(x => x.GetById(id));

            //Act
            var response = await _service.GetCountryOfResidenceByIdAsync(id);

            //Assert
            _countryOfResidenceRepositoryMock.Verify(x => x.GetById(id), Times.Once);
        }

        [Fact]
        public async Task When_GetCountryPhoneCodeByIdAsync_Called_Expect_DbCalled()
        {
            //Arrange
            var id = 1;
            _countryPhoneCodeRepositoryMock.Setup(x => x.GetById(id));

            //Act
            var response = await _service.GetCountryPhoneCodeByIdAsync(id);

            //Assert
            _countryPhoneCodeRepositoryMock.Verify(x => x.GetById(id), Times.Once);
        }

    }
}
