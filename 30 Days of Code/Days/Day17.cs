namespace _30_Days_of_Code.Days;

public static class Day17
{
    // Remove public modifier when pasting in HackerRank
    public class Calculator
    {
        // HackerRank expects power in lowercase.
        public int Power(int n, int p)
        {
            if (n < 0 || p < 0)
                throw new ArgumentException("n and p should be non-negative");
            return (int)Math.Pow(n, p);
        }
    }

    public static void Test()
    {
        Calculator c = new();
        Console.WriteLine(c.Power(3, 5));
        Console.WriteLine(c.Power(2, 4));
        try
        {
            Console.WriteLine(c.Power(-1, -2));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Console.WriteLine(c.Power(-1, 3));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}