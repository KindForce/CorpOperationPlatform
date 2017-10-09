using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SA.Cop.GitLab.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ActionType
    {
        Unknown,

        [EnumMember(Value = "update")]
        Update,

        [EnumMember(Value = "open")]
        Open,

        [EnumMember(Value = "merge")]
        Merge,

        [EnumMember(Value = "close")]
        Close
    }
}