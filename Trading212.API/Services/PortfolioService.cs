using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Trading212.API.DTOs.Requests;
using Trading212.API.DTOs.Responses;
using Trading212.API.DTOs.Responses.Portfolios;

namespace Trading212.API.Services
{
    public class PortfolioService : BaseService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortfolioService"/> class with the specified <paramref name="config"/>.
        /// </summary>
        /// <param name="config">The configuration settings for the trading platform.</param>
        /// <remarks>This constructor initializes a new instance of the <see cref="PortfolioService"/> class using the provided <paramref name="config"/>.</remarks>
        public PortfolioService(Trading212Config config) : base(config)
        {

        }

        /// <summary>
        /// Asynchronously retrieves a list of positions.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="List{T}"/> where T is <see cref="Position"/>.</returns>
        /// <remarks>This method fetches the list of positions asynchronously.</remarks>
        public async Task<Response<List<Position>>> GetPositionListAsync(CancellationToken cancellationToken = default)
        {
            return await base.Execute<List<Position>>(HttpMethod.Get, "equity/portfolio", TimeSpan.FromSeconds(5), cancellationToken);
        }

        /// <summary>
        /// Asynchronously retrieves a position with the specified <paramref name="ticker"/>.
        /// </summary>
        /// <param name="ticker">The ticker symbol of the position to retrieve.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Position"/>.</returns>
        /// <remarks>This method retrieves a list of positions asynchronously based on the provided <paramref name="ticker"/>.</remarks>
        public async Task<Response<List<Position>>> GetPositionAsync(string ticker, CancellationToken cancellationToken = default)
        {
            return await base.Execute<List<Position>>(HttpMethod.Get, "equity/portfolio", RequestHelper.CreateQuery(new { ticker }), TimeSpan.FromSeconds(1), cancellationToken);
        }
    }
}
