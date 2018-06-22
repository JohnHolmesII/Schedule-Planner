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
            this.lblWinter = new System.Windows.Forms.Label();
            this.lbxWinter = new System.Windows.Forms.ListBox();
            this.lblSpring = new System.Windows.Forms.Label();
            this.lbxSpring = new System.Windows.Forms.ListBox();
            this.lblSummer = new System.Windows.Forms.Label();
            this.lbxSummer = new System.Windows.Forms.ListBox();
            this.rboFall = new System.Windows.Forms.RadioButton();
            this.rboWinter = new System.Windows.Forms.RadioButton();
            this.rboSpring = new System.Windows.Forms.RadioButton();
            this.rboSummer = new System.Windows.Forms.RadioButton();
            this.cmdAdd = new System.Windows.Forms.Button();
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
            this.lbxAvailable.SelectedIndexChanged += new System.EventHandler(this.lbxAvailable_SelectedIndexChanged);
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
            this.lbxFall.Location = new System.Drawing.Point(52, 12);
            this.lbxFall.Name = "lbxFall";
            this.lbxFall.Size = new System.Drawing.Size(120, 95);
            this.lbxFall.TabIndex = 21;
            // 
            // lblFall
            // 
            this.lblFall.AutoSize = true;
            this.lblFall.Location = new System.Drawing.Point(23, 12);
            this.lblFall.Name = "lblFall";
            this.lblFall.Size = new System.Drawing.Size(23, 13);
            this.lblFall.TabIndex = 22;
            this.lblFall.Text = "Fall";
            // 
            // lblWinter
            // 
            this.lblWinter.AutoSize = true;
            this.lblWinter.Location = new System.Drawing.Point(206, 12);
            this.lblWinter.Name = "lblWinter";
            this.lblWinter.Size = new System.Drawing.Size(38, 13);
            this.lblWinter.TabIndex = 24;
            this.lblWinter.Text = "Winter";
            // 
            // lbxWinter
            // 
            this.lbxWinter.FormattingEnabled = true;
            this.lbxWinter.Location = new System.Drawing.Point(250, 12);
            this.lbxWinter.Name = "lbxWinter";
            this.lbxWinter.Size = new System.Drawing.Size(120, 95);
            this.lbxWinter.TabIndex = 23;
            // 
            // lblSpring
            // 
            this.lblSpring.AutoSize = true;
            this.lblSpring.Location = new System.Drawing.Point(12, 138);
            this.lblSpring.Name = "lblSpring";
            this.lblSpring.Size = new System.Drawing.Size(37, 13);
            this.lblSpring.TabIndex = 26;
            this.lblSpring.Text = "Spring";
            // 
            // lbxSpring
            // 
            this.lbxSpring.FormattingEnabled = true;
            this.lbxSpring.Location = new System.Drawing.Point(52, 138);
            this.lbxSpring.Name = "lbxSpring";
            this.lbxSpring.Size = new System.Drawing.Size(120, 95);
            this.lbxSpring.TabIndex = 25;
            // 
            // lblSummer
            // 
            this.lblSummer.AutoSize = true;
            this.lblSummer.Location = new System.Drawing.Point(199, 138);
            this.lblSummer.Name = "lblSummer";
            this.lblSummer.Size = new System.Drawing.Size(45, 13);
            this.lblSummer.TabIndex = 28;
            this.lblSummer.Text = "Summer";
            // 
            // lbxSummer
            // 
            this.lbxSummer.FormattingEnabled = true;
            this.lbxSummer.Location = new System.Drawing.Point(250, 138);
            this.lbxSummer.Name = "lbxSummer";
            this.lbxSummer.Size = new System.Drawing.Size(120, 95);
            this.lbxSummer.TabIndex = 27;
            // 
            // rboFall
            // 
            this.rboFall.AutoSize = true;
            this.rboFall.Checked = true;
            this.rboFall.Location = new System.Drawing.Point(448, 152);
            this.rboFall.Name = "rboFall";
            this.rboFall.Size = new System.Drawing.Size(41, 17);
            this.rboFall.TabIndex = 29;
            this.rboFall.TabStop = true;
            this.rboFall.Text = "Fall";
            this.rboFall.UseVisualStyleBackColor = true;
            // 
            // rboWinter
            // 
            this.rboWinter.AutoSize = true;
            this.rboWinter.Location = new System.Drawing.Point(509, 152);
            this.rboWinter.Name = "rboWinter";
            this.rboWinter.Size = new System.Drawing.Size(56, 17);
            this.rboWinter.TabIndex = 30;
            this.rboWinter.Text = "Winter";
            this.rboWinter.UseVisualStyleBackColor = true;
            // 
            // rboSpring
            // 
            this.rboSpring.AutoSize = true;
            this.rboSpring.Location = new System.Drawing.Point(448, 185);
            this.rboSpring.Name = "rboSpring";
            this.rboSpring.Size = new System.Drawing.Size(55, 17);
            this.rboSpring.TabIndex = 31;
            this.rboSpring.Text = "Spring";
            this.rboSpring.UseVisualStyleBackColor = true;
            // 
            // rboSummer
            // 
            this.rboSummer.AutoSize = true;
            this.rboSummer.Location = new System.Drawing.Point(509, 185);
            this.rboSummer.Name = "rboSummer";
            this.rboSummer.Size = new System.Drawing.Size(63, 17);
            this.rboSummer.TabIndex = 32;
            this.rboSummer.Text = "Summer";
            this.rboSummer.UseVisualStyleBackColor = true;
            // 
            // cmdAdd
            // 
            this.cmdAdd.Enabled = false;
            this.cmdAdd.Location = new System.Drawing.Point(448, 220);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(124, 31);
            this.cmdAdd.TabIndex = 33;
            this.cmdAdd.Text = "Add Course";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 364);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.rboSummer);
            this.Controls.Add(this.rboSpring);
            this.Controls.Add(this.rboWinter);
            this.Controls.Add(this.rboFall);
            this.Controls.Add(this.lblSummer);
            this.Controls.Add(this.lbxSummer);
            this.Controls.Add(this.lblSpring);
            this.Controls.Add(this.lbxSpring);
            this.Controls.Add(this.lblWinter);
            this.Controls.Add(this.lbxWinter);
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
        private System.Windows.Forms.Label lblWinter;
        private System.Windows.Forms.ListBox lbxWinter;
        private System.Windows.Forms.Label lblSpring;
        private System.Windows.Forms.ListBox lbxSpring;
        private System.Windows.Forms.Label lblSummer;
        private System.Windows.Forms.ListBox lbxSummer;
        private System.Windows.Forms.RadioButton rboFall;
        private System.Windows.Forms.RadioButton rboWinter;
        private System.Windows.Forms.RadioButton rboSpring;
        private System.Windows.Forms.RadioButton rboSummer;
        private System.Windows.Forms.Button cmdAdd;
    }
}