using System.Windows.Forms;
using System.Collections.Generic;

namespace Schedule_Planner
{
    public partial class frmSchedule : Form
    {
        private CourseDB       mainDB;
        private AcademicYear[] plan;
        private int            yearIndex;

        public frmSchedule()
        {
            InitializeComponent();

            if ((mainDB = CourseDB.LoadDB()) == null)
            {
                mainDB = new CourseDB(1000);
                mainDB.SaveDB();
            }

            mainDB.PopulateListBox(lbxAvailable);
            plan      = new AcademicYear[1];
            plan[0]   = new AcademicYear();
            yearIndex = 0;
        }

        private void cmdSwitch_Click(object sender, System.EventArgs e)
        {
            Enabled = false;
            Visible = false;
            (new frmBuilder()).Show();
        }

        private void cmdAdd_Click(object sender, System.EventArgs e)
        {
            AcademicYear currYear = plan[yearIndex];
            Course       cs       = (Course) lbxAvailable.SelectedItem;

            if (rboFall.Checked)
            {
                currYear.Fall.Add(cs.CourseID, cs);
                currYear.Fall.PopulateListBox(lbxFall);
            }
            else if (rboWinter.Checked)
            {
                currYear.Winter.Add(cs.CourseID, cs);
                currYear.Winter.PopulateListBox(lbxWinter);
            }
            else if (rboSpring.Checked)
            {
                currYear.Spring.Add(cs.CourseID, cs);
                currYear.Spring.PopulateListBox(lbxSpring);
            }
            else if (rboSummer.Checked)
            {
                currYear.Summer.Add(cs.CourseID, cs);
                currYear.Summer.PopulateListBox(lbxSummer);
            }
        }

        private void AddCourse(Course course, CourseDB term)
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

            // Check current year for prereqs
            ay = plan[yearIndex];
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

            if (iter.Length > 0)
            {
                term.Add(course.CourseID, course);
            }
        }

        private void AddYear()
        {
            AcademicYear[] tmp = new AcademicYear[plan.Length + 1];

            for (int i = 0; i < plan.Length; ++i)
            {
                tmp[i] = plan[i];
            }

            tmp[plan.Length] = new AcademicYear();
            plan = tmp;
        }

        private void lbxAvailable_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            cmdAdd.Enabled = true;
        }
    }
}
