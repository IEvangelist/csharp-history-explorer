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

    [Inject] public required ILocalStorageService LocalStorage { get; set; }

    void OnThemeChanged() => IsDarkTheme = !IsDarkTheme;
}
