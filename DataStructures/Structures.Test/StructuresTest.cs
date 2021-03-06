using System;
using Queue;
using Stack;
using Xunit;


namespace Structures.Test
{
    
    public class StructuresTest
    {
        #region Linked list 
        [Fact]
        public void AddDecimalLinkedList_Add_AddOk()
        {
            LinkedList<decimal> decimals = new LinkedList<decimal>();
            decimals.Add(Convert.ToDecimal(9.89));
            decimals.Add(Convert.ToDecimal(9));

            Assert.NotNull(decimals);
            Assert.True(decimals.Count == 2);
        }

        [Fact]
        public void ClearList_Clear_ClearOk()
        {
            LinkedList<decimal> decimals = new LinkedList<decimal>();
            decimals.Add(Convert.ToDecimal(9.89));
            decimals.Add(Convert.ToDecimal(9));

            decimals.Clear();

            Assert.True(decimals.Count == 0);
        }

         [Fact]
        public void ContainList_Contain_ContainOk()
        {
            LinkedList<decimal> decimals = new LinkedList<decimal>();
            decimals.Add(9);
            bool result = decimals.Contains(9);

            Assert.True(result);
        }

        [Fact]

        public void ContainList_Contain_ContainFalse()
        {
            LinkedList<decimal> decimals = new LinkedList<decimal>();
            decimals.Add(9);
            bool result = decimals.Contains(8);

            Assert.True(!result);
        }

        /*
         1)  Given a pointer to the head node of a linked list, 
           print its elements in order, one element per line. 
           If the head pointer is null (indicating the list is empty), 
           don’t print anything.
        */
        [Fact]
        public void PrintElements()
        {
            LinkedList<int> elements = new LinkedList<int>();
            elements.Add(9);
            elements.Add(5);
            elements.Add(4);

            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }

        [Fact]
        public void AddFirst()
        {
            LinkedList<int> elements = new LinkedList<int>();
            elements.AddFirst(9);
            elements.AddFirst(5);
            elements.AddFirst(4);

            Assert.NotNull(elements);
            Assert.True(elements.Head.Value == 4);
            Assert.False(elements.Head.Value == 5);
            Assert.False(elements.Head.Value == 9);

        }

         [Fact]
        public void InsertAt_insertAtFirst()
        {
            LinkedList<int> elements = new LinkedList<int>();
            elements.InsertAt(9,0);

            Assert.NotNull(elements);
            Assert.True(elements.Count == 1);
            Assert.True(elements.Head.Value == 9);
            

        }
        [Fact]
         public void InsertAt_insertInMiddle()
        {
            LinkedList<int> elements = new LinkedList<int>();
            elements.Add(5);
            elements.Add(4);
            elements.Add(10);
            elements.InsertAt(9,1);
             
            int valueInserted = elements.GetValue(1);

            Assert.NotNull(elements);
            Assert.True(elements.Count == 4);
            Assert.True(valueInserted == 9);
        }

         [Fact]
         public void GetValue()
        {
            LinkedList<int> elements = new LinkedList<int>();
            elements.Add(5);
            elements.Add(4);
            elements.Add(10);
            elements.GetValue(1);
             
            int valueInserted = elements.GetValue(1);

            Assert.NotNull(elements);
            Assert.True(elements.Count == 3);
            Assert.True(valueInserted == 4);
        }

        [Fact]
         public void GetValue_GetFirst()
        {
            LinkedList<int> elements = new LinkedList<int>();
            elements.Add(5);
            elements.Add(4);
            elements.Add(10);
            
             
            int valueInserted = elements.GetValue(0);

            Assert.NotNull(elements);
            Assert.True(elements.Count == 3);
            Assert.True(valueInserted == 5);
        }

        [Fact]
         public void GetValue_GetLast()
        {
            LinkedList<int> elements = new LinkedList<int>();
            elements.Add(5);
            elements.Add(4);
            elements.Add(10);
            
             
            int valueInserted = elements.GetValue(2);

            Assert.NotNull(elements);
            Assert.True(elements.Count == 3);
            Assert.True(valueInserted == 10);
        }    
        #endregion
        #region Doubly Linked List
        [Fact]
        public void AddLinkedList_AddLast_AddOk()
        {
            DoublyLinkedList.LinkedList<int> numbers = new DoublyLinkedList.LinkedList<int>();
            numbers.Add(4);

            Assert.NotNull(numbers);
            Assert.True(numbers.Count == 1);
        }

         [Fact]
        public void AddLinkedList_AddLast_AddOk2()
        {
            DoublyLinkedList.LinkedList<int> numbers = new DoublyLinkedList.LinkedList<int>();
            numbers.Add(4);
            numbers.Add(5);

            int first = numbers.GetValue(0);
            int second = numbers.GetValue(1);

            int expectedFirst = 4;
            int expectedSecond = 5;

            Assert.NotNull(numbers);
            Assert.True(first == expectedFirst);
            Assert.True(second == expectedSecond);
            Assert.True(numbers.Count == 2);
        }
        #endregion
        #region Stack
        [Fact]
        public void PushElement_Push_AddElementOnTop()
        {
           Stack<int> stack = new Stack<int>();
           stack.Push(2);

           Assert.NotNull(stack);
           Assert.Equal(stack.Count,1);
        }

         [Fact]
        public void PushElement_Push_VerifyOrder()
        {
           Stack<int> stack = new Stack<int>();
           stack.Push(2);
           stack.Push(4);
           Stack<int> expected = new Stack<int>();
           Assert.NotNull(stack);
           Assert.Equal(stack,expected);

           
        }
        #endregion
        #region Queue
        [Fact]
        public void EnqueueElement()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Assert.NotNull(queue);
            Assert.True(queue.Count == 3);
            
        }

        [Fact]
        public void DequeueElement()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Assert.NotNull(queue);
            Assert.True(queue.Count == 3);

            int firstValue = queue.Dequeue();
            Assert.True(firstValue == 10);

            int secondValue = queue.Dequeue();
            Assert.True(secondValue == 20);
            
            int thirdValue = queue.Dequeue();
            Assert.True(thirdValue == 30);
        }       
        #endregion
    }
}
