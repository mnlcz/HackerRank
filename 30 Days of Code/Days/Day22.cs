namespace _30_Days_of_Code.Days;

public static class Day22
{
    // Remove the ? operator when pasting in HackerRank
    private static int getHeight(Node? root)
    {
        if (root == null) return -1;
        return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
    }

    private class Node
    {
        public Node? left, right;
        public int data;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    public static void Test()
    {
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
        Console.WriteLine(getHeight(root));
    }
}