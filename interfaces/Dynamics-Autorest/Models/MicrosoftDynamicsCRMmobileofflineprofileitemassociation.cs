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
    /// Microsoft.Dynamics.CRM.mobileofflineprofileitemassociation
    /// </summary>
    public partial class MicrosoftDynamicsCRMmobileofflineprofileitemassociation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmobileofflineprofileitemassociation class.
        /// </summary>
        public MicrosoftDynamicsCRMmobileofflineprofileitemassociation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmobileofflineprofileitemassociation class.
        /// </summary>
        public MicrosoftDynamicsCRMmobileofflineprofileitemassociation(int? componentstate = default(int?), string _modifiedbyValue = default(string), string processid = default(string), string _createdbyValue = default(string), string solutionid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string introducedversion = default(string), string mobileofflineprofileitemassociationidunique = default(string), string name = default(string), string stageid = default(string), string relationshipdisplayname = default(string), string relationshipname = default(string), string traversedpath = default(string), string relationshipdata = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), string _modifiedonbehalfbyValue = default(string), bool? isvalidated = default(bool?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _mobileofflineprofileitemidValue = default(string), string versionnumber = default(string), string relationshipid = default(string), string _organizationidValue = default(string), string mobileofflineprofileitemassociationid = default(string), string profileitemassociationentityfilter = default(string), bool? ismanaged = default(bool?), System.DateTimeOffset? publishedon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), int? selectedrelationshipsschema = default(int?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), MicrosoftDynamicsCRMmobileofflineprofileitem regardingobjectid = default(MicrosoftDynamicsCRMmobileofflineprofileitem), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Componentstate = componentstate;
            this._modifiedbyValue = _modifiedbyValue;
            Processid = processid;
            this._createdbyValue = _createdbyValue;
            Solutionid = solutionid;
            Createdon = createdon;
            Introducedversion = introducedversion;
            Mobileofflineprofileitemassociationidunique = mobileofflineprofileitemassociationidunique;
            Name = name;
            Stageid = stageid;
            Relationshipdisplayname = relationshipdisplayname;
            Relationshipname = relationshipname;
            Traversedpath = traversedpath;
            Relationshipdata = relationshipdata;
            Overwritetime = overwritetime;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Isvalidated = isvalidated;
            Modifiedon = modifiedon;
            this._mobileofflineprofileitemidValue = _mobileofflineprofileitemidValue;
            Versionnumber = versionnumber;
            Relationshipid = relationshipid;
            this._organizationidValue = _organizationidValue;
            Mobileofflineprofileitemassociationid = mobileofflineprofileitemassociationid;
            Profileitemassociationentityfilter = profileitemassociationentityfilter;
            Ismanaged = ismanaged;
            Publishedon = publishedon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Selectedrelationshipsschema = selectedrelationshipsschema;
            Modifiedonbehalfby = modifiedonbehalfby;
            Modifiedby = modifiedby;
            Organizationid = organizationid;
            Regardingobjectid = regardingobjectid;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mobileofflineprofileitemassociationidunique")]
        public string Mobileofflineprofileitemassociationidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relationshipdisplayname")]
        public string Relationshipdisplayname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relationshipname")]
        public string Relationshipname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relationshipdata")]
        public string Relationshipdata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isvalidated")]
        public bool? Isvalidated { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_mobileofflineprofileitemid_value")]
        public string _mobileofflineprofileitemidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "relationshipid")]
        public string Relationshipid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mobileofflineprofileitemassociationid")]
        public string Mobileofflineprofileitemassociationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "profileitemassociationentityfilter")]
        public string Profileitemassociationentityfilter { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "publishedon")]
        public System.DateTimeOffset? Publishedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "selectedrelationshipsschema")]
        public int? Selectedrelationshipsschema { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid")]
        public MicrosoftDynamicsCRMmobileofflineprofileitem Regardingobjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

    }
}
