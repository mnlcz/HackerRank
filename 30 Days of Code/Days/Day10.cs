namespace _30_Days_of_Code.Days;
public static class Day10
{
    public static void Solution()
    {
        int n = Convert.ToInt32(Console.ReadLine()?.Trim());
        string binary = Convert.ToString(n, 2);
        Console.WriteLine(binary);
        int counter = 0;
        int max = Int32.MinValue;
        foreach (var c in binary)
        {
            if (c == '1')
                counter++;
            else
            {
                max = Math.Max(counter, max);
                counter = 0;
            }
        }
        max = Math.Max(counter, max);
        Console.WriteLine(max);
    }
}