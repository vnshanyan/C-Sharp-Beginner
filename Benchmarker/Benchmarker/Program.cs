using BenchmarkDotNet.Running;

namespace Benchmarker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var summery = BenchmarkRunner.Run<StringBenchmarker>();
        }
    }
}
