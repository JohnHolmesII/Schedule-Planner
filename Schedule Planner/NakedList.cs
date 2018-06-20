using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schedule_Planner
{
    [Serializable]
    class NakedList
    {
        public  uint Size { get; private set; }
        private Node Head;

        public NakedList()
        {
            Size = 0;
            Head = null;
        }

        public void   Add(Object o)
        {
            if (o == null) return;

            Node tmp = new Node(o);

            if (Head == null)
            {
                Head = tmp;
            }
            else
            {
                tmp.Next  = Head.Next;
                Head.Next = tmp;
            }

            ++Size;
        }

        public Object Get(int index)
        {
            if (index > Size || index < 0) return null;

            Node tmp = Head;

            for (int i = 0; i < index; ++i)
            {
                tmp = tmp.Next;
            }

            return tmp.Data;
        }

        public void   Remove(int index)
        {
            if (index > Size) return;

            if (index == 0)
            {
                Head = Head.Next;
            }
            else
            {
                Node prev = Head;
                Node curr;

                for (int i = 0; i < index - 1; ++i)
                {
                    prev = prev.Next;
                }

                curr      = prev.Next;
                prev.Next = curr.Next;
            }

            --Size;
        }

        public int    Contains(string key)
        {
            int  tmp  = -1;
            Node curr = Head;

            while (curr != null && !((CourseDB.Entry)curr.Data).Key.Equals(key))
            {
                ++tmp;
            }

            return tmp;
        }

        public void   Flush()
        {
            Head = null;
        }

        [Serializable]
        private class Node
        {
            public Object Data { get; set; }
            public Node   Next { get; set; }

            public Node(Object d)
            {
                Data = d;
                Next = null;
            }
        }
    }
}
