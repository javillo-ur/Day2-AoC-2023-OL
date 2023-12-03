﻿Console.WriteLine(File.ReadAllLines("input.txt").Select(j => j.Split(":"))
    .Where(j => j[1].Split(";")
        .All(s => s.Split(",").Select(r => new { color = r.Split(" ").First(t => t == "red" || t == "blue" || t == "green"), number = int.Parse(r.Split(" ").First(part => int.TryParse(part, out _))) })
            .All(r => (r.color == "red" && r.number <= 12) || 
                      (r.color == "green" && r.number <= 13) || 
                      (r.color == "blue" && r.number <= 14))))
    .Sum(r => int.Parse(r[0][5..])));