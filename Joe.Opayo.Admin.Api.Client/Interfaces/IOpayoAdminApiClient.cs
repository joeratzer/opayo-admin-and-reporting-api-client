using Joe.Opayo.Admin.Api.Client.Model;

namespace Joe.Opayo.Admin.Api.Client.Interfaces
{
    public interface IOpayoAdminApiClient
    {
        public Task<T> ProcessApiCommandAsync<T>(OpayoApiRequest request, string commandSpecificXml) where T : new();
    }
}
