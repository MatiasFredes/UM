using System;

namespace DoublyLinkedList
{
    public class Node<T>
    {
         public Node(T value)
        {
           this.Value = value;
           this.Next = null;
           this.Previous = null;
        }

        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }
    }
}
