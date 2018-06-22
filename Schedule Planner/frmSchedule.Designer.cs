namespace Schedule_Planner
{
    partial class frmSchedule
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
            this.lbxAvailable = new System.Windows.Forms.ListBox();
            this.cmdSwitch = new System.Windows.Forms.Button();
            this.lbxFall = new System.Windows.Forms.ListBox();
            this.lblFall = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxAvailable
            // 
            this.lbxAvailable.ColumnWidth = 350;
            this.lbxAvailable.FormattingEnabled = true;
            this.lbxAvailable.Location = new System.Drawing.Point(12, 257);
            this.lbxAvailable.MultiColumn = true;
            this.lbxAvailable.Name = "lbxAvailable";
            this.lbxAvailable.Size = new System.Drawing.Size(735, 95);
            this.lbxAvailable.Sorted = true;
            this.lbxAvailable.TabIndex = 0;
            // 
            // cmdSwitch
            // 
            this.cmdSwitch.Location = new System.Drawing.Point(655, 12);
            this.cmdSwitch.Name = "cmdSwitch";
            this.cmdSwitch.Size = new System.Drawing.Size(92, 31);
            this.cmdSwitch.TabIndex = 20;
            this.cmdSwitch.Text = "Open Builder";
            this.cmdSwitch.UseVisualStyleBackColor = true;
            this.cmdSwitch.Click += new System.EventHandler(this.cmdSwitch_Click);
            // 
            // lbxFall
            // 
            this.lbxFall.FormattingEnabled = true;
            this.lbxFall.Location = new System.Drawing.Point(80, 50);
            this.lbxFall.Name = "lbxFall";
            this.lbxFall.Size = new System.Drawing.Size(120, 95);
            this.lbxFall.TabIndex = 21;
            // 
            // lblFall
            // 
            this.lblFall.AutoSize = true;
            this.lblFall.Location = new System.Drawing.Point(39, 50);
            this.lblFall.Name = "lblFall";
            this.lblFall.Size = new System.Drawing.Size(23, 13);
            this.lblFall.TabIndex = 22;
            this.lblFall.Text = "Fall";
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 364);
            this.Controls.Add(this.lblFall);
            this.Controls.Add(this.lbxFall);
            this.Controls.Add(this.cmdSwitch);
            this.Controls.Add(this.lbxAvailable);
            this.Name = "frmSchedule";
            this.Text = "Schedule Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAvailable;
        private System.Windows.Forms.Button cmdSwitch;
        private System.Windows.Forms.ListBox lbxFall;
        private System.Windows.Forms.Label lblFall;
    }
}