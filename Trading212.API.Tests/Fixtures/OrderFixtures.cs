using Trading212.API.DTOs.Enums;
using Trading212.API.DTOs.Requests.Orders;

namespace Trading212.API.Tests.Fixtures
{
    internal static class OrderFixtures
    {
        internal static LimitOrderRequest CreateLimitOrderRequest()
        {
            var limit = new LimitOrderRequest()
            {
                LimitPrice = 1.0m,
                Quantity = 1.0m,
                Ticker = GlobalFixtures.Ticker,
                TimeValidity = TimeValidity.Day
            };

            return limit;
        }

        internal static MarketOrderRequest CreateMarketOrderRequest()
        {
            var market = new MarketOrderRequest()
            {
                Quantity = 1.0m,
                Ticker = GlobalFixtures.Ticker
            };

            return market;
        }

        internal static StopOrderRequest CreateStopOrderRequest()
        {
            var stop = new StopOrderRequest()
            {
                Quantity = 1.0m,
                StopPrice = 340.0m,
                Ticker = GlobalFixtures.Ticker,
                TimeValidity = TimeValidity.Day
            };

            return stop;
        }

        internal static StopLimitOrderRequest CreateStopLimitOrderRequest()
        {
            var stopLimit = new StopLimitOrderRequest()
            {
                LimitPrice = 1.0m,
                Quantity = 1.0m,
                StopPrice = 340.0m,
                Ticker = GlobalFixtures.Ticker,
                TimeValidity = TimeValidity.Day
            };

            return stopLimit;
        }
    }
}
