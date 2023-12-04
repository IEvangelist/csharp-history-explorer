// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Shared;

public sealed partial class MainLayout : IDisposable
{
    readonly MudTheme _theme = new();

    bool IsDarkTheme { get; set; }

    string ThemeIcon => State.UserThemePreference switch
    {
        ThemePreference.Dark => Icons.Material.TwoTone.DarkMode,
        ThemePreference.Light => Icons.Material.TwoTone.LightMode,
        _ => Icons.Material.TwoTone.AutoMode,
    };

    string ThemeIconText => State.UserThemePreference switch
    {
        ThemePreference.Dark => "Switch to System Theme mode",
        ThemePreference.Light => "Switch to Dark Theme mode",
        _ => "Switch to Light Theme mode",
    };

    [Inject] public required IDialogService DialogService { get; set; }
    [Inject] public required ILocalStorageService LocalStorage { get; set; }
    [Inject] public required AppService AppService { get; set; }
    [Inject] public required ILogger<MainLayout> Logger { get; set; }
    [Inject] public required AppState State { get; set; }

    protected override void OnInitialized()
    {
        State.StateChanged += StateHasChanged;

        AppService.OnWindowResized(
            (height, width) =>
            {
                Logger.LogInformation(
                    "Window resized to {Height}x{Width}.",
                    height, width);

                State.WindowSize = new(height, width);
            });


        var prefersDarkScheme =
            AppService.OnPrefersDarkSchemeChanged(PrefersDarkSchemeHandler);

        PrefersDarkSchemeHandler(prefersDarkScheme);

        base.OnInitialized();
    }

    private void EvaluateIsDarkMode() =>
        IsDarkTheme = State.UserThemePreference switch
        {
            ThemePreference.Dark => true,
            ThemePreference.Light => false,
            _ => State.SystemTheme is ThemePreference.Dark
        };

    void PrefersDarkSchemeHandler(bool prefersDarkScheme)
    {
        Logger.LogInformation(
            "Prefers dark scheme: {Value}",
            prefersDarkScheme);

        State.SystemTheme = prefersDarkScheme
            ? ThemePreference.Dark
            : ThemePreference.Light;

        EvaluateIsDarkMode();
        StateHasChanged();
    }

    void OnToggleDarkMode()
    {
        switch (State.UserThemePreference)
        {
            case ThemePreference.System:
                State.UserThemePreference = ThemePreference.Light;
                IsDarkTheme = false;
                break;

            case ThemePreference.Light:
                State.UserThemePreference = ThemePreference.Dark;
                IsDarkTheme = true;
                break;

            case ThemePreference.Dark:
                State.UserThemePreference = ThemePreference.System;
                IsDarkTheme = State.SystemTheme is ThemePreference.Dark;
                break;
        }
    }

    public void Dispose() => State.StateChanged += StateHasChanged;
    void OnShowSettingsDialog() => DialogService.Show<SettingsDialog>();
}
