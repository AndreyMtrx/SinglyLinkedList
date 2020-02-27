using System.Collections;

namespace SinglyLinkedList.Model
{
    /// <summary>
    /// Singly linked list
    /// </summary>
    public class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// First list node
        /// </summary>
        public LinkedListNode<T> Head { get; private set; }

        /// <summary>
        /// Last list node
        /// </summary>
        public LinkedListNode<T> Tail { get; private set; }

        /// <summary>
        /// All nodes quantity
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Create empty list
        /// </summary>
        public LinkedList()
        {
            SetDefaultValues();
        }

        /// <summary>
        /// Create list with initial node
        /// </summary>
        /// <param name="data"></param>
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        /// <summary>
        /// Add node to the end of the list
        /// </summary>
        public void Add(T data)
        {
            if (Head != null)
            {
                LinkedListNode<T> item = new LinkedListNode<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        /// <summary>
        /// Add node to the beginning of the list
        /// </summary>
        public void AddFirst(T data)
        {
            LinkedListNode<T> item = new LinkedListNode<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }

        /// <summary>
        /// Add node after specified data
        /// </summary>
        public void AddAfter(T target, T data)
        {
            if (Head != null)
            {
                LinkedListNode<T> item = new LinkedListNode<T>(data);
                if (Head.Data.Equals(target))
                {
                    item.Next = Head.Next;
                    Head.Next = item;
                    Count++;
                    return;
                }

                LinkedListNode<T> current = Head.Next;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        if (ReferenceEquals(Tail, current))
                        {
                            Tail.Next = item;
                            Tail = item;
                        }
                        else
                        {
                            item.Next = current.Next;
                            current.Next = item;
                        }
                        Count++;
                        return;
                    }
                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// Remove the first occurrence of list data
        /// </summary>
        public void Remove(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                LinkedListNode<T> current = Head.Next;
                LinkedListNode<T> previous = Head;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        if (ReferenceEquals(Tail, current))
                        {
                            Tail = previous;
                            previous.Next = null;
                        }
                        else
                        {
                            previous.Next = current.Next;
                        }
                        Count--;
                        return;
                    }
                    previous = current;
                    current = current.Next;
                }
            }
        }

        /// <summary>
        /// Clear the entire list
        /// </summary>
        public void Clear()
        {
            SetDefaultValues();
        }

        private void SetHeadAndTail(T data)
        {
            LinkedListNode<T> item = new LinkedListNode<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        private void SetDefaultValues()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        /// <summary>
        /// Get enumeration of all list nodes
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return "Singly linked list";
        }
    }
}