using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum DividendCashAction
    {
        [EnumMember(Value = "REINVEST")]
        Reinvest,

        [EnumMember(Value = "TO_ACCOUNT_CASH")]
        ToAccountCash
    }
}
