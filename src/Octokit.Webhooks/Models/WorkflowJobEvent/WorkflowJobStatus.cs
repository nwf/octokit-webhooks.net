namespace Octokit.Webhooks.Models.WorkflowJobEvent
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum WorkflowJobStatus
    {
        [EnumMember(Value = "queued")]
        Queued,
        [EnumMember(Value = "in_progress")]
        InProgress,
        [EnumMember(Value = "completed")]
        Completed,
    }
}
