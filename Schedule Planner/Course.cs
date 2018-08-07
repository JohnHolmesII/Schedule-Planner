using System;
using System.Collections.Generic;

namespace Schedule_Planner
{
    [Serializable]
    public class Course : ICloneable
    {
        public string CourseID    { get; }
        public string Description { get; }
        public byte   Units       { get; }
        public bool   Fall        { get; }
        public bool   Winter      { get; }
        public bool   Spring      { get; }
        public bool   Summer      { get; }
        public NList  Prereqs     { get; }
        public NList  Coreqs      { get; }

        public Course(string id, string desc, byte units, bool f, bool w, bool s, bool u, NList p, NList c)
        {
            CourseID    = id;
            Description = desc;
            Units       = units;
            Fall        = f;
            Winter      = w;
            Spring      = s;
            Summer      = u;
            Prereqs     = p;
            Coreqs      = c;
        }

        public  string Availability()
        {
            string s = "";

            if (!(Fall || Winter || Spring || Summer)) return "None";

            if (Fall)   s += "Fall ";
            if (Winter) s += "Winter ";
            if (Spring) s += "Spring ";
            if (Summer) s += "Summer";

            return s.Trim();
        }

        private string CourseListString(List<Course> cl)
        {
            string s = "";

            if (cl != null && cl.Count > 0)
            {
                foreach (Course c in cl)
                {
                    s += c.CourseID + ' ';
                }
            }
            else
            {
                s = "None";
            }

            return s.Trim();
        }

        override
        public  string ToString()
        {
            return String.Format("{0}: {1}, {2} Units, Available: {3}", CourseID, Description, Units, Availability());
        }

        public object Clone()
        {
            return this;
        }
    }
}
