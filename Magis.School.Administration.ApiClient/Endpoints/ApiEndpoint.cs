using System;
using System.Net.Http;
using Magis.School.Administration.ApiClient.Endpoints.Api;
using Magis.School.Administration.ApiClient.Utils;
using Newtonsoft.Json;
using Refit;

namespace Magis.School.Administration.ApiClient.Endpoints
{
    public class ApiEndpoint
    {
        public IInstitutions Institutions { get; }

        public IInstitutionNodes InstitutionNodes { get; }

        public IInstitutionNodePasswordLists InstitutionNodePasswordLists { get; }

        internal ApiEndpoint(string baseUrl, string userNameOrCustomerId, string password, JsonSerializerSettings jsonSerializerSettings)
        {
            var refitSettings = new RefitSettings {ContentSerializer = new JsonContentSerializer(jsonSerializerSettings)};
            var httpClient = new HttpClient(new ApiHttpClientHandler(userNameOrCustomerId, password)) {BaseAddress = new Uri(baseUrl)};

            Institutions = RestService.For<IInstitutions>(httpClient, refitSettings);
            InstitutionNodes = RestService.For<IInstitutionNodes>(httpClient, refitSettings);
            InstitutionNodePasswordLists = RestService.For<IInstitutionNodePasswordLists>(httpClient, refitSettings);
        }
    }
}
