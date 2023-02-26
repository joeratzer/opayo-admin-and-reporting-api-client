using System.ComponentModel.DataAnnotations;

namespace Joe.Opayo.Admin.Api.Client.Models.Enums
{
    public enum ApiCommandType
    {
        [Display(Name = "version")]
        Version = 1,

        [Display(Name = "createUser")]
        CreateUser = 2,

        [Display(Name = "deleteUser")]
        DeleteUser = 3,

        [Display(Name = "lockUser")]
        LockUser = 4,

        [Display(Name = "logAccountActivity")]
        LogAccountActivity = 5,

        [Display(Name = "logoutUser")]
        LogoutUser = 6,

        [Display(Name = "unlockUser")]
        UnlockUser = 7,

        [Display(Name = "setUserPassword")]
        SetUserPassword = 8,

        [Display(Name = "setUserRights")]
        SetUserRights = 9,

        [Display(Name = "set3DSecureStatus")]
        Set3dSecureStatus = 10,

        [Display(Name = "setAVSCV2Status")]
        SetAvsCv2Status = 11,

        [Display(Name = "set3DSecureRules")]
        Set3dSecureRules = 12,

        [Display(Name = "setAVSCV2Rules")]
        SetAvsCv2Rules = 13,

        [Display(Name = "setExpiryDate")]
        SetExpiryDate = 14,

        [Display(Name = "setVendorDetails")]
        SetVendorDetails = 15,

        [Display(Name = "setUserDetails")]
        SetUserDetails = 16,

        [Display(Name = "addBlockedCardRanges")]
        AddBlockedCardRanges = 17,

        [Display(Name = "addBlockedCountries")]
        AddBlockedCountries = 18,

        [Display(Name = "addBlockedIPs")]
        AddBlockedIps = 19,

        [Display(Name = "addBlockedIssuingCountries")]
        AddBlockedIssuingCountries = 20,

        [Display(Name = "addValidIPs")]
        AddValidIps = 21,

        [Display(Name = "addRestrictedDomains")]
        AddRestrictedDomains = 22,

        [Display(Name = "setVendorSurcharges")]
        SetVendorSurcharges = 23,

        [Display(Name = "deleteAVSCV2Rules")]
        DeleteAvsCv2Rules = 24,

        [Display(Name = "delete3DSecureRules")]
        Delete3dSecureRules = 25,

        [Display(Name = "deleteBlockedCardRanges")]
        DeleteBlockedCardRanges = 26,

        [Display(Name = "deleteBlockedCountries")]
        DeleteBlockedCountries = 27,

        [Display(Name = "deleteBlockedIPs")]
        DeleteBlockedIps = 28,

        [Display(Name = "deleteBlockedIssuingCountries")]
        DeleteBlockedIssuingCountries = 29,

        [Display(Name = "deleteValidIPs")]
        DeleteValidIps = 30,

        [Display(Name = "setPaymentPageTemplates")]
        SetPaymentPageTemplates = 31,

        [Display(Name = "setPaypalAccount")]
        SetPaypalAccount = 32,

        [Display(Name = "deletePaypalAccount")]
        DeletePaypalAccount = 33,

        [Display(Name = "deleteRestrictedDomain")]
        DeleteRestrictedDomain = 34,

        [Display(Name = "deleteVendorSurcharges")]
        DeleteVendorSurcharges = 35,

        [Display(Name = "doesUserExist")]
        DoesUserExist = 36,

        [Display(Name = "getUserRights")]
        GetUserRights = 37,

        [Display(Name = "getAccountLogs")]
        GetAccountLogs = 38,

        [Display(Name = "getVendorUserList")]
        GetVendorUserList = 39,

        [Display(Name = "getVendorDetails")]
        GetVendorDetails = 40,

        [Display(Name = "getVendorPProDetail")]
        GetVendorPproDetail = 41,

        [Display(Name = "getVendorPaymentSystems")]
        GetVendorPaymentSystems = 42,

        [Display(Name = " getValidIPs")]
        GetValidIps = 43,

        [Display(Name = "getURLs")]
        GetUrls = 44,

        [Display(Name = "get3DSecureStatus")]
        Get3dSecureStatus = 45,

        [Display(Name = "get3DSecureRules")]
        Get3dSecureRules = 46,

        [Display(Name = "getAVSCV2Status")]
        GetAvsCv2Status = 47,

        [Display(Name = "getAVSCV2Rules")]
        GetAvsCv2Rules = 48,

        [Display(Name = "getRestrictedDomains")]
        GetRestrictedDomains = 49,

        [Display(Name = "getBatchDetail")]
        GetBatchDetail = 50,

        [Display(Name = "getBatchList")]
        GetBatchList = 51,

        [Display(Name = "getCardType")]
        GetCardType = 52,

        [Display(Name = "getCardDetails")]
        GetCardDetails = 53,

        [Display(Name = "getCurrencies")]
        GetCurrencies = 54,

        [Display(Name = "getMerchantAccounts")]
        GetMerchantAccounts = 55,

        [Display(Name = "getTransactionCardDetails")]
        GetTransactionCardDetails = 56,

        [Display(Name = "getTransactionDetail")]
        GetTransactionDetail = 57,

        [Display(Name = "getTransactionIPDetails")]
        GetTransactionIpDetails = 58,

        [Display(Name = "getTransactionList")]
        GetTransactionList = 59,

        [Display(Name = "getTransactionSummary")]
        GetTransactionSummary = 60,

        [Display(Name = "getTransactionTypes")]
        GetTransactionTypes = 61,

        [Display(Name = "getRelatedTransactions")]
        GetRelatedTransactions = 62,

        [Display(Name = "getGiftAidReport")]
        GetGiftAidReport = 63,

        [Display(Name = "getAllCountries")]
        GetAllCountries = 64,

        [Display(Name = "getBlockedCardRanges")]
        GetBlockedCardRanges = 65,

        [Display(Name = "getBlockedCountries")]
        GetBlockedCountries = 66,

        [Display(Name = "getBlockedIPs")]
        GetBlockedIps = 67,

        [Display(Name = "getBlockedIssuingCountries")]
        GetBlockedIssuingCountries = 68,

        [Display(Name = "getTokenCount")]
        GetTokenCount = 69,

        [Display(Name = "getTokenDetails")]
        GetTokenDetails = 70,

        [Display(Name = "getT3MDetail")]
        GetT3MDetail = 71,

        [Display(Name = "getUserDetails")]
        GetUserDetails = 72,

        [Display(Name = "getFraudScreenDetail")]
        GetFraudScreenDetail = 73,

        [Display(Name = "getVendorSurcharge")]
        GetVendorSurcharge = 74
    }
}
