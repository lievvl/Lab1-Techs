``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1526 (21H1/May2021Update)
AMD Ryzen 7 5700U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT


```
|     Method |         Mean |     Error |    StdDev |    Gen 0 | Allocated |
|----------- |-------------:|----------:|----------:|---------:|----------:|
| SortBubble | 69,886.53 μs | 58.865 μs | 55.062 μs |        - |      48 B |
|    SortStd |     69.03 μs |  0.211 μs |  0.187 μs |        - |         - |
|  MergeSort |    310.83 μs |  2.273 μs |  2.015 μs | 377.9297 | 792,040 B |
