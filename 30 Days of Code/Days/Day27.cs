namespace _30_Days_of_Code.Days;

/*
 * 10 MAY 2022: HACKERRANK DOES NOT ACCEPT A C# SOLUTION FOR THIS PROBLEM.
 * At the end of this file there is a C++ implementation that HR accepts
 */

public static class Day27
{
    private static class TestDataEmptyArray
    {
        public static int[] GetArray() => Array.Empty<int>();
    }

    private static class TestDataUniqueValues
    {
        private static readonly int[] Arr = new[] { 1, 2, 3, 4, 5 };
        public static int[] GetArray() => Arr;
        public static int GetExpectedResult() => Array.IndexOf(Arr, Arr.Min());
    }

    private static class TestDataExactlyTwoDifferentMinimums
    {
        private static readonly int[] Arr = new[] { 1, 2, 1, 3, 4, 5, 6 };
        public static int[] GetArray() => Arr;
        public static int GetExpectedResult() => Array.IndexOf(Arr, Arr.Min());
    }
}

//----------------------------------------------------------------------------
/*
 * C++ IMPLEMENTATION
 */
//----------------------------------------------------------------------------

/*
class TestDataEmptyArray
{
public:
    static vector<int> get_array()
    {
        return vector<int>{};
    }
};

class TestDataUniqueValues
{
public:
    static vector<int> get_array()
    {
        return vector<int>{1, 2, 3, 4, 5};
    }
    
    static int get_expected_result()
    {
        auto arr = get_array();
        return distance(arr.begin(), min_element(arr.begin(), arr.end()));
    }
};

class TestDataExactlyTwoDifferentMinimums
{
public:
    static vector<int> get_array()
    {
        return vector<int>{1, 2, 1, 3, 4, 5, 6};
    }
    static int get_expected_result()
    {
        auto arr = get_array();
        return distance(arr.begin(), min_element(arr.begin(), arr.end()));
    }
};
*/