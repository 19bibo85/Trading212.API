using System.Net;
using Trading212.API.Services;
using Trading212.API.Tests.Fixtures;
using Xunit;

namespace Trading212.API.Tests
{
    public class AccountServiceTests : IDisposable
    {
        private readonly AccountService _service;

        public AccountServiceTests() 
        {
            _service = new AccountService(GlobalFixtures.CreateConfig());
        }

        [Fact]
        public async Task Given_an_account_service_When_retrieving_cash_Then_a_cash_object_is_returned()
        {
            // Act
            var result = await _service.GetCashAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
        }

        [Fact]
        public async Task Given_an_account_service_When_retrieving_metadata_Then_a_metadata_object_is_returned()
        {
            // Act
            var result = await _service.GetMetadataAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}
