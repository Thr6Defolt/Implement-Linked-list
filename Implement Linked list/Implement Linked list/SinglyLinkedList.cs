using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Implement_Linked_list
{
    public class SinglyLinkedList
    {
        public Node head;
        public void Add(int newData)
        {
            Node newNode = new Node(newData);
            Node current = head;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
            Console.WriteLine(newData + " added.");
        }
        public void Delete(int newData)
        {
            if (head != null)
            {
                if (head.data == newData)
                {
                    head = head.next;
                    Console.WriteLine(newData + " deleted.");
                }
                else
                {
                    Node current = head;
                    while (current.next != null && current.next.data != newData)
                    {
                        current = current.next;
                    }
                    if (current.next != null && current.next.data == newData)
                    {
                        current.next = current.next.next;
                        Console.WriteLine(newData + " deleted.");
                    }
                    else
                    {
                        Console.WriteLine(newData + " not found.");
                    }
                }
            }
            else
            {
                Console.WriteLine(newData + " not found.");
            }
        }
    }
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
