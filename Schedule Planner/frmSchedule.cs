using System.Windows.Forms;

namespace Schedule_Planner
{
    public partial class frmSchedule : Form
    {
        private CourseDB mainDB;

        public frmSchedule()
        {
            InitializeComponent();

            if ((mainDB = CourseDB.LoadDB()) == null)
            {
                mainDB = new CourseDB(1000);
                mainDB.SaveDB();
            }

            UpdateListBox();
        }

        private void UpdateListBox()
        {
            lbxAvailable.Items.Clear();

            string[] keys = mainDB.GetKeys();

            for (int i = 0; i < keys.Length; ++i)
            {
                lbxAvailable.Items.Add(mainDB.Get(keys[i]));
            }
        }

        private void cmdSwitch_Click(object sender, System.EventArgs e)
        {
            Enabled = false;
            Visible = false;
            (new frmBuilder()).Show();
        }
    }
}
