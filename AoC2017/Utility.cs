using System;
using System.Collections.Generic;
using System.Linq;

namespace AoC2017
{
    class Utility
    {
        public static string ReadAllTextFromFile(string path)
        {
            return System.IO.File.ReadAllText(path);
        }

        public static string[] ReadAllLinesFromFile(string path)
        {
            return ReadAllTextFromFile(path).Split().Where(x => x.Length > 0).Select(x => x.Trim()).ToArray();
        }

        public static IEnumerable<T[]> GetPermutations<T>(T[] values)
        {
            if (values.Length == 1)
                return new[] { values };

            return values.SelectMany(v => GetPermutations(values.Except(new[] { v }).ToArray()),
                (v, p) => new[] { v }.Concat(p).ToArray());
        }
    }
}
