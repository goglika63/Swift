// 1. Polindrome Function
static bool isPolindrome(string text)
{
    bool polindrome = true;
    for (int i = 0; i < text.Length - 1; i++)
    {
        int j = text.Length - 1 - i;
        if (text[i] != text[j])
        {
            polindrome = false;
        }
    }
    return polindrome;
}
if (isPolindrome("levan") == true)
{
    Console.WriteLine("The given text is polindrome");
}
else
{
    Console.WriteLine("The given text is not polindrome");
}

// 2. Coins
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

// 3. Array
int notContains(int[] array)
{
    var n = array.Length;
    for (var i = 0; i < n; ++i)
        while (array[i] > 0 && array[i] <= n && array[array[i] - 1] != array[i])
            Swap(i, array[i] - 1);

    for (var i = 0; i < n; ++i)
        if (array[i] != i + 1)
            return i + 1;

    return n + 1;

    void Swap(int i, int j)
    {
        var tmp = array[i];
        array[i] = array[j];
        array[j] = tmp;
    }
}
int[] array = { 1, 2, 3, 5, 6, -10 };
Console.WriteLine(notContains(array));

// 5.countWays
static int fib(int n)
{
    if (n <= 1)
        return n;
    return fib(n - 1) + fib(n - 2);
}
static int countWays(int s)
{
    return fib(s + 1);
}
int s = 4;
Console.WriteLine(countWays(s));



