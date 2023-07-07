# 🤓 C# History Explorer

A simple app to explore each version of C#, along with each versions list of features. Currently, each feature is simply a link to the corresponding official Microsoft docs, however, I'd like to eventually expose each feature with RAG, see [Future work](#future-work).

Demo app: https://ievangelist.github.io/csharp-history-explorer

## Future work

- Add `Retrieval Augmented Generation (RAG)` for content.
  - Query static content, feed it into OpenAI prompt, then generate new explainations of each version.

Currently, the app has a cog (Settings) dialog in the upper-right-hand side of the screen. This dialog exposes to the ability to temporarily store an API key, corresponding Endpoint, and Deployment ID for use with the `Azure.AI.OpenAI` NuGet package. This will be used when performing the aforementioned RAG functionality.

![image](https://github.com/IEvangelist/csharp-history-explorer/assets/7679720/b6f7a957-4d6b-4cf7-9258-5357bc193653)
