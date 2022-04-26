namespace _30_Days_of_Code.Days;
public static class Day1
{
    public static void Solution()
    {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        
        int i2;
        double d2;
        string s2;
        i2 = Convert.ToInt32(Console.ReadLine());
        d2 = Convert.ToDouble(Console.ReadLine());
        s2 = Console.ReadLine();
        Console.WriteLine(i + i2);
        Console.WriteLine((d + d2).ToString("f1"));
        Console.WriteLine(s + s2);
    }
}