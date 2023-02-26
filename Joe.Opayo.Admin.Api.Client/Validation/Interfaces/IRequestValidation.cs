using Joe.Opayo.Admin.Api.Client.Models;
using Joe.Opayo.Admin.Api.Client.Models.Validation;

namespace Joe.Opayo.Admin.Api.Client.Validation.Interfaces
{
    public interface IRequestValidation
    {
        ProcessValidationResult IsValid(OpayoApiRequest opayoApiRequest, string? additionalXmlCommand);
    }
}
