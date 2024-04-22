using Trading212.API.Services;

namespace Trading212.API.Tests.Fixtures.Fixtures
{
    public class PieServiceFixture : IDisposable
    {
        internal readonly PieService Service = new(GlobalFixtures.CreateConfig());

        internal long CreatePie()
        {
            var pie = Service
               .CreatePieAsync(PieFixtures.CreatePieRequest())
               .GetAwaiter()
               .GetResult();

            return pie?.Data?.Settings?.Id ?? 0;
        }

        public virtual void Dispose()
        {
            var pies = Service
                .GetPiesAsync()
                .GetAwaiter()
                .GetResult();

            foreach (var pie in pies.Data ?? [])
            {
                Service
                .DeletePieAsync(pie.Id ?? 0)
                .GetAwaiter()
                .GetResult();
            }

            GC.SuppressFinalize(this);
        }
    }
}
