using System.Collections;
using System.Collections.Generic;
using Structures;
namespace Queue
{
         public class Queue<T> : IEnumerable<T>

    {
       private Structures.LinkedList<T> _queue;
        
        public Queue()
        {
           this._queue = new Structures.LinkedList<T>();
        }

        public int Count
        {
            get {return this._queue.Count;}
        }

        public void Enqueue(T value)
        {
            this._queue.Add(value);
        }

        public T Dequeue()
        {
            T value = this._queue.GetValue(0);
            this._queue.RemoveFirst();
            return value;
        }

        public void Clear()
        {
            this._queue.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this._queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
          return this.GetEnumerator();
        }
    }
}

