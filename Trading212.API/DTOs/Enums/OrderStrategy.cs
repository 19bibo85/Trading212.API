using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum OrderStrategy
    {
        [EnumMember(Value = "QUANTITY")]
        QUANTITY,

        [EnumMember(Value = "VALUE")]
        VALUE,
    }
}
