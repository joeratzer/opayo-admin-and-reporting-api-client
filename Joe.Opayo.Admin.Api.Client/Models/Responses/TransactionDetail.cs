using System.Text;
using System.Xml.Serialization;

namespace Joe.Opayo.Admin.Api.Client.Models.Responses
{
    [XmlRoot(ElementName = "vspaccess")]
    public class TransactionDetail
    {
        [XmlElement(ElementName = "errorcode")]
        public string? ErrorCode { get; set; }

        [XmlElement(ElementName = "timestamp")]
        public string? TimeStamp { get; set; }

        [XmlElement(ElementName = "vpstxid")]
        public string? VpsTxId { get; set; }

        [XmlElement(ElementName = "vendortxcode")]
        public string? VendorTxCode { get; set; }

        [XmlElement(ElementName = "transactiontype")]
        public string? TransactionType { get; set; }

        [XmlElement(ElementName = "txstateid")]
        public string? TxStateId { get; set; }

        [XmlElement(ElementName = "status")]
        public string? Status { get; set; }

        [XmlElement(ElementName = "description")]
        public string? Description { get; set; }

        [XmlElement(ElementName = "amount")]
        public string? Amount { get; set; }

        [XmlElement(ElementName = "currency")]
        public string? Currency { get; set; }

        [XmlElement(ElementName = "started")]
        public string? Started { get; set; }

        [XmlElement(ElementName = "completed")]
        public string? Completed { get; set; }

        [XmlElement(ElementName = "securitykey")]
        public string? SecurityKey { get; set; }

        [XmlElement(ElementName = "clientip")]
        public string? ClientIp { get; set; }

        [XmlElement(ElementName = "giftaid")]
        public string? GiftAid { get; set; }

        [XmlElement(ElementName = "paymentsystem")]
        public string? PaymentSystem { get; set; }

        [XmlElement(ElementName = "paymentsystemdetails")]
        public string? PaymentSystemDetails { get; set; }

        [XmlElement(ElementName = "expirydate")]
        public string? ExpiryDate { get; set; }

        [XmlElement(ElementName = "last4digits")]
        public string? LastFourDigits { get; set; }

        [XmlElement(ElementName = "authprocessor")]
        public string? AuthProcessor { get; set; }

        [XmlElement(ElementName = "merchantnumber")]
        public string? MerchantNumber { get; set; }

        [XmlElement(ElementName = "accounttype")]
        public string? AccountType { get; set; }

        [XmlElement(ElementName = "vpsauthcode")]
        public string? VpsAuthCode { get; set; }

        [XmlElement(ElementName = "bankauthcode")]
        public string? BankAuthCode { get; set; }

        [XmlElement(ElementName = "batchid")]
        public string? BatchId { get; set; }

        [XmlElement(ElementName = "billingfirstnames")]
        public string? BillingFirstNames { get; set; }

        [XmlElement(ElementName = "billingsurname")]
        public string? BillingSurname { get; set; }

        [XmlElement(ElementName = "billingaddress")]
        public string? BillingAddress { get; set; }

        [XmlElement(ElementName = "billingaddress2")]
        public string? BillingAddress2 { get; set; }

        [XmlElement(ElementName = "billingcity")]
        public string? BillingCity { get; set; }

        [XmlElement(ElementName = "billingstate")]
        public string? BillingState { get; set; }

        [XmlElement(ElementName = "billingpostcode")]
        public string? BillingPostcode { get; set; }

        [XmlElement(ElementName = "billingcountry")]
        public string? BillingCountry { get; set; }

        [XmlElement(ElementName = "billingphone")]
        public string? BillingPhone { get; set; }

        [XmlElement(ElementName = "deliveryfirstnames")]
        public string? DeliveryFirstnames { get; set; }

        [XmlElement(ElementName = "deliverysurname")]
        public string? DeliverySurname { get; set; }

        [XmlElement(ElementName = "deliveryaddress")]
        public string? DeliveryAddress { get; set; }

        [XmlElement(ElementName = "deliveryaddress2")]
        public string? DeliveryAddress2 { get; set; }

        [XmlElement(ElementName = "deliverycity")]
        public string? DeliveryCity { get; set; }

        [XmlElement(ElementName = "deliverystate")]
        public string? DeliveryState { get; set; }

        [XmlElement(ElementName = "deliverypostcode")]
        public string? DeliveryPostcode { get; set; }

        [XmlElement(ElementName = "deliverycountry")]
        public string? DeliveryCountry { get; set; }

        [XmlElement(ElementName = "deliveryphone")]
        public string? DeliveryPhone { get; set; }

        [XmlElement(ElementName = "cardholder")]
        public string? Cardholder { get; set; }

        [XmlElement(ElementName = "cardaddress")]
        public string? CardAddress { get; set; }

        [XmlElement(ElementName = "cardaddress2")]
        public string? CardAddress2 { get; set; }

        [XmlElement(ElementName = "cardcity")]
        public string? CardCity { get; set; }

        [XmlElement(ElementName = "cardstate")]
        public string? CardState { get; set; }

        [XmlElement(ElementName = "cardpostcode")]
        public string? CardPostcode { get; set; }

        [XmlElement(ElementName = "cardcountry")]
        public string? CardCountry { get; set; }

        [XmlElement(ElementName = "customername")]
        public string? CustomerName { get; set; }

        [XmlElement(ElementName = "customeremail")]
        public string? CustomerEmail { get; set; }

        [XmlElement(ElementName = "contactnumber")]
        public string? ContactNumber { get; set; }

        [XmlElement(ElementName = "contactfax")]
        public string? ContactFax { get; set; }

        [XmlElement(ElementName = "vendoremail")]
        public string? VendorEmail { get; set; }

        [XmlElement(ElementName = "systemused")]
        public string? SystemUsed { get; set; }

        [XmlElement(ElementName = "vpsprotocol")]
        public string? VpsProtocol { get; set; }

        [XmlElement(ElementName = "callbackurl")]
        public string? CallbackUrl { get; set; }

        [XmlElement(ElementName = "refunded")]
        public string? Refunded { get; set; }

        [XmlElement(ElementName = "repeated")]
        public string? Repeated { get; set; }

        [XmlElement(ElementName = "basket")]
        public string? Basket { get; set; }

        [XmlElement(ElementName = "customerxml")]
        public string? CustomerXml { get; set; }

        [XmlElement(ElementName = "applyavscv2")]
        public string? ApplyAvsCv2 { get; set; }

        [XmlElement(ElementName = "apply3dsecure")]
        public int? Apply3dSecure { get; set; }

        [XmlElement(ElementName = "authattempt")]
        public string? AuthAttempt { get; set; }

        [XmlElement(ElementName = "cv2result")]
        public string? Cv2Result { get; set; }

        [XmlElement(ElementName = "addressresult")]
        public string? AddressResult { get; set; }

        [XmlElement(ElementName = "postcoderesult")]
        public string? PostcodeResult { get; set; }

        [XmlElement(ElementName = "threedattempt")]
        public string? ThreeDAttempt { get; set; }

        [XmlElement(ElementName = "threedresult")]
        public string? ThreeDResult { get; set; }

        [XmlElement(ElementName = "eci")]
        public string? Eci { get; set; }

        [XmlElement(ElementName = "t3mscore")]
        public string? T3MScore { get; set; }

        [XmlElement(ElementName = "t3maction")]
        public string? T3MAction { get; set; }

        [XmlElement(ElementName = "t3mid")]
        public string? T3Mid { get; set; }

        [XmlElement(ElementName = "emailmessage")]
        public string? EmailMessage { get; set; }

        [XmlElement(ElementName = "locale")]
        public string? Locale { get; set; }

        [XmlElement(ElementName = "declinecode")]
        public string? DeclineCode { get; set; }

        [XmlElement(ElementName = "vendordata")]
        public string? VendorData { get; set; }

        [XmlElement(ElementName = "website")]
        public string? Website { get; set; }

        [XmlElement(ElementName = "surcharge")]
        public string? Surcharge { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var properties = typeof(TransactionDetail).GetProperties().Where(p => p.CanRead && p.CanWrite);
            foreach (var property in properties)
            {
                sb.Append($"{property.Name}: {property.GetValue(this)}. ");
            }
            return sb.ToString().Trim();
        }
    }

}
