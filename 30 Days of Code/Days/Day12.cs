namespace _30_Days_of_Code.Days;
public static class Day12
{
    public static void Test()
    {
        Student s = new("Sancho", "Panza", 4847677, new int[] { 41, 42, 43, 44, 45, 46, 48 });
        s.printPerson();
        Console.WriteLine($"Grade: {s.Calculate()}");
    }
    public class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }

        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    public class Student : Person
    {
        private int[] testScores;

        public Student(string firstName, string lastName, int id, int[] scores) : base(firstName, lastName, id)
        {
            testScores = scores;
        }

        public char Calculate()
        {
            var sum = testScores.Sum();
            var average = sum / testScores.Length;
            char letter;
            if (average >= 90 && average <= 100) letter = 'O';
            else if (average >= 80 && average < 90) letter = 'E';
            else if (average >= 70 && average < 80) letter = 'A';
            else if (average >= 55 && average < 70) letter = 'P';
            else if (average >= 40 && average < 55) letter = 'D';
            else letter = 'T';
            return letter;
        }
    }
}