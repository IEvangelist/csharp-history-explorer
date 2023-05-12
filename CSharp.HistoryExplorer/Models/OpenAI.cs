// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Models;

public sealed class OpenAI
{
    public string ApiKey { get; set; } = default!;

    public string Endpoint { get; set; } = default!;

    public string DeploymentId { get; set; } = default!;

    public static readonly OpenAI Empty = new();
}
