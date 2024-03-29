﻿using SomerenLogic;
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
        public SomerenUI(User user)
        {
            InitializeComponent();
            welcomeLabel.Text = $"Welcome back {user.FirstName} {user.LastName}";
            if (!user.IsAdmin)
            {
                foreach (ToolStripMenuItem tsmi in activitiesToolStripMenuItem.DropDownItems)
                {
                    tsmi.Visible = false;
                }
                barServiceToolStripMenuItem.Visible = false;

            }
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
            ChangeToolStripMenu(dashboardToolStripMenuItem1);

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
                ShowCorrectPanel(pnlDashboard);
            }

            else if (panelName == "Students")
            {
                ShowCorrectPanel(pnlStudents);
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
                    logService.WriteLog(e);
                }
            }
            else if (panelName == "Activities")
            {
                ShowCorrectPanel(pnlActivities);

                try
                {
                    listViewActivities.Clear();
                    ActivityService activityService = new ActivityService();
                    List<Activity> activityList = activityService.GetActivity();

                    listViewActivities.View = View.Details;
                    listViewActivities.FullRowSelect = true;
                    listViewActivities.Columns.Add("ActivityNumber", 50);
                    listViewActivities.Columns.Add("ActivityName", 80);
                    listViewActivities.Columns.Add("Description", 80);
                    listViewActivities.Columns.Add("StartDateTime", 120);
                    listViewActivities.Columns.Add("EndDateTime", 120);

                    foreach (Activity activity in activityList)
                    {
                        ListViewItem li = new ListViewItem(activity.ActivityNumber.ToString());
                        li.SubItems.Add(activity.ActivityName);
                        li.SubItems.Add(activity.Description);
                        li.SubItems.Add(activity.StartDateTime.ToString());
                        li.SubItems.Add(activity.EndDateTime.ToString());
                        listViewActivities.Items.Add(li);
                    }
                    ColorListView(listViewActivities);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
                    logService.WriteLog(e);
                }
            }
            else if (panelName == "Participants")
            {
                ShowCorrectPanel(pnlParticipants);
                //hide unnecessary controls
                buttonAddParticipant.Hide();
                buttonExitAddingMode.Hide();
                instructionDescriptionAddingMode.Hide();

                //show necessary controls and edit labels in order to suit the situation (needed in case user returns from adding-mode)
                AddParticipantsStart.Show();
                deleteParticipant.Show();
                instructionsDescription.Show();
                labelParticipantsTitle.Text = "Students participating:";

                listViewActivitesParticipants.Clear();
                listViewParticipants.Clear();

                ActivityService activityService = new ActivityService();
                List<Activity> activityList = activityService.GetActivity();



                listViewActivitesParticipants.View = View.Details;
                listViewActivitesParticipants.Columns.Add("ActivityID");
                listViewActivitesParticipants.Columns.Add("ActivityName");
                listViewActivitesParticipants.Columns.Add("StartDateTime");
                listViewActivitesParticipants.Columns.Add("EndDateTime");
                listViewActivitesParticipants.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewActivitesParticipants.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

                listViewActivitesParticipants.FullRowSelect = true;

                foreach (Activity activity in activityList)
                {
                    ListViewItem li = new ListViewItem(activity.ActivityNumber.ToString());
                    li.SubItems.Add(activity.ActivityName);
                    li.SubItems.Add(activity.StartDateTime.ToString());
                    li.SubItems.Add(activity.EndDateTime.ToString());
                    listViewActivitesParticipants.Items.Add(li);
                }
                ColorListView(listViewActivitesParticipants);

            }
            else if (panelName == "Teachers")
            {
                ShowCorrectPanel(pnlTeacherPanel);
                try
                {

                    listViewTeachers.Clear();

                    TeacherService teacherService = new TeacherService();
                    List<Teacher> teacherList = teacherService.GetTeachers();

                    listViewTeachers.View = View.Details;
                    listViewTeachers.Columns.Add("Teacher id", 80);
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
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
                    logService.WriteLog(e);
                }
            }
            else if (panelName == "Revenue report")
            {
                ShowCorrectPanel(pnlRevenueReportPanel);
                listViewRevenueReport.Clear();
            }
            else if (panelName == "Cash register")
            {
                ShowCorrectPanel(pnlCashRegisterPanel);
                try
                {
                    StudentService studService = new StudentService();
                    List<Student> studentList = studService.GetStudents();


                    studentsListView.View = View.Details;
                    studentsListView.FullRowSelect = true;

                    studentsListView.Columns.Add("Student id", 50);
                    studentsListView.Columns.Add("First name", 120);
                    studentsListView.Columns.Add("Last name", 120);
                    studentsListView.Columns.Add("Date of birth", 70);
                    studentsListView.Columns.Add("Room number", 50);


                    foreach (Student s in studentList)
                    {
                        //s.StudentId.ToString();

                        ListViewItem li = new ListViewItem(s.StudentId.ToString());
                        li.SubItems.Add(s.FirstName);
                        li.SubItems.Add(s.LastName);
                        li.SubItems.Add(s.DateOfBirth.ToString("yyyy/MM/dd"));
                        li.SubItems.Add(s.RoomNumber.ToString());
                        li.Tag = s;
                        studentsListView.Items.Add(li);

                    }
                    ColorListView(studentsListView);



                    DrinkService drinkService = new DrinkService();
                    List<Drink> drinkList = drinkService.GetDrinksCR();

                    // clear the listview before filling it again
                    drinksListView.Clear();

                    drinksListView.View = View.Details;
                    drinksListView.FullRowSelect = true;
                    drinksListView.LabelEdit = true;
                    drinksListView.Columns.Add("Product id", 80);
                    drinksListView.Columns.Add("Drink name", 80);
                    drinksListView.Columns.Add("Stock", 70);
                    drinksListView.Columns.Add("Sales Value", 80);
                    drinksListView.Columns.Add("Number of drinks sold", 120);
                    drinksListView.Columns.Add("Drink is alcoholic", 80);

                    foreach (Drink drink in drinkList)
                    {
                        ListViewItem li = new ListViewItem(drink.ProductID.ToString());
                        li.SubItems.Add(drink.DrinkName);

                        li.SubItems.Add(drink.StockAmount.ToString());
                        li.SubItems.Add(drink.SalesValue.ToString());
                        li.SubItems.Add(drink.NumberOfDrinksSold.ToString());
                        li.SubItems.Add(drink.IsAlcoholic.ToString());
                        li.Tag = drink;
                        drinksListView.Items.Add(li);
                    }
                    ColorListView(drinksListView);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the cash register: ");
                    logService.WriteLog(e);

                }
            }
            try
            {
                //(VOID aanmaken voor hide panels?)
                if (panelName == "Rooms")
                {
                    ShowCorrectPanel(pnlRoomPanel);

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
                        MessageBox.Show("Something went wrong while loading the rooms: ");
                        logService.WriteLog(e);

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
                    ShowCorrectPanel(pnlDrinksPanel);

                    try
                    {
                        //AANPASSEN EN METHODES AANMAKEN.  
                        // fill the drinks listview within the rooms panel with a list of drinks
                        DrinkService drinkService = new DrinkService();
                        List<Drink> drinkList = drinkService.GetDrinks();

                        ShowDrinkListview();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Something went wrong while loading the drinks: ");
                        logService.WriteLog(e);

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Panel could not be loaded properly." + e.Message);
                logService.WriteLog(e);
            }
            try
            {
                if (panelName == "Supervisors")
                {
                    ShowCorrectPanel(pnlSupervisors);
                    try
                    {
                        ActivityService activityService = new ActivityService();
                        List<Activity> activityList = activityService.GetActivity();

                        addSupervisorActivityButton.Show();
                        textLabel.Show();
                        labeltext.Hide();
                        ChooseSupervisorButton.Hide();
                        deleteSupervisorButton.Show();
                        quitActionButton.Hide();
                        textLabel.Text = "To select an activity, you can click on one of the activities in the list" +
                            "after you have clicked on an activity you see the teachers that are supervising at that specific activity" +
                            "you can now press on the button";
                        // clear the listview before filling it again
                        activityTeacherListView.Clear();

                        activityTeacherListView.View = View.Details;
                        activityTeacherListView.FullRowSelect = true;
                        activityTeacherListView.LabelEdit = true;
                        activityTeacherListView.Columns.Add("Activity number", 80);
                        activityTeacherListView.Columns.Add("Activity name", 80);
                        activityTeacherListView.Columns.Add("Description", 80);
                        activityTeacherListView.Columns.Add("Start date time", 80);
                        activityTeacherListView.Columns.Add("End date time", 120);

                        foreach (Activity activity in activityList)
                        {
                            ListViewItem li = new ListViewItem(activity.ActivityNumber.ToString());
                            li.SubItems.Add(activity.ActivityName);
                            li.SubItems.Add(activity.Description);
                            li.SubItems.Add(activity.StartDateTime.ToString());
                            li.SubItems.Add(activity.EndDateTime.ToString());
                            li.Tag = activity;
                            activityTeacherListView.Items.Add(li);
                        }
                        ColorListView(activityTeacherListView);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Something went wrong while loading the supervisors: ");
                        logService.WriteLog(e);

                    }
                }
            }catch(Exception e)
            {
                MessageBox.Show("Panel could not be loaded properly." + e.Message);
                logService.WriteLog(e);
            }
        }
        private void ShowCorrectPanel(Panel panel)
        {
            foreach (Control c in Controls)
            {
                // hide everything that is not the panel specified or the menustrip
                if (c != panel && c != menuStrip1)
                {
                    c.Hide();
                }
                else
                {
                    c.Show();
                }
            }
        }

        private void ShowDrinkListview()
        {
            DrinkService drinkService = new DrinkService();
            // clear the listview before filling it again
            listViewDrink.Clear();
            listViewDrink.View = View.Details;
            listViewDrink.FullRowSelect = true;
            listViewDrink.Columns.Add("Drink name", 80);
            listViewDrink.Columns.Add("Stock", 60);
            listViewDrink.Columns.Add("Stock sufficient or not", 50);
            listViewDrink.Columns.Add("Tokens", 60);
            listViewDrink.Columns.Add("Number of drinks sold", 120);
            listViewDrink.Columns.Add("Drink is alcoholic", 80);
            List<Drink> drinkList = drinkService.GetDrinks();

            foreach (Drink drink in drinkList)
            {
                ListViewItem li = new ListViewItem(drink.DrinkName);
                li.SubItems.Add(drink.StockAmount.ToString());
                li.SubItems.Add(drinkService.SufficientInsufficient(drink));
                li.SubItems.Add(drink.SalesValue.ToString());
                li.SubItems.Add(drink.NumberOfDrinksSold.ToString());
                li.SubItems.Add(drink.IsAlcoholic.ToString());
                listViewDrink.Items.Add(li);
            }
            ColorListView(listViewDrink);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ChangeToolStripMenu(ToolStripMenuItem menuItem)
        {
            foreach (ToolStripMenuItem tsmi in menuStrip1.Items)
            {
                tsmi.ForeColor = default(Color);
                tsmi.BackColor = default(Color);
                for (int i = 0; i < tsmi.DropDownItems.Count; i++)
                {
                    tsmi.DropDownItems[i].ForeColor = default(Color);
                    tsmi.DropDownItems[i].BackColor = default(Color);
                }
            }
            menuItem.ForeColor = Color.White;
            menuItem.BackColor = Color.Black;
            if (menuItem.OwnerItem != null)
            {
                menuItem.OwnerItem.BackColor = Color.DarkGray;
                menuItem.OwnerItem.ForeColor = Color.LightGray;
            }
        }
        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
            ChangeToolStripMenu(dashboardToolStripMenuItem1);
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
        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Revenue report");
            ChangeToolStripMenu(revenueReportToolStripMenuItem);
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

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                listViewRevenueReport.Clear();

                RevenueReportService revenueReportService = new RevenueReportService();
                if (dateTimePickerStart.Value.Date > dateTimePickerEnd.Value.Date)
                {
                    throw new Exception("Start date cannot be higher than the end date!");
                }
                else if (dateTimePickerStart.Value > DateTime.Parse("01-01-2019") && dateTimePickerStart.Value <= DateTime.Now && dateTimePickerEnd.Value <= DateTime.Now)
                {
                    List<RevenueReport> revenueReport = revenueReportService.GetRevenueReport(dateTimePickerStart.Value, dateTimePickerEnd.Value);
                    listViewRevenueReport.View = View.Details;
                    listViewRevenueReport.Columns.Add("total sales", 120);
                    listViewRevenueReport.Columns.Add("turnover", 120);
                    listViewRevenueReport.Columns.Add("number of customers", 200);
                    ListViewItem li = new ListViewItem(revenueReport.Sum(item => item.sales).ToString());
                    li.SubItems.Add(revenueReport.Sum(item => item.turnOver).ToString());
                    li.SubItems.Add(revenueReport.Sum(item => item.numberOfCustomers).ToString());
                    listViewRevenueReport.Items.Add(li);
                    ColorListView(listViewRevenueReport);

                }
                else
                {
                    throw new Exception($"invalid date range. Please select a date between 01-01-2019 and {DateTime.Now.ToString("dd-MM-yyyy")}!");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("No results found, so the list has not been filled!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load : \n \n" + ex.Message);
                logService.WriteLog(ex);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkService drinkService = new DrinkService();
                int stock = int.Parse(textBoxStock.Text);
                int salesValue = int.Parse(textBoxSalesValue.Text);
                int numberOfDrinkSold = int.Parse(textBoxNumberOfDrinksSold.Text);
                string drinkName = textBoxDrinkName.Text;
                bool isAlcoholic = bool.Parse(textBoxAlcholicDrink.Text);

                drinkService.AddRowTable(stock, salesValue, numberOfDrinkSold, drinkName, isAlcoholic);

                Drink drink = new Drink();
                ListViewItem li = new ListViewItem(drinkName);
                li.SubItems.Add(stock.ToString());
                li.SubItems.Add(salesValue.ToString());
                li.SubItems.Add(numberOfDrinkSold.ToString());
                li.SubItems.Add(isAlcoholic.ToString());
                listViewDrink.Items.Add(li);

            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure to enter all the data in the textbox fields. ");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkService drinkService = new DrinkService();

                int stock = int.Parse(textBoxStock.Text);
                int salesValue = int.Parse(textBoxSalesValue.Text);
                int numberOfDrinkSold = int.Parse(textBoxNumberOfDrinksSold.Text);
                string drinkName = textBoxDrinkName.Text;

                bool isAlcoholic = bool.Parse(textBoxAlcholicDrink.Text);            
                drinkService.UpdateRowTable(stock, salesValue, numberOfDrinkSold, drinkName, isAlcoholic);

                ShowDrinkListview();
            }
            catch (Exception)
            {
                MessageBox.Show("Updating row failed, make sure to enter all the data in the textboxes, then press the update button");
                throw new Exception("Updating row failed. ");
            }

        }

        private void buttonChangeName_Click(object sender, EventArgs e)
        {
            string drinkName = textBoxDrinkName.Text;
            string newDrinkName = textBoxNewDrinkName.Text;

            try
            {

                DrinkService drinkService = new DrinkService();
                drinkService.UpdateNameInRow(drinkName, newDrinkName);
                // clear the listview before filling it again
                listViewDrink.Clear();
                listViewDrink.View = View.Details;
                listViewDrink.FullRowSelect = true;
                listViewDrink.Columns.Add("Drink name", 80);
                listViewDrink.Columns.Add("Stock", 60);
                listViewDrink.Columns.Add("Stock sufficient or not", 50);
                listViewDrink.Columns.Add("Tokens", 60);
                listViewDrink.Columns.Add("Number of drinks sold", 120);
                listViewDrink.Columns.Add("Drink is alcoholic", 80);
                List<Drink> drinkList = drinkService.GetDrinks();

                foreach (Drink drink in drinkList)
                {
                    ListViewItem li = new ListViewItem(drink.DrinkName);
                    li.SubItems.Add(drink.StockAmount.ToString());
                    li.SubItems.Add(drinkService.SufficientInsufficient(drink));
                    li.SubItems.Add(drink.SalesValue.ToString());
                    li.SubItems.Add(drink.NumberOfDrinksSold.ToString());
                    li.SubItems.Add(drink.IsAlcoholic.ToString());
                    listViewDrink.Items.Add(li);
                }
                ColorListView(listViewDrink);


            }
            catch (Exception)
            {
                MessageBox.Show("Updating name failed, make sure to enter two names in the textboxes, then press the change name button. Also make sure to old name is entered correctly");
                /*                throw new Exception("Updating row failed. ");*/
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkService drinkService = new DrinkService();
                string drinkNameEntered = listViewDrink.SelectedItems[0].Text;
                List<Drink> drinkList = drinkService.GetDrinks();

                // pop up message voor de gebruiker
                MessageBox.Show("Are you sure you want to delete the whole row from the list?");
                // Ook nog verwijderen uit de database!!!!
                drinkService.DeleteRowTable(drinkNameEntered);
                listViewDrink.Items.Remove(listViewDrink.SelectedItems[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row from the list, then press the delete button");
            }

        }

        private void buttonShowSortedList_Click(object sender, EventArgs e)
        {
            try
            {
                DrinkService drinkService = new DrinkService();
                List<Drink> drinkList = drinkService.ShowSortedList();
                // clear the listview before filling it again
                listViewDrink.Clear();
                listViewDrink.View = View.Details;
                listViewDrink.FullRowSelect = true;
                listViewDrink.LabelEdit = true;
                listViewDrink.Columns.Add("Drink name", 80);
                listViewDrink.Columns.Add("Stock", 60);
                listViewDrink.Columns.Add("Stock sufficient or not", 50);
                listViewDrink.Columns.Add("Tokens", 60);
                listViewDrink.Columns.Add("Number of drinks sold", 120);
                listViewDrink.Columns.Add("Drink is alcoholic", 80);

                foreach (Drink drink in drinkList)
                {
                    ListViewItem li = new ListViewItem(drink.DrinkName);
                    li.SubItems.Add(drink.StockAmount.ToString());
                    li.SubItems.Add(drinkService.SufficientInsufficient(drink));
                    li.SubItems.Add(drink.SalesValue.ToString());
                    li.SubItems.Add(drink.NumberOfDrinksSold.ToString());
                    li.SubItems.Add(drink.IsAlcoholic.ToString());
                    listViewDrink.Items.Add(li);
                }
                ColorListView(listViewDrink);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong while sorting the list");
                throw new Exception("Something went wrong while sorting the list");
            }

        }
        private void CashregistertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Cash register");
            ChangeToolStripMenu(CashregistertoolStripMenuItem);
        }

        private void checkOutbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = (Student)studentsListView.SelectedItems[0].Tag;
                List<Drink> drinks = new List<Drink>();
                OrderService orderService = new OrderService();

                for (int i = 0; i < drinksListView.SelectedItems.Count; i++)
                {
                    drinks.Add((Drink)drinksListView.SelectedItems[i].Tag);
                    Order order = new Order(drinks[i].ProductID, student.StudentId, DateTime.Now);
                    orderService.AddRowOrders(order.ProductId, order.StudentId, order.DateOfPurchase);
                }
                MessageBox.Show("Your transaction has been completed! ");
                ShowCorrectPanel(pnlCashRegisterPanel);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void drinksToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("Drinks");
            ChangeToolStripMenu(drinksToolStripMenuItem);
        }

        private void listViewActivitesParticipants_MouseClick(object sender, MouseEventArgs e)
        {
            if (AddParticipantsStart.Visible)
            {

                listViewParticipants.Clear();
                ActivityService activityService = new ActivityService();
                List<Student> participantList = activityService.GetParticipants(int.Parse(listViewActivitesParticipants.SelectedItems[0].SubItems[0].Text));

                listViewParticipants.View = View.Details;
                listViewParticipants.Columns.Add("StudentId");
                listViewParticipants.Columns.Add("First name");
                listViewParticipants.Columns.Add("Last name");
                listViewParticipants.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listViewParticipants.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewParticipants.FullRowSelect = true;


                foreach (Student participant in participantList)
                {
                    ListViewItem li = new ListViewItem(participant.StudentId.ToString());
                    li.SubItems.Add(participant.FirstName);
                    li.SubItems.Add(participant.LastName);
                    listViewParticipants.Items.Add(li);
                }
                ColorListView(listViewParticipants);
            }
        }

        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Participants");
            ChangeToolStripMenu(participantsToolStripMenuItem);
        }
        private void AddParticipants_Click(object sender, EventArgs e)
        {
            labelParticipantsTitle.Text = "Please select a student:";
            Console.WriteLine("Students participating:");
            
            AddParticipantsStart.Hide();
            deleteParticipant.Hide();
            instructionDescriptionAddingMode.Show();
            buttonAddParticipant.Show();
            buttonExitAddingMode.Show();
            StudentService studService = new StudentService();
            List<Student> studentList = studService.GetStudents();

            listViewParticipants.Clear();
            listViewParticipants.View = View.Details;
            listViewParticipants.FullRowSelect = true;

            listViewParticipants.Columns.Add("Student id", 50);
            listViewParticipants.Columns.Add("First name", 120);
            listViewParticipants.Columns.Add("Last name", 120);
            listViewParticipants.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewParticipants.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (Student s in studentList)
            {
                //s.StudentId.ToString();

                ListViewItem li = new ListViewItem(s.StudentId.ToString());
                li.SubItems.Add(s.FirstName);
                li.SubItems.Add(s.LastName);
                li.Tag = s;
                listViewParticipants.Items.Add(li);

            }
            ColorListView(listViewParticipants);
        }

        private void buttonExitAddingMode_Click(object sender, EventArgs e)
        {
            showPanel("Participants");
        }

        private void deleteParticipant_Click(object sender, EventArgs e)
        {
            if (listViewActivitesParticipants.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please first select an activity in order to choose a student to delete. Please read the instructions for further information.");
            }
            else if (listViewParticipants.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student to delete. " +
                    "If the table is empty, please select another activity. Please read the instructions for further information. ");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"removing student {listViewParticipants.SelectedItems[0].SubItems[0].Text} " +
                    $"{listViewParticipants.SelectedItems[0].SubItems[1].Text} from activity {listViewActivitesParticipants.SelectedItems[0].SubItems[0].Text} " +
                    $"{listViewActivitesParticipants.SelectedItems[0].SubItems[1].Text}.\nare you sure you wish to proceed? ",
                    "remove participant", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ActivityService activityService = new ActivityService();
                    activityService.DeleteParticipant(int.Parse(listViewParticipants.SelectedItems[0].SubItems[0].Text), int.Parse(listViewActivitesParticipants.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show("Succesfully removed participant");
                    // refresh the listview
                    listViewActivitesParticipants_MouseClick(new object(), new MouseEventArgs(0, 0, 0, 0, 0));
                }

            }
        }

        private void buttonAddParticipant_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewActivitesParticipants.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an activity to proceed! If it is not clear what to do, please reread the instructions");
                }
                else if(listViewParticipants.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select a student to proceed! If it is not clear what to do, please reread the instructions");
                }
                DialogResult dialogResult = MessageBox.Show($"adding student {listViewParticipants.SelectedItems[0].SubItems[1].Text} " +
                    $"{listViewParticipants.SelectedItems[0].SubItems[2].Text} to activity {listViewActivitesParticipants.SelectedItems[0].SubItems[0].Text} " +
                    $"{listViewActivitesParticipants.SelectedItems[0].SubItems[1].Text} as participant.\nare you sure you wish to proceed? ",
                    "Add student as participant", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ActivityService activityService = new ActivityService();
                    activityService.AddParticipant(int.Parse(listViewParticipants.SelectedItems[0].SubItems[0].Text),
                        int.Parse(listViewActivitesParticipants.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show("Succesfully added student as a participant");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }



        private void ChooseSupervisorButton_Click(object sender, EventArgs e)
        {
            textLabel.Hide();
            labeltext.Show();
            TeacherService teachService = new TeacherService();
            List<Teacher> teacherList = teachService.GetTeachers();
            labeltext.Text = "After you have chosen an activity you can do 2 things:" +
                "you can press the button on the left below to add a teacher by an activity. " +
                "2. you can press the button on the right below to end the action";
            ChooseSupervisorButton.Show();
            deleteSupervisorButton.Hide();
            quitActionButton.Show();
            labelSupervisorTitle.Show();
            addSupervisorActivityButton.Hide();

            supervisorsListView.View = View.Details;
            supervisorsListView.FullRowSelect = true;
            supervisorsListView.LabelEdit = true;
            supervisorsListView.Columns.Add("Teacher id", 80);
            supervisorsListView.Columns.Add("Firstname", 80);
            supervisorsListView.Columns.Add("Lastname", 80);

            foreach (Teacher teacher in teacherList)
            {
                ListViewItem li = new ListViewItem(teacher.TeacherID.ToString());
                li.SubItems.Add(teacher.FirstName);
                li.SubItems.Add(teacher.LastName);
                li.SubItems.Add(teacher.RoomNumber.ToString());
                li.SubItems.Add(teacher.Supervisor.ToString());
                li.Tag = teacher;
                supervisorsListView.Items.Add(li);
            }
            ColorListView(supervisorsListView);
        }

        private void quitActionButton_Click(object sender, EventArgs e)
        {
            supervisorsListView.Clear();
            showPanel("Supervisors");
        }
        private void supervisorsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("Supervisors");
            ChangeToolStripMenu(supervisorsToolStripMenuItem);
        }

        private void addSupervisorActivityButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (activityTeacherListView.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select an activity to proceed! If it is not clear what to do, please reread the instructions");
                }
                else if (supervisorsListView.SelectedItems.Count == 0)
                {
                    throw new Exception("Please select a teacher to proceed! If it is not clear what to do, please reread the instructions");
                }
                DialogResult dialogResult = MessageBox.Show($"adding teacher {supervisorsListView.SelectedItems[0].SubItems[0].Text} " +
                    $"{supervisorsListView.SelectedItems[0].SubItems[1].Text} to activity {activityTeacherListView.SelectedItems[0].SubItems[0].Text} " +
                    $"{activityTeacherListView.SelectedItems[0].SubItems[1].Text} as a supervisor.\nare you sure you wish to proceed? ",
                    "Add teacher as supervisor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ActivityService activityService = new ActivityService();
                    activityService.AddSupervisor(int.Parse(supervisorsListView.SelectedItems[0].SubItems[0].Text),
                        int.Parse(activityTeacherListView.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show("Succesfully added a teacher as a supervisor");
                }
            }
            catch
            {

            }
        }

        private void addActivitiesButton_Click(object sender, EventArgs e)
        {
            try
            {
                ActivityService activityService = new ActivityService();
                string activityName = textBoxActivityName.Text;
                string description = textBoxDescription.Text;
                DateTime startTime = DateTime.Parse(textBoxStartTime.Text);
                DateTime endTime = DateTime.Parse(textBoxEndTime.Text);


                if (activityName == "" || description == "")
                {
                    throw new Exception("The activity name or the description are empty. Please try again");
                }
                else
                {
                    activityService.AddRowActivity(activityName, description, startTime, endTime);
                }

                showPanel("Activities");
            }
            catch (Exception)
            {                
                MessageBox.Show("Something went wrong while adding a row. Make sure to enter all the data in the textboxes");
            }
}

        private void updateActivitiesButton_Click(object sender, EventArgs e)
        {
            try
            {

                ActivityService activityService = new ActivityService();
                List<Activity> activityList = activityService.GetActivity();

                string activityName = textBoxActivityName.Text;
                string description = textBoxDescription.Text;
                DateTime startTime = DateTime.Parse(textBoxStartTime.Text);
                DateTime endTime = DateTime.Parse(textBoxEndTime.Text);

                activityService.UpdateRowActivity(activityName, description, startTime, endTime);
                listViewActivities.Clear();
                listViewActivities.View = View.Details;
                listViewActivities.FullRowSelect = true;
                listViewActivities.Columns.Add("ActivityNumber", 50);
                listViewActivities.Columns.Add("ActivityName", 80);
                listViewActivities.Columns.Add("Description", 80);
                listViewActivities.Columns.Add("StartDateTime", 120);
                listViewActivities.Columns.Add("EndDateTime", 120);

                foreach (Activity activity in activityList)
                {
                    ListViewItem li = new ListViewItem(activity.ActivityNumber.ToString());
                    li.SubItems.Add(activity.ActivityName);
                    li.SubItems.Add(activity.Description);
                    li.SubItems.Add(activity.StartDateTime.ToString());
                    li.SubItems.Add(activity.EndDateTime.ToString());
                    listViewActivities.Items.Add(li);
                }
                ColorListView(listViewActivities);
            }
            catch (Exception)
            {
                MessageBox.Show("Updating row failed, make sure to enter all the data in the textboxes, then press the update button");
                throw new Exception("Updating row failed. ");
            }
        }

        private void deleteActivitiesButton_Click(object sender, EventArgs e)
        {
            try
            {
                ActivityService activityService = new ActivityService();
                string activityNumberEntered = listViewActivities.SelectedItems[0].Text;
                List<Activity> activities = activityService.GetActivity();

                // pop up message voor de gebruiker
                MessageBox.Show("Are you sure you want to delete the whole row from the list?");
                // Ook nog verwijderen uit de database!!!!
                activityService.DeleteRowActivity(activityNumberEntered);
                listViewActivities.Items.Remove(listViewActivities.SelectedItems[0]);
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a row from the list, then press the delete button");
            }
        }

        private void activitiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
            ChangeToolStripMenu(drinksToolStripMenuItem);
        }    

        private void deleteSupervisorButton_Click(object sender, EventArgs e)
        {

            if (activityTeacherListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please first select an activity in order to choose a teacher to delete. Please read the instructions for further information.");
            }
            else if (supervisorsListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a teacher to delete. " +
                    "If the table is empty, please select another activity. Please read the instructions for further information. ");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show($"removing teacher {supervisorsListView.SelectedItems[0].SubItems[0].Text} " +
                    $"{supervisorsListView.SelectedItems[0].SubItems[1].Text} from activity {activityTeacherListView.SelectedItems[0].SubItems[0].Text} " +
                    $"{activityTeacherListView.SelectedItems[0].SubItems[1].Text}.\nare you sure you wish to proceed? ",
                    "Add teacher as supervisor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ActivityService activityService = new ActivityService();
                    activityService.DeleteSupervisor(int.Parse(supervisorsListView.SelectedItems[0].SubItems[0].Text), int.Parse(activityTeacherListView.SelectedItems[0].SubItems[0].Text));
                    MessageBox.Show("Succesfully removed participant");
                    // refresh the listview
                    activityTeacherListView_MouseClick_1(new object(), new MouseEventArgs(0, 0, 0, 0, 0));
                }

            }
        }

        private void activityTeacherListView_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (addSupervisorActivityButton.Visible)
            {
                ActivityService activityService = new ActivityService();
                List<Teacher> teacherList = activityService.GetSupervisors(int.Parse(activityTeacherListView.SelectedItems[0].SubItems[0].Text));


                // clear the listview before filling it again
                supervisorsListView.Clear();

                supervisorsListView.View = View.Details;
                supervisorsListView.FullRowSelect = true;
                supervisorsListView.Columns.Add("Teacher id", 80);
                supervisorsListView.Columns.Add("Firstname", 80);
                supervisorsListView.Columns.Add("Lastname", 80);

                supervisorsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                supervisorsListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                foreach (Teacher teacher in teacherList)
                {
                    ListViewItem li = new ListViewItem(teacher.TeacherID.ToString());
                    li.SubItems.Add(teacher.FirstName);
                    li.SubItems.Add(teacher.LastName);
                    li.SubItems.Add(teacher.RoomNumber.ToString());
                    li.SubItems.Add(teacher.Supervisor.ToString());
                    li.Tag = teacher;
                    supervisorsListView.Items.Add(li);
                }
                ColorListView(supervisorsListView);
            }
        }

        private void activityTeacherListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void editActivitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activities");
            ChangeToolStripMenu(activitiesToolStripMenuItem);
        }
    }
}
