using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    internal class Node<T>
    {
        private T value;
        private Node<T> next;
        public Node()
        {

        }
        public Node(T value)
        {
            this.value = value;
            this.next = null;
        }

        public Node(T value, Node<T> next)
        {
            this.value = value;
            this.next = next;
        }

        public T GetValue()
        {
            return value;
        }

        public void SetValue(T value)
        {
            this.value = value;
        }

        public Node<T> GetNext()
        {
            return next;
        }

        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public bool HasNext()
        {
            return this.next != null;
        }
        public int NumberOfNodes()
        {
            int counter = 0;
            Node<T> head = this;
            while (head != null)
            {
                counter++;
                head = head.GetNext();
            }
            return counter;
        }
        public override string ToString()
        {
            //if (this.next == null)
            if (!HasNext())
            {
                return this.value + "-->" + "null";
            }

            return this.value + "-->" + this.next;
        }
    }
}
