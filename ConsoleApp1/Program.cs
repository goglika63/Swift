// 2. minSplit function
static int minSplit(int[] coins, int m, int amount)
{
    if (amount == 0) return 0;
    int result = int.MaxValue;
    for (int i = 0; i < m; i++)
    {
        if (coins[i] <= amount)
        {
            int sub_res = minSplit(coins, m,
                              amount - coins[i]);
            if (sub_res != int.MaxValue &&
                        sub_res + 1 < result)
                result = sub_res + 1;
        }
    }
    return result;
}
int[] coins = { 1, 5, 10, 20, 50 };
int m = coins.Length;
int amount = 101;
Console.WriteLine(minSplit(coins, m, amount));
