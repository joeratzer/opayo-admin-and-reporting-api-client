﻿using Joe.Opayo.Admin.Api.Client.Models;

namespace Joe.Opayo.Admin.Api.Client.Interfaces
{
    public interface IOpayoAdminApiClient
    {
        public Task<T> ProcessApiCommandAsync<T>(OpayoApiRequest request, string commandSpecificXml) where T : new();
    }
}
