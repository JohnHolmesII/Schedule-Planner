namespace Schedule_Planner
{
    partial class frmCourse
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
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCo = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbxPre = new System.Windows.Forms.ListBox();
            this.lbxCo = new System.Windows.Forms.ListBox();
            this.gbxAvail = new System.Windows.Forms.GroupBox();
            this.cbxSummer = new System.Windows.Forms.CheckBox();
            this.cbxSpring = new System.Windows.Forms.CheckBox();
            this.cbxWinter = new System.Windows.Forms.CheckBox();
            this.cbxFall = new System.Windows.Forms.CheckBox();
            this.gbxAvail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(12, 15);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(54, 13);
            this.lblCourseID.TabIndex = 0;
            this.lblCourseID.Text = "Course ID";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(12, 43);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(96, 13);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Course Description";
            // 
            // lblCo
            // 
            this.lblCo.AutoSize = true;
            this.lblCo.Location = new System.Drawing.Point(12, 162);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(64, 13);
            this.lblCo.TabIndex = 3;
            this.lblCo.Text = "Corequisites";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(12, 87);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(67, 13);
            this.lblPre.TabIndex = 4;
            this.lblPre.Text = "Prerequisites";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.SystemColors.Window;
            this.txtDesc.Location = new System.Drawing.Point(114, 40);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(291, 20);
            this.txtDesc.TabIndex = 5;
            this.txtDesc.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(114, 12);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            this.txtID.TabStop = false;
            // 
            // lbxPre
            // 
            this.lbxPre.FormattingEnabled = true;
            this.lbxPre.Location = new System.Drawing.Point(114, 87);
            this.lbxPre.Name = "lbxPre";
            this.lbxPre.Size = new System.Drawing.Size(291, 69);
            this.lbxPre.TabIndex = 8;
            this.lbxPre.TabStop = false;
            // 
            // lbxCo
            // 
            this.lbxCo.FormattingEnabled = true;
            this.lbxCo.Location = new System.Drawing.Point(114, 162);
            this.lbxCo.Name = "lbxCo";
            this.lbxCo.Size = new System.Drawing.Size(291, 69);
            this.lbxCo.TabIndex = 9;
            this.lbxCo.TabStop = false;
            // 
            // gbxAvail
            // 
            this.gbxAvail.Controls.Add(this.cbxSummer);
            this.gbxAvail.Controls.Add(this.cbxSpring);
            this.gbxAvail.Controls.Add(this.cbxWinter);
            this.gbxAvail.Controls.Add(this.cbxFall);
            this.gbxAvail.Location = new System.Drawing.Point(15, 249);
            this.gbxAvail.Name = "gbxAvail";
            this.gbxAvail.Size = new System.Drawing.Size(200, 100);
            this.gbxAvail.TabIndex = 10;
            this.gbxAvail.TabStop = false;
            this.gbxAvail.Text = "Availability";
            // 
            // cbxSummer
            // 
            this.cbxSummer.AutoSize = true;
            this.cbxSummer.Enabled = false;
            this.cbxSummer.Location = new System.Drawing.Point(115, 65);
            this.cbxSummer.Name = "cbxSummer";
            this.cbxSummer.Size = new System.Drawing.Size(64, 17);
            this.cbxSummer.TabIndex = 13;
            this.cbxSummer.Text = "Summer";
            this.cbxSummer.UseVisualStyleBackColor = true;
            // 
            // cbxSpring
            // 
            this.cbxSpring.AutoSize = true;
            this.cbxSpring.Enabled = false;
            this.cbxSpring.Location = new System.Drawing.Point(22, 65);
            this.cbxSpring.Name = "cbxSpring";
            this.cbxSpring.Size = new System.Drawing.Size(56, 17);
            this.cbxSpring.TabIndex = 12;
            this.cbxSpring.Text = "Spring";
            this.cbxSpring.UseVisualStyleBackColor = true;
            // 
            // cbxWinter
            // 
            this.cbxWinter.AutoSize = true;
            this.cbxWinter.Enabled = false;
            this.cbxWinter.Location = new System.Drawing.Point(115, 19);
            this.cbxWinter.Name = "cbxWinter";
            this.cbxWinter.Size = new System.Drawing.Size(57, 17);
            this.cbxWinter.TabIndex = 12;
            this.cbxWinter.Text = "Winter";
            this.cbxWinter.UseVisualStyleBackColor = true;
            // 
            // cbxFall
            // 
            this.cbxFall.AutoSize = true;
            this.cbxFall.Enabled = false;
            this.cbxFall.Location = new System.Drawing.Point(22, 19);
            this.cbxFall.Name = "cbxFall";
            this.cbxFall.Size = new System.Drawing.Size(42, 17);
            this.cbxFall.TabIndex = 11;
            this.cbxFall.Text = "Fall";
            this.cbxFall.UseVisualStyleBackColor = true;
            // 
            // frmCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(417, 361);
            this.Controls.Add(this.gbxAvail);
            this.Controls.Add(this.lbxCo);
            this.Controls.Add(this.lbxPre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblCourseID);
            this.Name = "frmCourse";
            this.Text = "Course Information Viewer";
            this.Load += new System.EventHandler(this.frmCourse_Load);
            this.gbxAvail.ResumeLayout(false);
            this.gbxAvail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ListBox lbxPre;
        private System.Windows.Forms.ListBox lbxCo;
        private System.Windows.Forms.GroupBox gbxAvail;
        private System.Windows.Forms.CheckBox cbxSummer;
        private System.Windows.Forms.CheckBox cbxSpring;
        private System.Windows.Forms.CheckBox cbxWinter;
        private System.Windows.Forms.CheckBox cbxFall;
    }
}