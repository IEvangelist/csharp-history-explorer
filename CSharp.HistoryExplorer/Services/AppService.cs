// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Services;

public sealed class AppService
{
    private readonly ConcurrentDictionary<Guid, Action<int, int>> s_callbackRegistry = new();
    private readonly IJSRuntime _runtime;

    private Action<bool>? _onPrefersDarkSchemeChanged;

    public AppService(IJSRuntime runtime) => _runtime = runtime;

    /// <summary>
    /// When the <c>window.onresize</c> event fires, the given
    /// <paramref name="onResized"/> callback is invoked.
    /// </summary>
    /// <returns>When successfully registered returns <c>true</c>, else <c>false</c>.</returns>
    internal bool OnWindowResized(Action<int, int> onResized)
    {
        var token = Guid.NewGuid();
        s_callbackRegistry[token] = onResized;

        return _runtime switch
        {
            IJSInProcessRuntime inProcessRuntime => inProcessRuntime.Invoke<bool>(
                "app.onWindowResized",
                DotNetObjectReference.Create(this),
                token,
                nameof(OnWindowResized)),

            _ => false
        };
    }

    [JSInvokable]
    public void OnWindowResized(string token, int width, int height)
    {
        if (Guid.TryParse(token, out var callbackKey) &&
            s_callbackRegistry.TryGetValue(callbackKey, out var callback))
        {
            callback.Invoke(width, height);
        }
    }

    /// <summary>
    /// When the <c>window.matchMedia('(prefers-color-scheme: dark)').onchange</c> event fires,
    /// the given <paramref name="onPrefersDarkSchemeChanged"/> will have its callback invoked.
    /// </summary>
    /// <returns>
    /// Returns <c>true</c> when the preferred scheme is <c>dark</c>, else <c>false</c>.
    /// </returns>
    internal bool OnPrefersDarkSchemeChanged(Action<bool> onPrefersDarkSchemeChanged)
    {
        _onPrefersDarkSchemeChanged = onPrefersDarkSchemeChanged;

        return _runtime switch
        {
            IJSInProcessRuntime inProcessRuntime => inProcessRuntime.Invoke<bool>(
                "app.onPrefersDarkSchemeChanged",
                DotNetObjectReference.Create(this),
                nameof(OnPrefersDarkSchemeChanged)),

            _ => false
        };
    }

    [JSInvokable]
    public void OnPrefersDarkSchemeChanged(bool prefersDarkScheme) =>
        _onPrefersDarkSchemeChanged?.Invoke(prefersDarkScheme);
}
