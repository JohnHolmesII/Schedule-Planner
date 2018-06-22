using System;
using System.Collections.Generic;

namespace Schedule_Planner
{
    [Serializable]
    public class Course
    {
        public string       CourseID    { get; }
        public string       Description { get; }
        public byte         Units       { get; }
        public bool         Fall        { get; }
        public bool         Winter      { get; }
        public bool         Spring      { get; }
        public bool         Summer      { get; }
        public List<Course> Prereqs     { get; }
        public List<Course> Coreqs      { get; }

        public Course(string id, string desc, byte units, bool f, bool w, bool s, bool u, List<Course> p, List<Course> c)
        {
            this.CourseID = id;
            this.Description = desc;
            this.Units = units;
            this.Fall = f;
            this.Winter = w;
            this.Spring = s;
            this.Summer = u;
            this.Prereqs = p;
            this.Coreqs = c;
        }

        public  string Availability()
        {
            string s = "";

            if (!(Fall || Winter || Spring || Summer)) return "None";

            if (Fall) s += "Fall ";
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
    }
}