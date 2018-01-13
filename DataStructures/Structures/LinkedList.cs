using System;
using System.Collections;
using System.Collections.Generic;

namespace Structures
{
    public class LinkedList<T> : ICollection<T>
    {
        public LinkedList()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Count { get; private set; }

        public bool IsReadOnly => throw new System.NotImplementedException();

        private void Add(Node<T> node)
        {
            if(Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
               Tail.Next = node;
               Tail = node;
            }

            Count++;
        }

        public void Add(T item)
        {
            this.Add(new Node<T>(item));
        }

        public void Clear()
        {
            this.Head = null;
            this.Tail = null;
            this.Count = 0;
        }

        public bool Contains(T item)
        {
            Node<T> node = this.Head;
            bool existsValue = false;
            if(node == null)
                existsValue = false;
            else
            {
                while(node != null)
                {
                    if(node.Value.Equals(item))
                    {
                        existsValue = true;
                        break;
                    }

                    else
                    {
                        node = node.Next;
                    }
                }
            } 

            return existsValue;   
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> node = this.Head;
            while(node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        public bool Remove(T item)
        {
             Node<T> node = this.Head;
             Node<T> previous = this.Head;
           
            if(node == null)
               throw new NullReferenceException();
            else
            {
                while(node != null)
                {
                    if(node.Value.Equals(item))
                    {
                        if(node == Head)
                        {
                            this.Head = this.Head.Next;
                            
                        }
                        if(node.Next == null)
                            this.Tail = previous;

                        previous.Next = node.Next;

                        this.Count--;
                        break;
                    }

                    else
                    {
                        previous = node;
                        node = node.Next;
                    }
                }
            } 

            return true;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
    
}