using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        //Add method
        //When an item is added, it should be added to the end of the list
        //When an item is added, the item should be added without any changes
        //When an item is added, no other item is replaced or lost
        //When an item is added, Count should increase by 1

        [TestMethod]
        public void Add_AddInt_IntIsAdded()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int item = 5;

            //Act
            custom.Add(item);

            //Assert
            Assert.AreEqual(1, custom.Count);
        }
        [TestMethod]
        public void Add_AddTwoStrings_TwoStringsAdded()
        {
            //Arrange
            CustomList<string> custom = new CustomList<string>();
            string item1 = "dog";
            string item2 = "cat";

            //Act
            custom.Add(item1);
            custom.Add(item2);
            
            //Assert
            Assert.AreEqual(2, custom.Count);
        }
        [TestMethod]
        public void Add_AddInt_IntAddedToEnd()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>();
            int item = 5;

            //Act
            custom.Add(item);

            //Assert
            Assert.AreEqual(item, custom[0]);
        }
        [TestMethod]
        public void Add_AddStringToEnd_StringAddedToEnd()
        {
            //Arrange
            CustomList<string> custom = new CustomList<string>() { "cat" };
            string item = "dog";

            //Act
            custom.Add(item);

            //Assert
            Assert.AreEqual(item, custom[1]);
        }

        //Remove method
        //When an item is removed, count should decrease by 1
        //When an item is removed, no other items should be removed
        //If an item is removed from the middle, index of items after should decrease by 1 
        [TestMethod]
        public void Remove_RemoveString_CountIsCorrect()
        {
            //Arrange
            CustomList<string> custom = new CustomList<string>() { "dog", "cat" };

            //Act
            custom.Remove("dog");

            //Assert
            Assert.AreEqual(1, custom.Count);
        }
        [TestMethod]
        public void Remove_RemoveTwoIntItems_CountIsCorrect()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>() { 1, 2, 3 };

            //Act
            custom.Remove(1);
            custom.Remove(2);

            //Assert
            Assert.AreEqual(1, custom.Count);
        }
        [TestMethod]
        public void Remove_RemoveInt_IntIndexIsCorrect()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>() { 10, 20 };

            //Act
            custom.Remove(10);

            //Assert
            Assert.AreEqual(20, custom[0]);
        }
        [TestMethod]
        public void Remove_RemoveTwoStrings_StringIndexIsCorrect()
        {
            //Arrange
            CustomList<string> custom = new CustomList<string>() { "dog", "cat", "bird" };

            //Act
            custom.Remove("dog");
            custom.Remove("cat");

            //Assert
            Assert.AreEqual("bird", custom[0]);
        }
        [TestMethod]
        public void Remove_RemoveIntFromMiddle_IntIndexCorrect()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>() { 1, 2, 3 };

            //Act
            custom.Remove(2);

            //Assert
            Assert.AreEqual(3, custom[1]);
        }

        //Custom Iterator method
        //For each step through the list, one item is displayed
        //Iterates through entire list

        //[TestMethod]
        //public void Iterate_IterateInt_IntIsDisplayed()
        //{
        //    //Arrange
        //    CustomList<int> custom = new CustomList<int>() { 1 };

        //    //Act
        //    custom.GetEnumerator(1);

        //    //Assert
        //    Assert.AreEqual(1, custom[0]);
        //}
        //[TestMethod]
        //public void Iterate_IterateString_StringIsDisplayed()
        //{
        //    //Arrange
        //    CustomList<string> custom = new CustomList<string>() { "dog", "cat", "bird" };

        //    //Act
        //    custom.GetEnumerator("bird");

        //    //Assert
        //    Assert.AreEqual("bird", custom[2]);
        //}

        //ToString method
        //Each item is displayed with a comma after it

        [TestMethod]
        public void Display_DisplayInts_IntsDisplayedWithCommas()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>() { 1, 2 };

            //Act
            custom.ToString();

            //Assert
            Assert.AreEqual("1, 2, ", ToString());
        }


        //AddLists method
        //Each item in one list should be added to the end of the other list
        //No items from either list should be lost or changed
        [TestMethod]
        public void AddLists_AddTwoIntLists_ListsAreCombined()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int> { 1, 2 };
            CustomList<int> list2 = new CustomList<int> { 3, 4 };

            //Act


            //Assert
        }


    }
}
