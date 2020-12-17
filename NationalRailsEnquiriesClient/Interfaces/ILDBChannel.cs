using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace NationalRailEnquiriesClient.Interfaces
{
    public interface ILDBServiceSoapChannel : ILDBService, IClientChannel
    {
    }
}
