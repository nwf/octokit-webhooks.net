namespace JamieMagee.Octokit.Webhooks.Events.Sponsorship
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;

    [WebhookActionType(SponsorshipActionValue.TierChanged)]
    public sealed record SponsorshipTierChangedEvent : SponsorshipEvent
    {
        [JsonPropertyName("action")]
        public override string Action => SponsorshipAction.TierChanged;
    }
}
