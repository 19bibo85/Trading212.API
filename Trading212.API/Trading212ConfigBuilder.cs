using System;
using Trading212.API.Enums;

namespace Trading212.API
{
    public sealed class Trading212ConfigBuilder
    {
        private static readonly Trading212Config _config = new Trading212Config();

        /// <summary>
        /// Initializes a new instance of the <see cref="Trading212ConfigBuilder"/> class with the specified API key.
        /// </summary>
        /// <param name="apiKey">The API key to use for configuration.</param>
        /// <remarks>This constructor initializes a new instance of the <see cref="Trading212ConfigBuilder"/> class with the provided API key.</remarks>
        private Trading212ConfigBuilder(string apiKey) 
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new ArgumentNullException(nameof(apiKey));

            _config.SetKey(apiKey);
        }

        /// <summary>
        /// Creates a new instance of <see cref="Trading212ConfigBuilder"/> with the specified API key.
        /// </summary>
        /// <param name="apiKey">The API key to use for configuration.</param>
        /// <returns>A new instance of <see cref="Trading212ConfigBuilder"/>.</returns>
        /// <remarks>This method creates a new instance of <see cref="Trading212ConfigBuilder"/> with the provided API key.</remarks>
        public static Trading212ConfigBuilder Create(string apiKey) => new Trading212ConfigBuilder(apiKey);

        /// <summary>
        /// Sets the environment for the Trading212 configuration.
        /// </summary>
        /// <param name="environment">The environment to set.</param>
        /// <returns>The <see cref="Trading212ConfigBuilder"/> instance.</returns>
        /// <remarks>This method sets the environment for the Trading212 configuration.</remarks>
        public Trading212ConfigBuilder WithEnvironment(Environments environment)
        {
            _config.SetEnvironment(environment);

            return this;
        }

        /// <summary>
        /// Sets the version for the Trading212 configuration.
        /// </summary>
        /// <param name="version">The version to set.</param>
        /// <returns>The <see cref="Trading212ConfigBuilder"/> instance.</returns>
        /// <remarks>This method sets the version for the Trading212 configuration.</remarks>
        public Trading212ConfigBuilder WithVersion(string version)
        {
            if (string.IsNullOrWhiteSpace(version))
                throw new ArgumentNullException(nameof(version));

            _config.SetVersion(version);

            return this;
        }

        /// <summary>
        /// Sets the retry attempts for failed requests for the Trading212 configuration.
        /// </summary>
        /// <param name="retry">The number of retry attempts to set.</param>
        /// <returns>The <see cref="Trading212ConfigBuilder"/> instance.</returns>
        /// <remarks>This method sets the number of retry attempts for failed requests for the Trading212 configuration.</remarks>
        public Trading212ConfigBuilder WithRetry(byte retry)
        {
            _config.SetRetry(retry);

            return this;
        }

        /// <summary>
        /// Builds the Trading212 configuration.
        /// </summary>
        /// <returns>The built <see cref="Trading212Config"/>.</returns>
        /// <remarks>This method builds the Trading212 configuration based on the set parameters.</remarks>
        public Trading212Config Build() => _config.Build();

        /// <summary>
        /// Reset the Trading212 configuration.
        /// </summary>
        /// <returns>The built <see cref="Trading212Config"/>.</returns>
        /// <remarks>This method reset the Trading212 configuration based on the default values.</remarks>
        public Trading212Config Reset() => _config.Reset();
    }
}
