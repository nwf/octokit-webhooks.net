namespace JamieMagee.Octokit.Webhooks.Events.Team
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;

    [WebhookActionType(TeamActionValue.Deleted)]
    public sealed record TeamDeletedEvent : TeamEvent
    {
        [JsonPropertyName("action")]
        public override string Action => TeamAction.Deleted;
    }
}
