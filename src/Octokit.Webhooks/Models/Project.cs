﻿namespace Octokit.Webhooks.Models
{
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;

    [PublicAPI]
    public sealed record Project
    {
        [JsonPropertyName("owner_url")]
        public string OwnerUrl { get; init; } = null!;

        [JsonPropertyName("url")]
        public string Url { get; init; } = null!;

        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; init; } = null!;

        [JsonPropertyName("columns_url")]
        public string ColumnsUrl { get; init; } = null!;

        [JsonPropertyName("id")]
        public int Id { get; init; }

        [JsonPropertyName("node_id")]
        public string NodeId { get; init; } = null!;

        [JsonPropertyName("name")]
        public string Name { get; init; } = null!;

        [JsonPropertyName("body")]
        public string? Body { get; init; }

        [JsonPropertyName("number")]
        public int Number { get; init; }

        [JsonPropertyName("state")]
        public ProjectState State { get; init; }

        [JsonPropertyName("creator")]
        public User Creator { get; init; } = null!;

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; init; } = null!;

        [JsonPropertyName("updated_at")]
        public string UpdatedAt { get; init; } = null!;
    }
}
