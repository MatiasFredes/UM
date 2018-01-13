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
    }
}
