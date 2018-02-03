using System;
using System.Collections;
using System.Collections.Generic;
using Structures;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
       private Structures.LinkedList<T> _stack;
        
        public Stack()
        {
           this._stack = new Structures.LinkedList<T>();
        }

        public int Count
        {
            get {return this._stack.Count;}
        }

        public void Push(T value)
        {
            this._stack.AddFirst(value);
        }

        public void Pop()
        {
            this._stack.RemoveFirst();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this._stack.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
          return this.GetEnumerator();
        }
    }
}
