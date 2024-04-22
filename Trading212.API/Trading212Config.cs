using System;
using System.Collections.Generic;
using Trading212.API.Enums;

namespace Trading212.API
{
    public sealed class Trading212Config
    {
        #region Private Members        

        private const string DefaultAPIKey = "";

        private const string DefaultVersion = Global.LatestVersion;

        private const Environments DefaultEnvironment = Environments.Live;

        private const byte DefaultRetry = 1;


        private static readonly Dictionary<Environments, string> _urls = new Dictionary<Environments, string>()
        {
            { Environments.Demo, Global.Trading212EndpointDemo },

            { Environments.Live, Global.Trading212EndpointLive }
        }
        ;

        private static string _apiKey = DefaultAPIKey;

        private static string _version = DefaultVersion;

        private static Environments _environment = DefaultEnvironment;

        private static byte _retry = DefaultRetry;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Trading212Config"/> class.
        /// </summary>
        public Trading212Config()
        {

        }

        internal void SetKey(string apiKey)  => _apiKey = apiKey;

        /// <summary>
        /// Gets the API key associated with the service.
        /// </summary>
        /// <remarks>This property retrieves the API key used by the service.</remarks>
        internal string APIKey => _apiKey;

        internal void SetEnvironment(Environments environment) => _environment = environment;

        /// <summary>
        /// Gets the environment settings associated with the service.
        /// </summary>
        /// <remarks>This property retrieves the environment settings used by the service.</remarks>
        public Environments Environment => _environment;

        internal void SetVersion(string version) => _version = version;

        /// <summary>
        /// Gets the version of the service.
        /// </summary>
        /// <remarks>This property retrieves the version of the service.</remarks>
        public string Version => _version;

        internal void SetRetry(byte retry) => _retry = retry;

        /// <summary>
        /// Gets the number of retry attempts for failed requests.
        /// </summary>
        /// <remarks>This property retrieves the number of retry attempts for failed requests.</remarks>
        public byte Retry => _retry;

        internal Uri BaseAddress => new Uri($"{_urls[_environment]}/api/{_version}/");

        internal Trading212Config Build() => this;

        internal Trading212Config Reset() 
        {
            this.SetKey(DefaultAPIKey);
            this.SetEnvironment(DefaultEnvironment);
            this.SetVersion(DefaultVersion);
            this.SetRetry(DefaultRetry);

            return this;
        }
    }
}
