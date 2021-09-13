﻿namespace JamieMagee.Octokit.Webhooks.Events
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Converter;

    [WebhookEventType(WebhookEventType.SecurityAdvisory)]
    [JsonConverter(typeof(WebhookConverter<SecurityAdvisoryEvent>))]
    public abstract record SecurityAdvisoryEvent : WebhookEvent
    {
    }
}
