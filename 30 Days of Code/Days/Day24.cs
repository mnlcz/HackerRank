namespace _30_Days_of_Code.Days;

public static class Day24
{
    // HR expects camelCase and nullable not enabled
    public static Node RemoveDuplicates(Node? head)
    {
        var nums = new HashSet<int>();
        if (head == null) return head;
        var iterator = head;
        nums.Add(head.data);
        while (iterator.next != null)
        {
            if (nums.Contains(iterator.next.data))
                iterator.next = iterator.next.next;
            else
            {
                nums.Add(iterator.next.data);
                iterator = iterator.next;
            }
        }

        return head;
    }

    // --------------------------------------------------------
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

    private static Node insert(Node? head, int data)
    {
        Node p = new Node(data);
        if (head == null)
            head = p;
        else if (head.next == null)
            head.next = p;
        else
        {
            Node start = head;
            while (start.next != null)
                start = start.next;
            start.next = p;
        }

        return head;
    }
}