using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magis.School.Administration.ApiClient.Models;

namespace Magis.School.Administration.ApiClient.Sample
{
    public static class Program
    {
        public static async Task Main(string[] args)
        {
            const string customerId = "KD12345678";

            var api = new ApiClient().Api("user", "password");
            Institution institution = await api.Institutions.GetInstitutionAsync(customerId).ConfigureAwait(false);
            Node[] nodes = (await api.InstitutionNodes.GetNodesAsync(customerId).ConfigureAwait(false)).ToArray();
            NodePasswordList[] passwordLists = (await api.InstitutionNodePasswordLists.GetPasswordListsAsync(customerId, "master-1").ConfigureAwait(false)).ToArray();
            NodePasswordList latestPasswordList = await api.InstitutionNodePasswordLists.GetLatestPasswordListAsync(customerId, "master-1").ConfigureAwait(false);
        }
    }
}
