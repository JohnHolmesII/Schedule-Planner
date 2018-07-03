using System;
using System.Text;

namespace Schedule_Planner
{
    [Serializable]
    class NList
    {
        public int   Length { get; private set; }
        public int   Index  { get; private set; }
        private Node Cursor { get; set; }
        private Node FrontN { get; set; }
        private Node BackN  { get; set; }

        // Special property accesors
        public int Front()
        {
            return FrontN.Data;
        }

        public int Back()
        {
            return BackN.Data;
        }

        public int Get()
        {
            if (Length > 0 && Index > -1)
            {
                return Cursor.Data;
            }
            else
            {
                throw new Exception("NList.Get(): List empty, or no Cursor");
            }
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
        public void Clear()
        {
            Length = 0;
            Index  = -1;
            Cursor = null;
            FrontN = null;
            BackN  = null;
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
                Index = -1;
            }
        }

        public void Prepend(int Data)
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

        public void Append(int Data)
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

        public void InsertBefore(int Data)
        {
            // Pre: Length > 0; index > -1
            if (Length > 0 && Index > -1)
            {
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
            else
            {
                throw new Exception("List.insertBefore(): List or Cursor not initialized");
            }
        }

        public void InsertAfter(int Data)
        {
            // Pre: Length > 0; index > -1
            if (Length > 0 && Index > -1)
            {
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
            else
            {
                throw new Exception("List.insertAfter(): List or Cursor not initialized");
            }
        }

        public void DeleteFront()
        {
            // Pre: Length > 0
            if (Length > 0)
            {
                FrontN = FrontN.Next;
                FrontN.Prev = null;
                --Length;
            }
            else
            {
                throw new Exception("List.deleteFront(): No FrontN");
            }
        }

        public void DeleteBack()
        {
            // Pre: Length > 0
            if (Length > 0)
            {
                BackN = BackN.Prev;
                BackN.Next = null;
                --Length;
            }
            else
            {
                throw new Exception("List.deleteBack(): No BackN");
            }
        }

        public void Delete()
        {
            // Pre: Length > 0; index > -1
            if (Length > 0 && Index > -1)
            {
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
                    Cursor           = null;
                    Index            = -1;
                    --Length;
                }
            }
            else
            {
                throw new Exception("List.delete(): List or Cursor not initialized");
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
                NList L   = (NList) o;
                Node me   = FrontN;
                Node them = L.FrontN;

                if ((tmp = Length == L.Length)) // Hidden assignment
                {
                    while (tmp && me != null)
                    {
                        tmp = me.Data == them.Data;
                        me = me.Next;
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
        public class Node
        {
            public int  Data { get; set; }
            public Node Prev { get; set; }
            public Node Next { get; set; }

            public Node(int d, Node p, Node n)
            {
                Data = d;
                Prev = p;
                Next = n;
            }

            public String toString()
            {
                String p = "N";
                String n = "N";

                if (Prev != null) p = Prev.Data.ToString();
                if (Next != null) n = Next.Data.ToString();

                return String.Format("%-2s<> %-2d<> %-2s", p, Data, n).Trim();
            }
        }
    }
}
