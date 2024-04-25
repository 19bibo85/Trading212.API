using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum MetadataType
    {
        [EnumMember(Value = "CRYPTOCURRENCY")]
        CRYPTOCURRENCY,

        [EnumMember(Value = "ETF")]
        ETF,

        [EnumMember(Value = "FOREX")]
        FOREX,

        [EnumMember(Value = "FUTURES")]
        FUTURES,

        [EnumMember(Value = "INDEX")]
        INDEX,

        [EnumMember(Value = "STOCK")]
        STOCK,

        [EnumMember(Value = "WARRANT")]
        WARRANT,

        [EnumMember(Value = "CRYPTO")]
        CRYPTO,

        [EnumMember(Value = "CVR")]
        CVR,

        [EnumMember(Value = "CORPACT")]
        CORPACT
    }
}
