﻿using System;
using System.Collections;
using System.Collections.Generic;
using Structures;

namespace Stack
{
    public class Stack<T> : ICollection<T>
    {
        private Node<T> Head;
        private Structures.LinkedList<T> _stack;

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public Stack()
        {
            this.Head = null;
            this._stack = new 
        }

        public void Add(T item)
        {
           
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}