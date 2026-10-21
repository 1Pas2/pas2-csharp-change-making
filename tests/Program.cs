using Pas2.ChangeMaking;

static void Check(bool condition, string message)
{
    if (!condition)
        throw new Exception(message);
}
static void Fails(Action action)
{
    try
    {
        action();
    }
    catch (Exception)
    {
        return;
    }
    throw new Exception("Expected failure");
}
var result = ChangeMaking.Solve(6, [1, 3, 4]);
Check(result is not null && result.Count == 2 && result.Sum() == 6, "non-greedy optimum");
Check(ChangeMaking.Solve(3, [2]) is null, "impossible");
Check(ChangeMaking.Solve(0, [])!.Count == 0, "zero");
Fails(() => ChangeMaking.Solve(2, [0]));
Fails(() => ChangeMaking.Solve(100001, [1]));
Console.WriteLine("All checks passed");
