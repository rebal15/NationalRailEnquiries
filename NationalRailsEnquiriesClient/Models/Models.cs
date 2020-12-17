using System;
using System.Collections.Generic;
using System.Text;

namespace NationalRailEnquiriesClient.Models
{
    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
    public partial class AccessToken
    {

        private string tokenValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string TokenValue
        {
            get
            {
                return this.tokenValueField;
            }
            set
            {
                this.tokenValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(ServiceDetails))]


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class BaseServiceDetails
    {

        private DateTime generatedAtField;

        private ServiceType serviceTypeField;

        private string locationNameField;

        private string crsField;

        private string operatorField;

        private string operatorCodeField;

        private string rsidField;

        private bool isCancelledField;

        private string cancelReasonField;

        private string delayReasonField;

        private string overdueMessageField;

        private ushort lengthField;

        private bool detachFrontField;

        private bool isReverseFormationField;

        private string platformField;

        private string staField;

        private string etaField;

        private string ataField;

        private string stdField;

        private string etdField;

        private string atdField;

        public BaseServiceDetails()
        {
            this.isCancelledField = false;
            this.lengthField = ((ushort)(0));
            this.detachFrontField = false;
            this.isReverseFormationField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public DateTime generatedAt
        {
            get
            {
                return this.generatedAtField;
            }
            set
            {
                this.generatedAtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ServiceType serviceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string locationName
        {
            get
            {
                return this.locationNameField;
            }
            set
            {
                this.locationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string @operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 5)]
        public string operatorCode
        {
            get
            {
                return this.operatorCodeField;
            }
            set
            {
                this.operatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 6)]
        public string rsid
        {
            get
            {
                return this.rsidField;
            }
            set
            {
                this.rsidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 7)]
        [System.ComponentModel.DefaultValue(false)]
        public bool isCancelled
        {
            get
            {
                return this.isCancelledField;
            }
            set
            {
                this.isCancelledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 8)]
        public string cancelReason
        {
            get
            {
                return this.cancelReasonField;
            }
            set
            {
                this.cancelReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 9)]
        public string delayReason
        {
            get
            {
                return this.delayReasonField;
            }
            set
            {
                this.delayReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 10)]
        public string overdueMessage
        {
            get
            {
                return this.overdueMessageField;
            }
            set
            {
                this.overdueMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 11)]
        [System.ComponentModel.DefaultValue(typeof(ushort), "0")]
        public ushort length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 12)]
        [System.ComponentModel.DefaultValue(false)]
        public bool detachFront
        {
            get
            {
                return this.detachFrontField;
            }
            set
            {
                this.detachFrontField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 13)]
        [System.ComponentModel.DefaultValue(false)]
        public bool isReverseFormation
        {
            get
            {
                return this.isReverseFormationField;
            }
            set
            {
                this.isReverseFormationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 14)]
        public string platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 15)]
        public string sta
        {
            get
            {
                return this.staField;
            }
            set
            {
                this.staField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 16)]
        public string eta
        {
            get
            {
                return this.etaField;
            }
            set
            {
                this.etaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 17)]
        public string ata
        {
            get
            {
                return this.ataField;
            }
            set
            {
                this.ataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 18)]
        public string std
        {
            get
            {
                return this.stdField;
            }
            set
            {
                this.stdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 19)]
        public string etd
        {
            get
            {
                return this.etdField;
            }
            set
            {
                this.etdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 20)]
        public string atd
        {
            get
            {
                return this.atdField;
            }
            set
            {
                this.atdField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2007-10-10/ldb/commontypes")]
    public enum ServiceType
    {

        /// <remarks/>
        train,

        /// <remarks/>
        bus,

        /// <remarks/>
        ferry,
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class ServiceDetails : BaseServiceDetails
    {

        private string[] adhocAlertsField;

        private FormationData formationField;

        private ArrayOfCallingPoints1[] previousCallingPointsField;

        private ArrayOfCallingPoints1[] subsequentCallingPointsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("adhocAlertText", Namespace = "http://thalesgroup.com/RTTI/2012-01-13/ldb/types")]
        public string[] adhocAlerts
        {
            get
            {
                return this.adhocAlertsField;
            }
            set
            {
                this.adhocAlertsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public FormationData formation
        {
            get
            {
                return this.formationField;
            }
            set
            {
                this.formationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 2)]
        [System.Xml.Serialization.XmlArrayItem("callingPointList")]
        public ArrayOfCallingPoints1[] previousCallingPoints
        {
            get
            {
                return this.previousCallingPointsField;
            }
            set
            {
                this.previousCallingPointsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 3)]
        [System.Xml.Serialization.XmlArrayItem("callingPointList")]
        public ArrayOfCallingPoints1[] subsequentCallingPoints
        {
            get
            {
                return this.subsequentCallingPointsField;
            }
            set
            {
                this.subsequentCallingPointsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class FormationData
    {

        private uint avgLoadingField;

        private bool avgLoadingFieldSpecified;

        private CoachData[] coachesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public uint avgLoading
        {
            get
            {
                return this.avgLoadingField;
            }
            set
            {
                this.avgLoadingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool avgLoadingSpecified
        {
            get
            {
                return this.avgLoadingFieldSpecified;
            }
            set
            {
                this.avgLoadingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("coach", IsNullable = false)]
        public CoachData[] coaches
        {
            get
            {
                return this.coachesField;
            }
            set
            {
                this.coachesField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class CoachData
    {

        private string coachClassField;

        private ToiletAvailabilityType toiletField;

        private uint loadingField;

        private bool loadingFieldSpecified;

        private string numberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string coachClass
        {
            get
            {
                return this.coachClassField;
            }
            set
            {
                this.coachClassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public ToiletAvailabilityType toilet
        {
            get
            {
                return this.toiletField;
            }
            set
            {
                this.toiletField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public uint loading
        {
            get
            {
                return this.loadingField;
            }
            set
            {
                this.loadingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public bool loadingSpecified
        {
            get
            {
                return this.loadingFieldSpecified;
            }
            set
            {
                this.loadingFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/commontypes")]
    public partial class ToiletAvailabilityType
    {

        private ToiletStatus statusField;

        private string valueField;

        public ToiletAvailabilityType()
        {
            this.statusField = ToiletStatus.InService;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        [System.ComponentModel.DefaultValue(ToiletStatus.InService)]
        public ToiletStatus status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlText()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/commontypes")]
    public enum ToiletStatus
    {

        /// <remarks/>
        Unknown,

        /// <remarks/>
        InService,

        /// <remarks/>
        NotInService,
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "ArrayOfCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class ArrayOfCallingPoints1
    {

        private CallingPoint1[] callingPointField;

        private ServiceType serviceTypeField;

        private bool serviceChangeRequiredField;

        private bool assocIsCancelledField;

        public ArrayOfCallingPoints1()
        {
            this.serviceTypeField = ServiceType.train;
            this.serviceChangeRequiredField = false;
            this.assocIsCancelledField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("callingPoint", IsNullable = true, Order = 0)]
        public CallingPoint1[] callingPoint
        {
            get
            {
                return this.callingPointField;
            }
            set
            {
                this.callingPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        [System.ComponentModel.DefaultValue(ServiceType.train)]
        public ServiceType serviceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        [System.ComponentModel.DefaultValue(false)]
        public bool serviceChangeRequired
        {
            get
            {
                return this.serviceChangeRequiredField;
            }
            set
            {
                this.serviceChangeRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        [System.ComponentModel.DefaultValue(false)]
        public bool assocIsCancelled
        {
            get
            {
                return this.assocIsCancelledField;
            }
            set
            {
                this.assocIsCancelledField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "CallingPoint", Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class CallingPoint1
    {

        private string locationNameField;

        private string crsField;

        private string stField;

        private string etField;

        private string atField;

        private bool isCancelledField;

        private ushort lengthField;

        private bool detachFrontField;

        private FormationData formationField;

        private string[] adhocAlertsField;

        public CallingPoint1()
        {
            this.isCancelledField = false;
            this.lengthField = ((ushort)(0));
            this.detachFrontField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string locationName
        {
            get
            {
                return this.locationNameField;
            }
            set
            {
                this.locationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string st
        {
            get
            {
                return this.stField;
            }
            set
            {
                this.stField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string et
        {
            get
            {
                return this.etField;
            }
            set
            {
                this.etField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string at
        {
            get
            {
                return this.atField;
            }
            set
            {
                this.atField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 5)]
        [System.ComponentModel.DefaultValue(false)]
        public bool isCancelled
        {
            get
            {
                return this.isCancelledField;
            }
            set
            {
                this.isCancelledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 6)]
        [System.ComponentModel.DefaultValue(typeof(ushort), "0")]
        public ushort length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 7)]
        [System.ComponentModel.DefaultValue(false)]
        public bool detachFront
        {
            get
            {
                return this.detachFrontField;
            }
            set
            {
                this.detachFrontField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 8)]
        public FormationData formation
        {
            get
            {
                return this.formationField;
            }
            set
            {
                this.formationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 9)]
        [System.Xml.Serialization.XmlArrayItem("adhocAlertText", Namespace = "http://thalesgroup.com/RTTI/2012-01-13/ldb/types")]
        public string[] adhocAlerts
        {
            get
            {
                return this.adhocAlertsField;
            }
            set
            {
                this.adhocAlertsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "DepartureItemWithCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class DepartureItemWithCallingPoints2
    {

        private ServiceItemWithCallingPoints2 serviceField;

        private string crsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public ServiceItemWithCallingPoints2 service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "ServiceItemWithCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class ServiceItemWithCallingPoints2 : ServiceItem2
    {

        private ArrayOfCallingPoints[] previousCallingPointsField;

        private ArrayOfCallingPoints[] subsequentCallingPointsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("callingPointList")]
        public ArrayOfCallingPoints[] previousCallingPoints
        {
            get
            {
                return this.previousCallingPointsField;
            }
            set
            {
                this.previousCallingPointsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("callingPointList")]
        public ArrayOfCallingPoints[] subsequentCallingPoints
        {
            get
            {
                return this.subsequentCallingPointsField;
            }
            set
            {
                this.subsequentCallingPointsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class ArrayOfCallingPoints
    {

        private CallingPoint[] callingPointField;

        private ServiceType serviceTypeField;

        private bool serviceChangeRequiredField;

        private bool assocIsCancelledField;

        public ArrayOfCallingPoints()
        {
            this.serviceTypeField = ServiceType.train;
            this.serviceChangeRequiredField = false;
            this.assocIsCancelledField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement("callingPoint", IsNullable = true, Order = 0)]
        public CallingPoint[] callingPoint
        {
            get
            {
                return this.callingPointField;
            }
            set
            {
                this.callingPointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        [System.ComponentModel.DefaultValue(ServiceType.train)]
        public ServiceType serviceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        [System.ComponentModel.DefaultValue(false)]
        public bool serviceChangeRequired
        {
            get
            {
                return this.serviceChangeRequiredField;
            }
            set
            {
                this.serviceChangeRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        [System.ComponentModel.DefaultValue(false)]
        public bool assocIsCancelled
        {
            get
            {
                return this.assocIsCancelledField;
            }
            set
            {
                this.assocIsCancelledField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class CallingPoint
    {

        private string locationNameField;

        private string crsField;

        private string stField;

        private string etField;

        private string atField;

        private bool isCancelledField;

        private ushort lengthField;

        private bool detachFrontField;

        private string[] adhocAlertsField;

        public CallingPoint()
        {
            this.isCancelledField = false;
            this.lengthField = ((ushort)(0));
            this.detachFrontField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string locationName
        {
            get
            {
                return this.locationNameField;
            }
            set
            {
                this.locationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string st
        {
            get
            {
                return this.stField;
            }
            set
            {
                this.stField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string et
        {
            get
            {
                return this.etField;
            }
            set
            {
                this.etField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string at
        {
            get
            {
                return this.atField;
            }
            set
            {
                this.atField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 5)]
        [System.ComponentModel.DefaultValue(false)]
        public bool isCancelled
        {
            get
            {
                return this.isCancelledField;
            }
            set
            {
                this.isCancelledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 6)]
        [System.ComponentModel.DefaultValue(typeof(ushort), "0")]
        public ushort length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 7)]
        [System.ComponentModel.DefaultValue(false)]
        public bool detachFront
        {
            get
            {
                return this.detachFrontField;
            }
            set
            {
                this.detachFrontField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 8)]
        [System.Xml.Serialization.XmlArrayItem("adhocAlertText", Namespace = "http://thalesgroup.com/RTTI/2012-01-13/ldb/types")]
        public string[] adhocAlerts
        {
            get
            {
                return this.adhocAlertsField;
            }
            set
            {
                this.adhocAlertsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItemWithCallingPoints2))]


    [System.Xml.Serialization.XmlType(TypeName = "ServiceItem", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class ServiceItem2 : BaseServiceItem
    {

        private ServiceLocation[] originField;

        private ServiceLocation[] destinationField;

        private ServiceLocation[] currentOriginsField;

        private ServiceLocation[] currentDestinationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("location")]
        public ServiceLocation[] origin
        {
            get
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("location")]
        public ServiceLocation[] destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 2)]
        [System.Xml.Serialization.XmlArrayItem("location")]
        public ServiceLocation[] currentOrigins
        {
            get
            {
                return this.currentOriginsField;
            }
            set
            {
                this.currentOriginsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 3)]
        [System.Xml.Serialization.XmlArrayItem("location")]
        public ServiceLocation[] currentDestinations
        {
            get
            {
                return this.currentDestinationsField;
            }
            set
            {
                this.currentDestinationsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class ServiceLocation
    {

        private string locationNameField;

        private string crsField;

        private string viaField;

        private string futureChangeToField;

        private bool assocIsCancelledField;

        public ServiceLocation()
        {
            this.assocIsCancelledField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string locationName
        {
            get
            {
                return this.locationNameField;
            }
            set
            {
                this.locationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string via
        {
            get
            {
                return this.viaField;
            }
            set
            {
                this.viaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string futureChangeTo
        {
            get
            {
                return this.futureChangeToField;
            }
            set
            {
                this.futureChangeToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 4)]
        [System.ComponentModel.DefaultValue(false)]
        public bool assocIsCancelled
        {
            get
            {
                return this.assocIsCancelledField;
            }
            set
            {
                this.assocIsCancelledField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItem2))]
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItemWithCallingPoints2))]
    [System.Xml.Serialization.XmlInclude(typeof(BaseServiceItem1))]
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItem))]
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItem1))]
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItemWithCallingPoints1))]
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItemWithCallingPoints))]


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class BaseServiceItem
    {

        private string staField;

        private string etaField;

        private string stdField;

        private string etdField;

        private string platformField;

        private string operatorField;

        private string operatorCodeField;

        private bool isCircularRouteField;

        private bool isCancelledField;

        private bool filterLocationCancelledField;

        private ServiceType serviceTypeField;

        private ushort lengthField;

        private bool detachFrontField;

        private bool isReverseFormationField;

        private string cancelReasonField;

        private string delayReasonField;

        private string serviceIDField;

        private string[] adhocAlertsField;

        public BaseServiceItem()
        {
            this.isCircularRouteField = false;
            this.isCancelledField = false;
            this.filterLocationCancelledField = false;
            this.lengthField = ((ushort)(0));
            this.detachFrontField = false;
            this.isReverseFormationField = false;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string sta
        {
            get
            {
                return this.staField;
            }
            set
            {
                this.staField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string eta
        {
            get
            {
                return this.etaField;
            }
            set
            {
                this.etaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string std
        {
            get
            {
                return this.stdField;
            }
            set
            {
                this.stdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string etd
        {
            get
            {
                return this.etdField;
            }
            set
            {
                this.etdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 5)]
        public string @operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 6)]
        public string operatorCode
        {
            get
            {
                return this.operatorCodeField;
            }
            set
            {
                this.operatorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 7)]
        [System.ComponentModel.DefaultValue(false)]
        public bool isCircularRoute
        {
            get
            {
                return this.isCircularRouteField;
            }
            set
            {
                this.isCircularRouteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 8)]
        [System.ComponentModel.DefaultValue(false)]
        public bool isCancelled
        {
            get
            {
                return this.isCancelledField;
            }
            set
            {
                this.isCancelledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 9)]
        [System.ComponentModel.DefaultValue(false)]
        public bool filterLocationCancelled
        {
            get
            {
                return this.filterLocationCancelledField;
            }
            set
            {
                this.filterLocationCancelledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 10)]
        public ServiceType serviceType
        {
            get
            {
                return this.serviceTypeField;
            }
            set
            {
                this.serviceTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 11)]
        [System.ComponentModel.DefaultValue(typeof(ushort), "0")]
        public ushort length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 12)]
        [System.ComponentModel.DefaultValue(false)]
        public bool detachFront
        {
            get
            {
                return this.detachFrontField;
            }
            set
            {
                this.detachFrontField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 13)]
        [System.ComponentModel.DefaultValue(false)]
        public bool isReverseFormation
        {
            get
            {
                return this.isReverseFormationField;
            }
            set
            {
                this.isReverseFormationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 14)]
        public string cancelReason
        {
            get
            {
                return this.cancelReasonField;
            }
            set
            {
                this.cancelReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 15)]
        public string delayReason
        {
            get
            {
                return this.delayReasonField;
            }
            set
            {
                this.delayReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 16)]
        public string serviceID
        {
            get
            {
                return this.serviceIDField;
            }
            set
            {
                this.serviceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 17)]
        [System.Xml.Serialization.XmlArrayItem("adhocAlertText", Namespace = "http://thalesgroup.com/RTTI/2012-01-13/ldb/types")]
        public string[] adhocAlerts
        {
            get
            {
                return this.adhocAlertsField;
            }
            set
            {
                this.adhocAlertsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItem))]
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItem1))]
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItemWithCallingPoints1))]
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItemWithCallingPoints))]


    [System.Xml.Serialization.XmlType(TypeName = "BaseServiceItem", Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
    public partial class BaseServiceItem1 : BaseServiceItem
    {

        private string rsidField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public string rsid
        {
            get
            {
                return this.rsidField;
            }
            set
            {
                this.rsidField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItem1))]
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItemWithCallingPoints1))]
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItemWithCallingPoints))]


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
    public partial class ServiceItem : BaseServiceItem1
    {

        private ServiceLocation[] originField;

        private ServiceLocation[] destinationField;

        private ServiceLocation[] currentOriginsField;

        private ServiceLocation[] currentDestinationsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("location", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public ServiceLocation[] origin
        {
            get 
            {
                return this.originField;
            }
            set
            {
                this.originField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("location", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public ServiceLocation[] destination
        {
            get
            {
                return this.destinationField;
            }
            set
            {
                this.destinationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 2)]
        [System.Xml.Serialization.XmlArrayItem("location", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public ServiceLocation[] currentOrigins
        {
            get
            {
                return this.currentOriginsField;
            }
            set
            {
                this.currentOriginsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 3)]
        [System.Xml.Serialization.XmlArrayItem("location", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public ServiceLocation[] currentDestinations
        {
            get
            {
                return this.currentDestinationsField;
            }
            set
            {
                this.currentDestinationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(ServiceItemWithCallingPoints1))]


    [System.Xml.Serialization.XmlType(TypeName = "ServiceItem", Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class ServiceItem1 : ServiceItem
    {

        private FormationData formationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public FormationData formation
        {
            get
            {
                return this.formationField;
            }
            set
            {
                this.formationField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "ServiceItemWithCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class ServiceItemWithCallingPoints1 : ServiceItem1
    {

        private ArrayOfCallingPoints1[] previousCallingPointsField;

        private ArrayOfCallingPoints1[] subsequentCallingPointsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("callingPointList")]
        public ArrayOfCallingPoints1[] previousCallingPoints
        {
            get
            {
                return this.previousCallingPointsField;
            }
            set
            {
                this.previousCallingPointsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("callingPointList")]
        public ArrayOfCallingPoints1[] subsequentCallingPoints
        {
            get
            {
                return this.subsequentCallingPointsField;
            }
            set
            {
                this.subsequentCallingPointsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
    public partial class ServiceItemWithCallingPoints : ServiceItem
    {

        private ArrayOfCallingPoints[] previousCallingPointsField;

        private ArrayOfCallingPoints[] subsequentCallingPointsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("callingPointList", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public ArrayOfCallingPoints[] previousCallingPoints
        {
            get
            {
                return this.previousCallingPointsField;
            }
            set
            {
                this.previousCallingPointsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("callingPointList", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
        public ArrayOfCallingPoints[] subsequentCallingPoints
        {
            get
            {
                return this.subsequentCallingPointsField;
            }
            set
            {
                this.subsequentCallingPointsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "DepartureItem", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class DepartureItem2
    {

        private ServiceItem2 serviceField;

        private string crsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public ServiceItem2 service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "DepartureItemWithCallingPoints", Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class DepartureItemWithCallingPoints1
    {

        private ServiceItemWithCallingPoints1 serviceField;

        private string crsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public ServiceItemWithCallingPoints1 service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "DepartureItem", Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class DepartureItem1
    {

        private ServiceItem1 serviceField;

        private string crsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public ServiceItem1 service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
    public partial class DepartureItemWithCallingPoints
    {

        private ServiceItemWithCallingPoints serviceField;

        private string crsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public ServiceItemWithCallingPoints service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
    public partial class DepartureItem
    {

        private ServiceItem serviceField;

        private string crsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(IsNullable = true, Order = 0)]
        public ServiceItem service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttribute()]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2012-01-13/ldb/types")]
    public partial class NRCCMessage
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlText()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlInclude(typeof(DeparturesBoardWithDetails2))]
    [System.Xml.Serialization.XmlInclude(typeof(DeparturesBoard2))]
    [System.Xml.Serialization.XmlInclude(typeof(StationBoardWithDetails2))]
    [System.Xml.Serialization.XmlInclude(typeof(StationBoard2))]
    [System.Xml.Serialization.XmlInclude(typeof(DeparturesBoardWithDetails1))]
    [System.Xml.Serialization.XmlInclude(typeof(DeparturesBoard1))]
    [System.Xml.Serialization.XmlInclude(typeof(StationBoardWithDetails1))]
    [System.Xml.Serialization.XmlInclude(typeof(StationBoard1))]
    [System.Xml.Serialization.XmlInclude(typeof(DeparturesBoardWithDetails))]
    [System.Xml.Serialization.XmlInclude(typeof(DeparturesBoard))]
    [System.Xml.Serialization.XmlInclude(typeof(StationBoardWithDetails))]
    [System.Xml.Serialization.XmlInclude(typeof(StationBoard))]


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class BaseStationBoard
    {

        private DateTime generatedAtField;

        private string locationNameField;

        private string crsField;

        private string filterLocationNameField;

        private string filtercrsField;

        private FilterType filterTypeField;

        private NRCCMessage[] nrccMessagesField;

        private bool platformAvailableField;

        private bool areServicesAvailableField;

        public BaseStationBoard()
        {
            this.filterTypeField = FilterType.to;
            this.platformAvailableField = false;
            this.areServicesAvailableField = true;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 0)]
        public DateTime generatedAt
        {
            get
            {
                return this.generatedAtField;
            }
            set
            {
                this.generatedAtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 1)]
        public string locationName
        {
            get
            {
                return this.locationNameField;
            }
            set
            {
                this.locationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 2)]
        public string crs
        {
            get
            {
                return this.crsField;
            }
            set
            {
                this.crsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 3)]
        public string filterLocationName
        {
            get
            {
                return this.filterLocationNameField;
            }
            set
            {
                this.filterLocationNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 4)]
        public string filtercrs
        {
            get
            {
                return this.filtercrsField;
            }
            set
            {
                this.filtercrsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 5)]
        [System.ComponentModel.DefaultValue(FilterType.to)]
        public FilterType filterType
        {
            get
            {
                return this.filterTypeField;
            }
            set
            {
                this.filterTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 6)]
        [System.Xml.Serialization.XmlArrayItem("message", Namespace = "http://thalesgroup.com/RTTI/2012-01-13/ldb/types")]
        public NRCCMessage[] nrccMessages
        {
            get
            {
                return this.nrccMessagesField;
            }
            set
            {
                this.nrccMessagesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 7)]
        [System.ComponentModel.DefaultValue(false)]
        public bool platformAvailable
        {
            get
            {
                return this.platformAvailableField;
            }
            set
            {
                this.platformAvailableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElement(Order = 8)]
        [System.ComponentModel.DefaultValue(true)]
        public bool areServicesAvailable
        {
            get
            {
                return this.areServicesAvailableField;
            }
            set
            {
                this.areServicesAvailableField = value;
            }
        }
    }

    /// <remarks/>

    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2007-10-10/ldb/commontypes")]
    public enum FilterType
    {

        /// <remarks/>
        to,

        /// <remarks/>
        from,
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "DeparturesBoardWithDetails", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class DeparturesBoardWithDetails2 : BaseStationBoard
    {

        private DepartureItemWithCallingPoints2[] departuresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("destination", IsNullable = false)]
        public DepartureItemWithCallingPoints2[] departures
        {
            get
            {
                return this.departuresField;
            }
            set
            {
                this.departuresField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "DeparturesBoard", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class DeparturesBoard2 : BaseStationBoard
    {

        private DepartureItem2[] departuresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("destination", IsNullable = false)]
        public DepartureItem2[] departures
        {
            get
            {
                return this.departuresField;
            }
            set
            {
                this.departuresField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "StationBoardWithDetails", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class StationBoardWithDetails2 : BaseStationBoard
    {

        private ServiceItemWithCallingPoints2[] trainServicesField;

        private ServiceItemWithCallingPoints2[] busServicesField;

        private ServiceItemWithCallingPoints2[] ferryServicesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("service")]
        public ServiceItemWithCallingPoints2[] trainServices
        {
            get
            {
                return this.trainServicesField;
            }
            set
            {
                this.trainServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("service")]
        public ServiceItemWithCallingPoints2[] busServices
        {
            get
            {
                return this.busServicesField;
            }
            set
            {
                this.busServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 2)]
        [System.Xml.Serialization.XmlArrayItem("service")]
        public ServiceItemWithCallingPoints2[] ferryServices
        {
            get
            {
                return this.ferryServicesField;
            }
            set
            {
                this.ferryServicesField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "StationBoard", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public partial class StationBoard2 : BaseStationBoard
    {

        private ServiceItem2[] trainServicesField;

        private ServiceItem2[] busServicesField;

        private ServiceItem2[] ferryServicesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("service")]
        public ServiceItem2[] trainServices
        {
            get
            {
                return this.trainServicesField;
            }
            set
            {
                this.trainServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("service")]
        public ServiceItem2[] busServices
        {
            get
            {
                return this.busServicesField;
            }
            set
            {
                this.busServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 2)]
        [System.Xml.Serialization.XmlArrayItem("service")]
        public ServiceItem2[] ferryServices
        {
            get
            {
                return this.ferryServicesField;
            }
            set
            {
                this.ferryServicesField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "DeparturesBoardWithDetails", Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class DeparturesBoardWithDetails1 : BaseStationBoard
    {

        private DepartureItemWithCallingPoints1[] departuresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("destination", IsNullable = false)]
        public DepartureItemWithCallingPoints1[] departures
        {
            get
            {
                return this.departuresField;
            }
            set
            {
                this.departuresField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "DeparturesBoard", Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class DeparturesBoard1 : BaseStationBoard
    {

        private DepartureItem1[] departuresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("destination", IsNullable = false)]
        public DepartureItem1[] departures
        {
            get
            {
                return this.departuresField;
            }
            set
            {
                this.departuresField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "StationBoardWithDetails", Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class StationBoardWithDetails1 : BaseStationBoard
    {

        private ServiceItemWithCallingPoints1[] trainServicesField;

        private ServiceItemWithCallingPoints1[] busServicesField;

        private ServiceItemWithCallingPoints1[] ferryServicesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("service", IsNullable = false)]
        public ServiceItemWithCallingPoints1[] trainServices
        {
            get
            {
                return this.trainServicesField;
            }
            set
            {
                this.trainServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("service", IsNullable = false)]
        public ServiceItemWithCallingPoints1[] busServices
        {
            get
            {
                return this.busServicesField;
            }
            set
            {
                this.busServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 2)]
        [System.Xml.Serialization.XmlArrayItem("service", IsNullable = false)]
        public ServiceItemWithCallingPoints1[] ferryServices
        {
            get
            {
                return this.ferryServicesField;
            }
            set
            {
                this.ferryServicesField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(TypeName = "StationBoard", Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/types")]
    public partial class StationBoard1 : BaseStationBoard
    {

        private ServiceItem1[] trainServicesField;

        private ServiceItem1[] busServicesField;

        private ServiceItem1[] ferryServicesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("service", IsNullable = false)]
        public ServiceItem1[] trainServices
        {
            get
            {
                return this.trainServicesField;
            }
            set
            {
                this.trainServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("service", IsNullable = false)]
        public ServiceItem1[] busServices
        {
            get
            {
                return this.busServicesField;
            }
            set
            {
                this.busServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 2)]
        [System.Xml.Serialization.XmlArrayItem("service", IsNullable = false)]
        public ServiceItem1[] ferryServices
        {
            get
            {
                return this.ferryServicesField;
            }
            set
            {
                this.ferryServicesField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
    public partial class DeparturesBoardWithDetails : BaseStationBoard
    {

        private DepartureItemWithCallingPoints[] departuresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("destination", IsNullable = false)]
        public DepartureItemWithCallingPoints[] departures
        {
            get
            {
                return this.departuresField;
            }
            set
            {
                this.departuresField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
    public partial class DeparturesBoard : BaseStationBoard
    {

        private DepartureItem[] departuresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("destination", IsNullable = false)]
        public DepartureItem[] departures
        {
            get
            {
                return this.departuresField;
            }
            set
            {
                this.departuresField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
    public partial class StationBoardWithDetails : BaseStationBoard
    {

        private ServiceItemWithCallingPoints[] trainServicesField;

        private ServiceItemWithCallingPoints[] busServicesField;

        private ServiceItemWithCallingPoints[] ferryServicesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("service")]
        public ServiceItemWithCallingPoints[] trainServices
        {
            get
            {
                return this.trainServicesField;
            }
            set
            {
                this.trainServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("service")]
        public ServiceItemWithCallingPoints[] busServices
        {
            get
            {
                return this.busServicesField;
            }
            set
            {
                this.busServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 2)]
        [System.Xml.Serialization.XmlArrayItem("service")]
        public ServiceItemWithCallingPoints[] ferryServices
        {
            get
            {
                return this.ferryServicesField;
            }
            set
            {
                this.ferryServicesField = value;
            }
        }
    }

    /// <remarks/>


    [System.Xml.Serialization.XmlType(Namespace = "http://thalesgroup.com/RTTI/2016-02-16/ldb/types")]
    public partial class StationBoard : BaseStationBoard
    {

        private ServiceItem[] trainServicesField;

        private ServiceItem[] busServicesField;

        private ServiceItem[] ferryServicesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 0)]
        [System.Xml.Serialization.XmlArrayItem("service")]
        public ServiceItem[] trainServices
        {
            get
            {
                return this.trainServicesField;
            }
            set
            {
                this.trainServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("service")]
        public ServiceItem[] busServices
        {
            get
            {
                return this.busServicesField;
            }
            set
            {
                this.busServicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Order = 2)]
        [System.Xml.Serialization.XmlArrayItem("service")]
        public ServiceItem[] ferryServices
        {
            get
            {
                return this.ferryServicesField;
            }
            set
            {
                this.ferryServicesField = value;
            }
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetDepartureBoardRequest", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetDepartureBoardRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public AccessToken AccessToken;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public ushort numRows;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 1)]
        public string crs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 2)]
        public string filterCrs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 3)]
        [System.ComponentModel.DefaultValue(FilterType.to)]
        public FilterType filterType;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 4)]
        [System.ComponentModel.DefaultValue(0)]
        public int timeOffset;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 5)]
        [System.ComponentModel.DefaultValue(120)]
        public int timeWindow;

        public GetDepartureBoardRequest()
        {
        }

        public GetDepartureBoardRequest(AccessToken AccessToken, ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset, int timeWindow)
        {
            this.AccessToken = AccessToken;
            this.numRows = numRows;
            this.crs = crs;
            this.filterCrs = filterCrs;
            this.filterType = filterType;
            this.timeOffset = timeOffset;
            this.timeWindow = timeWindow;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetDepartureBoardResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetDepartureBoardResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public StationBoard1 GetStationBoardResult;

        public GetDepartureBoardResponse()
        {
        }

        public GetDepartureBoardResponse(StationBoard1 GetStationBoardResult)
        {
            this.GetStationBoardResult = GetStationBoardResult;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetArrivalBoardRequest", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetArrivalBoardRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public AccessToken AccessToken;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public ushort numRows;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 1)]
        public string crs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 2)]
        public string filterCrs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 3)]
        [System.ComponentModel.DefaultValue(FilterType.to)]
        public FilterType filterType;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 4)]
        [System.ComponentModel.DefaultValue(0)]
        public int timeOffset;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 5)]
        [System.ComponentModel.DefaultValue(120)]
        public int timeWindow;

        public GetArrivalBoardRequest()
        {
        }

        public GetArrivalBoardRequest(AccessToken AccessToken, ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset, int timeWindow)
        {
            this.AccessToken = AccessToken;
            this.numRows = numRows;
            this.crs = crs;
            this.filterCrs = filterCrs;
            this.filterType = filterType;
            this.timeOffset = timeOffset;
            this.timeWindow = timeWindow;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetArrivalBoardResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetArrivalBoardResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public StationBoard1 GetStationBoardResult;

        public GetArrivalBoardResponse()
        {
        }

        public GetArrivalBoardResponse(StationBoard1 GetStationBoardResult)
        {
            this.GetStationBoardResult = GetStationBoardResult;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetArrivalDepartureBoardRequest", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetArrivalDepartureBoardRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public AccessToken AccessToken;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public ushort numRows;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 1)]
        public string crs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 2)]
        public string filterCrs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 3)]
        [System.ComponentModel.DefaultValue(FilterType.to)]
        public FilterType filterType;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 4)]
        [System.ComponentModel.DefaultValue(0)]
        public int timeOffset;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 5)]
        [System.ComponentModel.DefaultValue(120)]
        public int timeWindow;

        public GetArrivalDepartureBoardRequest()
        {
        }

        public GetArrivalDepartureBoardRequest(AccessToken AccessToken, ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset, int timeWindow)
        {
            this.AccessToken = AccessToken;
            this.numRows = numRows;
            this.crs = crs;
            this.filterCrs = filterCrs;
            this.filterType = filterType;
            this.timeOffset = timeOffset;
            this.timeWindow = timeWindow;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetArrivalDepartureBoardResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetArrivalDepartureBoardResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public StationBoard1 GetStationBoardResult;

        public GetArrivalDepartureBoardResponse()
        {
        }

        public GetArrivalDepartureBoardResponse(StationBoard1 GetStationBoardResult)
        {
            this.GetStationBoardResult = GetStationBoardResult;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetServiceDetailsRequest", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetServiceDetailsRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public AccessToken AccessToken;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public string serviceID;

        public GetServiceDetailsRequest()
        {
        }

        public GetServiceDetailsRequest(AccessToken AccessToken, string serviceID)
        {
            this.AccessToken = AccessToken;
            this.serviceID = serviceID;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetServiceDetailsResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetServiceDetailsResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public ServiceDetails GetServiceDetailsResult;

        public GetServiceDetailsResponse()
        {
        }

        public GetServiceDetailsResponse(ServiceDetails GetServiceDetailsResult)
        {
            this.GetServiceDetailsResult = GetServiceDetailsResult;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetDepBoardWithDetailsRequest", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetDepBoardWithDetailsRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public AccessToken AccessToken;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public ushort numRows;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 1)]
        public string crs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 2)]
        public string filterCrs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 3)]
        [System.ComponentModel.DefaultValue(FilterType.to)]
        public FilterType filterType;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 4)]
        [System.ComponentModel.DefaultValue(0)]
        public int timeOffset;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 5)]
        [System.ComponentModel.DefaultValue(120)]
        public int timeWindow;

        public GetDepBoardWithDetailsRequest()
        {
        }

        public GetDepBoardWithDetailsRequest(AccessToken AccessToken, ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset, int timeWindow)
        {
            this.AccessToken = AccessToken;
            this.numRows = numRows;
            this.crs = crs;
            this.filterCrs = filterCrs;
            this.filterType = filterType;
            this.timeOffset = timeOffset;
            this.timeWindow = timeWindow;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetDepBoardWithDetailsResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetDepBoardWithDetailsResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public StationBoardWithDetails1 GetStationBoardResult;

        public GetDepBoardWithDetailsResponse()
        {
        }

        public GetDepBoardWithDetailsResponse(StationBoardWithDetails1 GetStationBoardResult)
        {
            this.GetStationBoardResult = GetStationBoardResult;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetArrBoardWithDetailsRequest", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetArrBoardWithDetailsRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public AccessToken AccessToken;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public ushort numRows;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 1)]
        public string crs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 2)]
        public string filterCrs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 3)]
        [System.ComponentModel.DefaultValue(FilterType.to)]
        public FilterType filterType;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 4)]
        [System.ComponentModel.DefaultValue(0)]
        public int timeOffset;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 5)]
        [System.ComponentModel.DefaultValue(120)]
        public int timeWindow;

        public GetArrBoardWithDetailsRequest()
        {
        }

        public GetArrBoardWithDetailsRequest(AccessToken AccessToken, ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset, int timeWindow)
        {
            this.AccessToken = AccessToken;
            this.numRows = numRows;
            this.crs = crs;
            this.filterCrs = filterCrs;
            this.filterType = filterType;
            this.timeOffset = timeOffset;
            this.timeWindow = timeWindow;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetArrBoardWithDetailsResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetArrBoardWithDetailsResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public StationBoardWithDetails1 GetStationBoardResult;

        public GetArrBoardWithDetailsResponse()
        {
        }

        public GetArrBoardWithDetailsResponse(StationBoardWithDetails1 GetStationBoardResult)
        {
            this.GetStationBoardResult = GetStationBoardResult;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetArrDepBoardWithDetailsRequest", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetArrDepBoardWithDetailsRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public AccessToken AccessToken;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public ushort numRows;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 1)]
        public string crs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 2)]
        public string filterCrs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 3)]
        [System.ComponentModel.DefaultValue(FilterType.to)]
        public FilterType filterType;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 4)]
        [System.ComponentModel.DefaultValue(0)]
        public int timeOffset;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 5)]
        [System.ComponentModel.DefaultValue(120)]
        public int timeWindow;

        public GetArrDepBoardWithDetailsRequest()
        {
        }

        public GetArrDepBoardWithDetailsRequest(AccessToken AccessToken, ushort numRows, string crs, string filterCrs, FilterType filterType, int timeOffset, int timeWindow)
        {
            this.AccessToken = AccessToken;
            this.numRows = numRows;
            this.crs = crs;
            this.filterCrs = filterCrs;
            this.filterType = filterType;
            this.timeOffset = timeOffset;
            this.timeWindow = timeWindow;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetArrDepBoardWithDetailsResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetArrDepBoardWithDetailsResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public StationBoardWithDetails1 GetStationBoardResult;

        public GetArrDepBoardWithDetailsResponse()
        {
        }

        public GetArrDepBoardWithDetailsResponse(StationBoardWithDetails1 GetStationBoardResult)
        {
            this.GetStationBoardResult = GetStationBoardResult;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetNextDeparturesRequest", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetNextDeparturesRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public AccessToken AccessToken;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public string crs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("crs", IsNullable = false)]
        public string[] filterList;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 2)]
        [System.ComponentModel.DefaultValue(0)]
        public int timeOffset;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 3)]
        [System.ComponentModel.DefaultValue(120)]
        public int timeWindow;

        public GetNextDeparturesRequest()
        {
        }

        public GetNextDeparturesRequest(AccessToken AccessToken, string crs, string[] filterList, int timeOffset, int timeWindow)
        {
            this.AccessToken = AccessToken;
            this.crs = crs;
            this.filterList = filterList;
            this.timeOffset = timeOffset;
            this.timeWindow = timeWindow;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetNextDeparturesResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetNextDeparturesResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public DeparturesBoard1 DeparturesBoard;

        public GetNextDeparturesResponse()
        {
        }

        public GetNextDeparturesResponse(DeparturesBoard1 DeparturesBoard)
        {
            this.DeparturesBoard = DeparturesBoard;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetNextDeparturesWithDetailsRequest", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetNextDeparturesWithDetailsRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public AccessToken AccessToken;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public string crs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("crs", IsNullable = false)]
        public string[] filterList;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 2)]
        [System.ComponentModel.DefaultValue(0)]
        public int timeOffset;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 3)]
        [System.ComponentModel.DefaultValue(120)]
        public int timeWindow;

        public GetNextDeparturesWithDetailsRequest()
        {
        }

        public GetNextDeparturesWithDetailsRequest(AccessToken AccessToken, string crs, string[] filterList, int timeOffset, int timeWindow)
        {
            this.AccessToken = AccessToken;
            this.crs = crs;
            this.filterList = filterList;
            this.timeOffset = timeOffset;
            this.timeWindow = timeWindow;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetNextDeparturesWithDetailsResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetNextDeparturesWithDetailsResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public DeparturesBoardWithDetails1 DeparturesBoard;

        public GetNextDeparturesWithDetailsResponse()
        {
        }

        public GetNextDeparturesWithDetailsResponse(DeparturesBoardWithDetails1 DeparturesBoard)
        {
            this.DeparturesBoard = DeparturesBoard;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetFastestDeparturesRequest", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetFastestDeparturesRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public AccessToken AccessToken;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public string crs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("crs", IsNullable = false)]
        public string[] filterList;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 2)]
        [System.ComponentModel.DefaultValue(0)]
        public int timeOffset;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 3)]
        [System.ComponentModel.DefaultValue(120)]
        public int timeWindow;

        public GetFastestDeparturesRequest()
        {
        }

        public GetFastestDeparturesRequest(AccessToken AccessToken, string crs, string[] filterList, int timeOffset, int timeWindow)
        {
            this.AccessToken = AccessToken;
            this.crs = crs;
            this.filterList = filterList;
            this.timeOffset = timeOffset;
            this.timeWindow = timeWindow;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetFastestDeparturesResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetFastestDeparturesResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public DeparturesBoard1 DeparturesBoard;

        public GetFastestDeparturesResponse()
        {
        }

        public GetFastestDeparturesResponse(DeparturesBoard1 DeparturesBoard)
        {
            this.DeparturesBoard = DeparturesBoard;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetFastestDeparturesWithDetailsRequest", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetFastestDeparturesWithDetailsRequest
    {

        [System.ServiceModel.MessageHeader(Namespace = "http://thalesgroup.com/RTTI/2013-11-28/Token/types")]
        public AccessToken AccessToken;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public string crs;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 1)]
        [System.Xml.Serialization.XmlArrayItem("crs", IsNullable = false)]
        public string[] filterList;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 2)]
        [System.ComponentModel.DefaultValue(0)]
        public int timeOffset;

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 3)]
        [System.ComponentModel.DefaultValue(120)]
        public int timeWindow;

        public GetFastestDeparturesWithDetailsRequest()
        {
        }

        public GetFastestDeparturesWithDetailsRequest(AccessToken AccessToken, string crs, string[] filterList, int timeOffset, int timeWindow)
        {
            this.AccessToken = AccessToken;
            this.crs = crs;
            this.filterList = filterList;
            this.timeOffset = timeOffset;
            this.timeWindow = timeWindow;
        }
    }



    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContract(WrapperName = "GetFastestDeparturesWithDetailsResponse", WrapperNamespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", IsWrapped = true)]
    public partial class GetFastestDeparturesWithDetailsResponse
    {

        [System.ServiceModel.MessageBodyMember(Namespace = "http://thalesgroup.com/RTTI/2017-10-01/ldb/", Order = 0)]
        public DeparturesBoardWithDetails1 DeparturesBoard;

        public GetFastestDeparturesWithDetailsResponse()
        {
        }

        public GetFastestDeparturesWithDetailsResponse(DeparturesBoardWithDetails1 DeparturesBoard)
        {
            this.DeparturesBoard = DeparturesBoard;
        }
    }
}
