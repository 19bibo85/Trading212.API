using Trading212.API.Services;

namespace Trading212.API.Tests.Fixtures
{
    public class OrderServiceFixture : IDisposable
    {
        internal readonly OrderService Service = new(GlobalFixtures.CreateConfig());

        internal long CreateLimitOrder()
        {
            var order = Service
               .CreateLimitOrderAsync(OrderFixtures.CreateLimitOrderRequest())
               .GetAwaiter()
               .GetResult();            

            return order?.Data?.Id ?? 0;
        }

        public virtual void Dispose()
        {
            var orders = Service
                .GetOrdersAsync()
                .GetAwaiter()
                .GetResult();

            foreach (var order in orders.Data ?? [])
            {
                Service
                .CancelOrderAsync(order?.Id ?? 0)
                .GetAwaiter()
                .GetResult();
            }

            GC.SuppressFinalize(this);
        }
    }
}
