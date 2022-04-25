using System.Linq.Expressions;

namespace Day12;
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
        if(average >= 90 && average <= 100) letter = 'O';
        else if(average >= 80 && average < 90) letter = 'E';
        else if(average >= 70 && average < 80) letter = 'A';
        else if(average >= 55 && average < 70) letter = 'P';
        else if(average >= 40 && average < 55) letter = 'D';
        else letter = 'T';
        return letter;
    }
}