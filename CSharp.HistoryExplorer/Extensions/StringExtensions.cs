// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Extensions;

internal static class StringExtensions
{
    private static readonly MarkdownPipeline s_pipeline = new MarkdownPipelineBuilder()
        .ConfigureNewLine("\n")
        .UseAdvancedExtensions()
        .UseEmojiAndSmiley()
        .UseSoftlineBreakAsHardlineBreak()
        .Build();

    public static MarkupString ToHtml(this string markdown) => string.IsNullOrWhiteSpace(markdown) is false
        ? (MarkupString)Markdown.ToHtml(markdown, s_pipeline)
        : (MarkupString)"";
}
