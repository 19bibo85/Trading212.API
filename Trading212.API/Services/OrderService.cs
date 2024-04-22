using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Trading212.API.DTOs.Requests;
using Trading212.API.DTOs.Requests.Orders;
using Trading212.API.DTOs.Responses;
using Trading212.API.DTOs.Responses.Orders;

namespace Trading212.API.Services
{
    public class OrderService : BaseService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderService"/> class with the specified <paramref name="config"/>.
        /// </summary>
        /// <param name="config">The configuration settings for the trading platform.</param>
        /// <remarks>This constructor initializes a new instance of the <see cref="OrderService"/> class using the provided <paramref name="config"/>.</remarks>
        public OrderService(Trading212Config config) : base(config)
        {

        }

        /// <summary>
        /// Asynchronously retrieves a list of orders.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="List{T}"/> where T is <see cref="Order"/>.</returns>
        /// <remarks>This method fetches the list of orders asynchronously.</remarks>
        public async Task<Response<List<Order>>> GetOrdersAsync(CancellationToken cancellationToken = default)
        {
            return await base.Execute<List<Order>>(HttpMethod.Get, "equity/orders", TimeSpan.FromSeconds(5), cancellationToken);
        }

        /// <summary>
        /// Asynchronously creates a limit order based on the specified <paramref name="limitOrderRequest"/>.
        /// </summary>
        /// <param name="limitOrderRequest">The request containing data to create the limit order.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Order"/>.</returns>
        /// <remarks>This method creates a limit order asynchronously based on the provided <paramref name="limitOrderRequest"/>.</remarks>
        public async Task<Response<Order>> CreateLimitOrderAsync(LimitOrderRequest limitOrderRequest, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Order>(HttpMethod.Post, "equity/orders/limit", RequestHelper.CreateBody(limitOrderRequest), TimeSpan.FromSeconds(2), cancellationToken);
        }

        /// <summary>
        /// Asynchronously creates a market order based on the specified <paramref name="marketOrderRequest"/>.
        /// </summary>
        /// <param name="marketOrderRequest">The request containing data to create the market order.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Order"/>.</returns>
        /// <remarks>This method creates a market order asynchronously based on the provided <paramref name="marketOrderRequest"/>.</remarks>
        public async Task<Response<Order>> CreateMarketOrderAsync(MarketOrderRequest marketOrderRequest, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Order>(HttpMethod.Post, "equity/orders/market", RequestHelper.CreateBody(marketOrderRequest), TimeSpan.FromSeconds(1), cancellationToken);
        }

        /// <summary>
        /// Asynchronously creates a stop order based on the specified <paramref name="stopOrderRequest"/>.
        /// </summary>
        /// <param name="stopOrderRequest">The request containing data to create the stop order.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Order"/>.</returns>
        /// <remarks>This method creates a stop order asynchronously based on the provided <paramref name="stopOrderRequest"/>.</remarks>
        public async Task<Response<Order>> CreateStopOrderAsync(StopOrderRequest stopOrderRequest, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Order>(HttpMethod.Post, "equity/orders/stop", RequestHelper.CreateBody(stopOrderRequest), TimeSpan.FromSeconds(2), cancellationToken);
        }

        /// <summary>
        /// Asynchronously creates a stop-limit order based on the specified <paramref name="stopLimitOrderRequest"/>.
        /// </summary>
        /// <param name="stopLimitOrderRequest">The request containing data to create the stop-limit order.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Order"/>.</returns>
        /// <remarks>This method creates a stop-limit order asynchronously based on the provided <paramref name="stopLimitOrderRequest"/>.</remarks>
        public async Task<Response<Order>> CreateStopLimitOrderAsync(StopLimitOrderRequest stopLimitOrderRequest, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Order>(HttpMethod.Post, "equity/orders/stop_limit", RequestHelper.CreateBody(stopLimitOrderRequest), TimeSpan.FromSeconds(2), cancellationToken);
        }

        /// <summary>
        /// Asynchronously cancels an order with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the order to cancel.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Order"/>.</returns>
        /// <remarks>This method cancels an order asynchronously based on the provided <paramref name="id"/>.</remarks>
        public async Task<Response<Order>> CancelOrderAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Order>(HttpMethod.Delete, "equity/orders", id, TimeSpan.FromSeconds(1), cancellationToken);
        }

        /// <summary>
        /// Asynchronously retrieves an order with the specified <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the order to retrieve.</param>
        /// <param name="cancellationToken">The cancellation token to cancel the operation.</param>
        /// <returns>A task representing the asynchronous operation, containing a <see cref="Response{T}"/> of type <see cref="Order"/>.</returns>
        /// <remarks>This method retrieves an order asynchronously based on the provided <paramref name="id"/>.</remarks>
        public async Task<Response<Order>> GetOrderAsync(long id, CancellationToken cancellationToken = default)
        {
            return await base.Execute<Order>(HttpMethod.Get, "equity/orders", id, TimeSpan.FromSeconds(1), cancellationToken);
        }
    }
}
