// Remove public modifier when pasting in HackerRank
namespace Day13;
public class MyBook : Book
{
    public readonly int price;
        
    public MyBook(string t, string a, int p) : base(t, a) 
    {
        price = p;
    }

    public override void display()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
}