namespace _30_Days_of_Code.Days;

public static class Day18
{
    public class Solution
    {
        /*
         * The C# version used in HackerRank does not support new(). Change:
         *              - Stack<char> stack = new() to Stack<char> stack = new Stack<char>()
         *              - Queue<char> queue = new() to Queue<char> queue = new Queue<char>()
         */
        public Stack<char> stack = new();
        public Queue<char> queue = new();

        // HackerRank expects all methods in camelCase
        public void PushCharacter(char ch) => stack.Push(ch);
        public char PopCharacter() => stack.Pop();
        public void EnqueueCharacter(char ch) => queue.Enqueue(ch);
        public char DequeueCharacter() => queue.Dequeue();
    }
}