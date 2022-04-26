namespace _30_Days_of_Code.Days;
public static class Day3
{
    public static void Solution()
    {
        int N = Convert.ToInt32(Console.ReadLine().Trim());
        if (N % 2 == 0)
        {
            if (N >= 2 && N <= 5)
                Console.WriteLine("Not Weird");
            else if (N >= 6 && N <= 20)
                Console.WriteLine("Weird");
            else if (N > 20)
                Console.WriteLine("Not Weird");
        }
        else
            Console.WriteLine("Weird");
    }
}