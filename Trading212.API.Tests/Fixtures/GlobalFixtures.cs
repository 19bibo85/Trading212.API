using Trading212.API.Enums;

namespace Trading212.API.Tests.Fixtures
{
    internal class GlobalFixtures
    {
        internal const string Ticker = "AAPL_US_EQ";

        internal static Trading212ConfigBuilder FakeConfigBuilder => Trading212ConfigBuilder.Create("FAKE-API-KEY");

        internal static Trading212Config CreateConfig()
        {
            var environmentVariable = Environment.GetEnvironmentVariable("TRADING212_API_KEY");
            if (environmentVariable == null)
                throw new ArgumentNullException("Please make sure to set your API Key in the environment variable TRADING212_API_KEY");

            var config = Trading212ConfigBuilder
                .Create(environmentVariable)
                .WithEnvironment(Environments.Demo)
                .Build();

            return config;
        }
    }
}
