using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum TransactionType
    {

        [EnumMember(Value = "WITHDRAW")]
        WITHDRAW,

        [EnumMember(Value = "DEPOSIT")]
        DEPOSIT,

        [EnumMember(Value = "FEE")]
        FEE,

        [EnumMember(Value = "TRANSFER")]
        TRANSFER
    }
}
