namespace _30_Days_of_Code.Days;

public static class Day16
{
    public static void Solution()
    {
        /*
         * This project uses Nullable. When pasting the solution in HackerRank editor remove the <!> operator.
         */
        var s = Console.ReadLine()!;
        try
        {
            var n = int.Parse(s);
            Console.WriteLine(n);
        }
        catch (Exception)
        {
            Console.WriteLine("Bad String");
        }
    }
}