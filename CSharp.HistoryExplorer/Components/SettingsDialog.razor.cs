// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Components;

public sealed partial class SettingsDialog
{
    [CascadingParameter] public required MudDialogInstance Dialog { get; set; }

    [Inject] public required AppState State { get; set; }

    private void Cancel() => Dialog.Cancel();

    private void Save()
    {
        // TODO: Save...

        Dialog.Close();
    }
}
