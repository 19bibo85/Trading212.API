using System.Net;
using Trading212.API.DTOs.Requests.Historicals;
using Trading212.API.DTOs.Responses.Historicals;
using Trading212.API.Services;
using Trading212.API.Tests.Fixtures;
using Xunit;

namespace Trading212.API.Tests
{
    public class HistoricalServiceTests : IDisposable
    {
        private readonly HistoricalService _service;

        public HistoricalServiceTests()
        {
            _service = new HistoricalService(GlobalFixtures.CreateConfig());
        }

        [Fact]
        public async Task Given_a_historical_service_and_order_request_When_retrieving_orders_Then_an_order_object_with_its_items_is_returned()
        {
            // Arrange
            var orderRequest = new OrderRequest()
            {
                Ticker = GlobalFixtures.Ticker
            };

            // Act
            var result = await _service.GetOrdersAsync(orderRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<Order>(result.Data);
            Assert.NotNull(result.Data.Items);
            Assert.NotEmpty(result.Data.Items);
            Assert.IsType<List<OrderItem>>(result.Data.Items);
        }

        [Fact(Skip = "Dividends might not be paid yet")]
        public async Task Given_a_historical_service_and_order_request_When_retrieving_dividends_Then_an_dividend_object_with_its_items_is_returned()
        {
            // Arrange            
            var dividendRequest = new DividendRequest()
            {
                Ticker = GlobalFixtures.Ticker
            };

            // Act
            var result = await _service.GetDividendsAsync(dividendRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<Dividend>(result.Data);
            Assert.NotNull(result.Data.Items);
            Assert.NotEmpty(result.Data.Items);
            Assert.IsType<List<Dividend>>(result.Data.Items);
        }

        [Fact(Skip = "This endpoint is not available in demo mode")]
        public async Task Given_a_historical_service_When_retrieving_export_data_Then_a_list_of_export_objects_is_returned()
        {
            // Act
            var result = await _service.GetExportsAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.NotEmpty(result.Data);
            Assert.IsType<List<Export>>(result.Data);
        }

        [Fact(Skip = "This endpoint is not available in demo mode")]
        public async Task Given_a_historical_service_and_export_request_When_requesting_to_export_a_csv_file_Then_a_file_id_returned()
        {
            // Arrange
            var exportRequest = new ExportRequest();

            // Act
            var result = await _service.GetExportCsvAsync(exportRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<ExportCsv>(result.Data);
    }

        [Fact(Skip = "Transactions might not be available yet")]
        public async Task Given_a_historical_service_and_transaction_request_When_retrieving_transactions_Then_a_transaction_object_with_its_items_is_returned()
        {
            // Arrange
            var transactionRequest = new TransactionRequest();

            // Act
            var result = await _service.GetTransactionsAsync(transactionRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<Transaction>(result.Data);
            Assert.NotNull(result.Data.Items);
            Assert.NotEmpty(result.Data.Items);
            Assert.IsType<List<TransactionItem>>(result.Data.Items);
        }

        public void Dispose()
        {
            _service.Dispose();
        }
    }
}
