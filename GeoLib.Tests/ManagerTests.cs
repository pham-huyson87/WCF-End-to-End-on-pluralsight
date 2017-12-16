using GeoLib.Contracts;
using GeoLib.Data;
using GeoLib.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GeoLib.Tests
{
    [TestClass]
    public class ManagerTests
    {
        [TestMethod]
        public void GetZipInfoTest()
        {
            // Arrange
            Mock<IZipCodeRepository> mockZipCodeRepository = new Mock<IZipCodeRepository>();

            ZipCode zipCode = new ZipCode()
            {
                City = "LINCOLN PARK",
                State = new State() { Abbreviation = "NJ" },
                Zip = "07035"
            };

            mockZipCodeRepository
                            .Setup(mock =>
                                        mock.GetByZip("07035"))     // When got this exact call,
                                            .Returns(zipCode);      // return zipCode

            IGeoService geoService = new GeoManager(mockZipCodeRepository.Object);  // We inject a instance of ZipCodeRepository

            // Act
            ZipCodeData data = geoService.GetZipInfo("07035");

            // Assert
            Assert.IsTrue(
                        data.City.ToUpper() == "LINCOLN PARK" &&
                        data.State == "NJ"
                    );
        }
    }
}
