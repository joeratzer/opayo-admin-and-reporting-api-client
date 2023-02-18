using System.Xml;

namespace Joe.Opayo.Admin.Api.Client.Model.Extensions
{
    public static class XmlDocumentExtensions
    {
        public static void RemoveXmlDeclarationHeader(this XmlDocument? xmlDocument)
        {
            if (xmlDocument == null)
                return;

            foreach (XmlNode n in xmlDocument)
            {
                if (n.NodeType == XmlNodeType.XmlDeclaration)
                {
                    xmlDocument.RemoveChild(n);
                }
                break;
            }
        }
    }
}
