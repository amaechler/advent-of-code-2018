using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Aoc2018Lib
{
    public static class Days
    {

        /// <summary>
        /// Part 2 of Day 1 because I couldn't figure it out in F#.
        /// </summary>
        public static void RunDay1() {
            var changesOfFrequency = File.ReadLines("../Aoc2018/input/day1.txt")
                .Select(l => int.Parse(l))
                .ToArray();
            
            var frequencies = new List<int>();
            for (int i = 0;; i++) {
                var currentFrequency = i == 0 ? 0 : frequencies.Last();
                var currentFrequencyChange = changesOfFrequency[i % changesOfFrequency.Length];

                var newFrequency = currentFrequency + currentFrequencyChange;

                if (frequencies.Contains(newFrequency)) {
                    Console.WriteLine($"Duplicate frequency {newFrequency}");
                    break;
                }

                frequencies.Add(newFrequency);
            }
        }

    }

}
