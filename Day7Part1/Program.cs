﻿Console.WriteLine(File.ReadAllLines("input.txt").Select(line => (long.Parse(line.Split(":")[0].Trim()), line.Split(":")[1].Trim().Split(" ").Select(t => long.Parse(t.Trim())).ToList())).AsParallel().Where(aux => Enumerable.Range(0, (int)Math.Pow(2, aux.Item2.Count-1)).Any(op => Enumerable.Range(0, aux.Item2.Count-1).Aggregate((System.Collections.Immutable.ImmutableList.ToImmutableList(aux.Item2.Skip(1)), aux.Item2[0]), (curr, it) => ((op >> it & 1) == 0) ? (System.Collections.Immutable.ImmutableList.ToImmutableList(curr.Item1.Skip(1)), curr.Item2 + curr.Item1[0]) : (System.Collections.Immutable.ImmutableList.ToImmutableList(curr.Item1.Skip(1)), curr.Item2 * curr.Item1[0])).Item2 == aux.Item1)).Sum(x => x.Item1));