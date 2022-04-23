int n = Convert.ToInt32(Console.ReadLine());
Dictionary<string, int> phoneBook = new();
foreach (var i in Enumerable.Range(0, n))
{
    string? temp = Console.ReadLine();
    if(string.IsNullOrEmpty(temp)) return;
    string[] s = temp.Split(" ");
    string nombre = s[0];
    int numero;
    int.TryParse(s[1], out numero);
    phoneBook[nombre] = numero;
}

while (true)
{
    string? query = Console.ReadLine();
    if (string.IsNullOrEmpty(query)) break;

    if (phoneBook.ContainsKey(query))
        Console.WriteLine($"{query}={phoneBook[query]}");
    else
        Console.WriteLine("Not found");
}