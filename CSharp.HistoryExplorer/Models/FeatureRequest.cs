// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Models;

public readonly record struct FeatureRequest(
    string Name,
    SimpleVersion Version)
{
    public string Key => $"{Version}/{Name}";
}
