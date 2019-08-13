using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyListTesting
{
    [TestClass]
    public class MyListTest
    {
        [TestMethod]
        public void Add_AddTomEmptyList_ItemMovesToIndexZero()
        {
            //Arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            //Act
            testList.Add(1);
            actual = testList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
