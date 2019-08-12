using System.Collections.Generic;
using System.Threading.Tasks;
using Magis.School.Administration.ApiClient.Models;
using Refit;

namespace Magis.School.Administration.ApiClient.Endpoints.Api
{
    [Headers("Authorization: Basic")]
    public interface IInstitutionNodes
    {
        [Get("/api/institutions/{customerId}/nodes")]
        Task<IEnumerable<Node>> GetNodesAsync(string customerId);

        [Get("/api/institutions/{customerId}/nodes/{nodeName}")]
        Task<Node> GetNodeAsync(string customerId, [AliasAs("nodeName")] string name);

        [Put("/api/institutions/{customerId}/nodes")]
        Task<Node> CreateOrUpdateNodeAsync(string customerId, [Body] CreateOrUpdateNodeInput nodeInput);

        [Delete("/api/institutions/{customerId}/nodes/{name}")]
        Task DeleteNodeAsync(string customerId, string name);
    }
}
