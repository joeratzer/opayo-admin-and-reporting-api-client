﻿using System.Xml;
using System.Xml.Serialization;

namespace Joe.Opayo.Admin.Api.Client.Models.Extensions
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

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlText);
            xmlDoc.RemoveXmlDeclarationHeader();

            var serializer = new XmlSerializer(typeof(T));
            return (T?)serializer.Deserialize(new StringReader(xmlDoc.OuterXml));
        }

        public static bool IsValidXml(this string? xmlText)
        {
            if (xmlText == null)
                return false;

            try
            {
                var doc = new XmlDocument();
                doc.LoadXml(xmlText);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
