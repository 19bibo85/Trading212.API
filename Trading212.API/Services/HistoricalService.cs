using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Trading212.API.DTOs.Requests;
using Trading212.API.DTOs.Requests.Historicals;
using Trading212.API.DTOs.Responses;
using Trading212.API.DTOs.Responses.Historicals;

namespace Trading212.API.Services
{
    public class HistoricalService : BaseService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricalService"/> class with the specified <paramref name="config"/>.
        /// </summary>
        /// <param name="config">The configuration settings for the trading platform.</param>
        /// <remarks>This constructor initializes a new instance of the <see cref="HistoricalService"/> class using the provided <paramref name="config"/>.</remarks>
        public HistoricalService(Trading212Config config) : base(config)
        {

        }

        /// <summary>
        /// Asynchronously retrieves orders based on the specified <paramref name="orderDataRequest"/>.
        /// </summary>
        /// <param name="orderDataRequest">The request containing data to filter orders.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Order"/>.</returns>
        /// <remarks>This method fetches orders asynchronously based on the provided <paramref name="orderDataRequest"/>.</remarks>
        public async Task<Response<Order>> GetOrdersAsync(OrderRequest orderDataRequest, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Order>(HttpMethod.Get, "equity/history/orders", RequestHelper.CreateQuery(orderDataRequest), TimeSpan.FromSeconds(10), cancellationToken);
        }

        /// <summary>
        /// Asynchronously retrieves dividends based on the specified <paramref name="dividendRequest"/>.
        /// </summary>
        /// <param name="dividendRequest">The request containing data to filter dividends.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Dividend"/>.</returns>
        /// <remarks>This method fetches dividends asynchronously based on the provided <paramref name="dividendRequest"/>.</remarks>
        public async Task<Response<Dividend>> GetDividendsAsync(DividendRequest dividendRequest, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Dividend>(HttpMethod.Get, "equity/history/dividends", RequestHelper.CreateQuery(dividendRequest), TimeSpan.FromSeconds(10), cancellationToken);
        }

        /// <summary>
        /// Asynchronously retrieves a list of exports.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="List{T}}"/>.</returns>
        /// <remarks>This method fetches list of exports asynchronously.</remarks>
        public async Task<Response<List<Export>>> GetExportsAsync(CancellationToken cancellationToken = default)
        {
            return await base.Execute<List<Export>>(HttpMethod.Get, "equity/history/exports", TimeSpan.FromMinutes(1), cancellationToken);
        }

        /// <summary>
        /// Asynchronously retrieves CSV exports based on the specified <paramref name="exportRequest"/>.
        /// </summary>
        /// <param name="exportRequest">The request containing data to configure the CSV export.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="ExportCsv"/>.</returns>
        /// <remarks>This method fetches CSV exports asynchronously based on the provided <paramref name="exportRequest"/>.</remarks>
        public async Task<Response<ExportCsv>> GetExportCsvAsync(ExportRequest exportRequest, CancellationToken cancellationToken = default)
        {
            return await base.Execute<ExportCsv>(HttpMethod.Post, "equity/history/exports", RequestHelper.CreateBody(exportRequest), TimeSpan.FromSeconds(30), cancellationToken);
        }

        /// <summary>
        /// Asynchronously retrieves transactions based on the specified <paramref name="transactionRequest"/>.
        /// </summary>
        /// <param name="transactionRequest">The request containing data to filter transactions.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Transaction"/>.</returns>
        /// <remarks>This method fetches transactions asynchronously based on the provided <paramref name="transactionRequest"/>.</remarks>
        public async Task<Response<Transaction>> GetTransactionsAsync(TransactionRequest transactionRequest, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Transaction>(HttpMethod.Get, "equity/history/transactions", RequestHelper.CreateQuery(transactionRequest), TimeSpan.FromSeconds(10), cancellationToken);
        }
    }
}
