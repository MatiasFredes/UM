using System;
using Xunit;

namespace Structures.Test
{
    
    public class LinkedListTest
    {
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
    }
}
