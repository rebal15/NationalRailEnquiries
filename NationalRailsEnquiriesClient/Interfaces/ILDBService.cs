using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using NationalRailEnquiriesClient.Models;

namespace NationalRailEnquiriesClient.Interfaces
{
    [ServiceContract(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", ConfigurationName = "NationalRailEnquiriesClient.Interfaces.ILDBService")]
    public interface ILDBService
    {

        [OperationContract(Action = "http://thalesgroup.com/RTTI/2012-01-13/ldb/GetDepartureBoard", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(BaseServiceDetails))]
        [ServiceKnownType(typeof(BaseServiceItem))]
        [ServiceKnownType(typeof(BaseStationBoard))]
        System.Threading.Tasks.Task<GetDepartureBoardResponse> GetDepartureBoardAsync(GetDepartureBoardRequest request);

        [OperationContract(Action = "http://thalesgroup.com/RTTI/2012-01-13/ldb/GetArrivalBoard", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(BaseServiceDetails))]
        [ServiceKnownType(typeof(BaseServiceItem))]
        [ServiceKnownType(typeof(BaseStationBoard))]
        System.Threading.Tasks.Task<GetArrivalBoardResponse> GetArrivalBoardAsync(GetArrivalBoardRequest request);

        [OperationContract(Action = "http://thalesgroup.com/RTTI/2012-01-13/ldb/GetArrivalDepartureBoard", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(BaseServiceDetails))]
        [ServiceKnownType(typeof(BaseServiceItem))]
        [ServiceKnownType(typeof(BaseStationBoard))]
        System.Threading.Tasks.Task<GetArrivalDepartureBoardResponse> GetArrivalDepartureBoardAsync(GetArrivalDepartureBoardRequest request);

        [OperationContract(Action = "http://thalesgroup.com/RTTI/2012-01-13/ldb/GetServiceDetails", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(BaseServiceDetails))]
        [ServiceKnownType(typeof(BaseServiceItem))]
        [ServiceKnownType(typeof(BaseStationBoard))]
        System.Threading.Tasks.Task<GetServiceDetailsResponse> GetServiceDetailsAsync(GetServiceDetailsRequest request);

        [OperationContract(Action = "http://thalesgroup.com/RTTI/2015-05-14/ldb/GetDepBoardWithDetails", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(BaseServiceDetails))]
        [ServiceKnownType(typeof(BaseServiceItem))]
        [ServiceKnownType(typeof(BaseStationBoard))]
        System.Threading.Tasks.Task<GetDepBoardWithDetailsResponse> GetDepBoardWithDetailsAsync(GetDepBoardWithDetailsRequest request);

        [OperationContract(Action = "http://thalesgroup.com/RTTI/2015-05-14/ldb/GetArrBoardWithDetails", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(BaseServiceDetails))]
        [ServiceKnownType(typeof(BaseServiceItem))]
        [ServiceKnownType(typeof(BaseStationBoard))]
        System.Threading.Tasks.Task<GetArrBoardWithDetailsResponse> GetArrBoardWithDetailsAsync(GetArrBoardWithDetailsRequest request);

        [OperationContract(Action = "http://thalesgroup.com/RTTI/2015-05-14/ldb/GetArrDepBoardWithDetails", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(BaseServiceDetails))]
        [ServiceKnownType(typeof(BaseServiceItem))]
        [ServiceKnownType(typeof(BaseStationBoard))]
        System.Threading.Tasks.Task<GetArrDepBoardWithDetailsResponse> GetArrDepBoardWithDetailsAsync(GetArrDepBoardWithDetailsRequest request);

        [OperationContract(Action = "http://thalesgroup.com/RTTI/2015-05-14/ldb/GetNextDepartures", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(BaseServiceDetails))]
        [ServiceKnownType(typeof(BaseServiceItem))]
        [ServiceKnownType(typeof(BaseStationBoard))]
        System.Threading.Tasks.Task<GetNextDeparturesResponse> GetNextDeparturesAsync(GetNextDeparturesRequest request);

        [OperationContract(Action = "http://thalesgroup.com/RTTI/2015-05-14/ldb/GetNextDeparturesWithDetails", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(BaseServiceDetails))]
        [ServiceKnownType(typeof(BaseServiceItem))]
        [ServiceKnownType(typeof(BaseStationBoard))]
        System.Threading.Tasks.Task<GetNextDeparturesWithDetailsResponse> GetNextDeparturesWithDetailsAsync(GetNextDeparturesWithDetailsRequest request);

        [OperationContract(Action = "http://thalesgroup.com/RTTI/2015-05-14/ldb/GetFastestDepartures", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(BaseServiceDetails))]
        [ServiceKnownType(typeof(BaseServiceItem))]
        [ServiceKnownType(typeof(BaseStationBoard))]
        System.Threading.Tasks.Task<GetFastestDeparturesResponse> GetFastestDeparturesAsync(GetFastestDeparturesRequest request);

        [OperationContract(Action = "http://thalesgroup.com/RTTI/2015-05-14/ldb/GetFastestDeparturesWithDetails", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        [ServiceKnownType(typeof(BaseServiceDetails))]
        [ServiceKnownType(typeof(BaseServiceItem))]
        [ServiceKnownType(typeof(BaseStationBoard))]
        System.Threading.Tasks.Task<GetFastestDeparturesWithDetailsResponse> GetFastestDeparturesWithDetailsAsync(GetFastestDeparturesWithDetailsRequest request);
    }
}
