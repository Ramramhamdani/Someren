using SomerenModel;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {
            if (panelName == "Dashboard") {
                // hide all other panels
                pnl_Students.Hide();
                pnl_Teachers.Hide();
                pnl_Cash.Hide();
                pnl_Drink.Hide();
                //pnl_Rooms etc.. ******************************************* Add the rest

                // show dashboard
                pnl_Dashboard.Show();
                picbox_Someren4.Show();
            }
            else if (panelName == "Students") {
                // hide all other panels
                pnl_Dashboard.Hide();
                picbox_Someren4.Hide();
                pnl_Teachers.Hide();
                pnl_Cash.Hide();
                pnl_Drink.Hide();

                // show students
                pnl_Students.Show();

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.Clear();

                listViewStudents.Columns.Add("Name");
                foreach (SomerenModel.Student s in studentList) {
                    // Add the name to the list
                    ListViewItem li = new ListViewItem(s.Firstname);
                    listViewStudents.Items.Add(li);
                }
                /* ************************************************* RADIO BUTTONS! Switch between detailed and compact
                listViewStudents.View = View.Details; ************************** Second option with first and last name: detailed view

                listViewStudents.Columns.Add("FirstName"); 
                listViewStudents.Columns.Add("LastName");
                foreach (SomerenModel.Student s in studentList)
                {
                    ListViewItem li = new ListViewItem(s.Firstname);
                    listViewStudents.Items.Add(li);
                    li.SubItems.Add(s.Lastname);
                }
                */
            }
            else if (panelName == "Teachers") {
                // hide all other panels
                pnl_Dashboard.Hide();
                picbox_Someren4.Hide();
                pnl_Students.Hide();
                pnl_Cash.Hide();
                pnl_Drink.Hide();

                // show students
                pnl_Teachers.Show();

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Teacher_Service teachService = new SomerenLogic.Teacher_Service();
                List<Teacher> teacherList = teachService.GetTeachers();

                // clear the listview before filling it again
                listViewTeachers.Items.Clear();
                listViewTeachers.Columns.Add("Teachers", 100, HorizontalAlignment.Left);

                foreach (SomerenModel.Teacher t in teacherList) {
                    ListViewItem li = new ListViewItem(t.FirstName);
                    listViewTeachers.Items.Add(li);
                }
                /*
                listViewTeachers.View = View.Details; ************************** Second option with first and last name: detailed view

                listViewTeachers.Columns.Add(" TeacherID", 100, HorizontalAlignment.Left);
                listViewTeachers.Columns.Add("FirstName", 100, HorizontalAlignment.Left);
                listViewTeachers.Columns.Add("LastName", 100, HorizontalAlignment.Left);
                listViewTeachers.Columns.Add("Supervisor", 100, HorizontalAlignment.Left);

                foreach (SomerenModel.Teacher t in teacherList) {
                    ListViewItem li = new ListViewItem(t.teacherID.ToString());
                    li.SubItems.Add(t.FirstName);
                    li.SubItems.Add(t.LastName);
                    li.SubItems.Add(t.Supervisor);
                    listViewTeachers.Items.Add(li);
                }
                */
            }
            // ********************************************** have one list of rooms
            else if (panelName == "StudentRoom") {
                // hide all other panels
                pnl_Dashboard.Hide();
                picbox_Someren4.Hide();
                pnl_Cash.Hide();
                pnl_Drink.Hide();

                lbl_Students.Text = "Student's Room";
                // show students
                pnl_Students.Show();

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Sroom_Service roomService = new SomerenLogic.Sroom_Service();
                List<Room> roomList = roomService.GetRoom();

                // clear the listview before filling it again
                listViewStudents.Clear();

                //Adding columns
                listViewStudents.View = View.Details;
                listViewStudents.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("student/student", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("capacity", -2, HorizontalAlignment.Left);

                foreach (SomerenModel.Room s in roomList) {
                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    li.SubItems.Add(s.student);
                    li.SubItems.Add(s.Capacity.ToString());
                    listViewStudents.Items.Add(li);

                }
            }
            else if (panelName == "TeacherRoom") {
                // hide all other panels
                pnl_Dashboard.Hide();
                picbox_Someren4.Hide();
                pnl_Cash.Hide();
                pnl_Drink.Hide();

                lbl_Students.Text = "Teacher's Room";
                // show students
                pnl_Students.Show();

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Room_Service roomService = new SomerenLogic.Room_Service();
                List<Room> roomList = roomService.GetRoom();

                // clear the listview before filling it again
                listViewStudents.Clear();

                //Adding columns
                listViewStudents.View = View.Details;
                listViewStudents.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("teacher/student", -2, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("capacity", -2, HorizontalAlignment.Left);

                foreach (SomerenModel.Room s in roomList) {
                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    li.SubItems.Add(s.teacher.ToString());
                    li.SubItems.Add(s.Capacity.ToString());
                    listViewStudents.Items.Add(li);

                }
            }
            else if (panelName == "Drink Supplies") {
                pnl_Dashboard.Hide();
                picbox_Someren4.Hide();
                pnl_Students.Hide();
                pnl_Teachers.Hide();
                pnl_Cash.Hide();
                // show drink panel
                pnl_Drink.Show();
            }
            else if (panelName == "Cash Register") {
                // hide all other panels
                pnl_Dashboard.Hide();
                picbox_Someren4.Hide();
                pnl_Students.Hide();
                pnl_Teachers.Hide();
                pnl_Drink.Hide();
                // show cash panel
                pnl_Cash.Show();

                // ************************************ get list of drinks
                //SomerenLogic.Drinks_Service drinksService = new SomerenLogic.Drinks_Service();
                //List<Drinks> drinksList = drinksService.GetDrinkSupplies();
                radbtn_Lecturers.Checked = true;


                if (radbtn_Students.Checked) {
                    SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                    List<Student> studList = studService.GetStudents();

                    cmbbox_Role.DataSource = studList;
                    cmbbox_Role.DisplayMember = "FirstName";
                }
                else {
                    SomerenLogic.Teacher_Service teachService = new SomerenLogic.Teacher_Service();
                    List<Teacher> teachList = teachService.GetTeachers();

                    cmbbox_Role.DataSource = teachList;
                    cmbbox_Role.DisplayMember = "FirstName";
                }

                //((ListBox)list_Drinks).DataSource = drinksList;
                //((ListBox)list_Drinks).DisplayMember = "Name";
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void teacherRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Type = true;
            showPanel("TeacherRoom");
        }

        private void studentRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Room room = new Room();
            room.Type = false;
            showPanel("StudentRoom");
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e) {
            showPanel("Cash Register");
        }

        private void drinkSuppliesToolStripMenuItem_Click(object sender, EventArgs e) {
            showPanel("Drink Supplies");
        }

        private void radbtn_Lecturers_CheckedChanged(object sender, EventArgs e) {
            if (radbtn_Students.Checked) {
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studList = studService.GetStudents();

                cmbbox_Role.DataSource = studList;
                cmbbox_Role.DisplayMember = "FirstName";
            }
            else {
                SomerenLogic.Teacher_Service teachService = new SomerenLogic.Teacher_Service();
                List<Teacher> teachList = teachService.GetTeachers();

                cmbbox_Role.DataSource = teachList;
                cmbbox_Role.DisplayMember = "FirstName";
            }
        }

        private void btn_Check_Click(object sender, EventArgs e) {
            // code for checking out
        }
    }
}
