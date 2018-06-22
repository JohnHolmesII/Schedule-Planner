using System;
using System.Windows.Forms;

namespace Schedule_Planner
{
    public partial class frmBuilder : Form
    {
        private CourseDB mainDB;

        public frmBuilder()
        {
            InitializeComponent();

            if ((mainDB = CourseDB.LoadDB()) == null)
            {
                mainDB = new CourseDB(1000);
                mainDB.SaveDB();
            }

            mainDB.PopulateListBox(lbxCList);
        }

        private void   cmdGo_Click(object sender, EventArgs e)
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

                mainDB.Add(id, cs);
                mainDB.SaveDB();
                mainDB.PopulateListBox(lbxCList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void   cmdRemove_Click(object sender, EventArgs e)
        {
            Course cs = (Course) lbxCList.SelectedItem;

            if (cs != null)
            {
                mainDB.Remove(cs.CourseID);
                mainDB.SaveDB();
                mainDB.PopulateListBox(lbxCList);
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

        private void   lbxCList_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmdRemove.Enabled = true;
        }

        private void   cmdSwitch_Click(object sender, EventArgs e)
        {
            // Dirty filthy fucking hacks reeee
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "frmSchedule")
                {
                    frm.Enabled = true;
                    frm.Visible = true;
                    break;
                }
            }

            Close();
        }

        private void   frmBuilder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
