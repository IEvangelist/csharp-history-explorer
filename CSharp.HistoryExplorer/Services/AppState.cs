// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Services;

public sealed class AppState
{
    private readonly ILocalStorageService _storage;

    private WindowSize? _windowSize;
    private OpenAI _openAI = OpenAI.Empty;
    private ThemePreference _systemTheme = ThemePreference.System;
    private ThemePreference? _userThemePreference;

    public AppState(ILocalStorageService storage) => _storage = storage;

    public WindowSize? WindowSize
    {
        get => _windowSize;
        set
        {
            if (_windowSize != value)
            {
                _windowSize = value;
                AppStateChanged();
            }
        }
    }

    public OpenAI OpenAISettings
    {
        get => _openAI;
        set
        {
            if (_openAI != value && value is not null)
            {
                _openAI = value;
                AppStateChanged();
            }
        }
    }

    public ThemePreference SystemTheme
    {
        get => _systemTheme;
        set
        {
            if (_systemTheme != value)
            {
                _systemTheme = value;
                AppStateChanged();
            }
        }
    }

    public ThemePreference UserThemePreference
    {
        get
        {
            if (_userThemePreference is null &&
                _storage.GetItem<ThemePreference>(
                    StorageKeys.ThemePreferenceKey) is ThemePreference preference)
            {
                _userThemePreference = preference;
            }

            return _userThemePreference ??= ThemePreference.System;
        }
        set
        {
            if (_userThemePreference != value)
            {
                _userThemePreference = value;
                _storage.SetItem(StorageKeys.ThemePreferenceKey, value);

                AppStateChanged();
            }
        }
    }

    public event Action? StateChanged;

    private void AppStateChanged() => StateChanged?.Invoke();
}
