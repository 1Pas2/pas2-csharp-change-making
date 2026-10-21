using Pas2.ChangeMaking;

var result = ChangeMaking.Solve(6, [1, 3, 4]);
Console.WriteLine(result is null ? "impossible" : string.Join(",", result));
