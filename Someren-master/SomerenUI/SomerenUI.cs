using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        LogService logService = new LogService();
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
            dashboardToolStripMenuItem.ForeColor = Color.White;
            dashboardToolStripMenuItem.BackColor = Color.Black;
        }

        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {
                // hide all other panels
                pnlStudents.Hide();
                pnlRoomPanel.Hide();
                pnlTeacherPanel.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {

                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlRoomPanel.Hide();

                // show students
                pnlStudents.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService();
                    List<Student> studentList = studService.GetStudents();

                    // clear the listview before filling it again
                    listViewStudents.Clear();


                    listViewStudents.View = View.Details;
                    listViewStudents.Columns.Add("StudentId", 120);
                    listViewStudents.Columns.Add("FirstName");
                    listViewStudents.Columns.Add("LastName");
                    listViewStudents.Columns.Add("DateOfBirth", 120);

                    foreach (Student s in studentList)
                    {
                        ListViewItem li = new ListViewItem(s.StudentId.ToString());
                        li.SubItems.Add(s.FirstName);
                        li.SubItems.Add(s.LastName);
                        li.SubItems.Add(s.DateOfBirth.ToString("yyyy/MM/dd"));
                        listViewStudents.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                    logService.WriteLog(e.Message);
                }
            }
            else if(panelName == "Teachers")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();
                pnlRoomPanel.Hide();

                pnlTeacherPanel.Show();

                listViewTeachers.Clear();

                TeacherService teacherService = new TeacherService();
                List<Teacher> teacherList = teacherService.GetTeachers();

                listViewTeachers.View = View.Details;
                listViewTeachers.Columns.Add("TeacherID");
                listViewTeachers.Columns.Add("First Name");
                listViewTeachers.Columns.Add("Last Name");
                listViewTeachers.Columns.Add("supervisor");

                foreach (Teacher teacher in teacherList)
                {
                    ListViewItem li = new ListViewItem(teacher.TeacherID.ToString());
                    li.SubItems.Add(teacher.FirstName);
                    li.SubItems.Add(teacher.LastName);
                    li.SubItems.Add(teacher.Supervisor.ToString());
                    listViewTeachers.Items.Add(li);
                }


            }

            try
            {
                //(VOID aanmaken voor hide panels?)
                if (panelName == "Rooms")
                {
                    // hide all other panels
                    pnlDashboard.Hide();
                    imgDashboard.Hide();
                    pnlStudents.Hide();
                    pnlTeacherPanel.Hide();

                    // show rooms
                    pnlRoomPanel.Show();

                    try
                    {
                        //AANPASSEN EN METHODES AANMAKEN. 
                        // fill the rooms listview within the rooms panel with a list of rooms
                        RoomService roomService = new RoomService();
                        List<Room> roomList = roomService.GetRooms();

                        // clear the listview before filling it again
                        listViewRoom.Clear();


                        listViewRoom.View = View.Details;
                        listViewRoom.Columns.Add("Number", 120);
                        listViewRoom.Columns.Add("Capacity", 120);
                        listViewRoom.Columns.Add("Type", 120);
                    
                        foreach (Room room in roomList)
                        {
                            ListViewItem li = new ListViewItem(room.Number.ToString());
                            li.SubItems.Add(room.Capacity.ToString());
                            li.SubItems.Add(room.Type);
                            listViewRoom.Items.Add(li);
                        }

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Listview could not be loaded properly.");
                        logService.WriteLog(e.Message);
                    }
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Panel could not be loaded properly." + e.Message);
            }            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // panelen van kleur laten veranderen wanneer je erop drukt
            showPanel("Dashboard");
            ResetToolStripMenu();
            dashboardToolStripMenuItem.ForeColor = Color.White;
            dashboardToolStripMenuItem.BackColor = Color.Black;
        }
        private void ResetToolStripMenu()
        {
            dashboardToolStripMenuItem.ForeColor = default(Color);
            dashboardToolStripMenuItem.BackColor = default(Color);
           studentsToolStripMenuItem.ForeColor = default(Color);
            studentsToolStripMenuItem.BackColor = default(Color);
            roomsToolStripMenuItem.ForeColor = default(Color);
            roomsToolStripMenuItem.BackColor = default(Color);
            teachersToolStripMenuItem.ForeColor = default(Color);
            teachersToolStripMenuItem.BackColor = default(Color);
            activitiesToolStripMenuItem.ForeColor = default(Color);
            activitiesToolStripMenuItem.BackColor = default(Color);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
            studentsToolStripMenuItem.ForeColor = Color.White;
            studentsToolStripMenuItem.BackColor = Color.Black;

            roomsToolStripMenuItem.ForeColor = default(Color);
            roomsToolStripMenuItem.BackColor = default(Color);
            teachersToolStripMenuItem.ForeColor = default(Color);
            teachersToolStripMenuItem.BackColor = default(Color);
            activitiesToolStripMenuItem.ForeColor = default(Color);
            activitiesToolStripMenuItem.BackColor = default(Color);
            dashboardToolStripMenuItem.ForeColor = default(Color);
            dashboardToolStripMenuItem.BackColor = default(Color);
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // within this method I want to show what happens when 'Rooms' is clicked
            showPanel("Rooms");
            roomsToolStripMenuItem.ForeColor = Color.White;
            roomsToolStripMenuItem.BackColor = Color.Black;

            studentsToolStripMenuItem.ForeColor = default(Color);
            studentsToolStripMenuItem.BackColor = default(Color);
            teachersToolStripMenuItem.ForeColor = default(Color);
            teachersToolStripMenuItem.BackColor = default(Color);
            activitiesToolStripMenuItem.ForeColor = default(Color);
            activitiesToolStripMenuItem.BackColor = default(Color);
            dashboardToolStripMenuItem.ForeColor = default(Color);
            dashboardToolStripMenuItem.BackColor = default(Color);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listViewRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            this.menuStrip1.BackColor = Color.Red;
        }
        private void pnlTeacher_Paint(object sender, PaintEventArgs e)
        {
            showPanel("Rooms");
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
            Console.WriteLine("colin je stinkt");
            teachersToolStripMenuItem.ForeColor = Color.White;
            teachersToolStripMenuItem.BackColor = Color.Black;

            studentsToolStripMenuItem.ForeColor = default(Color);
            studentsToolStripMenuItem.BackColor = default(Color);
            roomsToolStripMenuItem.ForeColor = default(Color);
            roomsToolStripMenuItem.BackColor = default(Color);
            activitiesToolStripMenuItem.ForeColor = default(Color);
            activitiesToolStripMenuItem.BackColor = default(Color);
            dashboardToolStripMenuItem.ForeColor = default(Color);
            dashboardToolStripMenuItem.BackColor = default(Color);
        }
        private void activitiesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("Activities");
            activitiesToolStripMenuItem.ForeColor = Color.White;
            activitiesToolStripMenuItem.BackColor = Color.Black;

            studentsToolStripMenuItem.ForeColor = default(Color);
            studentsToolStripMenuItem.BackColor = default(Color);
            roomsToolStripMenuItem.ForeColor = default(Color);
            roomsToolStripMenuItem.BackColor = default(Color);
            teachersToolStripMenuItem.ForeColor = default(Color);
            teachersToolStripMenuItem.BackColor = default(Color);
            dashboardToolStripMenuItem.ForeColor = default(Color);
            dashboardToolStripMenuItem.BackColor = default(Color);
        }
    }
}
