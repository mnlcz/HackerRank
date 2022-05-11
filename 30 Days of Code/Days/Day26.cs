namespace _30_Days_of_Code.Days;

public static class Day26
{
    public static void Solution()
    {
        // Remove ! operators
        var tempActual = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
        var tempExpected = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
        var actual = new DateTime(tempActual[2], tempActual[1], tempActual[0]);
        var expected = new DateTime(tempExpected[2], tempExpected[1], tempExpected[0]);
        if(actual.Year < expected.Year) Console.WriteLine(0);
        else if (actual.Year > expected.Year) Console.WriteLine(10000);
        else if (actual.Month > expected.Month) Console.WriteLine(500 * (actual.Month - expected.Month));
        else if (actual.Day > expected.Day) Console.WriteLine(15 * (actual.Day - expected.Day));
        else Console.WriteLine(0);
    }
}