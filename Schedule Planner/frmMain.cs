﻿using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Schedule_Planner
{
    public partial class frmMain : Form
    {
        private CourseDB mainDB;

        public frmMain()
        {
            InitializeComponent();

            if ((mainDB = LoadDB()) == null)
            {
                mainDB = new CourseDB(10);
                SaveDB(mainDB);
            }
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

                mainDB.Add(id, cs);
                UpdateListBox();
                SaveDB(mainDB);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateListBox()
        {
            lbxCList.ResetText();

            string[] keys = mainDB.GetKeys();

            for (int i = 0; i < keys.Length; ++i)
            {
                Course cs = mainDB.Get(keys[i]);
                lbxCList.Items.Add(String.Format("{0}: {1}, {2} Units, Available: {3}", cs.CourseID, cs.Description, cs.Units, cs.Availability()));
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

        private void SaveDB(CourseDB cdb)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream fs = new FileStream("courses.db", FileMode.Create);

                formatter.Serialize(fs, cdb);
                fs.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error saving. " + e.Message);
            }
        }

        private CourseDB LoadDB()
        {
            CourseDB tmp = null;

            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream     fs        = new FileStream("courses.db", FileMode.Open);

                tmp = (CourseDB)formatter.Deserialize(fs);
                fs.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("LoadDB(): error loading. " + e.Message);
            }

            return tmp;
        }
    }
}
