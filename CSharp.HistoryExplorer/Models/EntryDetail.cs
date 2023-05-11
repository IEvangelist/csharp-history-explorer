// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Models;

public readonly record struct EntryDetail(
    string Text,
    string Name,
    string? Reference = null);