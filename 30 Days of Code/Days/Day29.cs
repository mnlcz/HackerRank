namespace _30_Days_of_Code.Days;

public static class Day29
{
    public static int BitwiseAnd(int n, int k)
    {
        var set = Enumerable.Range(1, n).ToList();
        var max = int.MinValue;
        for (var i = 0; i < n - 1; i++)
            for (var j = i + 1; j < n; j++)
                if((set[i] & set[j]) < k && (set[i] & set[j]) > max)
                    max = (set[i] & set[j]);
        return max;
    }
}