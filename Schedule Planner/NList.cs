using System;
using System.Diagnostics.Contracts;
using System.Text;

namespace Schedule_Planner
{
    [Serializable]
    public class NList
    {
        public int   Length { get; private set; }
        public int   Index  { get; private set; }
        private Node Cursor { get; set; }
        private Node FrontN { get; set; }
        private Node BackN  { get; set; }

        // Special property accesors
        public Object Front()
        {
            Contract.Requires(Length > 0, "List.Front(): No front");

            return FrontN.Data;
        }

        public Object Back()
        {
            Contract.Requires(Length > 0, "List.Back(): No back");

            return BackN.Data;
        }

        public Object Get()
        {
            Contract.Requires(Length > 0 && Index > -1, "NList.Get(): List empty, or no Cursor");

            return Cursor.Data;
        }

        // Constructor
        public NList()
        {
            Length = 0;
            Index  = -1;
            Cursor = null;
            FrontN = null;
            BackN  = null;
        }

        // Data manipulation
        public void Flush()
        {
            Length = 0;
            Index  = -1;
            Cursor = null;
            FrontN = null;
            BackN  = null;
        }

        public int  Contains(string key)
        {
            int tmp = -1;

            Node curr = FrontN;

            while (curr != null && ((CourseDB.Entry) curr.Data).Key.Equals(key))
            {
                curr = curr.Next;
                ++tmp;
            }

            return tmp;
        }

        public void MoveFront()
        {
            if (Length > 0)
            {
                Cursor = FrontN;
                Index  = 0;
            }
        }

        public void MoveBack()
        {
            if (Length > 0)
            {
                Cursor = BackN;
                Index  = Length - 1;
            }
        }

        public void MoveNext()
        {
            if (Cursor != null && Cursor != BackN)
            {
                Cursor = Cursor.Next;
                ++Index;
            }
            else if (Cursor == BackN)
            {
                Cursor = null;
                Index  = -1;
            }
        }

        public void MovePrev()
        {
            if (Cursor != null && Cursor != FrontN)
            {
                Cursor = Cursor.Prev;
                --Index;
            }
            else if (Cursor == FrontN)
            {
                Cursor = null;
                Index  = -1;
            }
        }

        public void Prepend(Object Data)
        {
            Node tmp = new Node(Data, null, FrontN);

            if (Length == 0)
            {
                BackN  = tmp;
                FrontN = tmp;
            }
            else
            {
                FrontN.Prev = tmp;
                FrontN      = tmp;
            }

            ++Length;
        }

        public void Append(Object Data)
        {
            Node tmp = new Node(Data, BackN, null);

            if (Length == 0)
            {
                BackN  = tmp;
                FrontN = tmp;
            }
            else
            {
                BackN.Next = tmp;
                BackN      = tmp;
            }

            ++Length;
        }

        public void InsertBefore(Object Data)
        {
            Contract.Requires(Length > 0 && Index > -1, "List.InsertBefore(): List or Cursor not initialized");

            Node tmp = new Node(Data, Cursor.Prev, Cursor);

            if (Index != 0) // Middle of the list
            {
                Cursor.Prev.Next = tmp;
                Cursor.Prev      = tmp;
                ++Length;
            }
            else            // Front of the list
            {
                Prepend(Data);
            }
        }

        public void InsertAfter(Object Data)
        {
            Contract.Requires(Length > 0 && Index > -1, "List.InsertAfter(): List or Cursor not initialized");

            Node tmp = new Node(Data, Cursor, Cursor.Next);

            if (Index != Length - 1) // Middle of the list
            {
                Cursor.Next.Prev = tmp;
                Cursor.Next      = tmp;
                ++Length;
            }
            else
            {
                Append(Data);       // Back of the list
            }
        }

        public void DeleteFront()
        {
            Contract.Requires(Length > 0, "List.DeleteFront(): No Front");

            if (Length == 1)
            {
                Flush();
                return;
            }

            FrontN      = FrontN.Next;
            FrontN.Prev = null;
            --Length;
        }

        public void DeleteBack()
        {
            Contract.Requires(Length > 0, "List.deleteBack(): No Back");

            if (Length == 1)
            {
                Flush();
                return;
            }

            BackN      = BackN.Prev;
            BackN.Next = null;
            --Length;
        }

        public void Delete()
        {
            Contract.Requires(Length > 0 && Index > -1, "List.delete(): List or Cursor not initialized");

            if (Length == 1)
            {
                Flush();
                return;
            }

            if (Index == 0)
            {
                DeleteFront();
            }
            else if (Index == Length - 1)
            {
                DeleteBack();
            }
            else
            {
                Cursor.Prev.Next = Cursor.Next;
                Cursor.Next.Prev = Cursor.Prev;
                Cursor = null;
                Index  = -1;
                --Length;
            }
        }

        // Other methods
        override
        public String ToString()
        {
            if (Length > 0)
            {
                StringBuilder sb   = new StringBuilder(Length * 7);
                Node          curr = FrontN;

                while (curr != null)
                {
                    sb.Append(" ").Append(curr.Data);
                    curr = curr.Next;
                }

                return sb.ToString(1, sb.Length - 1);
            }
            else
            {
                return "Empty list";
            }
        }

        override
        public bool Equals(Object o)
        {
            bool tmp = false;

            if (o is NList)
            {
                NList L    = (NList) o;
                Node  me   = FrontN;
                Node  them = L.FrontN;

                if ((tmp = Length == L.Length)) // Hidden assignment
                {
                    while (tmp && me != null)
                    {
                        tmp  = me.Data == them.Data;
                        me   = me.Next;
                        them = them.Next;
                    }
                }
            }

            return tmp;
        }

        public NList Copy()
        {
            NList tmp  = new NList();
            Node  curr = FrontN;

            while (curr != null)
            {
                tmp.Append(curr.Data);
                curr = curr.Next;
            }

            return tmp;
        }

        public NList Concat(NList L)
        {
            NList tmp  = Copy();
            Node  curr = L.FrontN;

            while (curr != null)
            {
                tmp.Append(curr.Data);
                curr = curr.Next;
            }

            return tmp;
        }

        // Inner class wrapper
        [Serializable]
        public class Node
        {
            public Object Data { get; set; }
            public Node   Prev { get; set; }
            public Node   Next { get; set; }

            public Node(Object d, Node p, Node n)
            {
                Data = d;
                Prev = p;
                Next = n;
            }

            override
            public String ToString()
            {
                String p = "N";
                String n = "N";

                if (Prev != null) p = Prev.Data.ToString();
                if (Next != null) n = Next.Data.ToString();

                return String.Format("%-2s<> %-2s<> %-2s", p, Data, n).Trim();
            }
        }
    }
}
