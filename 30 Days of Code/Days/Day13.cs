namespace Days.Day13;
public static class Day13
{
    public static void Test()
    {
        MyBook b = new("The Alchemist", "Paulo Coelho", 248);
        b.display();
    }
    public abstract class Book
    {
        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();
    }

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
}