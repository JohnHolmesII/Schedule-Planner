using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Schedule_Planner
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            try
            {
                string id    = GetString(txtCourseID);
                string name  = GetString(txtCourseName);
                byte   units = 0;

                if (!Byte.TryParse(GetString(txtCourseUnits), out units)) units = 0;

                Course cs = new Course(id,
                                       name,
                                       units,
                                       cbxFall.Checked,
                                       cbxWinter.Checked,
                                       cbxSpring.Checked,
                                       cbxSummer.Checked,
                                       null,
                                       null);

                lbxCList.Items.Add(String.Format("{0}: {1}, {2} Units, Available: {3}", cs.CourseID, cs.Description, cs.Units, cs.Availability()));

                uint hash = xxHashSharp.xxHash.CalculateHash(Encoding.UTF8.GetBytes(cs.CourseID));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetString(TextBox txt)
        {
            string id = txt.Text.Trim();

            if (String.IsNullOrEmpty(id))
            {
                throw new Exception(String.Format("{0} is empty", txt.Name.Remove(0, 3)));
            }

            return id;
        }
    }
}
