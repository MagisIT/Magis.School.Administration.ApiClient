using Magis.School.Administration.ApiClient.Enums;

namespace Magis.School.Administration.ApiClient.Models
{
    public class Node
    {
        public string InstitutionCustomerId { get; set; }

        public string Name { get; set; }

        public NodeType Type { get; set; }

        public NodeBranch Branch { get; set; }
    }
}
