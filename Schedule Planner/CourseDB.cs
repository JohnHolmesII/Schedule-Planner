using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Schedule_Planner
{
    class CourseDB : ISerializable
    {
        public ICollection<string> Keys => throw new NotImplementedException();

        public ICollection<Course> Values => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();

        public void Add(string key, Course value)
        {
            throw new NotImplementedException();
        }

        public bool ContainsKey(string key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(string key)
        {
            throw new NotImplementedException();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
