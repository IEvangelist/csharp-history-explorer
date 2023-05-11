// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Models;

public readonly record struct TimelineEntry(
    DateOnly Date,
    SimpleVersion Version,
    string Reference,
    EntryDetail[] Details)
{
    public string Label => $"C# {Version}";
}
