using System.Runtime.Serialization;

namespace Trading212.API.DTOs.Enums
{
    public enum ExportStatus
    {
        [EnumMember(Value = "Queued")]
        Queued,

        [EnumMember(Value = "Processing")]
        Processing,

        [EnumMember(Value = "Running")]
        Running,

        [EnumMember(Value = "Canceled")]
        Canceled,

        [EnumMember(Value = "Failed")]
        Failed,

        [EnumMember(Value = "Finished")]
        Finished,

    }
}
