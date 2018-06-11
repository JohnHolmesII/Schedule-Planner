using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string id;
            string name;
            byte units = 0;
            
            id = GetString(txtCourseID);
            name = GetString(txtCourseName);

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
        }

        private string GetString(TextBox txt)
        {
            string id = txt.Text.Trim();
            
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show(String.Format("{0} is empty", txt.Name.Remove(0, 3)));
            }

            return id;
        }
    }
}
