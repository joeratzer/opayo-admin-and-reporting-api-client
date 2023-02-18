using System.Xml;
using System.Xml.Serialization;

namespace Joe.Opayo.Admin.Api.Client.Model.Extensions
{
    public static class StringExtensions
    {
        public static string ToCsv(this List<string>? listOfStrings)
        {
            if (listOfStrings == null || !listOfStrings.Any())
                return string.Empty;

            return string.Join(",", listOfStrings.Select(x => x.ToString()).ToArray());
        }

        public static T? ToObject<T>(this string? xmlText) where T : new()
        {
            if (string.IsNullOrWhiteSpace(xmlText))
                return new T();

            var xml = new XmlDocument();
            xml.LoadXml(xmlText);
            var serializer = new XmlSerializer(typeof(T));
            return (T?)serializer.Deserialize(new StringReader(xml.OuterXml));
        }
    }
}
