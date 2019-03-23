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
            this.picbox_Someren4 = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teacherRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkSuppliesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.picbox_Someren2 = new System.Windows.Forms.PictureBox();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Students = new System.Windows.Forms.Label();
            this.pnl_Cash = new System.Windows.Forms.Panel();
            this.btn_Check = new System.Windows.Forms.Button();
            this.list_Drinks = new System.Windows.Forms.CheckedListBox();
            this.cmbbox_Role = new System.Windows.Forms.ComboBox();
            this.radbtn_Lecturers = new System.Windows.Forms.RadioButton();
            this.radbtn_Students = new System.Windows.Forms.RadioButton();
            this.lbl_Drink = new System.Windows.Forms.Label();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.picbox_Someren1 = new System.Windows.Forms.PictureBox();
            this.pnl_Teachers = new System.Windows.Forms.Panel();
            this.picbox_Someren3 = new System.Windows.Forms.PictureBox();
            this.lbl_Teachers = new System.Windows.Forms.Label();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.pnl_Drink = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Someren4)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            this.pnl_Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Someren2)).BeginInit();
            this.pnl_Cash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Someren1)).BeginInit();
            this.pnl_Teachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Someren3)).BeginInit();
            this.pnl_Drink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picbox_Someren4
            // 
            this.picbox_Someren4.Image = global::SomerenUI.Properties.Resources.someren;
            this.picbox_Someren4.Location = new System.Drawing.Point(1076, 28);
            this.picbox_Someren4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picbox_Someren4.Name = "picbox_Someren4";
            this.picbox_Someren4.Size = new System.Drawing.Size(176, 156);
            this.picbox_Someren4.TabIndex = 0;
            this.picbox_Someren4.TabStop = false;
            this.picbox_Someren4.Click += new System.EventHandler(this.img_Dashboard_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.drinkSuppliesToolStripMenuItem,
            this.cashRegisterToolStripMenuItem,
            this.revenueReportToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1252, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "Menu";
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
            // teacherRoomsToolStripMenuItem
            // 
            this.teacherRoomsToolStripMenuItem.Name = "teacherRoomsToolStripMenuItem";
            this.teacherRoomsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.teacherRoomsToolStripMenuItem.Text = "Teacher rooms";
            this.teacherRoomsToolStripMenuItem.Click += new System.EventHandler(this.teacherRoomsToolStripMenuItem_Click);
            // 
            // studentRoomsToolStripMenuItem
            // 
            this.studentRoomsToolStripMenuItem.Name = "studentRoomsToolStripMenuItem";
            this.studentRoomsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.studentRoomsToolStripMenuItem.Text = "Student rooms";
            this.studentRoomsToolStripMenuItem.Click += new System.EventHandler(this.studentRoomsToolStripMenuItem_Click);
            // 
            // drinkSuppliesToolStripMenuItem
            // 
            this.drinkSuppliesToolStripMenuItem.Name = "drinkSuppliesToolStripMenuItem";
            this.drinkSuppliesToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.drinkSuppliesToolStripMenuItem.Text = "Drink Supplies";
            this.drinkSuppliesToolStripMenuItem.Click += new System.EventHandler(this.drinkSuppliesToolStripMenuItem_Click);
            // 
            // cashRegisterToolStripMenuItem
            // 
            this.cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            this.cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.cashRegisterToolStripMenuItem.Text = "Cash Register";
            this.cashRegisterToolStripMenuItem.Click += new System.EventHandler(this.cashRegisterToolStripMenuItem_Click);
            // 
            // revenueReportToolStripMenuItem
            // 
            this.revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            this.revenueReportToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.revenueReportToolStripMenuItem.Text = "Revenue Report";
            this.revenueReportToolStripMenuItem.Click += new System.EventHandler(this.revenueReportToolStripMenuItem_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Controls.Add(this.picbox_Someren4);
            this.pnl_Dashboard.Location = new System.Drawing.Point(0, 0);
            this.pnl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dashboard.Location = new System.Drawing.Point(31, 42);
            this.lbl_Dashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(512, 36);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            this.lbl_Dashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.picbox_Someren2);
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Location = new System.Drawing.Point(0, 0);
            this.pnl_Students.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Students.TabIndex = 4;
            // 
            // picbox_Someren2
            // 
            this.picbox_Someren2.Image = global::SomerenUI.Properties.Resources.someren;
            this.picbox_Someren2.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbox_Someren2.InitialImage")));
            this.picbox_Someren2.Location = new System.Drawing.Point(1079, 28);
            this.picbox_Someren2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picbox_Someren2.Name = "picbox_Someren2";
            this.picbox_Someren2.Size = new System.Drawing.Size(173, 151);
            this.picbox_Someren2.TabIndex = 0;
            this.picbox_Someren2.TabStop = false;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.Location = new System.Drawing.Point(35, 81);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(1007, 363);
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
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(28, 42);
            this.lbl_Students.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(129, 33);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // pnl_Cash
            // 
            this.pnl_Cash.Controls.Add(this.btn_Check);
            this.pnl_Cash.Controls.Add(this.list_Drinks);
            this.pnl_Cash.Controls.Add(this.cmbbox_Role);
            this.pnl_Cash.Controls.Add(this.radbtn_Lecturers);
            this.pnl_Cash.Controls.Add(this.radbtn_Students);
            this.pnl_Cash.Controls.Add(this.lbl_Drink);
            this.pnl_Cash.Controls.Add(this.lbl_Role);
            this.pnl_Cash.Controls.Add(this.picbox_Someren1);
            this.pnl_Cash.Location = new System.Drawing.Point(0, 0);
            this.pnl_Cash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Cash.Name = "pnl_Cash";
            this.pnl_Cash.Size = new System.Drawing.Size(1261, 583);
            this.pnl_Cash.TabIndex = 6;
            // 
            // btn_Check
            // 
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(157, 318);
            this.btn_Check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(177, 54);
            this.btn_Check.TabIndex = 7;
            this.btn_Check.Text = "Check Out";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // list_Drinks
            // 
            this.list_Drinks.FormattingEnabled = true;
            this.list_Drinks.Location = new System.Drawing.Point(604, 108);
            this.list_Drinks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.list_Drinks.Name = "list_Drinks";
            this.list_Drinks.Size = new System.Drawing.Size(229, 259);
            this.list_Drinks.TabIndex = 6;
            // 
            // cmbbox_Role
            // 
            this.cmbbox_Role.FormattingEnabled = true;
            this.cmbbox_Role.Location = new System.Drawing.Point(129, 159);
            this.cmbbox_Role.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbbox_Role.Name = "cmbbox_Role";
            this.cmbbox_Role.Size = new System.Drawing.Size(229, 24);
            this.cmbbox_Role.TabIndex = 5;
            // 
            // radbtn_Lecturers
            // 
            this.radbtn_Lecturers.AutoSize = true;
            this.radbtn_Lecturers.Location = new System.Drawing.Point(272, 108);
            this.radbtn_Lecturers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radbtn_Lecturers.Name = "radbtn_Lecturers";
            this.radbtn_Lecturers.Size = new System.Drawing.Size(84, 21);
            this.radbtn_Lecturers.TabIndex = 4;
            this.radbtn_Lecturers.Text = "Lectures";
            this.radbtn_Lecturers.UseVisualStyleBackColor = true;
            this.radbtn_Lecturers.CheckedChanged += new System.EventHandler(this.radbtn_Lecturers_CheckedChanged);
            // 
            // radbtn_Students
            // 
            this.radbtn_Students.AutoSize = true;
            this.radbtn_Students.Checked = true;
            this.radbtn_Students.Location = new System.Drawing.Point(129, 108);
            this.radbtn_Students.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radbtn_Students.Name = "radbtn_Students";
            this.radbtn_Students.Size = new System.Drawing.Size(85, 21);
            this.radbtn_Students.TabIndex = 3;
            this.radbtn_Students.TabStop = true;
            this.radbtn_Students.Text = "Students";
            this.radbtn_Students.UseVisualStyleBackColor = true;
            // 
            // lbl_Drink
            // 
            this.lbl_Drink.AutoSize = true;
            this.lbl_Drink.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Drink.Location = new System.Drawing.Point(619, 60);
            this.lbl_Drink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Drink.Name = "lbl_Drink";
            this.lbl_Drink.Size = new System.Drawing.Size(173, 33);
            this.lbl_Drink.TabIndex = 2;
            this.lbl_Drink.Text = "Select Drink";
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Role.Location = new System.Drawing.Point(151, 60);
            this.lbl_Role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(164, 33);
            this.lbl_Role.TabIndex = 1;
            this.lbl_Role.Text = "Select Role";
            // 
            // picbox_Someren1
            // 
            this.picbox_Someren1.Image = global::SomerenUI.Properties.Resources.someren;
            this.picbox_Someren1.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbox_Someren1.InitialImage")));
            this.picbox_Someren1.Location = new System.Drawing.Point(1079, 28);
            this.picbox_Someren1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picbox_Someren1.Name = "picbox_Someren1";
            this.picbox_Someren1.Size = new System.Drawing.Size(173, 151);
            this.picbox_Someren1.TabIndex = 0;
            this.picbox_Someren1.TabStop = false;
            // 
            // pnl_Teachers
            // 
            this.pnl_Teachers.Controls.Add(this.picbox_Someren3);
            this.pnl_Teachers.Controls.Add(this.lbl_Teachers);
            this.pnl_Teachers.Controls.Add(this.listViewTeachers);
            this.pnl_Teachers.Location = new System.Drawing.Point(0, 0);
            this.pnl_Teachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Teachers.Name = "pnl_Teachers";
            this.pnl_Teachers.Size = new System.Drawing.Size(1251, 577);
            this.pnl_Teachers.TabIndex = 6;
            // 
            // picbox_Someren3
            // 
            this.picbox_Someren3.Image = global::SomerenUI.Properties.Resources.someren;
            this.picbox_Someren3.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbox_Someren3.InitialImage")));
            this.picbox_Someren3.Location = new System.Drawing.Point(1079, 28);
            this.picbox_Someren3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picbox_Someren3.Name = "picbox_Someren3";
            this.picbox_Someren3.Size = new System.Drawing.Size(173, 151);
            this.picbox_Someren3.TabIndex = 2;
            this.picbox_Someren3.TabStop = false;
            // 
            // lbl_Teachers
            // 
            this.lbl_Teachers.AutoSize = true;
            this.lbl_Teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Teachers.Location = new System.Drawing.Point(31, 42);
            this.lbl_Teachers.Name = "lbl_Teachers";
            this.lbl_Teachers.Size = new System.Drawing.Size(137, 33);
            this.lbl_Teachers.TabIndex = 1;
            this.lbl_Teachers.Text = "Teachers";
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Location = new System.Drawing.Point(35, 81);
            this.listViewTeachers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(1007, 365);
            this.listViewTeachers.TabIndex = 0;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            // 
            // pnl_Drink
            // 
            this.pnl_Drink.Controls.Add(this.pictureBox1);
            this.pnl_Drink.Location = new System.Drawing.Point(0, 0);
            this.pnl_Drink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Drink.Name = "pnl_Drink";
            this.pnl_Drink.Size = new System.Drawing.Size(1251, 574);
            this.pnl_Drink.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1079, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 622);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pnl_Drink);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_Teachers);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.pnl_Cash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Someren4)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Someren2)).EndInit();
            this.pnl_Cash.ResumeLayout(false);
            this.pnl_Cash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Someren1)).EndInit();
            this.pnl_Teachers.ResumeLayout(false);
            this.pnl_Teachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Someren3)).EndInit();
            this.pnl_Drink.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbox_Someren4;
        private System.Windows.Forms.MenuStrip menuStrip;
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
        private System.Windows.Forms.PictureBox picbox_Someren2;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.Panel pnl_Teachers;
        private System.Windows.Forms.Label lbl_Teachers;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ToolStripMenuItem teacherRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinkSuppliesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueReportToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Cash;
        private System.Windows.Forms.PictureBox picbox_Someren1;
        private System.Windows.Forms.CheckedListBox list_Drinks;
        private System.Windows.Forms.ComboBox cmbbox_Role;
        private System.Windows.Forms.RadioButton radbtn_Lecturers;
        private System.Windows.Forms.RadioButton radbtn_Students;
        private System.Windows.Forms.Label lbl_Drink;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.PictureBox picbox_Someren3;
        private System.Windows.Forms.Panel pnl_Drink;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

