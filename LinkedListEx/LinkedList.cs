using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListEx
{
    class LinkedList
    {
        public Node firstElement { get; private set; }
        private Node temporary;
        internal void AddInBack(string data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            temporary.Next = newNode;
            temporary = temporary.Next;
        }
        internal void AddInFront(string data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            newNode.Next = firstElement;
            firstElement = newNode;
        }
        internal Node Exists(string data)
        {
            Node temp = firstElement;
            while (temp != null)
            {
                if (temp.Data.Equals(data))
                    return temp;
                temp = temp.Next;
            }
            return null;
        }
        internal List<string> ToList()
        {
            List<string> rList = new List<string>();
            // Loop through all the data and add it to a list
            // To be continued
            return rList;
        }
        internal bool Remove(string data, Node firstElement)
        {
            Node ToRemove;
            Node Prev = firstElement;

            if (firstElement.Data == data)
            {
                this.firstElement = firstElement.Next;
                firstElement.Next = null;
                return true;
            }
            while (Prev != null)
            {
                if (Prev.Next.Data.Equals(data))
                {
                    ToRemove = Prev.Next;
                    Prev.Next = ToRemove.Next;
                    ToRemove.Next = null;
                    return true;
                }
                Prev = Prev.Next;
            }
            // Search for the data and delete it
            return false;
        }

    }
}
