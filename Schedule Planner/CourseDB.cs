using System;
using System.IO;
using System.Windows.Forms;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using xxHashSharp;

namespace Schedule_Planner
{
    [Serializable]
    class CourseDB
    {
        public  uint        Size { get; private set; }
        private uint        tableSize;
        private NakedList[] table;

        public CourseDB(uint rTSize)
        {
            Size      = 0;
            tableSize = rTSize;
            table     = new NakedList[tableSize];
        }

        public  void     Add(string key, Course value)
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

                for (int i = 0; i < workingSize; ++i)
                {
                    tmp = (Entry) table[index].Get(i);

                    if (tmp.Key == key)
                    {
                        tmp.Value = value;
                        return;
                    }
                }

                table[index].Add(new Entry(key, value));
                ++Size;
            }
        }
        
        public  Course   Get(string key)
        {
            Course tmp   = null;
            uint   index = GetIndex(key);

            for (int i = 0; i < table[index].Size; ++i)
            {
                Entry entry = (Entry) table[index].Get(i);

                if (entry.Value.CourseID.Equals(key))
                {
                    tmp = entry.Value;
                    break;
                }
            }

            return tmp;
        }

        public  bool     Remove(string key)
        {
            bool tmp   = false;
            uint index = GetIndex(key);

            for (int i = 0; i < table[index].Size; ++i)
            {
                Entry entry = (Entry)table[index].Get(i);

                if (entry.Value.CourseID.Equals(key))
                {
                    table[index].Remove(i);
                    tmp = true;
                    --Size;
                    break;
                }
            }

            return tmp;
        }

        public  string[] GetKeys()
        {
            string[]  tmp    = new string[Size];
            int       index  = 0;
            NakedList bucket = null;

            for (int i = 0; i < tableSize; ++i)
            {
                if ((bucket = table[i]) != null)
                {
                    for (int j = 0; j < bucket.Size; ++j)
                    {
                        Entry entry = (Entry) bucket.Get(j);
                        tmp[index]  = entry.Value.CourseID;
                        ++index;
                    }
                }
            }

            return tmp;
        }

        public  bool     ContainsKey(string key)
        {
            uint keyHash = xxHashSharp.xxHash.CalculateHash(Encoding.UTF8.GetBytes(key));

            return table[keyHash].Contains(key) > 0;
        }

        private uint     GetIndex(string key)
        {
            return xxHash.CalculateHash(Encoding.UTF8.GetBytes(key)) % tableSize;
        }

        public  void     PopulateListBox(ListBox lbx)
        {
            lbx.Items.Clear();

            string[] keys = GetKeys();

            for (int i = 0; i < keys.Length; ++i)
            {
                lbx.Items.Add(Get(keys[i]));
            }
        }

        public  void     SaveDB()
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream     fs        = new FileStream("courses.db", FileMode.Create);

                formatter.Serialize(fs, this);
                fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error saving. " + e.Message);
            }
        }

        static
        public  CourseDB LoadDB()
        {
            CourseDB tmp = null;

            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream     fs        = new FileStream("courses.db", FileMode.Open);

                tmp = (CourseDB)formatter.Deserialize(fs);
                fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("LoadDB(): error loading. " + e.Message);
            }

            return tmp;
        }

        [Serializable]
        public class Entry
        {
            public string Key   { get; }
            public Course Value { get; set; }

            public Entry(string k, Course v)
            {
                Key   = k;
                Value = v;
            }
        }
    }
}
