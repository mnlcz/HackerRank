namespace _30_Days_of_Code.Days;

/*
 * Remove all ! operators before pasting. HR does not support nullable.
 */
public static class Day25
{
    private static bool IsPrime(int n)
    {
        if (n == 1) return false;
        for (var i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }

    public static void Solution()
    {
        var n = int.Parse(Console.ReadLine()!);
        foreach (var i in Enumerable.Range(1, n))
        {
            var x = int.Parse(Console.ReadLine()!);
            Console.WriteLine(IsPrime(x) ? "Prime" : "Not prime");
        }
    }
}