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
    /// Microsoft.Dynamics.CRM.recurringappointmentmaster
    /// </summary>
    public partial class MicrosoftDynamicsCRMrecurringappointmentmaster
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMrecurringappointmentmaster class.
        /// </summary>
        public MicrosoftDynamicsCRMrecurringappointmentmaster()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMrecurringappointmentmaster class.
        /// </summary>
        public MicrosoftDynamicsCRMrecurringappointmentmaster(int? dayofmonth = default(int?), int? patternendtype = default(int?), int? outlookownerapptid = default(int?), bool? isalldayevent = default(bool?), System.DateTimeOffset? lastexpandedinstancedate = default(System.DateTimeOffset?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string location = default(string), System.DateTimeOffset? effectivestartdate = default(System.DateTimeOffset?), string _ruleidValue = default(string), string category = default(string), System.DateTimeOffset? patternstartdate = default(System.DateTimeOffset?), System.DateTimeOffset? nextexpansioninstancedate = default(System.DateTimeOffset?), System.DateTimeOffset? starttime = default(System.DateTimeOffset?), string subcategory = default(string), System.DateTimeOffset? effectiveenddate = default(System.DateTimeOffset?), bool? isnthmonthly = default(bool?), bool? seriesstatus = default(bool?), bool? isregenerate = default(bool?), System.DateTimeOffset? patternenddate = default(System.DateTimeOffset?), int? monthofyear = default(int?), int? duration = default(int?), string _groupidValue = default(string), bool? isnthyearly = default(bool?), string globalobjectid = default(string), int? importsequencenumber = default(int?), int? daysofweekmask = default(int?), string deletedexceptionslist = default(string), int? isunsafe = default(int?), int? recurrencepatterntype = default(int?), System.DateTimeOffset? endtime = default(System.DateTimeOffset?), int? occurrences = default(int?), int? firstdayofweek = default(int?), int? interval = default(int?), string subscriptionid = default(string), bool? isweekdaypattern = default(bool?), int? expansionstatecode = default(int?), int? instance = default(int?), IList<MicrosoftDynamicsCRMpostregarding> recurringappointmentmasterPostRegardings = default(IList<MicrosoftDynamicsCRMpostregarding>), IList<MicrosoftDynamicsCRMpostfollow> recurringappointmentmasterPostFollows = default(IList<MicrosoftDynamicsCRMpostfollow>), MicrosoftDynamicsCRMknowledgebaserecord regardingobjectidKnowledgebaserecordRecurringappointmentmaster = default(MicrosoftDynamicsCRMknowledgebaserecord), MicrosoftDynamicsCRMlead regardingobjectidLeadRecurringappointmentmaster = default(MicrosoftDynamicsCRMlead), MicrosoftDynamicsCRMbookableresourcebooking regardingobjectidBookableresourcebookingRecurringappointmentmaster = default(MicrosoftDynamicsCRMbookableresourcebooking), MicrosoftDynamicsCRMbookableresourcebookingheader regardingobjectidBookableresourcebookingheaderRecurringappointmentmaster = default(MicrosoftDynamicsCRMbookableresourcebookingheader), MicrosoftDynamicsCRMbulkoperation regardingobjectidBulkoperationRecurringappointmentmaster = default(MicrosoftDynamicsCRMbulkoperation), MicrosoftDynamicsCRMcampaign regardingobjectidCampaignRecurringappointmentmaster = default(MicrosoftDynamicsCRMcampaign), MicrosoftDynamicsCRMcampaignactivity regardingobjectidCampaignactivityRecurringappointmentmaster = default(MicrosoftDynamicsCRMcampaignactivity), IList<MicrosoftDynamicsCRMcampaignresponse> recurringappointmentmasterCampaignresponse = default(IList<MicrosoftDynamicsCRMcampaignresponse>), MicrosoftDynamicsCRMcontract regardingobjectidContractRecurringappointmentmaster = default(MicrosoftDynamicsCRMcontract), MicrosoftDynamicsCRMentitlement regardingobjectidEntitlementRecurringappointmentmaster = default(MicrosoftDynamicsCRMentitlement), MicrosoftDynamicsCRMentitlementtemplate regardingobjectidEntitlementtemplateRecurringappointmentmaster = default(MicrosoftDynamicsCRMentitlementtemplate), MicrosoftDynamicsCRMincident regardingobjectidIncidentRecurringappointmentmaster = default(MicrosoftDynamicsCRMincident), MicrosoftDynamicsCRMsite regardingobjectidSiteRecurringappointmentmaster = default(MicrosoftDynamicsCRMsite), MicrosoftDynamicsCRMservice serviceidRecurringappointmentmaster = default(MicrosoftDynamicsCRMservice), MicrosoftDynamicsCRMinvoice regardingobjectidInvoiceRecurringappointmentmaster = default(MicrosoftDynamicsCRMinvoice), MicrosoftDynamicsCRMopportunity regardingobjectidOpportunityRecurringappointmentmaster = default(MicrosoftDynamicsCRMopportunity), MicrosoftDynamicsCRMquote regardingobjectidQuoteRecurringappointmentmaster = default(MicrosoftDynamicsCRMquote), MicrosoftDynamicsCRMsalesorder regardingobjectidSalesorderRecurringappointmentmaster = default(MicrosoftDynamicsCRMsalesorder), MicrosoftDynamicsCRMmsdynPostalbum regardingobjectidMsdynPostalbumRecurringappointmentmaster = default(MicrosoftDynamicsCRMmsdynPostalbum), MicrosoftDynamicsCRMcsuComplaints regardingobjectidCsuComplaintsRecurringappointmentmaster = default(MicrosoftDynamicsCRMcsuComplaints), MicrosoftDynamicsCRMcsuSubjectofcomplaint regardingobjectidCsuSubjectofcomplaintRecurringappointmentmaster = default(MicrosoftDynamicsCRMcsuSubjectofcomplaint), MicrosoftDynamicsCRMcsuVehicledetail regardingobjectidCsuVehicledetailRecurringappointmentmaster = default(MicrosoftDynamicsCRMcsuVehicledetail), IList<MicrosoftDynamicsCRMbulkdeletefailure> recurringAppointmentMasterBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMasyncoperation> recurringAppointmentMasterAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMduplicaterecord> recurringAppointmentMasterDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMsystemuser owninguserRecurringappointmentmaster = default(MicrosoftDynamicsCRMsystemuser), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> recurringappointmentmasterPrincipalobjectattributeaccess = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMteam owningteamRecurringappointmentmaster = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMactivitypointer activityidActivitypointer = default(MicrosoftDynamicsCRMactivitypointer), IList<MicrosoftDynamicsCRMactivityparty> recurringappointmentmasterActivityParties = default(IList<MicrosoftDynamicsCRMactivityparty>), IList<MicrosoftDynamicsCRMduplicaterecord> recurringAppointmentMasterDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), MicrosoftDynamicsCRMbusinessunit owningbusinessunitRecurringappointmentmaster = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMsystemuser createdonbehalfbyRecurringappointmentmaster = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdbyRecurringappointmentmaster = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMknowledgearticle regardingobjectidKnowledgearticleRecurringappointmentmaster = default(MicrosoftDynamicsCRMknowledgearticle), IList<MicrosoftDynamicsCRMappointment> recurringappointmentmasterAppointment = default(IList<MicrosoftDynamicsCRMappointment>), MicrosoftDynamicsCRMaccount regardingobjectidAccountRecurringappointmentmaster = default(MicrosoftDynamicsCRMaccount), IList<MicrosoftDynamicsCRMqueueitem> recurringAppointmentMasterQueueItem = default(IList<MicrosoftDynamicsCRMqueueitem>), IList<MicrosoftDynamicsCRMconnection> recurringappointmentmasterConnections1 = default(IList<MicrosoftDynamicsCRMconnection>), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyRecurringappointmentmaster = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyidRecurringappointmentmaster = default(MicrosoftDynamicsCRMtransactioncurrency), IList<MicrosoftDynamicsCRMconnection> recurringappointmentmasterConnections2 = default(IList<MicrosoftDynamicsCRMconnection>), IList<MicrosoftDynamicsCRMsyncerror> recurringAppointmentMasterSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), MicrosoftDynamicsCRMprocessstage stageidProcessstage = default(MicrosoftDynamicsCRMprocessstage), IList<MicrosoftDynamicsCRMactioncard> recurringappointmentmasterActioncard = default(IList<MicrosoftDynamicsCRMactioncard>), MicrosoftDynamicsCRMcontact regardingobjectidContactRecurringappointmentmaster = default(MicrosoftDynamicsCRMcontact), MicrosoftDynamicsCRMsystemuser modifiedbyRecurringappointmentmaster = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMrecurrencerule activityidRecurrencerule = default(MicrosoftDynamicsCRMrecurrencerule), IList<MicrosoftDynamicsCRMprocesssession> recurringAppointmentMasterProcessSessions = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMannotation> recurringAppointmentMasterAnnotation = default(IList<MicrosoftDynamicsCRMannotation>))
        {
            Dayofmonth = dayofmonth;
            Patternendtype = patternendtype;
            Outlookownerapptid = outlookownerapptid;
            Isalldayevent = isalldayevent;
            Lastexpandedinstancedate = lastexpandedinstancedate;
            Overriddencreatedon = overriddencreatedon;
            Location = location;
            Effectivestartdate = effectivestartdate;
            this._ruleidValue = _ruleidValue;
            Category = category;
            Patternstartdate = patternstartdate;
            Nextexpansioninstancedate = nextexpansioninstancedate;
            Starttime = starttime;
            Subcategory = subcategory;
            Effectiveenddate = effectiveenddate;
            Isnthmonthly = isnthmonthly;
            Seriesstatus = seriesstatus;
            Isregenerate = isregenerate;
            Patternenddate = patternenddate;
            Monthofyear = monthofyear;
            Duration = duration;
            this._groupidValue = _groupidValue;
            Isnthyearly = isnthyearly;
            Globalobjectid = globalobjectid;
            Importsequencenumber = importsequencenumber;
            Daysofweekmask = daysofweekmask;
            Deletedexceptionslist = deletedexceptionslist;
            Isunsafe = isunsafe;
            Recurrencepatterntype = recurrencepatterntype;
            Endtime = endtime;
            Occurrences = occurrences;
            Firstdayofweek = firstdayofweek;
            Interval = interval;
            Subscriptionid = subscriptionid;
            Isweekdaypattern = isweekdaypattern;
            Expansionstatecode = expansionstatecode;
            Instance = instance;
            RecurringappointmentmasterPostRegardings = recurringappointmentmasterPostRegardings;
            RecurringappointmentmasterPostFollows = recurringappointmentmasterPostFollows;
            RegardingobjectidKnowledgebaserecordRecurringappointmentmaster = regardingobjectidKnowledgebaserecordRecurringappointmentmaster;
            RegardingobjectidLeadRecurringappointmentmaster = regardingobjectidLeadRecurringappointmentmaster;
            RegardingobjectidBookableresourcebookingRecurringappointmentmaster = regardingobjectidBookableresourcebookingRecurringappointmentmaster;
            RegardingobjectidBookableresourcebookingheaderRecurringappointmentmaster = regardingobjectidBookableresourcebookingheaderRecurringappointmentmaster;
            RegardingobjectidBulkoperationRecurringappointmentmaster = regardingobjectidBulkoperationRecurringappointmentmaster;
            RegardingobjectidCampaignRecurringappointmentmaster = regardingobjectidCampaignRecurringappointmentmaster;
            RegardingobjectidCampaignactivityRecurringappointmentmaster = regardingobjectidCampaignactivityRecurringappointmentmaster;
            RecurringappointmentmasterCampaignresponse = recurringappointmentmasterCampaignresponse;
            RegardingobjectidContractRecurringappointmentmaster = regardingobjectidContractRecurringappointmentmaster;
            RegardingobjectidEntitlementRecurringappointmentmaster = regardingobjectidEntitlementRecurringappointmentmaster;
            RegardingobjectidEntitlementtemplateRecurringappointmentmaster = regardingobjectidEntitlementtemplateRecurringappointmentmaster;
            RegardingobjectidIncidentRecurringappointmentmaster = regardingobjectidIncidentRecurringappointmentmaster;
            RegardingobjectidSiteRecurringappointmentmaster = regardingobjectidSiteRecurringappointmentmaster;
            ServiceidRecurringappointmentmaster = serviceidRecurringappointmentmaster;
            RegardingobjectidInvoiceRecurringappointmentmaster = regardingobjectidInvoiceRecurringappointmentmaster;
            RegardingobjectidOpportunityRecurringappointmentmaster = regardingobjectidOpportunityRecurringappointmentmaster;
            RegardingobjectidQuoteRecurringappointmentmaster = regardingobjectidQuoteRecurringappointmentmaster;
            RegardingobjectidSalesorderRecurringappointmentmaster = regardingobjectidSalesorderRecurringappointmentmaster;
            RegardingobjectidMsdynPostalbumRecurringappointmentmaster = regardingobjectidMsdynPostalbumRecurringappointmentmaster;
            RegardingobjectidCsuComplaintsRecurringappointmentmaster = regardingobjectidCsuComplaintsRecurringappointmentmaster;
            RegardingobjectidCsuSubjectofcomplaintRecurringappointmentmaster = regardingobjectidCsuSubjectofcomplaintRecurringappointmentmaster;
            RegardingobjectidCsuVehicledetailRecurringappointmentmaster = regardingobjectidCsuVehicledetailRecurringappointmentmaster;
            RecurringAppointmentMasterBulkDeleteFailures = recurringAppointmentMasterBulkDeleteFailures;
            RecurringAppointmentMasterAsyncOperations = recurringAppointmentMasterAsyncOperations;
            RecurringAppointmentMasterDuplicateBaseRecord = recurringAppointmentMasterDuplicateBaseRecord;
            OwninguserRecurringappointmentmaster = owninguserRecurringappointmentmaster;
            RecurringappointmentmasterPrincipalobjectattributeaccess = recurringappointmentmasterPrincipalobjectattributeaccess;
            OwningteamRecurringappointmentmaster = owningteamRecurringappointmentmaster;
            ActivityidActivitypointer = activityidActivitypointer;
            RecurringappointmentmasterActivityParties = recurringappointmentmasterActivityParties;
            RecurringAppointmentMasterDuplicateMatchingRecord = recurringAppointmentMasterDuplicateMatchingRecord;
            OwningbusinessunitRecurringappointmentmaster = owningbusinessunitRecurringappointmentmaster;
            CreatedonbehalfbyRecurringappointmentmaster = createdonbehalfbyRecurringappointmentmaster;
            CreatedbyRecurringappointmentmaster = createdbyRecurringappointmentmaster;
            RegardingobjectidKnowledgearticleRecurringappointmentmaster = regardingobjectidKnowledgearticleRecurringappointmentmaster;
            RecurringappointmentmasterAppointment = recurringappointmentmasterAppointment;
            RegardingobjectidAccountRecurringappointmentmaster = regardingobjectidAccountRecurringappointmentmaster;
            RecurringAppointmentMasterQueueItem = recurringAppointmentMasterQueueItem;
            RecurringappointmentmasterConnections1 = recurringappointmentmasterConnections1;
            ModifiedonbehalfbyRecurringappointmentmaster = modifiedonbehalfbyRecurringappointmentmaster;
            TransactioncurrencyidRecurringappointmentmaster = transactioncurrencyidRecurringappointmentmaster;
            RecurringappointmentmasterConnections2 = recurringappointmentmasterConnections2;
            RecurringAppointmentMasterSyncErrors = recurringAppointmentMasterSyncErrors;
            StageidProcessstage = stageidProcessstage;
            RecurringappointmentmasterActioncard = recurringappointmentmasterActioncard;
            RegardingobjectidContactRecurringappointmentmaster = regardingobjectidContactRecurringappointmentmaster;
            ModifiedbyRecurringappointmentmaster = modifiedbyRecurringappointmentmaster;
            ActivityidRecurrencerule = activityidRecurrencerule;
            RecurringAppointmentMasterProcessSessions = recurringAppointmentMasterProcessSessions;
            RecurringAppointmentMasterAnnotation = recurringAppointmentMasterAnnotation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "dayofmonth")]
        public int? Dayofmonth { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "patternendtype")]
        public int? Patternendtype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "outlookownerapptid")]
        public int? Outlookownerapptid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isalldayevent")]
        public bool? Isalldayevent { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastexpandedinstancedate")]
        public System.DateTimeOffset? Lastexpandedinstancedate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectivestartdate")]
        public System.DateTimeOffset? Effectivestartdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ruleid_value")]
        public string _ruleidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "category")]
        public string Category { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "patternstartdate")]
        public System.DateTimeOffset? Patternstartdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "nextexpansioninstancedate")]
        public System.DateTimeOffset? Nextexpansioninstancedate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "starttime")]
        public System.DateTimeOffset? Starttime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subcategory")]
        public string Subcategory { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "effectiveenddate")]
        public System.DateTimeOffset? Effectiveenddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isnthmonthly")]
        public bool? Isnthmonthly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "seriesstatus")]
        public bool? Seriesstatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isregenerate")]
        public bool? Isregenerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "patternenddate")]
        public System.DateTimeOffset? Patternenddate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "monthofyear")]
        public int? Monthofyear { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public int? Duration { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_groupid_value")]
        public string _groupidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isnthyearly")]
        public bool? Isnthyearly { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "globalobjectid")]
        public string Globalobjectid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "daysofweekmask")]
        public int? Daysofweekmask { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "deletedexceptionslist")]
        public string Deletedexceptionslist { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isunsafe")]
        public int? Isunsafe { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurrencepatterntype")]
        public int? Recurrencepatterntype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endtime")]
        public System.DateTimeOffset? Endtime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "occurrences")]
        public int? Occurrences { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "firstdayofweek")]
        public int? Firstdayofweek { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionid")]
        public string Subscriptionid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isweekdaypattern")]
        public bool? Isweekdaypattern { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "expansionstatecode")]
        public int? Expansionstatecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "instance")]
        public int? Instance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_PostRegardings")]
        public IList<MicrosoftDynamicsCRMpostregarding> RecurringappointmentmasterPostRegardings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_PostFollows")]
        public IList<MicrosoftDynamicsCRMpostfollow> RecurringappointmentmasterPostFollows { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgebaserecord_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMknowledgebaserecord RegardingobjectidKnowledgebaserecordRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_lead_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMlead RegardingobjectidLeadRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebooking_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMbookableresourcebooking RegardingobjectidBookableresourcebookingRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bookableresourcebookingheader_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMbookableresourcebookingheader RegardingobjectidBookableresourcebookingheaderRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_bulkoperation_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMbulkoperation RegardingobjectidBulkoperationRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaign_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMcampaign RegardingobjectidCampaignRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_campaignactivity_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMcampaignactivity RegardingobjectidCampaignactivityRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_campaignresponse")]
        public IList<MicrosoftDynamicsCRMcampaignresponse> RecurringappointmentmasterCampaignresponse { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contract_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMcontract RegardingobjectidContractRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlement_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMentitlement RegardingobjectidEntitlementRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_entitlementtemplate_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMentitlementtemplate RegardingobjectidEntitlementtemplateRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_incident_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMincident RegardingobjectidIncidentRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_site_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsite RegardingobjectidSiteRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "serviceid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMservice ServiceidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_invoice_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMinvoice RegardingobjectidInvoiceRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_opportunity_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMopportunity RegardingobjectidOpportunityRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_quote_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMquote RegardingobjectidQuoteRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_salesorder_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsalesorder RegardingobjectidSalesorderRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_msdyn_postalbum_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMmsdynPostalbum RegardingobjectidMsdynPostalbumRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_csu_complaints_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMcsuComplaints RegardingobjectidCsuComplaintsRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_csu_subjectofcomplaint_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMcsuSubjectofcomplaint RegardingobjectidCsuSubjectofcomplaintRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_csu_vehicledetail_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMcsuVehicledetail RegardingobjectidCsuVehicledetailRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> RecurringAppointmentMasterBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> RecurringAppointmentMasterAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> RecurringAppointmentMasterDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsystemuser OwninguserRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_principalobjectattributeaccess")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> RecurringappointmentmasterPrincipalobjectattributeaccess { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMteam OwningteamRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_activitypointer")]
        public MicrosoftDynamicsCRMactivitypointer ActivityidActivitypointer { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_activity_parties")]
        public IList<MicrosoftDynamicsCRMactivityparty> RecurringappointmentmasterActivityParties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> RecurringAppointmentMasterDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMbusinessunit OwningbusinessunitRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsystemuser CreatedonbehalfbyRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsystemuser CreatedbyRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_knowledgearticle_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMknowledgearticle RegardingobjectidKnowledgearticleRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_appointment")]
        public IList<MicrosoftDynamicsCRMappointment> RecurringappointmentmasterAppointment { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_account_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMaccount RegardingobjectidAccountRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_QueueItem")]
        public IList<MicrosoftDynamicsCRMqueueitem> RecurringAppointmentMasterQueueItem { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_connections1")]
        public IList<MicrosoftDynamicsCRMconnection> RecurringappointmentmasterConnections1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsystemuser ModifiedonbehalfbyRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMtransactioncurrency TransactioncurrencyidRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_connections2")]
        public IList<MicrosoftDynamicsCRMconnection> RecurringappointmentmasterConnections2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> RecurringAppointmentMasterSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "stageid_processstage")]
        public MicrosoftDynamicsCRMprocessstage StageidProcessstage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurringappointmentmaster_actioncard")]
        public IList<MicrosoftDynamicsCRMactioncard> RecurringappointmentmasterActioncard { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "regardingobjectid_contact_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMcontact RegardingobjectidContactRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby_recurringappointmentmaster")]
        public MicrosoftDynamicsCRMsystemuser ModifiedbyRecurringappointmentmaster { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "activityid_recurrencerule")]
        public MicrosoftDynamicsCRMrecurrencerule ActivityidRecurrencerule { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_ProcessSessions")]
        public IList<MicrosoftDynamicsCRMprocesssession> RecurringAppointmentMasterProcessSessions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "RecurringAppointmentMaster_Annotation")]
        public IList<MicrosoftDynamicsCRMannotation> RecurringAppointmentMasterAnnotation { get; set; }

    }
}
