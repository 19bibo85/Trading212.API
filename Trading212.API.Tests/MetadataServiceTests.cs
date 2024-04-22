using System.Net;
using Trading212.API.Services;
using Trading212.API.Tests.Fixtures;
using Xunit;

namespace Trading212.API.Tests
{
    public class MetadataServiceTests : IDisposable
    {
        private readonly MetadataService _service;

        public MetadataServiceTests()
        {
            _service = new MetadataService(GlobalFixtures.CreateConfig());
        }        

        [Fact]
        public async Task Given_a_metadata_service_When_retrieving_exchange_list_Then_a_list_of_exchange_objects_is_returned()
        {
            // Act
            var result = await _service.GetExchangeListAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.NotEmpty(result.Data);
        }

        [Fact]
        public async Task Given_a_metadata_service_When_retrieving_instrument_list_Then_a_list_of_instrument_objects_is_returned()
        {
            // Act
            var result = await _service.GetInstrumentListAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.NotEmpty(result.Data);
        }

        public void Dispose()
        {
           _service.Dispose();
        }
    }
}
