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

            if (course.Prereqs != null && course.Prereqs.Count > 0)
            {
                foreach (Course cs in course.Prereqs)
                {
                    lbxPre.Items.Add(cs);
                }
            }
            else
            {
                lbxPre.Items.Add("None");
            }

            if (course.Coreqs != null && course.Coreqs.Count > 0)
            {
                foreach (Course cs in course.Coreqs)
                {
                    lbxCo.Items.Add(cs);
                }
            }
            else
            {
                lbxCo.Items.Add("None");
            }
        }
    }
}
