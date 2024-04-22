# Trading212.API

An unofficial **C#** library that allows you to interact with the [Trading212](https://www.trading212.com/) API.

## How to send a request to an endpoints?

You can make a request to any of the **Trading212** endpoints by creating an instance of the `Trading212Config` class and injecting it into the service class.

```cs
var config = Trading212ConfigBuilder
    .Create("your-API-key")
    .WithEnvironment(Environments.Demo)
    .Build();  	
	
var service = new AccountService(config);

var result = await _service.GetCashAsync();
```

## How do I know if the request succeeded?

Every response includes its http status code and a message.

When a request succeeded the https status code returned is `HttpStatusCode.OK` and the message is set to `OK`. 

In the event of an error occurring during the request processing, the appropriate HTTP error status code is returned along with an error message.

## Notes

For a full reference of the `Trading212 Public API` endpoints please visit [Trading212 Public API documentation](https://t212public-api-docs.redoc.ly)

## Disclaimer

Nor me or Trading212 are responsible for the use of this API, first make sure that everything works well through the use of a DEMO account, then switch to REAL mode.

In addition, I don't take responsibility for the accuracy of the information reported here and the proper functioning of the API

All trademarks, logos and brand names are the property of their respective owners. All company, product and service names used in this website are for identification purposes only.
