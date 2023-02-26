using Joe.Opayo.Admin.Api.Client.Models;
using Joe.Opayo.Admin.Api.Client.Models.Enums;
using Joe.Opayo.Admin.Api.Client.Models.Extensions;
using Joe.Opayo.Admin.Api.Client.Validation;

namespace Joe.Opayo.Admin.Api.Unit.Test
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void Ensure_Vendor_Is_A_Mandatory_Field()
        {
            var request = new OpayoApiRequest(ApiCommandType.GetAllCountries, "password", "user", "");
            var validation = new RequestValidation();
            var result = validation.IsValid(request, null);

            Assert.AreEqual(false, result.Success);
            Assert.IsTrue(result.ErrorMessages.ToCsv().Contains(nameof(request.Vendor)));
        }

        [TestMethod]
        public void Ensure_User_Is_A_Mandatory_Field()
        {
            var request = new OpayoApiRequest(ApiCommandType.GetAllCountries, "password", "", "vendor");
            var validation = new RequestValidation();
            var result = validation.IsValid(request, null);

            Assert.AreEqual(false, result.Success);
            Assert.IsTrue(result.ErrorMessages.ToCsv().Contains(nameof(request.User)));
        }

        [TestMethod]
        public void Ensure_Password_Is_A_Mandatory_Field()
        {
            var request = new OpayoApiRequest(ApiCommandType.GetAllCountries, "", "user", "vendor");
            var validation = new RequestValidation();
            var result = validation.IsValid(request, null);

            Assert.AreEqual(false, result.Success);
            Assert.IsTrue(result.ErrorMessages.ToCsv().Contains(nameof(request.Password)));
        }
    }
}