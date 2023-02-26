using Joe.Opayo.Admin.Api.Client.Models;
using Joe.Opayo.Admin.Api.Client.Models.Extensions;
using Joe.Opayo.Admin.Api.Client.Models.Validation;
using Joe.Opayo.Admin.Api.Client.Validation.Interfaces;

namespace Joe.Opayo.Admin.Api.Client.Validation
{
    public class RequestValidation : IRequestValidation
    {
        private const string EmptyFieldText = "cannot be empty";

        public ProcessValidationResult IsValid(OpayoApiRequest opayoApiRequest, string? commandSpecificXml)
        {
            var result = new ProcessValidationResult();

            if (commandSpecificXml != null && !commandSpecificXml.IsValidXml())
            {
                result.AddErrorMessage($"The {nameof(commandSpecificXml)} is not valid Xml");
            }

            if (string.IsNullOrWhiteSpace(opayoApiRequest.Vendor))
            {
                result.AddErrorMessage($"{nameof(opayoApiRequest.Vendor)} {EmptyFieldText}");
            }

            if (string.IsNullOrWhiteSpace(opayoApiRequest.User))
            {
                result.AddErrorMessage($"{nameof(opayoApiRequest.User)} {EmptyFieldText}");
            }

            if (string.IsNullOrWhiteSpace(opayoApiRequest.Password))
            {
                result.AddErrorMessage($"{nameof(opayoApiRequest.Password)} {EmptyFieldText}");
            }

            return result;
        }
    }
}
