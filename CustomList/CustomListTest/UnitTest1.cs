using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
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
        [TestMethod]
        public void Iterate_IterateThroughIntList_IntListIterated()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>() { 1 };

            //Act
            custom.GetEnumerator();

            //Assert
            Assert.AreEqual(1, custom[0]);
        }
        [TestMethod]
        public void Iterate_IterateThroughStringList_StringListIterated()
        {
            //Arrange
            CustomList<string> custom = new CustomList<string>() { "dog", "cat" };

            //Act
            foreach (string value in custom)
            {
                custom[1].GetEnumerator();
            }

            //Assert
            Assert.AreEqual("cat", custom[1]);
        }
        [TestMethod]
        public void Display_DisplayInts_IntsDisplayedWithCommas()
        {
            //Arrange
            CustomList<int> custom = new CustomList<int>() { 1, 2 };

            //Act
            custom.ToString();

            //Assert
            Assert.AreEqual("1, 2, ", custom.ToString());
        }
        [TestMethod]
        public void Display_DisplayStrings_StringsDisplayedWithCommas()
        {
            //Arrange
            CustomList<string> custom = new CustomList<string>() { "dog", "cat", "bird" };

            //Act
            custom.ToString();

            //Assert
            Assert.AreEqual("dog, cat, bird, ", custom.ToString());
        }
        [TestMethod]
        public void AddLists_AddIntLists_IntListsAddedTogether()
        {
            //Arrange
            CustomList<int> custom1 = new CustomList<int>() { 1, 2 };
            CustomList<int> custom2 = new CustomList<int>() { 3, 4 };
            CustomList<int> custom3 = new CustomList<int>();

            //Act
            custom3 = custom1 + custom2;

            //Assert
            Assert.AreEqual(4, custom3.Count);
        }
        [TestMethod]
        public void AddLists_AddIntLists_IntListAddedToEnd()
        {
            //Arrange
            CustomList<int> custom1 = new CustomList<int>() { 1, 2 };
            CustomList<int> custom2 = new CustomList<int>() { 3, 4 };
            CustomList<int> custom3 = new CustomList<int>();

            //Act
            custom3 = custom1 + custom2;

            //Assert
            Assert.AreEqual(3, custom3[2]);
        }
        [TestMethod]
        public void AddLists_AddStringLists_StringListsAddedTogether()
        {
            //Arrange
            CustomList<string> custom1 = new CustomList<string>() { "one", "two" };
            CustomList<string> custom2 = new CustomList<string>() { "three", "four", "five" };
            CustomList<string> custom3 = new CustomList<string>();

            //Act
            custom3 = custom1 + custom2;

            //Assert
            Assert.AreEqual(5, custom3.Count);
        }
        [TestMethod]
        public void AddLists_AddStringLists_StringListAddedToEnd()
        {
            //Arrange
            CustomList<string> custom1 = new CustomList<string>() { "one", "two" };
            CustomList<string> custom2 = new CustomList<string>() { "three", "four", "five" };
            CustomList<string> custom3 = new CustomList<string>();

            //Act
            custom3 = custom1 + custom2;

            //Assert
            Assert.AreEqual("four", custom3[3]);
        }
        [TestMethod]
        public void RemoveList_RemoveIntList_IntListRemoved()
        {
            //Arrange
            CustomList<int> custom1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> custom2 = new CustomList<int>() { 1, 2, 3, 4 };

            //Act
            custom2 = custom2 - custom1;

            //Assert
            Assert.AreEqual(1, custom2.Count);
        }
        [TestMethod]
        public void RemoveList_RemoveStringList_StringListRemoved()
        {
            //Arrange
            CustomList<string> custom1 = new CustomList<string>() { "one", "two", "three" };
            CustomList<string> custom2 = new CustomList<string>() { "one", "two", "three", "four", "five" };

            //Act
            custom2 = custom2 - custom1;

            //Assert
            Assert.AreEqual(2, custom2.Count);
        }
        [TestMethod]
        public void ZipLists_ZipIntLists_IntListsZipped()
        {
            //Arrange
            CustomList<int> custom1 = new CustomList<int>() { 1, 2 };
            CustomList<int> custom2 = new CustomList<int>() { 3, 4 };
            CustomList<int> custom3 = new CustomList<int>();

            //Act
            custom3 = custom1.ZipperList(custom1, custom2);

            //Assert
            Assert.AreEqual(4, custom3.Count);
        }
        [TestMethod]
        public void ZipLists_ZipIntLists_IntAtCorrectIndex()
        {
            //Arrange
            CustomList<int> custom1 = new CustomList<int>() { 1, 2 };
            CustomList<int> custom2 = new CustomList<int>() { 3, 4 };
            CustomList<int> custom3 = new CustomList<int>();

            //Act
            custom3 = custom1.ZipperList(custom1, custom2);

            //Assert
            Assert.AreEqual(3, custom3[1]);
        }
        [TestMethod]
        public void ZipLists_ZipStringLists_StringListsZipped()
        {
            //Arrange
            CustomList<string> custom1 = new CustomList<string>() { "one", "two", "three" };
            CustomList<string> custom2 = new CustomList<string>() { "four", "five", "six" };
            CustomList<string> custom3 = new CustomList<string>();

            //Act
            custom3 = custom1.ZipperList(custom1, custom2);

            //Assert
            Assert.AreEqual(6, custom3.Count);
        }
        [TestMethod]
        public void ZipLists_ZipStringLists_StringAtCorrectIndex()
        {
            //Arrange
            CustomList<string> custom1 = new CustomList<string>() { "one", "two", "three" };
            CustomList<string> custom2 = new CustomList<string>() { "four", "five", "six" };
            CustomList<string> custom3 = new CustomList<string>();

            //Act
            custom3 = custom1.ZipperList(custom1, custom2);

            //Assert
            Assert.AreEqual("two", custom3[2]);
        }
    }
}
