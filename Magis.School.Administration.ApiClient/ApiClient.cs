using System;
using Magis.School.Administration.ApiClient.Endpoints;
using Magis.School.Administration.ApiClient.Serialization;

namespace Magis.School.Administration.ApiClient
{
    public class ApiClient
    {
        public const string DefaultBaseUrl = "https://administration.magis.school";

        public string BaseUrl { get; }

        private readonly JsonSettings _jsonSerializerSettings;

        public ApiClient() : this(DefaultBaseUrl) { }

        public ApiClient(string baseUrl)
        {
            BaseUrl = baseUrl ?? throw new ArgumentNullException(nameof(baseUrl));
            _jsonSerializerSettings = new JsonSettings();
        }

        public ApiEndpoint Api(string userNameOrCustomerId, string password)
        {
            return new ApiEndpoint(BaseUrl, userNameOrCustomerId,password, _jsonSerializerSettings);
        }
    }
}
