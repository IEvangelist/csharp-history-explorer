// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Services;

public sealed class FeatureClient
{
    private readonly HttpClient _client;
    private readonly IMemoryCache _cache;

    public FeatureClient(HttpClient client, IMemoryCache cache)
    {
        _client = client;
        _cache = cache;
    }

    public async Task<FeatureContent> GetFeatureContentAsync(FeatureRequest request, string reference)
    {
        var key = request.Key;
        var content = await _cache.GetOrCreateAsync(key, async _ =>
        {
            var markdown = await _client.GetStringAsync(key);
            var html = markdown.ToHtml();

            return new FeatureContent(html, reference);
        });

        return content ?? FeatureContent.Empty;
    }
}
