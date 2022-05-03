namespace _30_Days_of_Code.Days;

public static class Day21
{
    public static void PrintArray<T>(T[] a)
    {
        foreach (var i in a)
        {
            Console.WriteLine(i);
        }
    }

    public static void Test()
    {
        var nums = new[] { 1, 2, 3, 4, 5 };
        var words = new[] { "test1", "test2", "test3" };
        PrintArray(nums);
        PrintArray(words);
    }
}