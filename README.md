# NationalRailEnquiries
---
A simple National Rail OpenLDBWS wrapper for .NET Core

## Installation
To install, simply download from the GitHub repo, reference the `NationalRailEnquiriesClient` project in your own project or solution, and add the following namespaces to 
any file you wish to use it in:

```csharp
using NationalRailEnquiriesClient;
using NationalRailEnquiriesClient.Models;
```

## Dependencies/Requirements
A valid API key from National Rail is required. You can sign up for one [here](http://realtime.nationalrail.co.uk/OpenLDBWSRegistration/). Please note that it **must
be a token for the OpenLDBWS**. The documentation for this API can be found [here](http://lite.realtime.nationalrail.co.uk/openldbws/), and an overview of all National Rail APIs
can be seen [here](https://www.nationalrail.co.uk/46391.aspx)

## How to use
The `LiveDepartureBoardClient` contains all methods from the OpenLDBWS, as both synchronous and asynchronous methods.

The following code is an example of how to use this library. This code is also available as a separate project within the distributed solution.

```csharp
class Program
{
    static void Main(string[] args)
    {
        // Setup token
        var token = new AccessToken
        {
            TokenValue = "<YOUR ACCESS TOKEN>"
        };

        // Setup the request body
        var requestBody = new GetArrDepBoardWithDetailsRequest
        {
            AccessToken = token,
            crs = "VIC",
            numRows = 3,
            filterCrs = "SNR",
            filterType = FilterType.from,
            timeOffset = 0,
            timeWindow = 120
        };

        // Instantiate the client
        var client = new LiveDepartureBoardClient();

        // Execute and print to console
        GetArrDepBoardWithDetailsResponse result = client.GetArrDepBoardWithDetails(requestBody);
        Console.WriteLine(result);

        // Output from async method below
        Console.WriteLine(ArrDepAsync());
    }

    // Example of async client method
    public static async Task ArrDepAsync()
    {
        // Setup token
        var token = new AccessToken
        {
            TokenValue = "<YOUR ACCESS TOKEN>"
        };

        // Setup the request body
        var requestBody = new GetArrDepBoardWithDetailsRequest
        {
            AccessToken = token,
            crs = "VIC",
            numRows = 3,
            filterCrs = "SNR",
            filterType = FilterType.from,
            timeOffset = 0,
            timeWindow = 120
        };

        // Instantiate the client
        var client = new LiveDepartureBoardClient();

        // Execute and print to console
        Task<GetArrDepBoardWithDetailsResponse> task = client.GetArrDepBoardWithDetailsAsync(requestBody);
        var result = await task;
    }
}
```
---
Please file an issue if you find one! I'll be making wrappers for the other APIs at some point.
