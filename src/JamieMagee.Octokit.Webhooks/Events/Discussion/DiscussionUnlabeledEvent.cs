namespace JamieMagee.Octokit.Webhooks.Events.Discussion
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;

    [WebhookActionType(DiscussionActionValue.Unlabeled)]
    public sealed record DiscussionUnlabeledEvent : DiscussionEvent
    {
        [JsonPropertyName("action")]
        public override string Action => DiscussionAction.Unlabeled;
    }
}
