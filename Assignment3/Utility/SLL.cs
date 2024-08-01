using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Utility
{
    [DataContract]
    public class SLL: ILinkedListADT
    {
        [DataMember]
        private Node head;
        public SLL(Node head)
        {
            this.head = head;
        }
        public SLL()
        {
            this.head = null;
        }
        public bool IsEmpty()
        {
            return this.head == null;
        }
        public void Clear()
        {
            Node curr = this.head;
            while (curr != null)
            {
                Node next = curr.next;
                curr.next = null;
                curr = next;
            }
        }
        public void AddLast(User value)
        {
            Node newNode = new Node(value);
            if (IsEmpty())
            {
                this.head = newNode;
                return;
            }
            Node curr = this.head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = newNode;
        }
        public void AddFirst(User value)
        {
            Node newNode = new Node(value);
            if (IsEmpty())
            {
                this.head = newNode;
                return;
            }
            newNode.next = this.head;
            this.head = newNode;
        }
        public void Add(User value, int index)
        {
            if(index < 0)
            {
                throw new IndexOutOfRangeException("Can not insert the element at negative index");
            }
            if(index == 0)
            {
                AddFirst(value);
                return;
            }
            Node newNode = new Node(value);
            Node curr = this.head;
            int i = 0;
            while(curr != null && i < index-1)
            {
                curr = curr.next;
                i += 1;
            }
            if(curr == null)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            newNode.next = curr.next;
            curr.next = newNode;
        }
        public void Replace(User value, int index)
        {
            Node curr = this.head;
            int i = 0;
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Can not insert the element at negative index");
            }
            while (curr != null && i < index)
            {
                i += 1;
                curr = curr.next;
            }
            if (curr == null)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            curr.data = value;
        }
        public int Count()
        {
            int size = 0;
            for (Node curr = this.head; curr != null; curr = curr.next, size++) ;
            return size;
        }
        public void RemoveFirst()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Can not remove an element from empty list");
            }
            this.head = this.head.next;
        }
        public void RemoveLast()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can not remove an element from empty list");
            }
            Node curr = this.head;
            while(curr.next.next != null)
            {
                curr = curr.next;
            }
            curr.next = null;
        }
        public void Remove(int index)
        {
            if (index < 0)
            {
                throw new IndexOutOfRangeException("Can not remove an element at negative index");
            }
            if (IsEmpty())
            {
                throw new InvalidOperationException("Can not remove an element from empty list");
            }
            if(index == 0)
            {
                RemoveFirst();
                return;
            }
            Node prev = null;
            Node curr = this.head;
            int i = 0;
            while(curr != null && i < index)
            {
                prev = curr;
                curr = curr.next;
                i++;
            }
            if(curr == null)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            prev.next = curr.next;
        }
        public User GetValue(int index)
        {
            if(index < 0)
            {
                throw new IndexOutOfRangeException("Please provide a positive index");
            }
            int i = 0;
            Node curr = this.head;
            while(i < index && curr != null)
            {
                i++;
                curr = curr.next;
            }
            if(curr == null)
            {
                throw new IndexOutOfRangeException("Index out of bounds");
            }
            return curr.data;
        }
        public int IndexOf(User value)
        {
            Node curr = this.head;
            int i = 0;
            while(curr != null)
            {
                if(curr.data.Equals(value))
                {
                    return i;
                }
                i++;
                curr = curr.next;
            }
            return -1;
        }
        public bool Contains(User value)
        {
            return IndexOf(value) >= 0;
        }
        public void Reverse()
        {
            Node prev = null;
            Node curr = this.head;
            Node next = null;

            while (curr != null)
            {
                next = curr.next;  // Store next
                curr.next = prev;  // Reverse current node's pointer
                prev = curr;       // Move pointers one position ahead.
                curr = next;
            }
            if(this.head != null)
                this.head = prev;
        }
        public void Join(SLL otherList)
        {
            if (head == null)
            {
                head = otherList.head;
            }
            else
            {
                Node curr = head;
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = otherList.head;
            }
        }
    }
}
