using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Magis.School.Administration.ApiClient.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum NodeType
    {
        Master = 0,
        Slave = 1
    }
}
