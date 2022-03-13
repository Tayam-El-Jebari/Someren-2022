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
        private void ColorListView(ListView listview)
        {
            for (int i = 0; i < listview.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listview.Items[i].BackColor = Color.LightBlue;
                }
            }
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
                ShowCorrectPannel(pnlStudents);
                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService();
                    List<Student> studentList = studService.GetStudents();

                    // clear the listview before filling it again
                    listViewStudents.Clear();


                    listViewStudents.View = View.Details;
                    listViewStudents.Columns.Add("Student id", 80);
                    listViewStudents.Columns.Add("First name", 150);
                    listViewStudents.Columns.Add("Last name", 150);
                    listViewStudents.Columns.Add("Date of birth", 100);
                    listViewStudents.Columns.Add("Room number", 80);

                    foreach (Student s in studentList)
                    {
                        ListViewItem li = new ListViewItem(s.StudentId.ToString());
                        li.SubItems.Add(s.FirstName);
                        li.SubItems.Add(s.LastName);
                        li.SubItems.Add(s.DateOfBirth.ToString("yyyy/MM/dd"));
                        li.SubItems.Add(s.RoomNumber.ToString());
                        listViewStudents.Items.Add(li);
                    }

                    ColorListView(listViewStudents);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                    logService.WriteLog(e.Message);
                }
            }
            else if(panelName == "Teachers")
            {
                ShowCorrectPannel(pnlTeacherPanel);


                listViewTeachers.Clear();

                TeacherService teacherService = new TeacherService();
                List<Teacher> teacherList = teacherService.GetTeachers();

                listViewTeachers.View = View.Details;

                listViewTeachers.Columns.Add("Teacher id",80);
                listViewTeachers.Columns.Add("First name", 120);
                listViewTeachers.Columns.Add("Last name", 120);
                listViewTeachers.Columns.Add("Room number", 80);
                listViewTeachers.Columns.Add("Supervisor", 80); 
                foreach (Teacher teacher in teacherList)
                {
                    ListViewItem li = new ListViewItem(teacher.TeacherID.ToString());
                    li.SubItems.Add(teacher.FirstName);
                    li.SubItems.Add(teacher.LastName);
                    li.SubItems.Add(teacher.RoomNumber.ToString());
                    li.SubItems.Add(teacher.Supervisor.ToString());
                    listViewTeachers.Items.Add(li);
                }
                ColorListView(listViewTeachers);
            }

            try
            {
                //(VOID aanmaken voor hide panels?)
                if (panelName == "Rooms")
                {
                    ShowCorrectPannel(pnlRoomPanel);

                    try
                    {
                        //AANPASSEN EN METHODES AANMAKEN. 
                        // fill the rooms listview within the rooms panel with a list of rooms
                        RoomService roomService = new RoomService();
                        List<Room> roomList = roomService.GetRooms();

                        // clear the listview before filling it again
                        listViewRoom.Clear();

                        listViewRoom.View = View.Details;
                        listViewRoom.Columns.Add("Number", 80);
                        listViewRoom.Columns.Add("Capacity", 80);
                        listViewRoom.Columns.Add("Type", 120);
                    
                        foreach (Room room in roomList)
                        {
                            ListViewItem li = new ListViewItem(room.Number.ToString());
                            li.SubItems.Add(room.Capacity.ToString());
                            li.SubItems.Add(room.Type);
                            listViewRoom.Items.Add(li);
                            
                        }
                        ColorListView(listViewRoom);

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

            try
            {
                //(VOID aanmaken voor hide panels?)
                if (panelName == "Drinks")
                {
                    ShowCorrectPannel(pnlDrinksPanel);

                    try
                    {
                        //AANPASSEN EN METHODES AANMAKEN.  
                        // fill the drinks listview within the rooms panel with a list of drinks
                        DrinkService drinkService = new DrinkService();
                        List<Drink> drinkList = drinkService.GetDrinks();

                        // clear the listview before filling it again
                        listViewDrink.Clear();

                        listViewDrink.View = View.Details;
                        listViewDrink.FullRowSelect = true;
                        listViewDrink.Columns.Add("ProductID", 70);
                        listViewDrink.Columns.Add("Drink name", 80);
                        listViewDrink.Columns.Add("Stock", 70);
                        listViewDrink.Columns.Add("Sales Value", 80);
                        listViewDrink.Columns.Add("Number of drinks sold", 120);

                        
                        foreach (Drink drink in drinkList)
                        {
                            ListViewItem li = new ListViewItem(drink.ProductID.ToString());
                            li.SubItems.Add(drink.DrinkName);
                            li.SubItems.Add(drink.StockAmount.ToString());
                            li.SubItems.Add(drink.SalesValue.ToString());
                            li.SubItems.Add(drink.NumberOfDrinksSold.ToString());
                            listViewDrink.Items.Add(li);

                        }
                        ColorListView(listViewDrink);

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
        private void ShowCorrectPannel(Panel panel)
        {
            pnlDashboard.Hide();
            imgDashboard.Hide();
            pnlStudents.Hide();
            pnlRoomPanel.Hide();
            pnlTeacherPanel.Hide();
            pnlDrinksPanel.Hide();

            panel.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ChangeToolStripMenu(ToolStripMenuItem menuItem)
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
            menuItem.ForeColor = Color.White;
            menuItem.BackColor = Color.Black;
        }
        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
            ChangeToolStripMenu(dashboardToolStripMenuItem);
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
            ChangeToolStripMenu(studentsToolStripMenuItem);
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // within this method I want to show what happens when 'Rooms' is clicked
            showPanel("Rooms");
            ChangeToolStripMenu(roomsToolStripMenuItem);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            ChangeToolStripMenu(teachersToolStripMenuItem);
        }
        private void activitiesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("Activities");
            ChangeToolStripMenu(activitiesToolStripMenuItem);
        }

        private void pictureBoxSomerenTeacher_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Een leuke tekst als je op de foto drukt");
        }

        private void pictureBoxSomerenRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Een leuke tekst als je op de foto drukt");
        }

        private void pictureBoxSomerenStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Een leuke tekst als je op de foto drukt");
        }

        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
            ChangeToolStripMenu(drinksToolStripMenuItem);
            labelRoomTitle.Hide();
            labelDrink.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();
            drinkService.AddRowTable(int.Parse(textBoxStock.Text), int.Parse(textBoxSalesValue.Text), 
                int.Parse(textBoxNumberOfDrinksSold.Text), textBoxDrinkName.Text);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();
            drinkService.UpdateRowTable(int.Parse(textBoxStock.Text), int.Parse(textBoxSalesValue.Text),
                int.Parse(textBoxNumberOfDrinksSold.Text), textBoxDrinkName.Text);
            /*listViewDrink.SelectedItems[0].SubItems[0].Text = textBoxDrinkName.Text;
            listViewDrink.SelectedItems[0].SubItems[1].Text = textBoxStock.Text;
            listViewDrink.SelectedItems[0].SubItems[2].Text = textBoxSalesValue.Text;
            listViewDrink.SelectedItems[0].SubItems[3].Text = textBoxNumberOfDrinksSold.Text;*/
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

    }
}
