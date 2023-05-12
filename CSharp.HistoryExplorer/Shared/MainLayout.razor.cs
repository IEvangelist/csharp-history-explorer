// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Shared;

public sealed partial class MainLayout
{
    readonly MudTheme _theme = new();

    bool IsDarkTheme
    {
        get => LocalStorage.GetItem<bool>(StorageKeys.PrefersDarkThemeKey);
        set => LocalStorage.SetItem<bool>(StorageKeys.PrefersDarkThemeKey, value);
    }

    [Inject] public required IDialogService DialogService { get; set; }
    [Inject] public required ILocalStorageService LocalStorage { get; set; }
    [Inject] public required WindowService WindowService { get; set; }
    [Inject] public required ILogger<MainLayout> Logger { get; set; }
    [Inject] public required AppState State { get; set; }

    protected override void OnInitialized()
    {
        WindowService.OnWindowResized(
            (height, width) =>
                {
                    Logger.LogInformation(
                        "Window resized to {Height}x{Width}.",
                        height, width);

                    State.WindowSize = new(height, width);
                });

        base.OnInitialized();
    }

    void OnThemeChanged() => IsDarkTheme = !IsDarkTheme;
    void OnShowSettingsDialog() => DialogService.Show<SettingsDialog>();
}
