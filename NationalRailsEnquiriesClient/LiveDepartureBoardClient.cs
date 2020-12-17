using NationalRailEnquiriesClient.Interfaces;
using NationalRailEnquiriesClient.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NationalRailEnquiriesClient
{
    public class LiveDepartureBoardClient
    {
        private readonly string _url = "https://lite.realtime.nationalrail.co.uk/OpenLDBWS/ldb11.asmx";
        private readonly LDBServiceSoapClient _soapClient;
        public LiveDepartureBoardClient()
        {
            var binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.Transport;
            var endpoint = new EndpointAddress(_url);
            _soapClient = new LDBServiceSoapClient(binding, endpoint);
        }

        // Departure Boards
        public GetDepartureBoardResponse GetDepartureBoard(GetDepartureBoardRequest requestBody)
        {
            return _soapClient.GetDepartureBoardAsync(requestBody.AccessToken, requestBody.numRows, requestBody.crs, requestBody.filterCrs, requestBody.filterType, requestBody.timeOffset, requestBody.timeWindow).Result;
        }

        public Task<GetDepartureBoardResponse> GetDepartureBoardAsync(GetDepartureBoardRequest requestBody)
        {
            return _soapClient.GetDepartureBoardAsync(requestBody.AccessToken, requestBody.numRows, requestBody.crs, requestBody.filterCrs, requestBody.filterType, requestBody.timeOffset, requestBody.timeWindow);
        }
        public GetDepBoardWithDetailsResponse GetDepartureBoardWithDetails(GetDepBoardWithDetailsRequest requestBody)
        {
            return _soapClient.GetDepBoardWithDetailsAsync(requestBody.AccessToken, requestBody.numRows, requestBody.crs, requestBody.filterCrs, requestBody.filterType, requestBody.timeOffset, requestBody.timeWindow).Result;
        }

        public Task<GetDepBoardWithDetailsResponse> GetDepartureBoardWithDetailsAsync(GetDepBoardWithDetailsRequest requestBody)
        {
            return _soapClient.GetDepBoardWithDetailsAsync(requestBody.AccessToken, requestBody.numRows, requestBody.crs, requestBody.filterCrs, requestBody.filterType, requestBody.timeOffset, requestBody.timeWindow);
        }

        // Arrival Boards
        public GetArrivalBoardResponse GetArrivalBoard(GetArrivalBoardRequest requestBody)
        {
            return _soapClient.GetArrivalBoardAsync(requestBody.AccessToken, requestBody.numRows, requestBody.crs, requestBody.filterCrs, requestBody.filterType, requestBody.timeOffset, requestBody.timeWindow).Result;
        }

        public Task<GetArrivalBoardResponse> GetArrivalBoardAsync(GetDepartureBoardRequest requestBody)
        {
            return _soapClient.GetArrivalBoardAsync(requestBody.AccessToken, requestBody.numRows, requestBody.crs, requestBody.filterCrs, requestBody.filterType, requestBody.timeOffset, requestBody.timeWindow);
        }
        public GetArrBoardWithDetailsResponse GetArrivalBoardWithDetails(GetArrBoardWithDetailsRequest requestBody)
        {
            return _soapClient.GetArrBoardWithDetailsAsync(requestBody.AccessToken, requestBody.numRows, requestBody.crs, requestBody.filterCrs, requestBody.filterType, requestBody.timeOffset, requestBody.timeWindow).Result;
        }

        public Task<GetArrBoardWithDetailsResponse> GetArrivalBoardWithDetailsAsync(GetArrBoardWithDetailsRequest requestBody)
        {
            return _soapClient.GetArrBoardWithDetailsAsync(requestBody.AccessToken, requestBody.numRows, requestBody.crs, requestBody.filterCrs, requestBody.filterType, requestBody.timeOffset, requestBody.timeWindow);
        }

        // Arrival Departure Boards
        public GetArrivalDepartureBoardResponse GetArrDepBoard(GetArrivalDepartureBoardRequest requestBody)
        {
            return _soapClient.GetArrivalDepartureBoardAsync(requestBody.AccessToken, requestBody.numRows, requestBody.crs, requestBody.filterCrs, requestBody.filterType, requestBody.timeOffset, requestBody.timeWindow).Result;
        }

        public Task<GetArrivalDepartureBoardResponse> GetArrDepBoardAsync(GetArrivalDepartureBoardRequest requestBody)
        {
            return _soapClient.GetArrivalDepartureBoardAsync(requestBody.AccessToken, requestBody.numRows, requestBody.crs, requestBody.filterCrs, requestBody.filterType, requestBody.timeOffset, requestBody.timeWindow);
        }
        public GetArrDepBoardWithDetailsResponse GetArrDepBoardWithDetails(GetArrDepBoardWithDetailsRequest requestBody)
        {
            return _soapClient.GetArrDepBoardWithDetailsAsync(requestBody.AccessToken, requestBody.numRows, requestBody.crs, requestBody.filterCrs, requestBody.filterType, requestBody.timeOffset, requestBody.timeWindow).Result;
        }

        public Task<GetArrDepBoardWithDetailsResponse> GetArrDepBoardWithDetailsAsync(GetArrDepBoardWithDetailsRequest requestBody)
        {
            return _soapClient.GetArrDepBoardWithDetailsAsync(requestBody.AccessToken, requestBody.numRows, requestBody.crs, requestBody.filterCrs, requestBody.filterType, requestBody.timeOffset, requestBody.timeWindow);
        }

        // Service Details
        public GetServiceDetailsResponse GetServiceDetails(GetServiceDetailsRequest requestBody)
        {
            return _soapClient.GetServiceDetailsAsync(requestBody.AccessToken, requestBody.serviceID).Result;
        }

        public Task<GetServiceDetailsResponse> GetServiceDetailsAsync(GetServiceDetailsRequest requestBody)
        {
            return _soapClient.GetServiceDetailsAsync(requestBody.AccessToken, requestBody.serviceID);
        }

        // Next Departures
        public GetNextDeparturesResponse GetNextDepartures(GetNextDeparturesRequest requestBody)
        {
            return _soapClient.GetNextDeparturesAsync(requestBody.AccessToken, requestBody.crs, requestBody.filterList, requestBody.timeOffset, requestBody.timeWindow).Result;
        }

        public Task<GetNextDeparturesResponse> GetNextDeparturesAsync(GetNextDeparturesRequest requestBody)
        {
            return _soapClient.GetNextDeparturesAsync(requestBody.AccessToken, requestBody.crs, requestBody.filterList, requestBody.timeOffset, requestBody.timeWindow);
        }

        public GetNextDeparturesWithDetailsResponse GetNextDeparturesWithDetails(GetNextDeparturesWithDetailsRequest requestBody)
        {
            return _soapClient.GetNextDeparturesWithDetailsAsync(requestBody.AccessToken, requestBody.crs, requestBody.filterList, requestBody.timeOffset, requestBody.timeWindow).Result;
        }

        public Task<GetNextDeparturesWithDetailsResponse> GetNextDeparturesWithDetailsAsync(GetNextDeparturesWithDetailsRequest requestBody)
        {
            return _soapClient.GetNextDeparturesWithDetailsAsync(requestBody.AccessToken, requestBody.crs, requestBody.filterList, requestBody.timeOffset, requestBody.timeWindow);
        }

        // Fastest Departures
        public GetFastestDeparturesResponse GetFastestDepartures(GetFastestDeparturesRequest requestBody)
        {
            return _soapClient.GetFastestDeparturesAsync(requestBody.AccessToken, requestBody.crs, requestBody.filterList, requestBody.timeOffset, requestBody.timeWindow).Result;
        }

        public Task<GetFastestDeparturesResponse> GetFastestDeparturesAsync(GetFastestDeparturesRequest requestBody)
        {
            return _soapClient.GetFastestDeparturesAsync(requestBody.AccessToken, requestBody.crs, requestBody.filterList, requestBody.timeOffset, requestBody.timeWindow);
        }

        public GetFastestDeparturesWithDetailsResponse GetFastestDeparturesWithDetails(GetFastestDeparturesWithDetailsRequest requestBody)
        {
            return _soapClient.GetFastestDeparturesWithDetailsAsync(requestBody.AccessToken, requestBody.crs, requestBody.filterList, requestBody.timeOffset, requestBody.timeWindow).Result;
        }

        public Task<GetFastestDeparturesWithDetailsResponse> GetFastestDeparturesWithDetailsAsync(GetFastestDeparturesWithDetailsRequest requestBody)
        {
            return _soapClient.GetFastestDeparturesWithDetailsAsync(requestBody.AccessToken, requestBody.crs, requestBody.filterList, requestBody.timeOffset, requestBody.timeWindow);
        }
    }
}
