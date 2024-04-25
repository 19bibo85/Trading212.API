using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum PieErrorName
    {
        [EnumMember(Value = "DELISTED")]
        DELISTED,

        [EnumMember(Value = "SUSPENDED")]
        SUSPENDED,

        [EnumMember(Value = "NO_LONGER_TRADABLE")]
        NO_LONGER_TRADABLE,

        [EnumMember(Value = "MAX_POSITION_SIZE_REACHED")]
        MAX_POSITION_SIZE_REACHED,

        [EnumMember(Value = "APPROACHING_MAX_POSITION_SIZE")]
        APPROACHING_MAX_POSITION_SIZE,

        [EnumMember(Value = "COMPLEX_INSTRUMENT_APP_TEST_REQUIRED")]
        COMPLEX_INSTRUMENT_APP_TEST_REQUIRED
    }
}
