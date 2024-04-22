using Trading212.API.Enums;
using Trading212.API.Tests.Fixtures;
using Xunit;

namespace Trading212.API.Tests
{
    public class ConfigTests : IDisposable
    {
        private readonly Trading212ConfigBuilder _builder;

        public ConfigTests() 
        {
            _builder = GlobalFixtures.FakeConfigBuilder;
        }

        [Fact]
        public void Given_an_empty_api_key_When_creating_a_config_builder_Then_an_argument_null_exception_is_thrown()
        {
            // Assert
            Assert.Throws<ArgumentNullException>(() => Trading212ConfigBuilder.Create(string.Empty));
        }

        [Fact]
        public void Given_a_fake_config_builder_When_setting_the_environment_to_live_Then_the_environment_is_live()
        {
            // Arrange
            var config = 
                _builder
                .WithEnvironment(Environments.Live)
                .Build();

            // Assert
            Assert.NotNull(config);
            Assert.Equal(Environments.Live, config.Environment);
        }

        [Fact]
        public void Given_a_fake_config_builder_When_setting_the_environment_to_empty_Then_an_argument_null_exception_is_thrown()
        {
            // Assert
            Assert.Throws<ArgumentNullException>(() => _builder.WithVersion(string.Empty));
        }

        [Fact]
        public void Given_a_fake_config_builder_When_setting_the_version_to_1_Then_the_version_is_1()
        {
            // Arrange
            var config = _builder
                .WithVersion("v1")
                .Build();

            // Assert
            Assert.NotNull(config);
            Assert.Equal("v1", config.Version);
        }

        [Fact]
        public void Given_a_fake_config_builder_When_setting_the_retry_to_2_Then_the_retry_is_2()
        {
            // Arrange
            var config = _builder
                .WithRetry(2)
                .Build();

            // Assert
            Assert.NotNull(config);
            Assert.Equal(2, config.Retry);
        }

        public void Dispose()
        {
            _builder.Reset();
        }
    }
}
