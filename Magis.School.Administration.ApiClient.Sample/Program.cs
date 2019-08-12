using System;
using System.Threading.Tasks;
using Magis.School.Administration.ApiClient.Models;

namespace Magis.School.Administration.ApiClient.Sample
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            var api = new ApiClient().Api("KD12345678", "password");
            Institution institution = await api.Institutions.GetInstitutionAsync("KD12345678").ConfigureAwait(false);
        }
    }
}
