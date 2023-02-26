using System.Xml.Serialization;

namespace Joe.Opayo.Admin.Api.Client.Models.Responses
{
    public class BaseTransactionDetail
    {
        [XmlElement(ElementName = "errorcode")]
        public string? ErrorCode { get; set; }

        [XmlElement(ElementName = "timestamp")]
        public string? TimeStamp { get; set; }
    }
}
