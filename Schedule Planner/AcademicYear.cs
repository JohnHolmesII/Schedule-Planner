using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Schedule_Planner
{
    [Serializable]
    class AcademicYear
    {
        private string  fileName = "";
        public int      Year   { get; set; }
        public CourseDB Fall   { get; set; }
        public CourseDB Winter { get; set; }
        public CourseDB Spring { get; set; }
        public CourseDB Summer { get; set; }

        public AcademicYear(int year)
        {
            Year     = year;
            Fall     = new CourseDB(7);
            Winter   = new CourseDB(7);
            Spring   = new CourseDB(7);
            Summer   = new CourseDB(7);
            fileName = FileName(year);
        }

        public void SaveYear()
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream     fs        = new FileStream(fileName, FileMode.Create);

                formatter.Serialize(fs, this);
                fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("SaveYear(): Error saving. " + e.Message);
            }
        }

        static
        public AcademicYear LoadYear(int year)
        {
            AcademicYear tmp = null;

            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream     fs        = new FileStream(FileName(year), FileMode.Open);

                tmp = (AcademicYear) formatter.Deserialize(fs);
                fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("LoadYear(): error loading. " + e.Message);
            }

            return tmp;
        }

        static
        private string FileName(int year)
        {
            return "AY" + year.ToString() + ".db";
        }
    }
}
