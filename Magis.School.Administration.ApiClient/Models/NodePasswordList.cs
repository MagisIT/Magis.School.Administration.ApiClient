using System;

namespace Magis.School.Administration.ApiClient.Models
{
    public class NodePasswordList
    {
        public string InstitutionCustomerId { get; set; }

        public string NodeName { get; set; }

        public DateTime Date { get; set; }

        public string EncryptedPasswordList { get; set; }
    }
}
