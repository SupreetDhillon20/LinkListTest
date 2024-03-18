using System.Collections;
using System.Collections.Generic;
using MyList;
using NUnit.Framework;

namespace LinkListTest
{
    
    [TestFixture]
    public class LinkListTest
    {
 
        [Test]
        public void TestAddFirst()
        {
            // Arrange
            LinkList list = new LinkList();

            // Act
            list.AddTheFirst("Joe Blow");

            // Assert
            Assert.AreEqual("Joe Blow", list.Head?.Data);
            Assert.AreEqual(1, list.counter);
        }

        [Test]
        public void TestAddLast()
        {
            // Arrange
            LinkList list = new LinkList();

            // Act
            list.AddTheLast("Joe Blow");

            // Assert
            Assert.AreEqual("Joe Blow", list.Tail?.Data);
            Assert.AreEqual(1, list.counter);
        }

        [Test]
        public void TestRemoveFirst()
        {
            // Arrange
            LinkList list = new LinkList();
            list.AddTheFirst("Joe Blow");

            // Act
            list.RemoveFirst();

            // Assert
            Assert.IsNull(list.Head);
            Assert.IsNull(list.Tail);
            Assert.AreEqual(0, list.counter);
        }

        [Test]
        public void TestRemoveLast()
        {
            // Arrange
            LinkList list = new LinkList();
            list.AddTheLast("Joe Blow");

            // Act
            list.RemoveLast();

            // Assert
            Assert.IsNull(list.Head);
            Assert.IsNull(list.Tail);
            Assert.AreEqual(0, list.counter);
        }

        [Test]
        public void TestGetValue()
        {
            // Arrange
            LinkList list = new LinkList();
            list.AddTheFirst("Joe Blow");
            list.AddTheLast("Joe Schmoe");

            // Act
            string value = list.GetValue(1);

            // Assert
            Assert.AreEqual("Joe Schmoe", value);
        }

        [Test]
        public void TestSize()
        {
            // Arrange
            LinkList list = new LinkList();
            list.AddTheFirst("Joe Blow");
            list.AddTheLast("Joe Schmoe");

            // Act
            int size = list.counter;

            // Assert
            Assert.AreEqual(2, size);
        }
    }
}