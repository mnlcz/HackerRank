static int HourGlassSum(in List<List<int>> matrix)
{
    int max = Int32.MinValue;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            int sum = (matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2] + matrix[i + 1][j + 1] + matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2]);
            max = sum > max ? sum : max;
        }
    }
    return max;
}

List<List<int>> arr = new();

for (int i = 0; i < 6; i++)
{
    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
}

Console.WriteLine(HourGlassSum(arr));