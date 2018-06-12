using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using xxHashSharp;

namespace Schedule_Planner
{
    [Serializable]
    class CourseDB
    {
        public  uint Size { get; private set; }
        private uint tableSize;
        private NakedList[] table;

        public CourseDB(uint rTSize)
        {
            Size = 0;
            tableSize = rTSize;
            table = new NakedList[tableSize];
        }

        public void Add(string key, Course value)
        {
            uint index = GetIndex(key);

            if (table[index] == null)
            {
                NakedList tmp = new NakedList();
                tmp.Add(new Entry(key, value));
                table[index] = tmp;
                ++Size;
            }
            else
            {
                Entry tmp;
                uint  workingSize = table[index].Size;

                for (uint i = 0; i < workingSize; ++i)
                {
                    tmp = (Entry) table[index].Get(i);

                    if (tmp.Key == key)
                    {
                        tmp.Value = value;
                        return;
                    }
                    else
                    {
                        table[index].Add(new Entry(key, value));
                        ++Size;
                        return;
                    }
                }
            }
        }

        public bool Remove(string key)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(string key)
        {
            throw new NotImplementedException();
        }

        public string[] Keys => throw new NotImplementedException();

        public Course[] Values => throw new NotImplementedException();

        private uint GetIndex(string key)
        {
            return xxHash.CalculateHash(Encoding.UTF8.GetBytes(key)) % tableSize;
        }

        private class Entry
        {
            public string Key   { get; }
            public Course Value { get; set; }

            public Entry(string k, Course v)
            {
                Key = k;
                Value = v;
            }
        }
    }
}
