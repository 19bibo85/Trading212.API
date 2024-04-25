using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum PieStatus
    {
        [EnumMember(Value = "AHEAD")]
        AHEAD,

        [EnumMember(Value = "ON_TRACK")]
        ON_TRACK,

        [EnumMember(Value = "BEHIND")]
        BEHIND,
    }
}
