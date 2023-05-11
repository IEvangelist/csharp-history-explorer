// Copyright (c) David Pine. All rights reserved.
// Licensed under the MIT License.

namespace CSharp.HistoryExplorer.Models;

public readonly record struct SimpleVersion(byte Major, byte Minor = 0)
{
    public override string ToString() => $"{Major}.{Minor}";
}
