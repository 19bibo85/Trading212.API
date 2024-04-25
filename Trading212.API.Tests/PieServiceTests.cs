using System.Net;
using Trading212.API.DTOs.Enums;
using Trading212.API.DTOs.Responses.Pies;
using Trading212.API.Tests.Fixtures;
using Trading212.API.Tests.Fixtures.Fixtures;
using Xunit;

namespace Trading212.API.Tests
{
    public class PieServiceTests : IClassFixture<PieServiceFixture>
    {
        private readonly PieServiceFixture _pieServiceFixture;

        public PieServiceTests(PieServiceFixture pieServiceFixture)
        {
            _pieServiceFixture = pieServiceFixture;
        }

        [Fact]
        public async Task Given_a_pie_service_When_retrieving_a_list_of_pie_Then_a_list_of_pie_objects_is_returned()
        {
            // Arrange
            _pieServiceFixture.CreatePie();

            // Act
            var result = await _pieServiceFixture.Service.GetPiesAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.NotEmpty(result.Data);
            Assert.IsType<List<Pies>>(result.Data);
        }

        [Fact]
        public async Task Given_a_pie_service_When_creating_a_pie_Then_a_pie_is_created()
        {
            // Arrange
            var pieRequest = PieFixtures.CreatePieRequest();

            // Act
            var result = await _pieServiceFixture.Service.CreatePieAsync(pieRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<Pie>(result.Data);
            Assert.IsType<Settings>(result.Data.Settings);
            Assert.Equal(PieDividendCashAction.REINVEST, result.Data.Settings.DividendCashAction);
            Assert.NotNull(result.Data.Settings.EndDate);
            Assert.Equal(PieIcon.Unicorn, result.Data.Settings.Icon);
            Assert.NotNull(result.Data.Instruments);
            Assert.NotEmpty(result.Data.Instruments);
            Assert.Equal(GlobalFixtures.Ticker, result.Data.Instruments[0].Ticker);
            Assert.NotNull(result.Data.Settings.Name);
        }

        [Fact]
        public async Task Given_a_pie_service_When_deleting_a_pie_Then_the_pie_is_deleted()
        {
            // Arrange
            var id = _pieServiceFixture.CreatePie();

            // Act
            var result = await _pieServiceFixture.Service.DeletePieAsync(id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
        }

        [Fact]
        public async Task Given_a_pie_service_When_retrieving_a_pie_Then_a_pie_object_is_returned()
        {
            // Arrange
            var id = _pieServiceFixture.CreatePie();

            // Act
            var result = await _pieServiceFixture.Service.GetPieAsync(id);
            
            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<Pie>(result.Data);
        }

        [Fact]
        public async Task Given_a_pie_service_When_updating_a_pie_Then_a_pie_is_updated()
        {
            // Arrange
            var id = _pieServiceFixture.CreatePie();
            var pieRequest = PieFixtures.CreatePieRequest();
            pieRequest.Name = $"Updated Pie {DateTime.UtcNow.Ticks}";

            // Act
            var result = await _pieServiceFixture.Service.UpdatePieAsync(id, pieRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<Pie>(result.Data);
        }
    }    
}
