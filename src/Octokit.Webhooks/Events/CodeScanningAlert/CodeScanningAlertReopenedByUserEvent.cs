namespace Octokit.Webhooks.Events.CodeScanningAlert
{
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;

    [PublicAPI]
    [WebhookActionType(CodeScanningAlertActionValue.ReopenedByUser)]
    public sealed record CodeScanningAlertReopenedByUserEvent : CodeScanningAlertEvent
    {
        [JsonPropertyName("action")]
        public override string Action => CodeScanningAlertAction.ReopenedByUser;
    }
}
