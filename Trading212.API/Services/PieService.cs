using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Trading212.API.DTOs.Requests;
using Trading212.API.DTOs.Requests.Pies;
using Trading212.API.DTOs.Responses;
using Trading212.API.DTOs.Responses.Pies;

namespace Trading212.API.Services
{
    public class PieService : BaseService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PieService"/> class with the specified <paramref name="config"/>.
        /// </summary>
        /// <param name="config">The configuration settings for the trading platform.</param>
        /// <remarks>This constructor initializes a new instance of the <see cref="PieService"/> class using the provided <paramref name="config"/>.</remarks>
        public PieService(Trading212Config config) : base(config)
        {

        }

        /// <summary>
        /// Asynchronously retrieves a list of pies.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="List{T}"/> where T is <see cref="Pies"/>.</returns>
        /// <remarks>This method fetches the list of pies asynchronously.</remarks>
        public async Task<Response<List<Pies>>> GetPiesAsync(CancellationToken cancellationToken = default)
        {
            return await base.Execute<List<Pies>>(HttpMethod.Get, "equity/pies", TimeSpan.FromSeconds(30), cancellationToken);
        }

        /// <summary>
        /// Asynchronously creates a pie based on the specified <paramref name="pieRequest"/>.
        /// </summary>
        /// <param name="pieRequest">The request containing data to create the pie.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Pie"/>.</returns>
        /// <remarks>This method creates a pie asynchronously based on the provided <paramref name="pieRequest"/>.</remarks>
        public async Task<Response<Pie>> CreatePieAsync(PieRequest pieRequest, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Pie>(HttpMethod.Post, "equity/pies", RequestHelper.CreateBody(pieRequest), TimeSpan.FromSeconds(5), cancellationToken);
        }

        /// <summary>
        /// Asynchronously deletes a pie with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the pie to delete.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Pie"/>.</returns>
        /// <remarks>This method deletes a pie asynchronously based on the provided <paramref name="id"/>.</remarks>
        public async Task<Response<Pie>> DeletePieAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Pie>(HttpMethod.Delete, "equity/pies", id, TimeSpan.FromSeconds(5), cancellationToken);
        }

        /// <summary>
        /// Asynchronously retrieves a pie with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the pie to retrieve.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Pie"/>.</returns>
        /// <remarks>This method retrieves a pie asynchronously based on the provided <paramref name="id"/>.</remarks>
        public async Task<Response<Pie>> GetPieAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Pie>(HttpMethod.Get, "equity/pies", id, TimeSpan.FromSeconds(5), cancellationToken);
        }

        /// <summary>
        /// Asynchronously updates a pie with the specified <paramref name="id"/> based on the provided <paramref name="pieRequest"/>.
        /// </summary>
        /// <param name="id">The ID of the pie to update.</param>
        /// <param name="pieRequest">The request containing data to update the pie.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Pie"/>.</returns>
        /// <remarks>This method updates a pie asynchronously based on the provided <paramref name="id"/> and <paramref name="pieRequest"/>.</remarks>
        public async Task<Response<Pie>> UpdatePieAsync(long id, PieRequest pieRequest, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Pie>(HttpMethod.Post, "equity/pies", id, RequestHelper.CreateBody(pieRequest), TimeSpan.FromSeconds(5), cancellationToken);
        }        
    }
}
