using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum OrderExecutor
    {
        [EnumMember(Value = "API")]
        API,

        [EnumMember(Value = "IOS")]
        IOS,

        [EnumMember(Value = "ANDROID")]
        ANDROID,

        [EnumMember(Value = "WEB")]
        WEB,

        [EnumMember(Value = "SYSTEM")]
        SYSTEM,

        [EnumMember(Value = "AUTOINVEST")]
        AUTOINVEST,
    }
}
