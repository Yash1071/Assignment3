using Assignment3;
using Assignment3.Utility;
using NUnit.Framework;
using System;
using System.Collections.Generic;

[TestFixture]
public class LinkedListTests
{
    private SLL users;

    [SetUp]
    public void Setup()
    {
        users = new SLL();
    }

    [Test]
    public void AddFirst_ShouldAddNodeToBeginningOfList()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        users.AddFirst(obj1);
        users.AddFirst(obj2);
        Assert.AreEqual(2, users.Count());
        Assert.AreEqual(obj2.Id, users.GetValue(0).Id);
        Assert.AreEqual(obj2.Name, users.GetValue(0).Name);
        Assert.AreEqual(obj2.Email, users.GetValue(0).Email);
        Assert.AreEqual(obj2.Password, users.GetValue(0).Password);

        Assert.AreEqual(obj1.Id, users.GetValue(1).Id);
        Assert.AreEqual(obj1.Name, users.GetValue(1).Name);
        Assert.AreEqual(obj1.Email, users.GetValue(1).Email);
        Assert.AreEqual(obj1.Password, users.GetValue(1).Password);
    }

    [Test]
    public void AddLast_ShouldAddNodeToEndOfList()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        users.AddLast(obj1);
        users.AddLast(obj2);
        Assert.AreEqual(2, users.Count());
        Assert.AreEqual(obj1.Id, users.GetValue(0).Id);
        Assert.AreEqual(obj1.Name, users.GetValue(0).Name);
        Assert.AreEqual(obj1.Email, users.GetValue(0).Email);
        Assert.AreEqual(obj1.Password, users.GetValue(0).Password);

        Assert.AreEqual(obj2.Id, users.GetValue(1).Id);
        Assert.AreEqual(obj2.Name, users.GetValue(1).Name);
        Assert.AreEqual(obj2.Email, users.GetValue(1).Email);
        Assert.AreEqual(obj2.Password, users.GetValue(1).Password);
    }

    [Test]
    public void RemoveFirst_ShouldRemoveFirstNode()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        users.AddLast(obj1);
        users.AddLast(obj2);
        users.RemoveFirst();

        Assert.AreEqual(1, users.Count());
        Assert.AreEqual(obj2.Id, users.GetValue(0).Id);
        Assert.AreEqual(obj2.Name, users.GetValue(0).Name);
        Assert.AreEqual(obj2.Email, users.GetValue(0).Email);
        Assert.AreEqual(obj2.Password, users.GetValue(0).Password);
    }

    [Test]
    public void RemoveLast_ShouldRemoveLastNode()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        users.AddLast(obj1);
        users.AddLast(obj2);
        users.RemoveLast();

        Assert.AreEqual(1, users.Count());
        Assert.AreEqual(obj1.Id, users.GetValue(0).Id);
        Assert.AreEqual(obj1.Name, users.GetValue(0).Name);
        Assert.AreEqual(obj1.Email, users.GetValue(0).Email);
        Assert.AreEqual(obj1.Password, users.GetValue(0).Password);
    }

    [Test]
    public void GetValue_ShouldRetrieveValueAtGivenIndex()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        User obj3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
        users.AddLast(obj1);
        users.AddLast(obj2);
        users.AddLast(obj3);

        Assert.AreEqual(obj2.Id, users.GetValue(1).Id);
        Assert.AreEqual(obj2.Name, users.GetValue(1).Name);
        Assert.AreEqual(obj2.Email, users.GetValue(1).Email);
        Assert.AreEqual(obj2.Password, users.GetValue(1).Password);
    }

    [Test]
    public void Count_ShouldReturnCorrectSize()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        User obj3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
        User obj4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");
        User obj5 = new User(5, "Mickey Mouse", "mickey.mouse@disney.com", "disney123");
        User obj6 = new User(6, "Donald Duck", "donald.duck@disney.com", "duck1234");
        
        users.AddLast(obj1);
        users.AddLast(obj2);
        users.AddLast(obj3);
        users.AddLast(obj4);
        users.AddLast(obj5);
        users.AddLast(obj6);
        Assert.AreEqual(6, users.Count());
    }

    [Test]
    public void RemoveFirst_Emptyusers_ShouldThrowException()
    {
        Assert.Throws<InvalidOperationException>(() => users.RemoveFirst());
    }

    [Test]
    public void RemoveLast_Emptyusers_ShouldThrowException()
    {
        Assert.Throws<InvalidOperationException>(() => users.RemoveLast());
    }

    [Test]
    public void GetValue_InvalidIndex_ShouldThrowException()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        users.AddLast(obj1);
        Assert.Throws<IndexOutOfRangeException>(() => users.GetValue(-1));
        Assert.Throws<IndexOutOfRangeException>(() => users.GetValue(1));
    }
    [Test]
    public void InsertAt_ShouldInsertItemInMiddle()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        User obj3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
        User obj4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");
        User obj5 = new User(5, "Mickey Mouse", "mickey.mouse@disney.com", "disney123");
        User obj6 = new User(6, "Donald Duck", "donald.duck@disney.com", "duck1234");

        users.AddLast(obj1);
        users.AddLast(obj2);
        users.AddLast(obj3);
        users.AddLast(obj5);  
        users.AddLast(obj6);

        users.Add(obj4, 3);  // Insert obj4 at index 3 (middle of the list)

        Assert.AreEqual(6, users.Count());
        Assert.AreEqual(obj4, users.GetValue(3));  // Ensure obj4 is at the correct position
    }
    [Test]
    public void Replace_ShouldReplaceItemAtIndex()
    {
        // Arrange
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        User obj3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
        User obj4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");
        User obj5 = new User(5, "Mickey Mouse", "mickey.mouse@disney.com", "disney123");
        User obj6 = new User(6, "Donald Duck", "donald.duck@disney.com", "duck1234");

        users.AddLast(obj1);
        users.AddLast(obj2);
        users.AddLast(obj3);
        users.AddLast(obj4);
        users.AddLast(obj5);

        users.Replace(obj6, 2);  

        Assert.AreEqual(5, users.Count());  // Ensure the list size is unchanged
        Assert.AreEqual(obj6, users.GetValue(2));  // Ensure obj6 is at the correct position
    }
    [Test]
    public void Remove_ShouldRemoveItemAtIndex()
    {
        // Arrange
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        User obj3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");

        users.AddLast(obj1);
        users.AddLast(obj2);
        users.AddLast(obj3);

        users.Remove(1);  

        Assert.AreEqual(2, users.Count());  // Ensure the list size is reduced
        Assert.AreEqual(obj3, users.GetValue(1));  // Ensure obj3 is now at index 1
    }

    [Test]
    public void Remove_ShouldThrowIndexOutOfRangeExceptionForNegativeIndex()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        users.AddLast(obj1);

        Assert.Throws<IndexOutOfRangeException>(() => users.Remove(-1));
    }

    [Test]
    public void Remove_ShouldThrowInvalidOperationExceptionForEmptyList()
    {
        Assert.Throws<InvalidOperationException>(() => users.Remove(0));
    }

    [Test]
    public void Remove_ShouldThrowIndexOutOfRangeExceptionForIndexOutOfBounds()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        users.AddLast(obj1);
        users.AddLast(obj2);

        Assert.Throws<IndexOutOfRangeException>(() => users.Remove(5));
    }

    [Test]
    public void Remove_ShouldRemoveFirstItem()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        User obj3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");

        users.AddLast(obj1);
        users.AddLast(obj2);
        users.AddLast(obj3);

        users.Remove(0);  // Remove the first user (obj1)

        Assert.AreEqual(2, users.Count());  // Ensure the list size is reduced
        Assert.AreEqual(obj2, users.GetValue(0));  // Ensure obj2 is now at index 0
    }
    public void IndexOf_ShouldReturnCorrectIndex_WhenUserExists()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        User obj3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
        User obj4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");

        users.AddLast(obj1);
        users.AddLast(obj2);
        users.AddLast(obj3);
        users.AddLast(obj4);

        int index = users.IndexOf(obj3);  

        Assert.AreEqual(2, index); 
    }

    [Test]
    public void IndexOf_ShouldReturnNegativeOne_WhenUserDoesNotExist()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        User obj3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
        User obj4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");

        users.AddLast(obj1);
        users.AddLast(obj2);
        users.AddLast(obj3);

        int index = users.IndexOf(obj4);  

        Assert.AreEqual(-1, index);  
    }
    [Test]
    public void Reverse_ShouldReverseTheOrderOfElements()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");
        User obj3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");

        users.AddLast(obj1);
        users.AddLast(obj2);
        users.AddLast(obj3);

        users.Reverse();

        Assert.AreEqual(obj3, users.GetValue(0));
        Assert.AreEqual(obj2, users.GetValue(1));
        Assert.AreEqual(obj1, users.GetValue(2));
    }
    [Test]
    public void Join_ShouldConcatenateTwoLists()
    {
        User obj1 = new User(1, "Joe Blow", "jblow@gmail.com", "password");
        User obj2 = new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef");

        users.AddLast(obj1);
        users.AddLast(obj2);

        SLL otherList = new SLL();
        User obj3 = new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555");
        User obj4 = new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999");

        otherList.AddLast(obj3);
        otherList.AddLast(obj4);

        users.Join(otherList);

        Assert.AreEqual(4, users.Count());
        Assert.AreEqual(obj1, users.GetValue(0));
        Assert.AreEqual(obj2, users.GetValue(1));
        Assert.AreEqual(obj3, users.GetValue(2));
        Assert.AreEqual(obj4, users.GetValue(3));
    }

}