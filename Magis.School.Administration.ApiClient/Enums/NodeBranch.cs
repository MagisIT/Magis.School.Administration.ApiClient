using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Magis.School.Administration.ApiClient.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NodeBranch
    {
        Stable = 0,
        Beta = 1
    }
}
