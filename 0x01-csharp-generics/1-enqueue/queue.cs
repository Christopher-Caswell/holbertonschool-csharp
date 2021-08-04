using System;

/// <summary>
/// Generic queue class.
/// </summary>
class Queue<T>
{
   Node head = null;
   Node tail = null;
   int count = 0;

    /// <summary>
    /// Return Queue type.
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Node class.
    /// </summary>
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        /// <summary>
        /// Set a value for a node.
        /// </summary>
        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// Enqueue a value to the queue.
    /// </summary>
    public void Enqueue(T value)
    {
        if (head == null)
        {
            head = new Node(value);
            tail = head;
        }
        else
        {
            tail.next = new Node(value);
            tail = tail.next;
        }
        count++;
    }

    /// <summary>
    /// Count Nodes in the queue.
    /// </summary>
    public int Count()
    {
        return count;
    }
}
