using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum OrderFillType
    {
        [EnumMember(Value = "TOTV")]
        TOTV,

        [EnumMember(Value = "OTC")]
        OTC
    }
}
