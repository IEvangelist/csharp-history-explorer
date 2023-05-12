// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Services;

public sealed class AppState
{
    private WindowSize? _windowSize;
    private OpenAI _openAI = OpenAI.Empty;

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

    public event Action? StateChanged;

    private void AppStateChanged() => StateChanged?.Invoke();
}
