// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Pages;

public sealed partial class Index
{
    internal Color[] Colors { get; } = new[]
    {
        Color.Primary,
        Color.Secondary,
        Color.Tertiary,
        Color.Info,
        Color.Warning,
        Color.Success
    };

    internal IReadOnlySet<TimelineEntry> Items { get; } = History.Items;

    [Inject] public required IDialogService Dialog { get; set; }
    [Inject] public required AppState State { get; set; }

    private void OnDisplayFeatureDialog(TimelineEntry entry, EntryDetail detail)
    {
        var title = $"{entry.Label}: {ToNormalizedTitle(detail.Name)}";

        Dialog.Show<FeatureDialog>(title, new DialogParameters
        {
            [nameof(FeatureDialog.Name)] = detail.Name,
            [nameof(FeatureDialog.Reference)] = detail.Reference,
            [nameof(FeatureDialog.Version)] = entry.Version
        },
        new DialogOptions
        {
            FullScreen = State.WindowSize is null or { Height: < 1080, Width: < 1920 }
        }) ;

        static string ToNormalizedTitle(string value)
        {
            return CultureInfo.InvariantCulture.TextInfo.ToTitleCase(
                value.Replace(".md", "")
                    .Replace('-', ' '));
        }
    }
}
