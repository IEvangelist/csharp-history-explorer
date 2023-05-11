// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Components;

public sealed partial class FeatureDialog
{
    private bool _isLoading = true;
    private FeatureContent _content = default!;

    [Parameter] public required string Name { get; set; }
    [Parameter] public required SimpleVersion Version { get; set; }
    [Parameter] public required string Reference { get; set; }

    [CascadingParameter] public required MudDialogInstance Dialog { get; set; }

    [Inject] public required FeatureClient Client { get; set; }
    [Inject] public required IJSInProcessRuntime JavaScript { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        _content = await Client.GetFeatureContentAsync(
            new FeatureRequest(Name, Version), Reference);

        _isLoading = false;

        await base.OnParametersSetAsync();
    }

    protected override void OnAfterRender(bool firstRender) => JavaScript.InvokeVoid("highlight");

    private void OnCloseClick() => Dialog.Close();
}
