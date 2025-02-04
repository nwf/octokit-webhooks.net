﻿namespace Octokit.Webhooks.Models.TeamEvent
{
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;

    [PublicAPI]
    public sealed record ChangesRepositoryPermissionsFrom
    {
        [JsonPropertyName("admin")]
        public bool? Admin { get; init; }

        [JsonPropertyName("pull")]
        public bool? Pull { get; init; }

        [JsonPropertyName("push")]
        public bool? Push { get; init; }
    }
}
