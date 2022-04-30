namespace _30_Days_of_Code.Days;

public static class Day19
{
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }

    public class Calculator : AdvancedArithmetic
    {
        public int divisorSum(int n)
        {
            var sum = 0;
            for (var i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }

    public static void Test()
    {
        Calculator c = new();
        Console.WriteLine(c.divisorSum(25));
        Console.WriteLine(c.divisorSum(20));
    }
}