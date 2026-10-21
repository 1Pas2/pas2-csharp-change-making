namespace Pas2.ChangeMaking;

public static class ChangeMaking
{
    public static IReadOnlyList<int>? Solve(int amount, IEnumerable<int> denominations)
    {
        if (amount < 0 || amount > 100000)
            throw new ArgumentOutOfRangeException(nameof(amount));
        ArgumentNullException.ThrowIfNull(denominations);
        var coins = denominations.Distinct().OrderBy(x => x).ToArray();
        if (coins.Any(x => x <= 0))
            throw new ArgumentException("Positive denominations required");
        int[] count = new int[amount + 1],
            last = new int[amount + 1];
        Array.Fill(count, int.MaxValue);
        count[0] = 0;
        for (int sum = 1; sum <= amount; sum++)
        {
            foreach (int coin in coins)
            {
                if (coin > sum)
                    break;
                if (count[sum - coin] != int.MaxValue && count[sum - coin] + 1 < count[sum])
                {
                    count[sum] = count[sum - coin] + 1;
                    last[sum] = coin;
                }
            }
        }
        if (count[amount] == int.MaxValue)
            return null;
        var result = new List<int>();
        for (int remaining = amount; remaining > 0; remaining -= last[remaining])
            result.Add(last[remaining]);
        return result;
    }
}
