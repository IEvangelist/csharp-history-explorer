// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Services;

public sealed class WindowService
{
    private readonly ConcurrentDictionary<Guid, Action<int, int>> s_callbackRegistry = new();
    private readonly IJSRuntime _runtime;

    public WindowService(IJSRuntime runtime) => _runtime = runtime;

    /// <summary>
    /// When the <c>window.onresize</c> event fires, the given
    /// <paramref name="component"/> will have its <paramref name="onResized"/>
    /// callback invoked.
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
}
