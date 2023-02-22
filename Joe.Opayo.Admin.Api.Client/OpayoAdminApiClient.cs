using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using Joe.Opayo.Admin.Api.Client.Interfaces;
using Joe.Opayo.Admin.Api.Client.Models;
using Joe.Opayo.Admin.Api.Client.Models.Exceptions;
using Joe.Opayo.Admin.Api.Client.Models.Extensions;

namespace Joe.Opayo.Admin.Api.Client
{
    public class OpayoAdminApiClient : IOpayoAdminApiClient
    {
        private const string LiveUrl= "https://live.sagepay.com";
        private const string TestUrl = "https://test.sagepay.com";
        private static readonly HttpClient Client = new();

        public async Task<T> ProcessApiCommandAsync<T>(OpayoApiRequest request, string commandSpecificXml) where T : new()
        {
            var xmlCommand = GetApiCommandWithSignatureAsXml(request.ApiCommandType.GetDisplayName(),
                request.Vendor,
                request.User,
                commandSpecificXml,
                request.Password);

            var result = await PostApiCommandAsync(xmlCommand, request.Test);

            if (result.Content == null || !result.Success)
                throw new ProcessApiCommandException($"Failed to process command. Message: {result.Messages.ToCsv()}. Content: {result.Content}.");

            return result.Content.ToObject<T>() ?? new T();
        }

        private static async Task<OpayoApiResponse> PostApiCommandAsync(string xmlCommand, 
            bool testEndpoint = false)
        {
            if (string.IsNullOrWhiteSpace(xmlCommand))
                throw new ArgumentException($"{nameof(xmlCommand)} cannot be empty. {nameof(xmlCommand)}: {xmlCommand}", $"{nameof(xmlCommand)}");

            if (Client.BaseAddress == null)
            {
                Client.BaseAddress = new Uri(testEndpoint ? TestUrl : LiveUrl);
            }            
            var postParams = new Dictionary<string, string> { { "XML", xmlCommand } };
            var postContent = new FormUrlEncodedContent(postParams);
            var response = await Client.PostAsync("/access/access.htm", postContent);
            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return new OpayoApiResponse(responseContent, true);
            }
            var apiResponse = new OpayoApiResponse(null, false);
            apiResponse.Messages.Add($"Failed. {nameof(response.StatusCode)}: {response.StatusCode}. {await response.Content.ReadAsStringAsync()}");
            return apiResponse;
        }

        private string GetApiCommandWithSignatureAsXml(string apiCommandName, 
            string vendor, 
            string user, 
            string? commandSpecificXml, 
            string password)
        {
            var commandXml = GetApiCommandAsXml(apiCommandName, vendor, user, commandSpecificXml, password);
            var signature = GetHashedSignature(commandXml);
            return "XML=<vspaccess>" + GetApiCommandAsXml(apiCommandName, vendor, user, commandSpecificXml, null, signature) + "</vspaccess>";
        }

        private static string GetApiCommandAsXml(string apiCommandName, 
            string vendor, 
            string user, 
            string? commandSpecificXml, 
            string? password = null, 
            string? signature = null)
        {
            return $"<command>{apiCommandName}</command><vendor>{vendor}</vendor><user>{user}</user>{commandSpecificXml ?? string.Empty}{(string.IsNullOrEmpty(password) == false ? "<password>" + password + "</password>" : string.Empty)}{(string.IsNullOrEmpty(signature) == false ? "<signature>" + signature + "</signature>" : string.Empty)}";
        }

        private static string GetHashedSignature(string data)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(data));
            var sig = BitConverter.ToString(hash).Replace("-", string.Empty);
            return sig;
        }
    }
}