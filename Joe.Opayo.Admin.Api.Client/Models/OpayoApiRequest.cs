using Joe.Opayo.Admin.Api.Client.Models.Enums;

namespace Joe.Opayo.Admin.Api.Client.Models
{
    public class OpayoApiRequest
    {
        public OpayoApiRequest(ApiCommandType apiCommandType,
            string password,
            string user,
            string vendor)
        {
            ApiCommandType = apiCommandType;
            Password = password;
            User = user;
            Vendor = vendor;
        }

        public ApiCommandType ApiCommandType { get; set; }
        public string Password { get; set; }
        public string User { get; set; }
        public string Vendor { get; set; }
    }
}