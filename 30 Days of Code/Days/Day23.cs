namespace _30_Days_of_Code.Days;

public static class Day23
{
    public class Node
    {
        public Node? left, right;
        public int data;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    // HR expects camelCase
    private static void LevelOrder(Node root)
    {
        var queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count != 0)
        {
            var current = queue.Dequeue();
            Console.Write(current.data + " ");
            if (current.left != null)
                queue.Enqueue(current.left);
            if (current.right != null)
                queue.Enqueue(current.right);
        }
    }

    public static void Test()
    {
        // Testing with Day22 data
        Node root = new(3);
        Node num1 = new(1);
        Node num2 = new(2);
        Node num4 = new(4);
        Node num5 = new(5);
        Node num6 = new(6);
        Node num7 = new(7);
        root.left = num2;
        root.right = num5;
        num2.left = num1;
        num5.left = num4;
        num5.right = num6;
        num6.right = num7;
        LevelOrder(root);
    }
}