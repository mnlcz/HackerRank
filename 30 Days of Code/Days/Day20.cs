namespace _30_Days_of_Code.Days;

public static class Day20
{
    public static void Solution()
    {
        var a = new List<int> { 4, 3, 1, 2 };
        // Solution starts here    
        var numberOfSwaps = BubbleSort(a);
        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a.Last()}");
    }

    private static int BubbleSort(List<int> l)
    {
        var n = l.Count;
        var numberOfSwaps = 0;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n - 1; j++)
            {
                if (l[j] <= l[j + 1]) continue;
                // (l[j], l[j + 1]) = (l[j + 1], l[j]); // The C# version that HackerRank uses does not support this.
                // So I have to do it in the boring way:
                var temp = l[j];
                l[j] = l[j + 1];
                l[j + 1] = temp;
                numberOfSwaps++;
            }

            if (numberOfSwaps == 0) break;
        }

        return numberOfSwaps;
    }
}