using System;
using System.Collections.Generic;
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
                string id      = GetString(txtCourseID);
                string name    = GetString(txtCourseName);
                byte   units   = 0;
                NList  prereqs = new NList();

                if (!Byte.TryParse(GetString(txtCourseUnits), out units)) units = 0;

                foreach (object course in lbxPrereqs.Items)
                {
                    prereqs.Append((Course) course);
                }

                Course cs = new Course(id,
                                       name,
                                       units,
                                       cbxFall.Checked,
                                       cbxWinter.Checked,
                                       cbxSpring.Checked,
                                       cbxSummer.Checked,
                                       prereqs,
                                       null);

                mainDB.Add(id, cs);
                mainDB.SaveDB();
                mainDB.PopulateListBox(lbxCList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error creating course. {0}", ex.Message));
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

        private void   cmdAddPre_Click(object sender, EventArgs e)
        {
            Course cs = (Course) lbxCList.SelectedItem;

            if (cs != null)
            {
                lbxPrereqs.Items.Add(cs);
            }
        }

        private void   cmdRemPre_Click(object sender, EventArgs e)
        {
            Course cs = (Course) lbxPrereqs.SelectedItem;

            if (cs != null)
            {
                lbxPrereqs.Items.Remove(cs);
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
            if (lbxCList.SelectedItem != null)
            {
                cmdRemove.Enabled                          = true;
                cmdAddPre.Enabled                          = true;
                cmsCourseMenu.Items["tsiViewData"].Enabled = true;
            }
        }

        private void   lbxPrereqs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxPrereqs.SelectedItem != null)
            {
                cmsCourseMenu.Items["tsiViewData"].Enabled = true;
                cmdRemPre.Enabled = true;
            }
        }

        private void   cmdSwitch_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void   cmsCourseMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Course cs = null;

            if (lbxCList.ContainsFocus)
            {
                cs = (Course) lbxCList.SelectedItem;
            }
            else if (lbxPrereqs.ContainsFocus)
            {
                cs = (Course) lbxPrereqs.SelectedItem;
            }

            if (cs != null)
            {
                (new frmCourse(cs)).ShowDialog();
            }
        }
    }
}
