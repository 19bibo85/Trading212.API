using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum PieDividendCashAction
    {
        [EnumMember(Value = "REINVEST")]
        REINVEST,

        [EnumMember(Value = "TO_ACCOUNT_CASH")]
        TO_ACCOUNT_CASH
    }
}
