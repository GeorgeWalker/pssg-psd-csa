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
    /// Microsoft.Dynamics.CRM.csu_payment
    /// </summary>
    public partial class MicrosoftDynamicsCRMcsuPayment
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcsuPayment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuPayment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftDynamicsCRMcsuPayment
        /// class.
        /// </summary>
        public MicrosoftDynamicsCRMcsuPayment(string csuTransactionnumber = default(string), int? csuPaymentmethod = default(int?), string _owningteamValue = default(string), string csuTransferdetails = default(string), string _createdbyValue = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), System.DateTimeOffset? csuPaymentdate = default(System.DateTimeOffset?), string csuName = default(string), decimal? exchangerate = default(decimal?), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), string _createdonbehalfbyValue = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string csuSendersinformation = default(string), string _owningbusinessunitValue = default(string), int? importsequencenumber = default(int?), string _owninguserValue = default(string), string csuPayableto = default(string), string csuPaymentid = default(string), string _modifiedbyValue = default(string), string _csuAmpValue = default(string), int? utcconversiontimezonecode = default(int?), int? csuReconsiderationfee = default(int?), int? timezoneruleversionnumber = default(int?), string _modifiedonbehalfbyValue = default(string), string versionnumber = default(string), string _csuAmporderValue = default(string), string csuChequenumber = default(string), string csuTransitnumber = default(string), string _owneridValue = default(string), string csuMoneyorderdetails = default(string), int? statecode = default(int?), string csuAccountnumber = default(string), string csuBank = default(string), int? csuRefund = default(int?), int? statuscode = default(int?), string _transactioncurrencyidValue = default(string), decimal? csuPaymentamount = default(decimal?), decimal? csuPaymentamountBase = default(decimal?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> csuPaymentSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> csuPaymentDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> csuPaymentDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> csuPaymentAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> csuPaymentMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> csuPaymentProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> csuPaymentBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> csuPaymentPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>), MicrosoftDynamicsCRMtransactioncurrency transactioncurrencyid = default(MicrosoftDynamicsCRMtransactioncurrency), MicrosoftDynamicsCRMcsuAmporder csuAMPOrder = default(MicrosoftDynamicsCRMcsuAmporder), MicrosoftDynamicsCRMcsuAmp csuAMP = default(MicrosoftDynamicsCRMcsuAmp))
        {
            CsuTransactionnumber = csuTransactionnumber;
            CsuPaymentmethod = csuPaymentmethod;
            this._owningteamValue = _owningteamValue;
            CsuTransferdetails = csuTransferdetails;
            this._createdbyValue = _createdbyValue;
            Overriddencreatedon = overriddencreatedon;
            CsuPaymentdate = csuPaymentdate;
            CsuName = csuName;
            Exchangerate = exchangerate;
            Createdon = createdon;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Modifiedon = modifiedon;
            CsuSendersinformation = csuSendersinformation;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            Importsequencenumber = importsequencenumber;
            this._owninguserValue = _owninguserValue;
            CsuPayableto = csuPayableto;
            CsuPaymentid = csuPaymentid;
            this._modifiedbyValue = _modifiedbyValue;
            this._csuAmpValue = _csuAmpValue;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            CsuReconsiderationfee = csuReconsiderationfee;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Versionnumber = versionnumber;
            this._csuAmporderValue = _csuAmporderValue;
            CsuChequenumber = csuChequenumber;
            CsuTransitnumber = csuTransitnumber;
            this._owneridValue = _owneridValue;
            CsuMoneyorderdetails = csuMoneyorderdetails;
            Statecode = statecode;
            CsuAccountnumber = csuAccountnumber;
            CsuBank = csuBank;
            CsuRefund = csuRefund;
            Statuscode = statuscode;
            this._transactioncurrencyidValue = _transactioncurrencyidValue;
            CsuPaymentamount = csuPaymentamount;
            CsuPaymentamountBase = csuPaymentamountBase;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            CsuPaymentSyncErrors = csuPaymentSyncErrors;
            CsuPaymentDuplicateMatchingRecord = csuPaymentDuplicateMatchingRecord;
            CsuPaymentDuplicateBaseRecord = csuPaymentDuplicateBaseRecord;
            CsuPaymentAsyncOperations = csuPaymentAsyncOperations;
            CsuPaymentMailboxTrackingFolders = csuPaymentMailboxTrackingFolders;
            CsuPaymentProcessSession = csuPaymentProcessSession;
            CsuPaymentBulkDeleteFailures = csuPaymentBulkDeleteFailures;
            CsuPaymentPrincipalObjectAttributeAccesses = csuPaymentPrincipalObjectAttributeAccesses;
            Transactioncurrencyid = transactioncurrencyid;
            CsuAMPOrder = csuAMPOrder;
            CsuAMP = csuAMP;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_transactionnumber")]
        public string CsuTransactionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_paymentmethod")]
        public int? CsuPaymentmethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_transferdetails")]
        public string CsuTransferdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_paymentdate")]
        public System.DateTimeOffset? CsuPaymentdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_name")]
        public string CsuName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "exchangerate")]
        public decimal? Exchangerate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

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
        [JsonProperty(PropertyName = "csu_sendersinformation")]
        public string CsuSendersinformation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_payableto")]
        public string CsuPayableto { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_paymentid")]
        public string CsuPaymentid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_amp_value")]
        public string _csuAmpValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_reconsiderationfee")]
        public int? CsuReconsiderationfee { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_csu_amporder_value")]
        public string _csuAmporderValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_chequenumber")]
        public string CsuChequenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_transitnumber")]
        public string CsuTransitnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_moneyorderdetails")]
        public string CsuMoneyorderdetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_accountnumber")]
        public string CsuAccountnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_bank")]
        public string CsuBank { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_refund")]
        public int? CsuRefund { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_transactioncurrencyid_value")]
        public string _transactioncurrencyidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_paymentamount")]
        public decimal? CsuPaymentamount { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_paymentamount_base")]
        public decimal? CsuPaymentamountBase { get; set; }

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
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

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
        [JsonProperty(PropertyName = "csu_payment_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> CsuPaymentSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_payment_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuPaymentDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_payment_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> CsuPaymentDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_payment_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> CsuPaymentAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_payment_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> CsuPaymentMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_payment_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> CsuPaymentProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_payment_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> CsuPaymentBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_payment_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> CsuPaymentPrincipalObjectAttributeAccesses { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "transactioncurrencyid")]
        public MicrosoftDynamicsCRMtransactioncurrency Transactioncurrencyid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_AMPOrder")]
        public MicrosoftDynamicsCRMcsuAmporder CsuAMPOrder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "csu_AMP")]
        public MicrosoftDynamicsCRMcsuAmp CsuAMP { get; set; }

    }
}
