using System.Threading.Tasks;
using Magis.School.Administration.ApiClient.Models;
using Refit;

namespace Magis.School.Administration.ApiClient.Endpoints.Api
{
    [Headers("Authorization: Basic")]
    public interface IInstitutions
    {
        [Get("/api/institutions/{customerId}")]
        Task<Institution> GetInstitutionAsync(string customerId);
    }
}
