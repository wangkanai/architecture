// Copyright (c) 2014-2024 Sarin Na Wangkanai,All Rights Reserved.

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace Wangkanai.Architecture;

[SimpleJob(RuntimeMoniker.Net80)]
[RPlotExporter]
public class CollectionBenchmark
{
    const int N = 1000;

    [Benchmark]
    public void Array()
    {
        var array = new int[N];
        for (var i = 0; i < array.Length; i++)
            array[i] = i;
    }

    [Benchmark]
    public void List()
    {
        var list = new List<int>();
        for (var i = 0; i < N; i++)
            list.Add(i);
    }

    [Benchmark]
    public void Span()
    {
        var span = new Span<int>();
        for (var i = 0; i < N; i++)
            span.Fill(i);
    }
}