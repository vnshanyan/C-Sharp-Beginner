``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.26100
Intel Core Ultra 7 155H, 1 CPU, 22 logical and 16 physical cores
.NET SDK=10.0.100-preview.3.25201.16
  [Host]     : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT
  Job-AIRQIO : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT

IterationCount=1  LaunchCount=1  WarmupCount=1  

```
|        Method | TotalCount |             Mean | Error |         Gen 0 |         Gen 1 |         Gen 2 |     Allocated |
|-------------- |----------- |-----------------:|------:|--------------:|--------------:|--------------:|--------------:|
|        **String** |       **1000** |       **166.153 μs** |    **NA** |      **306.3965** |        **6.1035** |             **-** |      **3,754 KB** |
| StringBuilder |       1000 |         5.437 μs |    NA |        1.3275 |        0.0381 |             - |         16 KB |
|        **String** |     **100000** | **9,081,985.700 μs** |    **NA** | **15181000.0000** | **15145000.0000** | **11715000.0000** | **56,551,663 KB** |
| StringBuilder |     100000 |     1,093.940 μs |    NA |      424.8047 |      424.8047 |      221.6797 |      2,315 KB |
