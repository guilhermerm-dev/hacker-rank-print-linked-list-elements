using System;

namespace hackar_rank_print_the_elements_of_a_linked_list_solution
{
    class Program
    {
        static void Main()
        {
            SinglyLinkedListNode next = new SinglyLinkedListNode(13, null);
            SinglyLinkedListNode root = new SinglyLinkedListNode(16, next);
            PrintLinkedList(root);
        }

        private static void PrintLinkedList(SinglyLinkedListNode root)
        {
            if(root is not null)
            {
                Console.WriteLine(root.Data);
                PrintLinkedList(root.Next);
            }
        }
    }

    class SinglyLinkedListNode {

        public int Data;
        public SinglyLinkedListNode Next;

        public SinglyLinkedListNode(int data, SinglyLinkedListNode next)
        {
            this.Data = data;
            this.Next = next;
        }
    }
}
