using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Trading212.API.DTOs.Responses;
using Trading212.API.DTOs.Responses.Accounts;

namespace Trading212.API.Services
{
    public class AccountService : BaseService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountService"/> class with the specified <paramref name="config"/>.
        /// </summary>
        /// <param name="config">The configuration settings for the trading platform.</param>
        /// <remarks>This constructor initializes a new instance of the <see cref="AccountService"/> class using the provided <paramref name="config"/>.</remarks>
        public AccountService(Trading212Config config) : base(config)
        {

        }

        /// <summary>
        /// Asynchronously retrieves cash information.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Cash"/>.</returns>
        /// <remarks>This method fetches cash information asynchronously.</remarks>
        public async Task<Response<Cash>> GetCashAsync(CancellationToken cancellationToken = default)
        {
            return await base.Execute<Cash>(HttpMethod.Get, "equity/account/cash", TimeSpan.FromSeconds(2), cancellationToken);
        }

        /// <summary>
        /// Asynchronously retrieves metadata information.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Metadata"/>.</returns>
        /// <remarks>This method fetches metadata information asynchronously.</remarks>
        public async Task<Response<Metadata>> GetMetadataAsync(CancellationToken cancellationToken = default)
        {
            return await base.Execute<Metadata>(HttpMethod.Get, "equity/account/info", TimeSpan.FromSeconds(30), cancellationToken);
        }
    }
}
