namespace Schedule_Planner
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxCList = new System.Windows.Forms.ListBox();
            this.cmdGo = new System.Windows.Forms.Button();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseUnits = new System.Windows.Forms.Label();
            this.txtCourseUnits = new System.Windows.Forms.TextBox();
            this.cbxFall = new System.Windows.Forms.CheckBox();
            this.cbxWinter = new System.Windows.Forms.CheckBox();
            this.cbxSummer = new System.Windows.Forms.CheckBox();
            this.cbxSpring = new System.Windows.Forms.CheckBox();
            this.gbxAvail = new System.Windows.Forms.GroupBox();
            this.cmdRemove = new System.Windows.Forms.Button();
            this.gbxAvail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxCList
            // 
            this.lbxCList.FormattingEnabled = true;
            this.lbxCList.Location = new System.Drawing.Point(330, 12);
            this.lbxCList.Name = "lbxCList";
            this.lbxCList.Size = new System.Drawing.Size(417, 212);
            this.lbxCList.TabIndex = 0;
            this.lbxCList.SelectedIndexChanged += new System.EventHandler(this.lbxCList_SelectedIndexChanged);
            // 
            // cmdGo
            // 
            this.cmdGo.Location = new System.Drawing.Point(261, 298);
            this.cmdGo.Name = "cmdGo";
            this.cmdGo.Size = new System.Drawing.Size(115, 45);
            this.cmdGo.TabIndex = 1;
            this.cmdGo.Text = "Add Course";
            this.cmdGo.UseVisualStyleBackColor = true;
            this.cmdGo.Click += new System.EventHandler(this.cmdGo_Click);
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(114, 36);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(179, 20);
            this.txtCourseID.TabIndex = 6;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(12, 39);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(54, 13);
            this.lblCourseID.TabIndex = 7;
            this.lblCourseID.Text = "Course ID";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(12, 65);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(71, 13);
            this.lblCourseName.TabIndex = 9;
            this.lblCourseName.Text = "Course Name";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(114, 62);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(179, 20);
            this.txtCourseName.TabIndex = 8;
            // 
            // lblCourseUnits
            // 
            this.lblCourseUnits.AutoSize = true;
            this.lblCourseUnits.Location = new System.Drawing.Point(12, 91);
            this.lblCourseUnits.Name = "lblCourseUnits";
            this.lblCourseUnits.Size = new System.Drawing.Size(31, 13);
            this.lblCourseUnits.TabIndex = 11;
            this.lblCourseUnits.Text = "Units";
            // 
            // txtCourseUnits
            // 
            this.txtCourseUnits.Location = new System.Drawing.Point(114, 88);
            this.txtCourseUnits.Name = "txtCourseUnits";
            this.txtCourseUnits.Size = new System.Drawing.Size(179, 20);
            this.txtCourseUnits.TabIndex = 10;
            // 
            // cbxFall
            // 
            this.cbxFall.AutoSize = true;
            this.cbxFall.Location = new System.Drawing.Point(6, 28);
            this.cbxFall.Name = "cbxFall";
            this.cbxFall.Size = new System.Drawing.Size(42, 17);
            this.cbxFall.TabIndex = 13;
            this.cbxFall.Text = "Fall";
            this.cbxFall.UseVisualStyleBackColor = true;
            // 
            // cbxWinter
            // 
            this.cbxWinter.AutoSize = true;
            this.cbxWinter.Location = new System.Drawing.Point(68, 28);
            this.cbxWinter.Name = "cbxWinter";
            this.cbxWinter.Size = new System.Drawing.Size(57, 17);
            this.cbxWinter.TabIndex = 14;
            this.cbxWinter.Text = "Winter";
            this.cbxWinter.UseVisualStyleBackColor = true;
            // 
            // cbxSummer
            // 
            this.cbxSummer.AutoSize = true;
            this.cbxSummer.Location = new System.Drawing.Point(68, 51);
            this.cbxSummer.Name = "cbxSummer";
            this.cbxSummer.Size = new System.Drawing.Size(64, 17);
            this.cbxSummer.TabIndex = 15;
            this.cbxSummer.Text = "Summer";
            this.cbxSummer.UseVisualStyleBackColor = true;
            // 
            // cbxSpring
            // 
            this.cbxSpring.AutoSize = true;
            this.cbxSpring.Location = new System.Drawing.Point(6, 51);
            this.cbxSpring.Name = "cbxSpring";
            this.cbxSpring.Size = new System.Drawing.Size(56, 17);
            this.cbxSpring.TabIndex = 16;
            this.cbxSpring.Text = "Spring";
            this.cbxSpring.UseVisualStyleBackColor = true;
            // 
            // gbxAvail
            // 
            this.gbxAvail.Controls.Add(this.cbxFall);
            this.gbxAvail.Controls.Add(this.cbxSummer);
            this.gbxAvail.Controls.Add(this.cbxSpring);
            this.gbxAvail.Controls.Add(this.cbxWinter);
            this.gbxAvail.Location = new System.Drawing.Point(15, 141);
            this.gbxAvail.Name = "gbxAvail";
            this.gbxAvail.Size = new System.Drawing.Size(174, 83);
            this.gbxAvail.TabIndex = 17;
            this.gbxAvail.TabStop = false;
            this.gbxAvail.Text = "Availability";
            // 
            // cmdRemove
            // 
            this.cmdRemove.Enabled = false;
            this.cmdRemove.Location = new System.Drawing.Point(382, 298);
            this.cmdRemove.Name = "cmdRemove";
            this.cmdRemove.Size = new System.Drawing.Size(115, 45);
            this.cmdRemove.TabIndex = 18;
            this.cmdRemove.Text = "Remove Course";
            this.cmdRemove.UseVisualStyleBackColor = true;
            this.cmdRemove.Click += new System.EventHandler(this.cmdRemove_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 364);
            this.Controls.Add(this.cmdRemove);
            this.Controls.Add(this.gbxAvail);
            this.Controls.Add(this.lblCourseUnits);
            this.Controls.Add(this.txtCourseUnits);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.cmdGo);
            this.Controls.Add(this.lbxCList);
            this.Name = "frmMain";
            this.Text = "Course Builder";
            this.gbxAvail.ResumeLayout(false);
            this.gbxAvail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCList;
        private System.Windows.Forms.Button cmdGo;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCourseUnits;
        private System.Windows.Forms.TextBox txtCourseUnits;
        private System.Windows.Forms.CheckBox cbxFall;
        private System.Windows.Forms.CheckBox cbxWinter;
        private System.Windows.Forms.CheckBox cbxSummer;
        private System.Windows.Forms.CheckBox cbxSpring;
        private System.Windows.Forms.GroupBox gbxAvail;
        private System.Windows.Forms.Button cmdRemove;
    }
}

