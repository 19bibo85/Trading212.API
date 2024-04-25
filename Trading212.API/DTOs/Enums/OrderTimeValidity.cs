using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum OrderTimeValidity
    {
        [EnumMember(Value = "DAY")]
        DAY,

        [EnumMember(Value = "GTC")]
        GTC
    }
}
