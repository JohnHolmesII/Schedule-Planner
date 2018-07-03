using System;

namespace Schedule_Planner
{
    [Serializable]
    class AcademicYear
    {
        public CourseDB Fall   { get; set; }
        public CourseDB Winter { get; set; }
        public CourseDB Spring { get; set; }
        public CourseDB Summer { get; set; }

        public AcademicYear()
        {
            Fall   = new CourseDB(30);
            Winter = new CourseDB(30);
            Spring = new CourseDB(30);
            Summer = new CourseDB(30);
        }
    }
}
