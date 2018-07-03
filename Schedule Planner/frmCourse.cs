using System;
using System.Windows.Forms;

namespace Schedule_Planner
{
    public partial class frmCourse : Form
    {
        Course course;

        public frmCourse(Course cs)
        {
            InitializeComponent();
            course = cs;
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            txtID.Text        = course.CourseID;
            txtDesc.Text      = course.Description;
            cbxFall.Checked   = course.Fall;
            cbxWinter.Checked = course.Winter;
            cbxSpring.Checked = course.Spring;
            cbxSummer.Checked = course.Summer;

            if (course.Prereqs != null && course.Prereqs.Length > 0)
            {
                NList iter = course.Prereqs;
                for (iter.MoveFront(); iter.Index >= 0; iter.MoveNext())
                {
                    lbxPre.Items.Add(iter);
                }
            }
            else
            {
                lbxPre.Items.Add("None");
            }

            if (course.Coreqs != null && course.Coreqs.Length > 0)
            {
                NList iter = course.Coreqs;
                for (iter.MoveFront(); iter.Index >= 0; iter.MoveNext())
                {
                    lbxCo.Items.Add(iter);
                }
            }
            else
            {
                lbxCo.Items.Add("None");
            }
        }
    }
}
