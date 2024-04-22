using System.Net;
using Trading212.API.DTOs.Responses.Portfolios;
using Trading212.API.Services;
using Trading212.API.Tests.Fixtures;
using Xunit;

namespace Trading212.API.Tests
{
    public class PortfolioServiceTests : IDisposable
    {
        private readonly PortfolioService _service;

        public PortfolioServiceTests()
        {
            _service = new PortfolioService(GlobalFixtures.CreateConfig());
        }

        [Fact]
        public async Task Given_a_portfolio_service_When_retrieving_position_list_Then_a_list_of_position_objects_is_returned()
        {
            // ACT
            var result = await _service.GetPositionListAsync();

            // ASSERT
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.NotEmpty(result.Data);
            Assert.IsType<List<Position>>(result.Data);
        }

        [Fact]
        public async Task Given_a_portfolio_service_and_ticker_When_retrieving_a_position_Then_a_position_object_is_returned()
        {
            // Act
            var result = await _service.GetPositionAsync(GlobalFixtures.Ticker);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.NotEmpty(result.Data);
            Assert.IsType<List<Position>>(result.Data);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}
