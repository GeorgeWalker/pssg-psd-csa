// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Pssg.Css.Interfaces.DynamicsAutorest.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.columnmapping
    /// </summary>
    public partial class MicrosoftDynamicsCRMcolumnmapping
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcolumnmapping
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcolumnmapping()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcolumnmapping
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcolumnmapping(int? processcode = default(int?), string _modifiedbyValue = default(string), int? statuscode = default(int?), string sourceattributename = default(string), string solutionid = default(string), string introducedversion = default(string), int? componentstate = default(int?), string _createdbyValue = default(string), string _modifiedonbehalfbyValue = default(string), System.DateTimeOffset? overwritetime = default(System.DateTimeOffset?), int? statecode = default(int?), bool? ismanaged = default(bool?), string columnmappingidunique = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string columnmappingid = default(string), string _importmapidValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string targetattributename = default(string), string _createdonbehalfbyValue = default(string), string sourceentityname = default(string), string targetentityname = default(string), IList<MicrosoftDynamicsCRMpicklistmapping> pickListMappingColumnMapping = default(IList<MicrosoftDynamicsCRMpicklistmapping>), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMimportmap importmapid = default(MicrosoftDynamicsCRMimportmap), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMlookupmapping> lookUpMappingColumnMapping = default(IList<MicrosoftDynamicsCRMlookupmapping>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser))
        {
            Processcode = processcode;
            this._modifiedbyValue = _modifiedbyValue;
            Statuscode = statuscode;
            Sourceattributename = sourceattributename;
            Solutionid = solutionid;
            Introducedversion = introducedversion;
            Componentstate = componentstate;
            this._createdbyValue = _createdbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Overwritetime = overwritetime;
            Statecode = statecode;
            Ismanaged = ismanaged;
            Columnmappingidunique = columnmappingidunique;
            Createdon = createdon;
            Columnmappingid = columnmappingid;
            this._importmapidValue = _importmapidValue;
            Modifiedon = modifiedon;
            Targetattributename = targetattributename;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Sourceentityname = sourceentityname;
            Targetentityname = targetentityname;
            PickListMappingColumnMapping = pickListMappingColumnMapping;
            Modifiedby = modifiedby;
            Importmapid = importmapid;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            LookUpMappingColumnMapping = lookUpMappingColumnMapping;
            Modifiedonbehalfby = modifiedonbehalfby;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processcode")]
        public int? Processcode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceattributename")]
        public string Sourceattributename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutionid")]
        public string Solutionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "introducedversion")]
        public string Introducedversion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "componentstate")]
        public int? Componentstate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overwritetime")]
        public System.DateTimeOffset? Overwritetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ismanaged")]
        public bool? Ismanaged { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columnmappingidunique")]
        public string Columnmappingidunique { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "columnmappingid")]
        public string Columnmappingid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_importmapid_value")]
        public string _importmapidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetattributename")]
        public string Targetattributename { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sourceentityname")]
        public string Sourceentityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "targetentityname")]
        public string Targetentityname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PickListMapping_ColumnMapping")]
        public IList<MicrosoftDynamicsCRMpicklistmapping> PickListMappingColumnMapping { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importmapid")]
        public MicrosoftDynamicsCRMimportmap Importmapid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "LookUpMapping_ColumnMapping")]
        public IList<MicrosoftDynamicsCRMlookupmapping> LookUpMappingColumnMapping { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

    }
}