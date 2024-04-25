using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum OrderStatus
    {
        [EnumMember(Value = "LOCAL")]
        LOCAL,

        [EnumMember(Value = "UNCONFIRMED")]
        UNCONFIRMED,

        [EnumMember(Value = "CONFIRMED")]
        CONFIRMED,

        [EnumMember(Value = "NEW")]
        NEW,

        [EnumMember(Value = "CANCELLING")]
        CANCELLING,

        [EnumMember(Value = "CANCELLED")]
        CANCELLED,

        [EnumMember(Value = "PARTIALLY_FILLED")]
        PARTIALLY_FILLED,

        [EnumMember(Value = "FILLED")]
        FILLED,

        [EnumMember(Value = "REJECTED")]
        REJECTED,

        [EnumMember(Value = "REPLACING")]
        REPLACING,

        [EnumMember(Value = "REPLACED")]
        REPLACED
    }
}
