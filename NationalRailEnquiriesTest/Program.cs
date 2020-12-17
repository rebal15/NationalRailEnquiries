using System;
using System.Threading.Tasks;
using NationalRailEnquiriesClient;
using NationalRailEnquiriesClient.Models;

namespace NationalRailEnquiriesTest
{
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
}
