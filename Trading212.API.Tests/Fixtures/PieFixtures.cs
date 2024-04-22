using Trading212.API.DTOs.Enums;
using Trading212.API.DTOs.Requests.Pies;

namespace Trading212.API.Tests.Fixtures
{
    internal static class PieFixtures
    {
        internal static PieRequest CreatePieRequest()
        {
            var pie = new PieRequest()
            {
                DividendCashAction = DividendCashAction.Reinvest,
                EndDate = DateTime.UtcNow.Date.AddDays(1),
                Goal = 10,
                Icon = Icon.Unicorn,
                InstrumentShares = new InstrumentSharesRequest()
                {
                    { GlobalFixtures.Ticker, 1.0m }

                },
                Name = $"Pie {DateTime.UtcNow.Ticks}",
            };

            return pie;
        }
    }
}
