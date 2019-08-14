using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyListTesting
{
    [TestClass]
    public class MyListTest
    {
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            MyList<int> testList = new MyList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(1);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToListWithExistingItem_NewItemGoesToEndOfList()
        {
            // arrange
            MyList<int> testList = new MyList<int>();
            int expected = 2;
            int actual;

            // act
            testList.Add(1);
            testList.Add(2);
            actual = testList[1];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddToEmptyList_CountGoesToOne()
        {
            // arrange
            MyList<int> testList = new MyList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(10);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
