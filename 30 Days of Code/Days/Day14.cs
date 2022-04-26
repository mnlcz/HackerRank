namespace _30_Days_of_Code.Days;

public static class Day14
{
    public class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] e)
        {
            elements = e;
        }

        public void computeDifference()
        {
            var low = elements.Min();
            var high = elements.Max();
            maximumDifference = high - low;
        }
    }

    public static void Test()
    {
        var a = new[] { 1, 2, 5 };
        Difference d = new(a);
        d.computeDifference();
        Console.WriteLine(d.maximumDifference);
    }
}