namespace Days.Day8;
public static class Day8
{
    public static void Solution()
    {
        int n = Int32.Parse(Console.ReadLine());
        Dictionary<string,string> phonebook = new();
        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            phonebook[line[0]] = line[1];
        }
        string name;
        while ((name = Console.ReadLine()) != null)
        {
            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine(name + "=" + phonebook[name]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}