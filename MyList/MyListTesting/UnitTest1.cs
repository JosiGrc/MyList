using System;
using MyList;
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

        [TestMethod]
        public void Add_IncreaseListSize_CapacitySizeDoubles()
        {
            //Arrange
            MyList<int> testList = new MyList<int>();
            int expected = 8;
            int actual;

            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);

        }
        //////////////////////////////////////////////////////////////////////Remove Method Tests Below

        public void Remove_RemoveTheFirstInstaceOfSomething_TheFirstInstanceOfSomethingBeingRemoved()
        {
            //Arrange
            MyList<int> testList = new MyList<int>();
            int expected = 3;
            int actual;

            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(4);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Remove_ItemsShiftIndex_IntemsShiftIndexWhenSomethingIsRemoved()
        {
            //Arrange
            MyList<int> testList = new MyList<int>();
            int expected = 3;
            int actual;

            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(4);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void Remove_RemovingMoreThanOneItem_MoreThanOneItemIsRemoved()
        {
            //Arrange
            MyList<int> testList = new MyList<int>();
            int expected = 2;
            int actual;

            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Remove(4);
            testList.Remove(3);
            actual = testList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void Remove_CapacitySizeDoesntChange_NoCapacityChangeAfterItemsBEingRemoved()
        {
            //Arrange
            MyList<int> testList = new MyList<int>();
            int expected = 8;
            int actual;

            //Act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Remove(5);
            actual = testList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
