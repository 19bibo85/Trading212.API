using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum PieErrorSeverity
    {
        [EnumMember(Value = "IRREVERSIBLE")]
        IRREVERSIBLE,

        [EnumMember(Value = "REVERSIBLE")]
        REVERSIBLE,

        [EnumMember(Value = "INFORMATIVE")]
        INFORMATIVE
    }
}
