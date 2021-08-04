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

    /// <summary>
    /// Dequeue a value from the queue.
    /// </summary>
    public T Dequeue()
    {
        if (count != 0)
        {
            T value = head.value;
            head = head.next;
            count--;
            return value;
        }
        Console.WriteLine("Queue is empty");
        return default(T);
    }

    /// <summary>
    /// Peek at the next value in the queue.
    /// </summary>
    public T Peek()
    {
        if (count != 0)
        {
            return head.value;
        }
        Console.WriteLine("Queue is empty");
        return default(T);
    }

    /// <summary>
    /// Print the queue.
    /// </summary>
    public void Print()
    {
        if (count != 0)
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }
    }

    /// <summary>
    /// Concatenate the queue.
    /// </summary>
    public string Concatenate()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
            return null;
        }

        string x = "";
        Node current = head;

        for (int i = 0; i < count; i++)
        {
            x += current.value.ToString();
            if (typeof(T) == typeof(string))
            {
                x += " ";
            }
            current = current.next;
        }
        return x;
    }
}
