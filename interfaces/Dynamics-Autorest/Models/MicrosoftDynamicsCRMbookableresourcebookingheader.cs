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
    /// Microsoft.Dynamics.CRM.bookableresourcebookingheader
    /// </summary>
    public partial class MicrosoftDynamicsCRMbookableresourcebookingheader
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresourcebookingheader class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresourcebookingheader()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMbookableresourcebookingheader class.
        /// </summary>
        public MicrosoftDynamicsCRMbookableresourcebookingheader(string versionnumber = default(string), string stageid = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string name = default(string), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), int? importsequencenumber = default(int?), string _owningteamValue = default(string), System.DateTimeOffset? endtime = default(System.DateTimeOffset?), string _transactioncurrencyidValue = default(string), string processid = default(string), System.DateTimeOffset? starttime = default(System.DateTimeOffset?), string _owneridValue = default(string), decimal? exchangerate = default(decimal?), string _owningbusinessunitValue = default(string), int? timezoneruleversionnumber = default(int?), int? duration = default(int?), int? statecode = default(int?), int? utcconversiontimezonecode = default(int?), int? statuscode = default(int?), string _owninguserValue = default(string), string traversedpath = default(string), string _createdbyValue = default(string), string bookableresourcebookingheaderid = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMactivitypointer> bookableresourcebookingheaderActivityPointers = default(IList<MicrosoftDynamicsCRMactivitypointer>), IList<MicrosoftDynamicsCRMsyncerror> bookableResourceBookingHeaderSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourcebookingheaderDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> bookableresourcebookingheaderDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> bookableresourcebookingheaderAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> bookableresourcebookingheaderMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> bookableresourcebookingheaderProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> bookableresourcebookingheaderBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> bookableresourcebookingheaderPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), IList<MicrosoftDynamicsCRMappointment> bookableresourcebookingheaderAppointments = default(IList<MicrosoftDynamicsCRMappointment>), IList<MicrosoftDynamicsCRMemail> bookableresourcebookingheaderEmails = default(IList<MicrosoftDynamicsCRMemail>), IList<MicrosoftDynamicsCRMfax> bookableresourcebookingheaderFaxes = default(IList<MicrosoftDynamicsCRMfax>), IList<MicrosoftDynamicsCRMletter> bookableresourcebookingheaderLetters = default(IList<MicrosoftDynamicsCRMletter>), IList<MicrosoftDynamicsCRMphonecall> bookableresourcebookingheaderPhoneCalls = default(IList<MicrosoftDynamicsCRMphonecall>), IList<MicrosoftDynamicsCRMtask> bookableresourcebookingheaderTasks = default(IList<MicrosoftDynamicsCRMtask>), IList<MicrosoftDynamicsCRMrecurringappointmentmaster> bookableresourcebookingheaderRecurringAppointmentMasters = default(IList<MicrosoftDynamicsCRMrecurringappointmentmaster>), IList<MicrosoftDynamicsCRMsocialactivity> bookableresourcebookingheaderSocialActivities = default(IList<MicrosoftDynamicsCRMsocialactivity>), IList<MicrosoftDynamicsCRMannotation> bookableresourcebookingheaderAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMbookableresourcebooking> bookableresourcebookingheaderBookableresourcebookingHeader = default(IList<MicrosoftDynamicsCRMbookableresourcebooking>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMbulkoperation> bookableresourcebookingheaderBulkOperations = default(IList<MicrosoftDynamicsCRMbulkoperation>), IList<MicrosoftDynamicsCRMcampaignactivity> bookableresourcebookingheaderCampaignActivities = default(IList<MicrosoftDynamicsCRMcampaignactivity>), IList<MicrosoftDynamicsCRMcampaignresponse> bookableresourcebookingheaderCampaignResponses = default(IList<MicrosoftDynamicsCRMcampaignresponse>), IList<MicrosoftDynamicsCRMincidentresolution> bookableresourcebookingheaderIncidentResolutions = default(IList<MicrosoftDynamicsCRMincidentresolution>), IList<MicrosoftDynamicsCRMserviceappointment> bookableresourcebookingheaderServiceAppointments = default(IList<MicrosoftDynamicsCRMserviceappointment>), IList<MicrosoftDynamicsCRMopportunityclose> bookableresourcebookingheaderOpportunityCloses = default(IList<MicrosoftDynamicsCRMopportunityclose>), IList<MicrosoftDynamicsCRMorderclose> bookableresourcebookingheaderOrderCloses = default(IList<MicrosoftDynamicsCRMorderclose>), IList<MicrosoftDynamicsCRMquoteclose> bookableresourcebookingheaderQuoteCloses = default(IList<MicrosoftDynamicsCRMquoteclose>), IList<MicrosoftDynamicsCRMcsuCasetask> bookableresourcebookingheaderCsuCasetasks = default(IList<MicrosoftDynamicsCRMcsuCasetask>))
        {
            Versionnumber = versionnumber;
            Stageid = stageid;
            Overriddencreatedon = overriddencreatedon;
            Createdon = createdon;
            Name = name;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Importsequencenumber = importsequencenumber;
            this._owningteamValue = _owningteamValue;
            Endtime = endtime;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            Processid = processid;
            Starttime = starttime;
            this._owneridValue = _owneridValue;
            Exchangerate = exchangerate;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Duration = duration;
            Statecode = statecode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Statuscode = statuscode;
            this._owninguserValue = _owninguserValue;
            Traversedpath = traversedpath;
            this._createdbyValue = _createdbyValue;
            Bookableresourcebookingheaderid = bookableresourcebookingheaderid;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            BookableresourcebookingheaderActivityPointers = bookableresourcebookingheaderActivityPointers;
            BookableResourceBookingHeaderSyncErrors = bookableResourceBookingHeaderSyncErrors;
            BookableresourcebookingheaderDuplicateMatchingRecord = bookableresourcebookingheaderDuplicateMatchingRecord;
            BookableresourcebookingheaderDuplicateBaseRecord = bookableresourcebookingheaderDuplicateBaseRecord;
            BookableresourcebookingheaderAsyncOperations = bookableresourcebookingheaderAsyncOperations;
            BookableresourcebookingheaderMailboxTrackingFolders = bookableresourcebookingheaderMailboxTrackingFolders;
            BookableresourcebookingheaderProcessSession = bookableresourcebookingheaderProcessSession;
            BookableresourcebookingheaderBulkDeleteFailures = bookableresourcebookingheaderBulkDeleteFailures;
            BookableresourcebookingheaderPrincipalObjectAttributeAccesses = bookableresourcebookingheaderPrincipalObjectAttributeAccesses;
            BookableresourcebookingheaderAppointments = bookableresourcebookingheaderAppointments;
            BookableresourcebookingheaderEmails = bookableresourcebookingheaderEmails;
            BookableresourcebookingheaderFaxes = bookableresourcebookingheaderFaxes;
            BookableresourcebookingheaderLetters = bookableresourcebookingheaderLetters;
            BookableresourcebookingheaderPhoneCalls = bookableresourcebookingheaderPhoneCalls;
            BookableresourcebookingheaderTasks = bookableresourcebookingheaderTasks;
            BookableresourcebookingheaderRecurringAppointmentMasters = bookableresourcebookingheaderRecurringAppointmentMasters;
            BookableresourcebookingheaderSocialActivities = bookableresourcebookingheaderSocialActivities;
            BookableresourcebookingheaderAnnotations = bookableresourcebookingheaderAnnotations;
            BookableresourcebookingheaderBookableresourcebookingHeader = bookableresourcebookingheaderBookableresourcebookingHeader;
            Transactioncurrencyid = transactioncurrencyid;
            BookableresourcebookingheaderBulkOperations = bookableresourcebookingheaderBulkOperations;
            BookableresourcebookingheaderCampaignActivities = bookableresourcebookingheaderCampaignActivities;
            BookableresourcebookingheaderCampaignResponses = bookableresourcebookingheaderCampaignResponses;
            BookableresourcebookingheaderIncidentResolutions = bookableresourcebookingheaderIncidentResolutions;
            BookableresourcebookingheaderServiceAppointments = bookableresourcebookingheaderServiceAppointments;
            BookableresourcebookingheaderOpportunityCloses = bookableresourcebookingheaderOpportunityCloses;
            BookableresourcebookingheaderOrderCloses = bookableresourcebookingheaderOrderCloses;
            BookableresourcebookingheaderQuoteCloses = bookableresourcebookingheaderQuoteCloses;
            BookableresourcebookingheaderCsuCasetasks = bookableresourcebookingheaderCsuCasetasks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid")]
        public string Stageid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endtime")]
        public System.DateTimeOffset? Endtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "processid")]
        public string Processid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "starttime")]
        public System.DateTimeOffset? Starttime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traversedpath")]
        public string Traversedpath { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheaderid")]
        public string Bookableresourcebookingheaderid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

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

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_ActivityPointers")]
        public IList<MicrosoftDynamicsCRMactivitypointer> BookableresourcebookingheaderActivityPointers { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "BookableResourceBookingHeader_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> BookableResourceBookingHeaderSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourcebookingheaderDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> BookableresourcebookingheaderDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> BookableresourcebookingheaderAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> BookableresourcebookingheaderMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> BookableresourcebookingheaderProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> BookableresourcebookingheaderBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> BookableresourcebookingheaderPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_Appointments")]
        public IList<MicrosoftDynamicsCRMappointment> BookableresourcebookingheaderAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_Emails")]
        public IList<MicrosoftDynamicsCRMemail> BookableresourcebookingheaderEmails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_Faxes")]
        public IList<MicrosoftDynamicsCRMfax> BookableresourcebookingheaderFaxes { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_Letters")]
        public IList<MicrosoftDynamicsCRMletter> BookableresourcebookingheaderLetters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_PhoneCalls")]
        public IList<MicrosoftDynamicsCRMphonecall> BookableresourcebookingheaderPhoneCalls { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_Tasks")]
        public IList<MicrosoftDynamicsCRMtask> BookableresourcebookingheaderTasks { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_RecurringAppointmentMasters")]
        public IList<MicrosoftDynamicsCRMrecurringappointmentmaster> BookableresourcebookingheaderRecurringAppointmentMasters { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_SocialActivities")]
        public IList<MicrosoftDynamicsCRMsocialactivity> BookableresourcebookingheaderSocialActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> BookableresourcebookingheaderAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_bookableresourcebooking_Header")]
        public IList<MicrosoftDynamicsCRMbookableresourcebooking> BookableresourcebookingheaderBookableresourcebookingHeader { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_BulkOperations")]
        public IList<MicrosoftDynamicsCRMbulkoperation> BookableresourcebookingheaderBulkOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_CampaignActivities")]
        public IList<MicrosoftDynamicsCRMcampaignactivity> BookableresourcebookingheaderCampaignActivities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_CampaignResponses")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> BookableresourcebookingheaderCampaignResponses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_IncidentResolutions")]
        public IList<MicrosoftDynamicsCRMincidentresolution> BookableresourcebookingheaderIncidentResolutions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_ServiceAppointments")]
        public IList<MicrosoftDynamicsCRMserviceappointment> BookableresourcebookingheaderServiceAppointments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_OpportunityCloses")]
        public IList<MicrosoftDynamicsCRMopportunityclose> BookableresourcebookingheaderOpportunityCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_OrderCloses")]
        public IList<MicrosoftDynamicsCRMorderclose> BookableresourcebookingheaderOrderCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_QuoteCloses")]
        public IList<MicrosoftDynamicsCRMquoteclose> BookableresourcebookingheaderQuoteCloses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bookableresourcebookingheader_csu_casetasks")]
        public IList<MicrosoftDynamicsCRMcsuCasetask> BookableresourcebookingheaderCsuCasetasks { get; set; }

    }
}
