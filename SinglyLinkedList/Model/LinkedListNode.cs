using System;

namespace SinglyLinkedList.Model
{
    /// <summary>
    /// List node
    /// </summary>
    public class LinkedListNode<T>
    {
        private T data = default(T);

        /// <summary>
        /// Stored data of list node
        /// </summary>
        public T Data
        {
            get
            {
                return data;
            }
            set
            {
                if (value != null)
                    data = value;
                else
                    throw new ArgumentNullException(nameof(value));
            }
        }

        /// <summary>
        /// Stored data of next node relative to this
        /// </summary>
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}