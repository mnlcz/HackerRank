using System.Text.RegularExpressions;

namespace _30_Days_of_Code.Days;
public static class Day28
{
    public static void Solution()
    {
        // Remove ! before running in HR 
        var n = Convert.ToInt32(Console.ReadLine()!.Trim());
        var names = new List<string>();

        for (var nItr = 0; nItr < n; nItr++)
        {
            // Remove ! before running in HR 
            var firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');
            var firstName = firstMultipleInput[0];
            var emailId = firstMultipleInput[1];
            if (Regex.IsMatch(emailId, @".+@gmail\.com$"))
                names.Add(firstName);
        }

        names.Sort();
        names.ForEach(Console.WriteLine);
    }
}