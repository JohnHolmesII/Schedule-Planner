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
            Fall   = new CourseDB(1000);
            Winter = new CourseDB(1000);
            Spring = new CourseDB(1000);
            Summer = new CourseDB(1000);
        }
    }
}
