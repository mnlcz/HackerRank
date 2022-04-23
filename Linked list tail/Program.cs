﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode? next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode? head;

        public SinglyLinkedList()
        {
            this.head = null;
        }

    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
    {
        while (node != null)
        {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }

    // Complete the insertNodeAtTail function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
    {
        SinglyLinkedListNode temp = head;
        if (temp == null)
        {
            head = new SinglyLinkedListNode(data);
            return head;
        }
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = new SinglyLinkedListNode(data);
        return head;
    }

    static void Main(string[] args)
    {
        var llist = new SinglyLinkedList();
        llist.head = insertNodeAtTail(llist.head, 1);
        Console.WriteLine(llist.head.data);
        llist.head = insertNodeAtTail(llist.head, 2);
        Console.WriteLine(llist.head.next.data);

    }
}
