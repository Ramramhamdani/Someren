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
            this.img_Dashboard = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnl_Teachers = new System.Windows.Forms.Panel();
            this.lbl_Teachers = new System.Windows.Forms.Label();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.teacherRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.pnl_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_Teachers.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_Dashboard
            // 
            this.img_Dashboard.Location = new System.Drawing.Point(836, 0);
            this.img_Dashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.img_Dashboard.Name = "img_Dashboard";
            this.img_Dashboard.Size = new System.Drawing.Size(414, 332);
            this.img_Dashboard.TabIndex = 0;
            this.img_Dashboard.TabStop = false;
            this.img_Dashboard.Click += new System.EventHandler(this.img_Dashboard_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
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
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherRoomsToolStripMenuItem,
            this.studentRoomsToolStripMenuItem});
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Controls.Add(this.img_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(18, 16);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(243, 17);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Controls.Add(this.pictureBox1);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Location = new System.Drawing.Point(0, 0);
            this.pnl_Students.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Students.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.Location = new System.Drawing.Point(21, 66);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(1020, 363);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1074, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(28, 26);
            this.lbl_Students.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(129, 33);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnl_Teachers
            // 
            this.pnl_Teachers.Controls.Add(this.lbl_Teachers);
            this.pnl_Teachers.Controls.Add(this.listViewTeachers);
            this.pnl_Teachers.Location = new System.Drawing.Point(0, 0);
            this.pnl_Teachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Teachers.Name = "pnl_Teachers";
            this.pnl_Teachers.Size = new System.Drawing.Size(1251, 577);
            this.pnl_Teachers.TabIndex = 6;
            // 
            // lbl_Teachers
            // 
            this.lbl_Teachers.AutoSize = true;
            this.lbl_Teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Teachers.Location = new System.Drawing.Point(15, 28);
            this.lbl_Teachers.Name = "lbl_Teachers";
            this.lbl_Teachers.Size = new System.Drawing.Size(128, 31);
            this.lbl_Teachers.TabIndex = 1;
            this.lbl_Teachers.Text = "Teachers";
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Location = new System.Drawing.Point(21, 66);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(1021, 365);
            this.listViewTeachers.TabIndex = 0;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // teacherRoomsToolStripMenuItem
            // 
            this.teacherRoomsToolStripMenuItem.Name = "teacherRoomsToolStripMenuItem";
            this.teacherRoomsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.teacherRoomsToolStripMenuItem.Text = "Teacher rooms";
            this.teacherRoomsToolStripMenuItem.Click += new System.EventHandler(this.teacherRoomsToolStripMenuItem_Click);
            // 
            // studentRoomsToolStripMenuItem
            // 
            this.studentRoomsToolStripMenuItem.Name = "studentRoomsToolStripMenuItem";
            this.studentRoomsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.studentRoomsToolStripMenuItem.Text = "Student rooms";
            this.studentRoomsToolStripMenuItem.Click += new System.EventHandler(this.studentRoomsToolStripMenuItem_Click);
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 622);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_Teachers);
            this.Controls.Add(this.pnl_Dashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Dashboard)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_Teachers.ResumeLayout(false);
            this.pnl_Teachers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_Dashboard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Students;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.Panel pnl_Teachers;
        private System.Windows.Forms.Label lbl_Teachers;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ToolStripMenuItem teacherRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRoomsToolStripMenuItem;
    }
}

