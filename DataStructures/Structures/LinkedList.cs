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

         /*
         You are given the pointer to the head node of a linked list and an integer to add to the list. 
         Create a new node with the given integer. 
         Insert this node at the tail of the linked list and return 
         the head node of the linked list formed after inserting this new node. 
         The given head pointer may be null, meaning that the initial list is empty.
        */
        private void AddLast(Node<T> node)
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

        private void AddFirst(Node<T> node)
        {
            if(Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
               node.Next = Head;
               Head = node;
            }

            Count++;
        }
        // 2) Insert a node at the tail of a linked list
        public void Add(T item)
        {
            this.AddLast(new Node<T>(item));
        }
        
        // 3) Insert a node at the head of a linked list
        public void AddFirst(T item)
        {
            this.AddFirst(new Node<T>(item));
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

        public T GetValue(int position)
        {
            Node<T> nodeAux = this.Head;
            int currentPosition = 0;
            

            while(nodeAux != null)
            {
                if(currentPosition == position)
                {
                    return nodeAux.Value;
                }
                nodeAux = nodeAux.Next;
                currentPosition++;
            }
            
            return default(T);
        }

        /*
          4) Insert a node at a specific position in a linked list
        */
        public void InsertAt(T value, int position)
        {
            Node<T> node = new Node<T>(value);

            Node<T> previous = this.Head;
            Node<T> nodeAux = this.Head;
            int currentPosition = 0;

           if(position > this.Count)
               throw new ArgumentOutOfRangeException();
           else
           {
               if(this.Head == null)
               {
                    this.Head = node;
                    this.Tail = node;
               }
               else
               {
                   while(nodeAux != null)
                   {
                       if(position == currentPosition)
                       {
                           previous.Next = nodeAux;
                           node.Next = nodeAux;
                           
                           break;
                       }
                       else
                       {
                           previous = nodeAux;
                           nodeAux = nodeAux.Next;
                           currentPosition++;
                       }
                   }
               }
                this.Count++;
           }

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

        public void RemoveFirst()
        {
            if(this.Count > 0)
            {
                this.Head = Head.Next;
                this.Count--;
            }
        }



        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
    
}