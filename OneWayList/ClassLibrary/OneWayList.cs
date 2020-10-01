
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class cOneWayList : IEnumerable
    {
        Node head;
        Node tail;
        int count;

        public void Add(string data)
        {
            Node node = new Node(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }

        public bool Remove(string data)
        {
            Node current = head;
            Node previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {

                    if (previous != null)
                    {

                        previous.Next = current.Next;


                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {

                        head = head.Next;


                        if (head == null)
                            tail = null;
                    }
                    count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }
            return false;
        }

        public static void Except(ref cOneWayList list, cOneWayList exceptList)
        {
            foreach (string item in list)
            {

                foreach (string exceptItem in exceptList)
                {
                    if (item.Equals(exceptItem))
                    {

                        list.Remove(item);
                        break;
                    }
                }

            }

        }



       

        IEnumerator IEnumerable.GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
