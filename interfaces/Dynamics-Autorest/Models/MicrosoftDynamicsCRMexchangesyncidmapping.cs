// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Pssg.Css.Interfaces.DynamicsAutorest.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.exchangesyncidmapping
    /// </summary>
    public partial class MicrosoftDynamicsCRMexchangesyncidmapping
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMexchangesyncidmapping class.
        /// </summary>
        public MicrosoftDynamicsCRMexchangesyncidmapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMexchangesyncidmapping class.
        /// </summary>
        public MicrosoftDynamicsCRMexchangesyncidmapping(int? objecttypecode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), System.DateTimeOffset? lastsyncerroroccurredon = default(System.DateTimeOffset?), string objectid = default(string), string _owninguserValue = default(string), int? retries = default(int?), string itemsubject = default(string), bool? isdeletedinexchange = default(bool?), string versionnumber = default(string), int? fromcrmchangetype = default(int?), string _owningbusinessunitValue = default(string), int? tocrmchangetype = default(int?), string _owneridValue = default(string), string _owningteamValue = default(string), string exchangesyncidmappingid = default(string), bool? isunlinkedincrm = default(bool?), int? lastsyncerrorcode = default(int?), int? userdecision = default(int?), string exchangeentryid = default(string), string lastsyncerror = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit))
        {
            Objecttypecode = objecttypecode;
            Modifiedon = modifiedon;
            Lastsyncerroroccurredon = lastsyncerroroccurredon;
            Objectid = objectid;
            this._owninguserValue = _owninguserValue;
            Retries = retries;
            Itemsubject = itemsubject;
            Isdeletedinexchange = isdeletedinexchange;
            Versionnumber = versionnumber;
            Fromcrmchangetype = fromcrmchangetype;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Tocrmchangetype = tocrmchangetype;
            this._owneridValue = _owneridValue;
            this._owningteamValue = _owningteamValue;
            Exchangesyncidmappingid = exchangesyncidmappingid;
            Isunlinkedincrm = isunlinkedincrm;
            Lastsyncerrorcode = lastsyncerrorcode;
            Userdecision = userdecision;
            Exchangeentryid = exchangeentryid;
            Lastsyncerror = lastsyncerror;
            Createdon = createdon;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objecttypecode")]
        public int? Objecttypecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerroroccurredon")]
        public System.DateTimeOffset? Lastsyncerroroccurredon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "objectid")]
        public string Objectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "retries")]
        public int? Retries { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "itemsubject")]
        public string Itemsubject { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isdeletedinexchange")]
        public bool? Isdeletedinexchange { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fromcrmchangetype")]
        public int? Fromcrmchangetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tocrmchangetype")]
        public int? Tocrmchangetype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangesyncidmappingid")]
        public string Exchangesyncidmappingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isunlinkedincrm")]
        public bool? Isunlinkedincrm { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerrorcode")]
        public int? Lastsyncerrorcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "userdecision")]
        public int? Userdecision { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangeentryid")]
        public string Exchangeentryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastsyncerror")]
        public string Lastsyncerror { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

    }
}
