using System.Collections.Generic;

namespace Implement_Linked_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList list = new SinglyLinkedList();
            list.Add(5);
            list.Add(8);
            list.Add(9);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Delete(2);
            list.Delete(5);
            list.Delete(1);
            list.Delete(3);
            list.Delete(4);


        }
    }
}