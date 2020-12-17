using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Channels;
using NationalRailEnquiriesClient.Models;

namespace NationalRailEnquiriesClient.Interfaces
{
    public partial class LDBServiceSoapClient : ClientBase<ILDBService>, ILDBService
    {

        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(ServiceEndpoint serviceEndpoint, ClientCredentials clientCredentials);

        public LDBServiceSoapClient(EndpointConfiguration endpointConfiguration) :
                base(GetBindingForEndpoint(endpointConfiguration), GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public LDBServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(GetBindingForEndpoint(endpointConfiguration), new EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public LDBServiceSoapClient(EndpointConfiguration endpointConfiguration, EndpointAddress remoteAddress) :
                base(GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public LDBServiceSoapClient(Binding binding, EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetDepartureBoardResponse> ILDBService.GetDepartureBoardAsync(GetDepartureBoardRequest request)
        {
            return Channel.GetDepartureBoardAsync(request);
        }

        public System.Threading.Tasks.Task<GetDepartureBoardResponse> GetDepartureBoardAsync(AccessToken AccessToken, ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset, int timeWindow)
        {
            GetDepartureBoardRequest inValue = new GetDepartureBoardRequest
            {
                AccessToken = AccessToken,
                numRows = numRows,
                crs = crs,
                filterCrs = filterCrs,
                filterType = filterType,
                timeOffset = timeOffset,
                timeWindow = timeWindow
            };
            return ((ILDBService)(this)).GetDepartureBoardAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetArrivalBoardResponse> ILDBService.GetArrivalBoardAsync(GetArrivalBoardRequest request)
        {
            return Channel.GetArrivalBoardAsync(request);
        }

        public System.Threading.Tasks.Task<GetArrivalBoardResponse> GetArrivalBoardAsync(AccessToken AccessToken, ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset, int timeWindow)
        {
            GetArrivalBoardRequest inValue = new GetArrivalBoardRequest
            {
                AccessToken = AccessToken,
                numRows = numRows,
                crs = crs,
                filterCrs = filterCrs,
                filterType = filterType,
                timeOffset = timeOffset,
                timeWindow = timeWindow
            };
            return ((ILDBService)(this)).GetArrivalBoardAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetArrivalDepartureBoardResponse> ILDBService.GetArrivalDepartureBoardAsync(GetArrivalDepartureBoardRequest request)
        {
            return Channel.GetArrivalDepartureBoardAsync(request);
        }

        public System.Threading.Tasks.Task<GetArrivalDepartureBoardResponse> GetArrivalDepartureBoardAsync(AccessToken AccessToken, ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset, int timeWindow)
        {
            GetArrivalDepartureBoardRequest inValue = new GetArrivalDepartureBoardRequest
            {
                AccessToken = AccessToken,
                numRows = numRows,
                crs = crs,
                filterCrs = filterCrs,
                filterType = filterType,
                timeOffset = timeOffset,
                timeWindow = timeWindow
            };
            return ((ILDBService)(this)).GetArrivalDepartureBoardAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetServiceDetailsResponse> ILDBService.GetServiceDetailsAsync(GetServiceDetailsRequest request)
        {
            return Channel.GetServiceDetailsAsync(request);
        }

        public System.Threading.Tasks.Task<GetServiceDetailsResponse> GetServiceDetailsAsync(AccessToken AccessToken, string serviceID)
        {
            GetServiceDetailsRequest inValue = new GetServiceDetailsRequest
            {
                AccessToken = AccessToken,
                serviceID = serviceID
            };
            return ((ILDBService)(this)).GetServiceDetailsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetDepBoardWithDetailsResponse> ILDBService.GetDepBoardWithDetailsAsync(GetDepBoardWithDetailsRequest request)
        {
            return Channel.GetDepBoardWithDetailsAsync(request);
        }

        public System.Threading.Tasks.Task<GetDepBoardWithDetailsResponse> GetDepBoardWithDetailsAsync(AccessToken AccessToken, ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset, int timeWindow)
        {
            GetDepBoardWithDetailsRequest inValue = new GetDepBoardWithDetailsRequest
            {
                AccessToken = AccessToken,
                numRows = numRows,
                crs = crs,
                filterCrs = filterCrs,
                filterType = filterType,
                timeOffset = timeOffset,
                timeWindow = timeWindow
            };
            return ((ILDBService)(this)).GetDepBoardWithDetailsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetArrBoardWithDetailsResponse> ILDBService.GetArrBoardWithDetailsAsync(GetArrBoardWithDetailsRequest request)
        {
            return Channel.GetArrBoardWithDetailsAsync(request);
        }

        public System.Threading.Tasks.Task<GetArrBoardWithDetailsResponse> GetArrBoardWithDetailsAsync(AccessToken AccessToken, ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset, int timeWindow)
        {
            GetArrBoardWithDetailsRequest inValue = new GetArrBoardWithDetailsRequest
            {
                AccessToken = AccessToken,
                numRows = numRows,
                crs = crs,
                filterCrs = filterCrs,
                filterType = filterType,
                timeOffset = timeOffset,
                timeWindow = timeWindow
            };
            return ((ILDBService)(this)).GetArrBoardWithDetailsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetArrDepBoardWithDetailsResponse> ILDBService.GetArrDepBoardWithDetailsAsync(GetArrDepBoardWithDetailsRequest request)
        {
            return Channel.GetArrDepBoardWithDetailsAsync(request);
        }

        public System.Threading.Tasks.Task<GetArrDepBoardWithDetailsResponse> GetArrDepBoardWithDetailsAsync(AccessToken AccessToken, ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset, int timeWindow)
        {
            GetArrDepBoardWithDetailsRequest inValue = new GetArrDepBoardWithDetailsRequest
            {
                AccessToken = AccessToken,
                numRows = numRows,
                crs = crs,
                filterCrs = filterCrs,
                filterType = filterType,
                timeOffset = timeOffset,
                timeWindow = timeWindow
            };
            return ((ILDBService)(this)).GetArrDepBoardWithDetailsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetNextDeparturesResponse> ILDBService.GetNextDeparturesAsync(GetNextDeparturesRequest request)
        {
            return Channel.GetNextDeparturesAsync(request);
        }

        public System.Threading.Tasks.Task<GetNextDeparturesResponse> GetNextDeparturesAsync(AccessToken AccessToken, string crs, string[] filterList, int timeOffset, int timeWindow)
        {
            GetNextDeparturesRequest inValue = new GetNextDeparturesRequest
            {
                AccessToken = AccessToken,
                crs = crs,
                filterList = filterList,
                timeOffset = timeOffset,
                timeWindow = timeWindow
            };
            return ((ILDBService)(this)).GetNextDeparturesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetNextDeparturesWithDetailsResponse> ILDBService.GetNextDeparturesWithDetailsAsync(GetNextDeparturesWithDetailsRequest request)
        {
            return Channel.GetNextDeparturesWithDetailsAsync(request);
        }

        public System.Threading.Tasks.Task<GetNextDeparturesWithDetailsResponse> GetNextDeparturesWithDetailsAsync(AccessToken AccessToken, string crs, string[] filterList, int timeOffset, int timeWindow)
        {
            GetNextDeparturesWithDetailsRequest inValue = new GetNextDeparturesWithDetailsRequest
            {
                AccessToken = AccessToken,
                crs = crs,
                filterList = filterList,
                timeOffset = timeOffset,
                timeWindow = timeWindow
            };
            return ((ILDBService)(this)).GetNextDeparturesWithDetailsAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetFastestDeparturesResponse> ILDBService.GetFastestDeparturesAsync(GetFastestDeparturesRequest request)
        {
            return Channel.GetFastestDeparturesAsync(request);
        }

        public System.Threading.Tasks.Task<GetFastestDeparturesResponse> GetFastestDeparturesAsync(AccessToken AccessToken, string crs, string[] filterList, int timeOffset, int timeWindow)
        {
            GetFastestDeparturesRequest inValue = new GetFastestDeparturesRequest
            {
                AccessToken = AccessToken,
                crs = crs,
                filterList = filterList,
                timeOffset = timeOffset,
                timeWindow = timeWindow
            };
            return ((ILDBService)(this)).GetFastestDeparturesAsync(inValue);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<GetFastestDeparturesWithDetailsResponse> ILDBService.GetFastestDeparturesWithDetailsAsync(GetFastestDeparturesWithDetailsRequest request)
        {
            return Channel.GetFastestDeparturesWithDetailsAsync(request);
        }

        public System.Threading.Tasks.Task<GetFastestDeparturesWithDetailsResponse> GetFastestDeparturesWithDetailsAsync(AccessToken AccessToken, string crs, string[] filterList, int timeOffset, int timeWindow)
        {
            GetFastestDeparturesWithDetailsRequest inValue = new GetFastestDeparturesWithDetailsRequest
            {
                AccessToken = AccessToken,
                crs = crs,
                filterList = filterList,
                timeOffset = timeOffset,
                timeWindow = timeWindow
            };
            return ((ILDBService)(this)).GetFastestDeparturesWithDetailsAsync(inValue);
        }

        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((ICommunicationObject)(this)).EndOpen));
        }

        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((ICommunicationObject)(this)).EndClose));
        }

        private static Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.LDBServiceSoap))
            {
                BasicHttpBinding result = new BasicHttpBinding
                {
                    MaxBufferSize = int.MaxValue,
                    ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max,
                    MaxReceivedMessageSize = int.MaxValue,
                    AllowCookies = true
                };
                result.Security.Mode = BasicHttpSecurityMode.Transport;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.LDBServiceSoap12))
            {
                CustomBinding result = new CustomBinding();
                TextMessageEncodingBindingElement textBindingElement = new TextMessageEncodingBindingElement
                {
                    MessageVersion = MessageVersion.CreateVersion(EnvelopeVersion.Soap12, AddressingVersion.None)
                };
                result.Elements.Add(textBindingElement);
                HttpsTransportBindingElement httpsBindingElement = new HttpsTransportBindingElement
                {
                    AllowCookies = true,
                    MaxBufferSize = int.MaxValue,
                    MaxReceivedMessageSize = int.MaxValue
                };
                result.Elements.Add(httpsBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        private static EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.LDBServiceSoap))
            {
                return new EndpointAddress("https://lite.realtime.nationalrail.co.uk/OpenLDBWS/ldb11.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.LDBServiceSoap12))
            {
                return new EndpointAddress("https://lite.realtime.nationalrail.co.uk/OpenLDBWS/ldb11.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        public enum EndpointConfiguration
        {

            LDBServiceSoap,

            LDBServiceSoap12,
        }
    }
}
