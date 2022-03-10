namespace SomerenUI
{
    partial class SomerenUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lbl_dashboard_shortcuts = new System.Windows.Forms.Label();
            this.lbl_Dashboard_welcome = new System.Windows.Forms.Label();
            this.imgDashboard = new System.Windows.Forms.PictureBox();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxSomerenStudent = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnlTeacherPanel = new System.Windows.Forms.Panel();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxSomerenTeacher = new System.Windows.Forms.PictureBox();
            this.labelTitleTeachers = new System.Windows.Forms.Label();
            this.labelRoomTitle = new System.Windows.Forms.Label();
            this.listViewRoom = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlRoomPanel = new System.Windows.Forms.Panel();
            this.pictureBoxSomerenRoom = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).BeginInit();
            this.pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomerenStudent)).BeginInit();
            this.pnlTeacherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomerenTeacher)).BeginInit();
            this.pnlRoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomerenRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1283, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 26);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.teachersToolStripMenuItem.Text = "Teachers";
            this.teachersToolStripMenuItem.Click += new System.EventHandler(this.teachersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.activitiesToolStripMenuItem.Text = "Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click_1);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.pnlDashboard.Controls.Add(this.lbl_dashboard_shortcuts);
            this.pnlDashboard.Controls.Add(this.lbl_Dashboard_welcome);
            this.pnlDashboard.Controls.Add(this.imgDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(13, 35);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1251, 574);
            this.pnlDashboard.TabIndex = 2;
            // 
            // lbl_dashboard_shortcuts
            // 
            this.lbl_dashboard_shortcuts.AutoSize = true;
            this.lbl_dashboard_shortcuts.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dashboard_shortcuts.ForeColor = System.Drawing.Color.Snow;
            this.lbl_dashboard_shortcuts.Location = new System.Drawing.Point(527, 343);
            this.lbl_dashboard_shortcuts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_dashboard_shortcuts.Name = "lbl_dashboard_shortcuts";
            this.lbl_dashboard_shortcuts.Size = new System.Drawing.Size(158, 38);
            this.lbl_dashboard_shortcuts.TabIndex = 2;
            this.lbl_dashboard_shortcuts.Text = "shortcuts";
            // 
            // lbl_Dashboard_welcome
            // 
            this.lbl_Dashboard_welcome.AutoSize = true;
            this.lbl_Dashboard_welcome.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dashboard_welcome.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Dashboard_welcome.Location = new System.Drawing.Point(21, 5);
            this.lbl_Dashboard_welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard_welcome.Name = "lbl_Dashboard_welcome";
            this.lbl_Dashboard_welcome.Size = new System.Drawing.Size(394, 26);
            this.lbl_Dashboard_welcome.TabIndex = 1;
            this.lbl_Dashboard_welcome.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard_welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // imgDashboard
            // 
            this.imgDashboard.Image = global::SomerenUI.Properties.Resources.csm_heide_tot_aan_de_horizon_natiopnale_beeldbank_e7ebebd92d;
            this.imgDashboard.Location = new System.Drawing.Point(-57, 31);
            this.imgDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.imgDashboard.Name = "imgDashboard";
            this.imgDashboard.Size = new System.Drawing.Size(1314, 294);
            this.imgDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgDashboard.TabIndex = 0;
            this.imgDashboard.TabStop = false;
            this.imgDashboard.Click += new System.EventHandler(this.imgDashboard_Click);
            // 
            // pnlStudents
            // 
            this.pnlStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Controls.Add(this.pictureBoxSomerenStudent);
            this.pnlStudents.Controls.Add(this.lbl_Students);
            this.pnlStudents.Location = new System.Drawing.Point(1, 28);
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(1251, 574);
            this.pnlStudents.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.HideSelection = false;
            this.listViewStudents.Location = new System.Drawing.Point(21, 52);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(4);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(1020, 377);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            // 
            // pictureBoxSomerenStudent
            // 
            this.pictureBoxSomerenStudent.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBoxSomerenStudent.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSomerenStudent.InitialImage")));
            this.pictureBoxSomerenStudent.Location = new System.Drawing.Point(1073, 0);
            this.pictureBoxSomerenStudent.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSomerenStudent.Name = "pictureBoxSomerenStudent";
            this.pictureBoxSomerenStudent.Size = new System.Drawing.Size(173, 151);
            this.pictureBoxSomerenStudent.TabIndex = 0;
            this.pictureBoxSomerenStudent.TabStop = false;
            this.pictureBoxSomerenStudent.Click += new System.EventHandler(this.pictureBoxSomerenStudent_Click);
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.ForeColor = System.Drawing.Color.Snow;
            this.lbl_Students.Location = new System.Drawing.Point(13, 12);
            this.lbl_Students.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(146, 38);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnlTeacherPanel
            // 
            this.pnlTeacherPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.pnlTeacherPanel.Controls.Add(this.listViewTeachers);
            this.pnlTeacherPanel.Controls.Add(this.pictureBoxSomerenTeacher);
            this.pnlTeacherPanel.Controls.Add(this.labelTitleTeachers);
            this.pnlTeacherPanel.Location = new System.Drawing.Point(4, 28);
            this.pnlTeacherPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTeacherPanel.Name = "pnlTeacherPanel";
            this.pnlTeacherPanel.Size = new System.Drawing.Size(1251, 574);
            this.pnlTeacherPanel.TabIndex = 7;
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(21, 52);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(4);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(1020, 377);
            this.listViewTeachers.TabIndex = 5;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date of Birth";
            // 
            // pictureBoxSomerenTeacher
            // 
            this.pictureBoxSomerenTeacher.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBoxSomerenTeacher.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSomerenTeacher.InitialImage")));
            this.pictureBoxSomerenTeacher.Location = new System.Drawing.Point(1073, 0);
            this.pictureBoxSomerenTeacher.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSomerenTeacher.Name = "pictureBoxSomerenTeacher";
            this.pictureBoxSomerenTeacher.Size = new System.Drawing.Size(173, 151);
            this.pictureBoxSomerenTeacher.TabIndex = 0;
            this.pictureBoxSomerenTeacher.TabStop = false;
            this.pictureBoxSomerenTeacher.Click += new System.EventHandler(this.pictureBoxSomerenTeacher_Click);
            // 
            // labelTitleTeachers
            // 
            this.labelTitleTeachers.AutoSize = true;
            this.labelTitleTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleTeachers.ForeColor = System.Drawing.Color.Snow;
            this.labelTitleTeachers.Location = new System.Drawing.Point(13, 12);
            this.labelTitleTeachers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleTeachers.Name = "labelTitleTeachers";
            this.labelTitleTeachers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitleTeachers.Size = new System.Drawing.Size(154, 38);
            this.labelTitleTeachers.TabIndex = 3;
            this.labelTitleTeachers.Text = "Teachers";
            // 
            // labelRoomTitle
            // 
            this.labelRoomTitle.AutoSize = true;
            this.labelRoomTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomTitle.ForeColor = System.Drawing.Color.Snow;
            this.labelRoomTitle.Location = new System.Drawing.Point(13, 12);
            this.labelRoomTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoomTitle.Name = "labelRoomTitle";
            this.labelRoomTitle.Size = new System.Drawing.Size(121, 38);
            this.labelRoomTitle.TabIndex = 3;
            this.labelRoomTitle.Text = "Rooms";
            // 
            // listViewRoom
            // 
            this.listViewRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewRoom.HideSelection = false;
            this.listViewRoom.Location = new System.Drawing.Point(21, 52);
            this.listViewRoom.Margin = new System.Windows.Forms.Padding(4);
            this.listViewRoom.Name = "listViewRoom";
            this.listViewRoom.Size = new System.Drawing.Size(991, 500);
            this.listViewRoom.TabIndex = 5;
            this.listViewRoom.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date of Birth";
            // 
            // pnlRoomPanel
            // 
            this.pnlRoomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(75)))), ((int)(((byte)(109)))));
            this.pnlRoomPanel.Controls.Add(this.listViewRoom);
            this.pnlRoomPanel.Controls.Add(this.pictureBoxSomerenRoom);
            this.pnlRoomPanel.Controls.Add(this.labelRoomTitle);
            this.pnlRoomPanel.Location = new System.Drawing.Point(2, 28);
            this.pnlRoomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRoomPanel.Name = "pnlRoomPanel";
            this.pnlRoomPanel.Size = new System.Drawing.Size(1251, 574);
            this.pnlRoomPanel.TabIndex = 6;
            // 
            // pictureBoxSomerenRoom
            // 
            this.pictureBoxSomerenRoom.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBoxSomerenRoom.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSomerenRoom.InitialImage")));
            this.pictureBoxSomerenRoom.Location = new System.Drawing.Point(1073, 0);
            this.pictureBoxSomerenRoom.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxSomerenRoom.Name = "pictureBoxSomerenRoom";
            this.pictureBoxSomerenRoom.Size = new System.Drawing.Size(173, 151);
            this.pictureBoxSomerenRoom.TabIndex = 0;
            this.pictureBoxSomerenRoom.TabStop = false;
            this.pictureBoxSomerenRoom.Click += new System.EventHandler(this.pictureBoxSomerenRoom_Click);
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1283, 622);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlRoomPanel);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlTeacherPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).EndInit();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomerenStudent)).EndInit();
            this.pnlTeacherPanel.ResumeLayout(false);
            this.pnlTeacherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomerenTeacher)).EndInit();
            this.pnlRoomPanel.ResumeLayout(false);
            this.pnlRoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomerenRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lbl_Dashboard_welcome;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBoxSomerenStudent;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.Panel pnlTeacherPanel;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBoxSomerenTeacher;
        private System.Windows.Forms.Label labelTitleTeachers;
        private System.Windows.Forms.Label labelRoomTitle;
        private System.Windows.Forms.PictureBox pictureBoxSomerenRoom;
        private System.Windows.Forms.ListView listViewRoom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel pnlRoomPanel;
        private System.Windows.Forms.Label lbl_dashboard_shortcuts;
    }
}

