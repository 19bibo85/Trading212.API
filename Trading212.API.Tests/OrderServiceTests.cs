using System.Net;
using Trading212.API.DTOs.Responses.Orders;
using Trading212.API.Tests.Fixtures;
using Xunit;

namespace Trading212.API.Tests
{
    public class OrderServiceTests : IClassFixture<OrderServiceFixture>
    {
        private readonly OrderServiceFixture _orderServiceFixture;

        public OrderServiceTests(OrderServiceFixture orderServiceFixture)
        {
            _orderServiceFixture = orderServiceFixture;
        }

        [Fact]
        public async Task Given_an_order_service_When_retrieving_a_list_of_orders_Then_a_list_of_order_objects_is_returned()
        {
            // Act
            var result = await _orderServiceFixture.Service.GetOrdersAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<List<Order>>(result.Data);
        }

        [Fact]
        public async Task Given_an_order_service_When_creating_a_limit_order_Then_a_limit_order_is_created()
        {
            // Arrange
            var limitOrderRequest = OrderFixtures.CreateLimitOrderRequest();

            // Act
            var result = await _orderServiceFixture.Service.CreateLimitOrderAsync(limitOrderRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<Order>(result.Data);
            Assert.Equal(1.0m, result.Data.LimitPrice);
            Assert.Equal(1.0m, result.Data.Quantity);
            Assert.Equal(GlobalFixtures.Ticker, result.Data.Ticker);
        }

        
        [Fact(Skip = "Avoid creating multiple market orders")]
        public async Task Given_an_order_service_When_creating_a_market_order_Then_a_market_order_is_created()
        {
            // Arrange
            var marketOrderRequest = OrderFixtures.CreateMarketOrderRequest();

            // Act
            var result = await _orderServiceFixture.Service.CreateMarketOrderAsync(marketOrderRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<Order>(result.Data);
        }
        
        [Fact(Skip = "Stop price should be based on the market price")]
        public async Task Given_an_order_service_When_creating_a_stop_order_Then_a_stop_order_is_created()
        {
            // Arrange
            var stopOrderRequest = OrderFixtures.CreateStopOrderRequest();

            // Act
            var result = await _orderServiceFixture.Service.CreateStopOrderAsync(stopOrderRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<Order>(result.Data);
        }

        [Fact(Skip = "This endpoint seems not working")]
        public async Task Given_an_order_service_When_creating_a_stop_limit_order_Then_a_stop_limit_order_is_created()
        {
            // Arrange
            var stopLimitOrderRequest = OrderFixtures.CreateStopLimitOrderRequest();

            // Act
            var result = await _orderServiceFixture.Service.CreateStopLimitOrderAsync(stopLimitOrderRequest);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<Order>(result.Data);
        }

        [Fact]
        public async Task Given_an_order_service_When_cancelling_an_order_Then_the_order_is_cancelled()
        {
            // Arrange            
            var orderId = _orderServiceFixture.CreateLimitOrder();

            // Act
            var result = await _orderServiceFixture.Service.CancelOrderAsync(orderId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
        }

        [Fact]
        public async Task Given_an_order_service_When_retrieving_an_orders_Then_the_order_object_is_returned()
        {
            // Arrange
            var orderId = _orderServiceFixture.CreateLimitOrder();

            // Act
            var result = await _orderServiceFixture.Service.GetOrderAsync(orderId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(HttpStatusCode.OK, result.Status);
            Assert.Equal("OK", result.Message);
            Assert.NotNull(result.Data);
            Assert.IsType<Order>(result.Data);
        }
    }
}
