using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum OrderType
    {
        [EnumMember(Value = "LIMIT")]
        LIMIT,

        [EnumMember(Value = "STOP")]
        STOP,

        [EnumMember(Value = "MARKET")]
        MARKET,

        [EnumMember(Value = "STOP_LIMIT")]
        STOP_LIMIT
    }
}
