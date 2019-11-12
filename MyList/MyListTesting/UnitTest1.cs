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

        [TestMethod]
           
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
        [TestMethod]
        public void Remove_ItemsShiftIndex_ItemsShiftIndexWhenSomethingIsRemoved()
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
        [TestMethod]
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
        [TestMethod]
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


        /////////////////////////////////////////////ToString Method tests below

        [TestMethod]
        public void ToString_AddingIntToList_GettingBackString()
        {
            //Arrange
            MyList<int> testList = new MyList<int>();
            string expected = "1";
            string actual;
            //Act
            testList.Add(1);
            actual = testList.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_AddingMultipleIntsToList_GettingBackAListOfString()
        {
            //Arrange
            MyList<int> testList = new MyList<int>();
            string expected = "1,2";
            string actual;
            //Act
            testList.Add(1);
            testList.Add(2);
            actual = testList.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ToString_AddingAStringToList_GettingAStringBack()
        {
            //Arrange
            MyList<string> testList = new MyList<string>();
            string expected = "1";
            string actual;
            //Act
            testList.Add("1");
            actual = testList.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_AddingBoolToList_GettingBoolResultInStringFormat()
        {
            //Arrange
            MyList<bool> testList = new MyList<bool>();
            string expected = "true";
            string actual;
            //Act
            testList.Add(true);
            actual = testList.ToString();


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Zip_ZipTwoListsTogether_GettingOneListWithTheContetntsOfBothList()
        {
            //Arrange
            MyList<int> listOne = new MyList<int>() { 1, 2, 3 };
            MyList<int> listTwo = new MyList<int>() { 4, 5, 6 };
            MyList<int> zipList = new MyList<int>();

            //Act
            zipList = MyList<int>.Zip(listOne, listTwo);

            //Assert
        }






    }
}
