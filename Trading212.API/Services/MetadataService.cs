using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Trading212.API.DTOs.Responses;
using Trading212.API.DTOs.Responses.Metadatas;

namespace Trading212.API.Services
{
    public class MetadataService : BaseService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataService"/> class with the specified <paramref name="config"/>.
        /// </summary>
        /// <param name="config">The configuration settings for the trading platform.</param>
        /// <remarks>This constructor initializes a new instance of the <see cref="MetadataService"/> class using the provided <paramref name="config"/>.</remarks>
        public MetadataService(Trading212Config config) : base(config)
        {

        }

        /// <summary>
        /// Asynchronously retrieves a list of exchanges.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="List{T}"/> where T is <see cref="ExchangeList"/>.</returns>
        /// <remarks>This method fetches the list of exchanges asynchronously.</remarks>
        public async Task<Response<List<ExchangeList>>> GetExchangeListAsync(CancellationToken cancellationToken = default)
        {
            return await base.Execute<List<ExchangeList>>(HttpMethod.Get, "equity/metadata/exchanges", TimeSpan.FromSeconds(30), cancellationToken);
        }

        /// <summary>
        /// Asynchronously retrieves a list of instruments.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="List{T}"/> where T is <see cref="InstrumentList"/>.</returns>
        /// <remarks>This method fetches the list of instruments asynchronously.</remarks>
        public async Task<Response<List<InstrumentList>>> GetInstrumentListAsync(CancellationToken cancellationToken = default)
        {
            return await base.Execute<List<InstrumentList>>(HttpMethod.Get,"equity/metadata/instruments", TimeSpan.FromSeconds(50), cancellationToken);
        }
    }
}
