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
            else if (panelName == "Teachers")
            {
                ShowCorrectPanel(pnlTeacherPanel);


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
                    studentsListView.Columns.Add("Student id", 50);
                    studentsListView.Columns.Add("First name", 120);
                    studentsListView.Columns.Add("Last name", 120);
                    studentsListView.Columns.Add("Date of birth", 70);
                    studentsListView.Columns.Add("Room number", 50);


                    foreach (Student s in studentList)
                    {
                        s.StudentId.ToString();

                        ListViewItem li = new ListViewItem(s.StudentId.ToString());
                        li.SubItems.Add(s.FirstName);
                        li.SubItems.Add(s.LastName);
                        li.SubItems.Add(s.DateOfBirth.ToString("yyyy/MM/dd"));
                        li.SubItems.Add(s.RoomNumber.ToString());
                        studentsListView.Items.Add(li);

                    }



                    DrinkService driService = new DrinkService();
                    List<Drinks> drinkList = driService.GetDrinksCR();


                    drinksListView.View = View.Details;
                    drinksListView.Columns.Add("Order id", 50);
                    drinksListView.Columns.Add("Product id", 50);
                    drinksListView.Columns.Add("Student id", 50);
                    drinksListView.Columns.Add("Date of purchase", 70);


                    foreach (Drinks d in drinkList)
                    {
                        d.OrderId.ToString();

                        ListViewItem li = new ListViewItem(d.OrderId.ToString());
                        li.SubItems.Add(d.ProductId.ToString());
                        li.SubItems.Add(d.StudentId.ToString());
                        li.SubItems.Add(d.DateOfPurchase.ToString());
                        drinksListView.Items.Add(li);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
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
                        MessageBox.Show("Listview could not be loaded properly.");
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
                        MessageBox.Show("Listview could not be loaded properly.");
                        logService.WriteLog(e);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Panel could not be loaded properly." + e.Message);
                logService.WriteLog(e);
            }
        }
        private void ShowCorrectPanel(Panel panel)
        {
            foreach(Control c in Controls)
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
            listViewDrink.Columns.Add("Stock", 70);
            listViewDrink.Columns.Add("Stock sufficient or not", 50);
            listViewDrink.Columns.Add("Sales Value", 80);
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
                for(int i = 0; i < tsmi.DropDownItems.Count; i++)
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
        private void activitiesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showPanel("Activities");
            ChangeToolStripMenu(activitiesToolStripMenuItem);
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
                if (dateTimePickerStart.Value > DateTime.Parse("01-01-2019") || dateTimePickerEnd.Value <= DateTime.Now)
                {
                    List<RevenueReport> revenueReport = revenueReportService.GetRevenueReport(dateTimePickerStart.Value, dateTimePickerEnd.Value);
                    listViewRevenueReport.View = View.Details;
                    listViewRevenueReport.Columns.Add("total sales", 120);
                    listViewRevenueReport.Columns.Add("turnover", 120);
                    listViewRevenueReport.Columns.Add("number of customers", 200);
                    ListViewItem li = new ListViewItem(revenueReport.Sum(item => item.sales).ToString());
                    li.SubItems.Add(revenueReport.Sum(item => item.turnover).ToString());
                    li.SubItems.Add(revenueReport.Sum(item => item.numberOfCustomers).ToString());
                    listViewRevenueReport.Items.Add(li);
                    ColorListView(listViewRevenueReport);

                }
                else if (dateTimePickerStart.Value > dateTimePickerEnd.Value)
                {
                    throw new Exception("Start date cannot be higher than the end date!");
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
                MessageBox.Show("Failed to load, if this keeps happening, please contact us and tell us this error message : \n" + ex.Message);
                logService.WriteLog(ex);
            }
        }
        private void drinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Drinks");
            ChangeToolStripMenu(drinksToolStripMenuItem);

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
                listViewDrink.Columns.Add("Stock", 70);
                listViewDrink.Columns.Add("Stock sufficient or not");
                listViewDrink.Columns.Add("Sales Value", 80);
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
                listViewDrink.Columns.Add("Stock", 70);
                listViewDrink.Columns.Add("Stock sufficient or not");
                listViewDrink.Columns.Add("Sales Value", 80);
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
            MessageBox.Show("Your transaction has been completed! ");
        }


    }
}
