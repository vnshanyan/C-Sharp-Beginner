﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Benchmarker
{
    [MemoryDiagnoser]
    [SimpleJob(launchCount: 1, warmupCount: 1, targetCount: 1)]
    public class StringBenchmarker
    {
        [Params(1000, 100000)]
        public int TotalCount { get; set; }

        [Benchmark(Description = "String")]
        public void TestString()
        {
            string value = "";
            for (int i = 0; i < TotalCount; i++)
            {
                value += "a" + i;
            }

            string result = value;
        }

        [Benchmark(Description = "StringBuilder")]
        public void TestStringBuilder()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < TotalCount; i++)
            {
                builder.Append('a').Append(i);
            }

            string result = builder.ToString();
        }
    }
}
