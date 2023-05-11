// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Models;

public record class FeatureContent(MarkupString Html, string Reference)
{
    public static FeatureContent Empty { get; } = new(
        (MarkupString)"Unable to retrieve feature content. Sorry for the inconvenience.",
        string.Empty);
}
