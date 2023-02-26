using System.Xml.Serialization;

namespace Joe.Opayo.Admin.Api.Client.Models.Responses
{
    [XmlRoot(ElementName = "vspaccess")]
    public class UserDetail : BaseTransactionDetail
    {
        [XmlElement(ElementName = "username")]
        public string? Username { get; set; }

        [XmlElement(ElementName = "firstname")]
        public string? Firstname { get; set; }

        [XmlElement(ElementName = "lastname")]
        public string? Lastname { get; set; }

        [XmlElement(ElementName = "commsoptin")]
        public string? CommunicationsOptIn { get; set; }
    }
}
