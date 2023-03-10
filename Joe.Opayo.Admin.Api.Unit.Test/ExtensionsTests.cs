using Joe.Opayo.Admin.Api.Client.Models.Enums;
using Joe.Opayo.Admin.Api.Client.Models.Extensions;
using Joe.Opayo.Admin.Api.Client.Models.Responses;

namespace Joe.Opayo.Admin.Api.Unit.Test
{
    [TestClass]
    public class ExtensionsTests
    {
        [TestMethod]
        public void Ensure_ToCcv_Returns_Expected_Csv()
        {
            var listOfStrings = new List<string> { "the", "cat", "sat" };

            var result = listOfStrings.ToCsv();

            Assert.AreEqual("the,cat,sat", result);
        }

        [TestMethod]
        public void Ensure_ToCcv_Returns_Empty_String_On_Null_List()
        {
            List<string>? listOfStrings = null;

            var result = listOfStrings.ToCsv();

            Assert.AreEqual(string.Empty, result);
        }

        [TestMethod]
        public void Ensure_ToObject_Returns_Expected_Object()
        {
            const string accountType = "E";
            const string xml = $"<?xml version=\"1.0\" encoding=\"ISO-8859-1\" ?><vspaccess>  <errorcode>0000</errorcode>  <timestamp></timestamp>  <vpstxid>11111-814B-8B59-326C-B8041600546D</vpstxid>  <vendortxcode>AAA-A22-3479-3116-</vendortxcode>  <transactiontype>Payment</transactiontype>  <txstateid>16</txstateid>  <status>Successfully authorised transaction.</status>  <accounttype>E</accounttype>  <completed></completed>  <securitykey></securitykey></vspaccess>";

            var result = xml.ToObject<TransactionDetail>();

            Assert.AreEqual(accountType, result?.AccountType);
        }

        [TestMethod]
        public void Ensure_IsValidXml_Returns_True_For_Valid_Xml()
        {
            const string xml = "<someXmlTag>123456789</someXmlTag>";

            var result = xml.IsValidXml();

            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Ensure_IsValidXml_Returns_False_For_Invalid_Xml()
        {
            const string xml = "<someXmlTag>123456789<nnn>";

            var result = xml.IsValidXml();

            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void Ensure_GetDisplayName_Returns_An_Enums_Display_Attribute()
        {
            const ApiCommandType status = ApiCommandType.Version;

            Assert.AreEqual("version", status.GetDisplayName());
        }
    }
}