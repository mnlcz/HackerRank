namespace Days.Day7;
public static class Day7
{
    public static void Solution()
    {
        var list = new List<int> { 1, 2, 3, 4 };
        list.Reverse();
        var s = string.Join(',', list);
        Console.WriteLine($"[{s}]");
    }
}