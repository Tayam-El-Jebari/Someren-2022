﻿namespace SomerenUI
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
            this.imgDashboard = new System.Windows.Forms.PictureBox();
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
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.pnlRoomPanel = new System.Windows.Forms.Panel();
            this.listViewRoom = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxSomerenRoom = new System.Windows.Forms.PictureBox();
            this.labelRoomTitle = new System.Windows.Forms.Label();
            this.pnlTeacherPanel = new System.Windows.Forms.Panel();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxSomerenTeacher = new System.Windows.Forms.PictureBox();
            this.labelTitleTeachers = new System.Windows.Forms.Label();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBoxSomerenStudent = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.pnlStudents.SuspendLayout();
            this.pnlRoomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomerenRoom)).BeginInit();
            this.pnlTeacherPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomerenTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomerenStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // imgDashboard
            // 
            this.imgDashboard.Location = new System.Drawing.Point(836, 0);
            this.imgDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.imgDashboard.Name = "imgDashboard";
            this.imgDashboard.Size = new System.Drawing.Size(415, 332);
            this.imgDashboard.TabIndex = 0;
            this.imgDashboard.TabStop = false;
            this.imgDashboard.Click += new System.EventHandler(this.imgDashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.teachersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1283, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
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
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // teachersToolStripMenuItem
            // 
            this.teachersToolStripMenuItem.Name = "teachersToolStripMenuItem";
            this.teachersToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.teachersToolStripMenuItem.Text = "Teachers";
            this.teachersToolStripMenuItem.Click += new System.EventHandler(this.teachersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.activitiesToolStripMenuItem.Text = "Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click_1);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lbl_Dashboard);
            this.pnlDashboard.Controls.Add(this.imgDashboard);
            this.pnlDashboard.Location = new System.Drawing.Point(13, 35);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1251, 574);
            this.pnlDashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(17, 16);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(243, 17);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Controls.Add(this.pictureBoxSomerenStudent);
            this.pnlStudents.Controls.Add(this.lbl_Students);
            this.pnlStudents.Location = new System.Drawing.Point(13, 32);
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(4);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(1251, 574);
            this.pnlStudents.TabIndex = 4;
            // 
            // pnlRoomPanel
            // 
            this.pnlRoomPanel.Controls.Add(this.listViewRoom);
            this.pnlRoomPanel.Controls.Add(this.pictureBoxSomerenRoom);
            this.pnlRoomPanel.Controls.Add(this.labelRoomTitle);
            this.pnlRoomPanel.Location = new System.Drawing.Point(8, 32);
            this.pnlRoomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRoomPanel.Name = "pnlRoomPanel";
            this.pnlRoomPanel.Size = new System.Drawing.Size(1251, 574);
            this.pnlRoomPanel.TabIndex = 6;
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
            this.listViewRoom.SelectedIndexChanged += new System.EventHandler(this.listViewRoom_SelectedIndexChanged);
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
            // labelRoomTitle
            // 
            this.labelRoomTitle.AutoSize = true;
            this.labelRoomTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoomTitle.Location = new System.Drawing.Point(13, 12);
            this.labelRoomTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoomTitle.Name = "labelRoomTitle";
            this.labelRoomTitle.Size = new System.Drawing.Size(108, 33);
            this.labelRoomTitle.TabIndex = 3;
            this.labelRoomTitle.Text = "Rooms";
            // 
            // pnlTeacherPanel
            // 
            this.pnlTeacherPanel.Controls.Add(this.listViewTeachers);
            this.pnlTeacherPanel.Controls.Add(this.pictureBoxSomerenTeacher);
            this.pnlTeacherPanel.Controls.Add(this.labelTitleTeachers);
            this.pnlTeacherPanel.Location = new System.Drawing.Point(8, 31);
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
            this.labelTitleTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleTeachers.Location = new System.Drawing.Point(13, 12);
            this.labelTitleTeachers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitleTeachers.Name = "labelTitleTeachers";
            this.labelTitleTeachers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitleTeachers.Size = new System.Drawing.Size(137, 33);
            this.labelTitleTeachers.TabIndex = 3;
            this.labelTitleTeachers.Text = "Teachers";
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
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(13, 12);
            this.lbl_Students.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(129, 33);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1283, 622);
            this.Controls.Add(this.pnlRoomPanel);
            this.Controls.Add(this.pnlTeacherPanel);
            this.Controls.Add(this.pnlStudents);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.pnlRoomPanel.ResumeLayout(false);
            this.pnlRoomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomerenRoom)).EndInit();
            this.pnlTeacherPanel.ResumeLayout(false);
            this.pnlTeacherPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomerenTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomerenStudent)).EndInit();
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
        private System.Windows.Forms.Label lbl_Dashboard;
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
        private System.Windows.Forms.Panel pnlRoomPanel;
        private System.Windows.Forms.ListView listViewRoom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.PictureBox pictureBoxSomerenRoom;
        private System.Windows.Forms.Label labelRoomTitle;
        private System.Windows.Forms.Panel pnlTeacherPanel;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBoxSomerenTeacher;
        private System.Windows.Forms.Label labelTitleTeachers;
    }
}

