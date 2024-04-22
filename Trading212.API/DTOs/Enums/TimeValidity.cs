using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum TimeValidity
    {
        [EnumMember(Value = "DAY")]
        Day,

        [EnumMember(Value = "GTC")]
        Gtc
    }
}
