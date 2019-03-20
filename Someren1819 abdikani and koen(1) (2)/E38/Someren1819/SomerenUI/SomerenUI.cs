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

            if (panelName == "Dashboard")
            {

                // hide all other panels
                pnl_Students.Hide();
                pnl_Teachers.Hide();

                // show dashboard
                pnl_Dashboard.Show();
                img_Dashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Teachers.Hide();

                // show students
                pnl_Students.Show();


                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.Clear();

                listViewStudents.View = View.Details;

                listViewStudents.Columns.Add(" StudentID", 100, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("Firstname", 100, HorizontalAlignment.Left);
                listViewStudents.Columns.Add("Lastname", 100, HorizontalAlignment.Left);

                foreach (SomerenModel.Student s in studentList)
                {
                    //ListViewItem li = new ListViewItem(s.FirstName);
                    //listViewStudents.Items.Add(li);

                    ListViewItem li = new ListViewItem(s.studentID.ToString());
                    li.SubItems.Add(s.Firstname);
                    li.SubItems.Add(s.Lastname);
                    listViewStudents.Items.Add(li);
                }
            }
            else if (panelName == "Teachers")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();
                pnl_Students.Hide();

                // show students
                pnl_Teachers.Show();
                

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Teacher_Service teachService = new SomerenLogic.Teacher_Service();
                List<Teacher> teacherList = teachService.GetTeachers();

                // clear the listview before filling it again
                listViewTeachers.Items.Clear();


                listViewTeachers.View = View.Details;

                listViewTeachers.Columns.Add(" TeacherID", 100, HorizontalAlignment.Left);
                listViewTeachers.Columns.Add("FirstName", 100, HorizontalAlignment.Left);
                listViewTeachers.Columns.Add("LastName", 100, HorizontalAlignment.Left);
                listViewTeachers.Columns.Add("Supervisor", 100, HorizontalAlignment.Left);



                foreach (SomerenModel.Teacher t in teacherList)
                {

                    ListViewItem li = new ListViewItem(t.teacherID.ToString());
                    li.SubItems.Add(t.FirstName);
                    li.SubItems.Add(t.LastName);
                    li.SubItems.Add(t.Supervisor);
                    listViewTeachers.Items.Add(li);


                }
            }
            else if (panelName == "StudentRoom")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();

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

                foreach (SomerenModel.Room s in roomList)
                {

                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    li.SubItems.Add(s.student);
                    li.SubItems.Add(s.Capacity.ToString());
                    listViewStudents.Items.Add(li);

                }
            }
            else if (panelName == "TeacherRoom")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                img_Dashboard.Hide();

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

                foreach (SomerenModel.Room s in roomList)
                {

                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    li.SubItems.Add(s.teacher.ToString());
                    li.SubItems.Add(s.Capacity.ToString());
                    listViewStudents.Items.Add(li);

                }
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listViewTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Teachers_Click(object sender, EventArgs e)
        {

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
    }
}
