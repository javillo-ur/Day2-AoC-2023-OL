﻿Console.WriteLine(File.ReadAllLines("input.txt").Select(j => j.Split(":")[1])
    .Select(j => j.Split(";").SelectMany(r => r.Split(",")))
    .Sum(j => j.Where(r => r.Split(" ").Any(t => t == "red")).Max(r => int.Parse(r.Split(" ").First(k => int.TryParse(k, out _)))) *
              j.Where(r => r.Split(" ").Any(t => t == "blue")).Max(r => int.Parse(r.Split(" ").First(k => int.TryParse(k, out _)))) *
              j.Where(r => r.Split(" ").Any(t => t == "green")).Max(r => int.Parse(r.Split(" ").First(k => int.TryParse(k, out _))))));