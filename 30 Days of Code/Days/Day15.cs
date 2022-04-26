namespace _30_Days_of_Code.Days;

public static class Day15
{
    public class Node
    {
        public int data;
        public Node? next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    
    /*
     * This project uses Nullable, and C# 10. For this implementation work in HackerRank you have to:
     *                  - Change <is> to == and <is not> to !=
     *                  - Change <Node?> to <Node>
     *                  - <Insert> to <insert> (HackerRank does not follow C# code style)
     */
    public static Node Insert(Node? head, int data)
    {
        Node newNode = new(data);
        if (head is null)
            head = newNode;
        else
        {
            var iterator = head;
            while (iterator.next is not null)
            {
                iterator = iterator.next;
            }

            iterator.next = newNode;
        }

        return head;
    }
}