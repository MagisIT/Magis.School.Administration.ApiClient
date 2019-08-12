using System.Collections.Generic;
using System.Threading.Tasks;
using Magis.School.Administration.ApiClient.Models;
using Refit;

namespace Magis.School.Administration.ApiClient.Endpoints.Api
{
    [Headers("Authorization: Basic")]
    public interface IInstitutionNodePasswordLists
    {
        [Get("/api/institutions/{customerId}/nodes/{nodeName}/passwordlists")]
        Task<IEnumerable<NodePasswordList>> GetPasswordListsAsync(string customerId, string nodeName);

        [Get("/api/institutions/{customerId}/nodes/{nodeName}/passwordlists/latest")]
        Task<NodePasswordList> GetLatestPasswordListAsync(string customerId, string nodeName);

        [Put("/api/institutions/{customerId}/nodes/{nodeName}/passwordlists")]
        Task AddNodePasswordList(string customerId,string nodeName, [Body] AddNodePasswordListInput passwordListInput);
    }
}
