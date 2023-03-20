using System;
using System.Text;

namespace Singleton
{
    internal class Stack<T>
    {
        private Node<T> head;

        public Stack()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Push(T x)
        {
            Node<T> node = new Node<T>(x);
            node.SetNext(head);
            head = node;
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T value = head.GetValue();
            head = head.GetNext();
            return value;
        }

        public T Top()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return head.GetValue();
        }
        public int Count()
        {
            int count = 0;
            Node<T> current = head;
            while (current != null)
            {
                count++;
                current = current.GetNext();
            }
            return count;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            Node<T> current = head;
            while (current != null)
            {
                sb.Append(current.GetValue().ToString());
                if (current.HasNext())
                {
                    sb.Append(",");
                }
                current = current.GetNext();
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}
