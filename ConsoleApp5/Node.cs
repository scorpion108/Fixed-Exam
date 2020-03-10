using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Node<T>
    {
        private T Value;
        private Node<T> next;

        public Node(T Value)
        {
            this.Value = Value;
            this.next = null;
        }

        public Node(T Value, Node<T> next)
        {
            this.Value = Value;
            this.next = next;
        }

        public T GetValue()
        {
            return Value;
        }

        public Node<T> GetNext()
        {
            return next;
        }

        public void SetValue(T Value)
        {
            this.Value = Value;
        }

        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}