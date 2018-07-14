using System.Windows.Forms;
using System.Collections.Generic;

namespace Schedule_Planner
{
    public partial class frmSchedule : Form
    {
        private CourseDB       mainDB;
        private AcademicYear[] plan;
        private int            yearIndex;
        private int            year;

        public frmSchedule()
        {
            InitializeComponent();
            year    = System.DateTime.Now.Year;
            plan    = new AcademicYear[1];
            mainDB  = CourseDB.LoadDB();
            plan[0] = AcademicYear.LoadYear(year);

            if (mainDB == null)
            {
                mainDB = new CourseDB(1000);
                mainDB.SaveDB();
            }

            if (plan[0] == null)
            {
                plan[0] = new AcademicYear(year);
                plan[0].SaveYear();
            }

            plan[0].Fall.PopulateListBox(lbxFall);
            plan[0].Winter.PopulateListBox(lbxWinter);
            plan[0].Spring.PopulateListBox(lbxSpring);
            plan[0].Summer.PopulateListBox(lbxSummer);
            mainDB.PopulateListBox(lbxAvailable);
            yearIndex = 0;
        }

        private void cmdSwitch_Click(object sender, System.EventArgs e)
        {
            (new frmBuilder()).ShowDialog(); // Blocking
            mainDB = CourseDB.LoadDB();
            mainDB.PopulateListBox(lbxAvailable);
        }

        private void cmdAdd_Click(object sender, System.EventArgs e)
        {
            AcademicYear currYear = plan[yearIndex];
            Course       cs       = (Course) lbxAvailable.SelectedItem;

            if (rboFall.Checked)
            {
                AddCourse(cs, currYear.Fall, lbxFall);
            }
            else if (rboWinter.Checked)
            {
                AddCourse(cs, currYear.Winter, lbxWinter);
            }
            else if (rboSpring.Checked)
            {
                AddCourse(cs, currYear.Spring, lbxSpring);
            }
            else if (rboSummer.Checked)
            {
                AddCourse(cs, currYear.Summer, lbxSummer);
            }
        }

        private void AddCourse(Course course, CourseDB term, ListBox lbx)
        {
            NList        iter = course.Prereqs.Copy();
            AcademicYear ay;
            Course       cs;
            bool         found;

            // Check previous years for prereqs
            for (int i = 0; i < yearIndex; ++i)
            {
                ay = plan[i];

                for (iter.MoveFront(); iter.Index >= 0; iter.MoveNext())
                {
                    cs    = (Course) iter.Get();
                    found = ay.Fall.ContainsKey(cs.CourseID) || ay.Winter.ContainsKey(cs.CourseID) || ay.Spring.ContainsKey(cs.CourseID) || ay.Summer.ContainsKey(cs.CourseID);

                    if (found)
                    {
                        iter.Delete();
                    }
                }
            }

            ay = plan[yearIndex];

            // Check current year for prereqs
            for (iter.MoveFront(); iter.Index >= 0; iter.MoveNext())
            {
                cs = (Course) iter.Get();

                if (term == ay.Winter)
                {
                    found = ay.Fall.ContainsKey(cs.CourseID);
                }
                else if (term == ay.Spring)
                {
                    found = ay.Winter.ContainsKey(cs.CourseID) || ay.Fall.ContainsKey(cs.CourseID);
                }
                else if (term == ay.Summer)
                {
                    found = ay.Spring.ContainsKey(cs.CourseID) || ay.Winter.ContainsKey(cs.CourseID) || ay.Fall.ContainsKey(cs.CourseID);
                }
                else
                {
                    found = false;
                }

                if (found)
                {
                    iter.Delete();
                }

            }

            // Only add the course if it's prerequisites have been satisfied
            if (iter.Length < 1)
            {
                term.Add(course.CourseID, course);
                ay.SaveYear();
                term.PopulateListBox(lbx);
            }
        }

        private void AddYear(int year)
        {
            AcademicYear[] tmp = new AcademicYear[plan.Length + 1];

            for (int i = 0; i < plan.Length; ++i)
            {
                tmp[i] = plan[i];
            }

            tmp[plan.Length] = new AcademicYear(year);
            plan             = tmp;
        }

        private void lbxAvailable_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            cmdAdd.Enabled = true;
        }
    }
}
