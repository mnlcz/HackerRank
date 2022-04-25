namespace Days.Day5;
public static class Day5
{
    public static void Solution()
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        for(int i = 1; i < 11; i++)
            Console.WriteLine($"{n} x {i} = {n * i}");
    }
}