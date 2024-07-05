using Kursovaya3kurs.classes;
using Microsoft.EntityFrameworkCore;
using System.Net.WebSockets;

namespace Kursovaya3kurs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ScheduleEditingForm scheduleEditingForm = new ScheduleEditingForm();
        ShowVisitsForm showVisitsForm = new ShowVisitsForm();
        StudentsEditingForm studentEditingForm = new StudentsEditingForm();
        PaidVisitsForm paidVisitsForm = new PaidVisitsForm();
        ChartForm chartForm = new ChartForm();
        AuthForm authForm = new AuthForm();


        private void ScheduleEditingBtn_Click(object sender, EventArgs e)
        {
            if (CurrentUser.login != String.Empty)
            {
                if (CurrentUser.isAdmin == 1)
                {
                    Hide();
                    scheduleEditingForm.Show();
                }
                else
                {
                    MessageBox.Show("У вас нет прав", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Hide();
                authForm.Show();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                var schedule = db.schedules.ToList();

                schedule.Sort(new TimeComparer());

                var sportObjects = db.sportObjects.ToList();
                var students = db.students
                    .OrderBy(s => s.Fio)
                    .Include(s => s.Group)
                    .ToList();
                foreach (var student in students)
                {
                    StudentsLB.Items.Add(student);
                }
                ScheduleCB.DataSource = schedule;
                SportObjCB.DataSource = sportObjects;
            }
            if (CurrentUser.login != String.Empty)
            {
                CurrentUserLabel.Text = $"Вы авторизовались как {CurrentUser.login}";
                AuthBtn.Enabled = false;
                LeaveAccountBtn.Enabled = true;
            }
            else
            {
                CurrentUserLabel.Text = "Вы не авторизованы";
            }
        }

        private void StudentIdCardNumberTB_TextChanged(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var students = db.students
                    .Where(s => s.StudentId.ToString().StartsWith(StudentIdCardNumberTB.Text) || s.Fio.ToString().StartsWith(StudentIdCardNumberTB.Text))
                    .OrderBy(s => s.Fio)
                    .Include(s => s.Group)
                    .ToList();
                StudentsLB.Items.Clear();
                foreach (var student in students)
                {
                    StudentsLB.Items.Add(student);
                }
            }
        }

        private void AddVisitBtn_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (StudentsLB.SelectedItem != null)
                {
                    if (CurrentUser.login != String.Empty)
                    {
                        var selectedstudent = (Student)StudentsLB.SelectedItem;
                        Visits visit = new Visits { StudentId = selectedstudent.StudentId, ScheduleTime = ScheduleCB.Text, SportObjectName = SportObjCB.Text, Date = DateTime.Today, ViewerFio = CurrentUser.name };
                        db.visits.Add(visit);
                        db.SaveChanges();
                        MessageBox.Show("Посещение отмечено!");
                        DateTime today = DateTime.Today;
                        var todayvisits = db.visits
                            .Where(s => s.Student.StudentId == selectedstudent.StudentId)
                            .Where(s => s.Date == today)
                            .ToList();
                        TodayVisitsLB.Items.Clear();
                        foreach (var todayvisit in todayvisits)
                        {
                            TodayVisitsLB.Items.Add(todayvisit);
                        }
                    }
                    else 
                    {
                        DialogResult result = MessageBox.Show("Чтобы отмечать посещения нужно авторизоваться. Авторизоваться?", "Вы не авторизованы", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            Hide();
                            authForm.Show();
                        }
                        else 
                        {
                            return;
                        }
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void StudentsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (StudentsLB.SelectedItem != null)
                {
                    DateTime today = DateTime.Today;
                    var selectedstudent = (Student)StudentsLB.SelectedItem;
                    var todayvisits = db.visits
                        .Where(s => s.Student.StudentId == selectedstudent.StudentId)
                        .Where(s => s.Date == today)
                        .ToList();
                    TodayVisitsLB.Items.Clear();
                    foreach (var todayvisit in todayvisits)
                    {
                        TodayVisitsLB.Items.Add(todayvisit);
                    }
                }
            }
        }

        private void VisitsShowBtn_Click(object sender, EventArgs e)
        {
            if (CurrentUser.login != String.Empty)
            {
                if (CurrentUser.isAdmin == 1)
                {
                    Hide();
                    showVisitsForm.Show();
                }
                else
                {
                    MessageBox.Show("У вас нет прав", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Hide();
                authForm.Show();
            }
        }

        private void StudentEditingBtn_Click(object sender, EventArgs e)
        {
            if (CurrentUser.login != String.Empty)
            {
                if (CurrentUser.isAdmin == 1)
                {
                    Hide();
                    studentEditingForm.Show();
                }
                else 
                {
                    MessageBox.Show("У вас нет прав", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Hide();
                authForm.Show();
            }
        }

        private void PaidVisitsBtn_Click(object sender, EventArgs e)
        {
            if (CurrentUser.login != String.Empty)
            {
                Hide();
                paidVisitsForm.Show();
            }
            else 
            {
                Hide();
                authForm.Show();
            }
        }

        private void ShowPaidVisitsChartBtn_Click(object sender, EventArgs e)
        {
            if (CurrentUser.login != String.Empty)
            {
                if (CurrentUser.isAdmin == 1)
                {
                    Hide();
                    chartForm.Show();
                }
                else
                {
                    MessageBox.Show("У вас нет прав", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Hide();
                authForm.Show();
            }
        }


        private void TodayVisitsLB_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            e.DrawBackground();
            Brush myBrush = Brushes.SeaGreen;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                myBrush = Brushes.PapayaWhip;
                e.Graphics.FillRectangle(new SolidBrush(Color.SeaGreen), e.Bounds);
            }

            e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void TodayVisitsLB_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            e.ItemHeight = listBox.Font.Height;
        }

        private void ScheduleCB_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            e.DrawBackground();
            Brush myBrush = Brushes.SeaGreen;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                myBrush = Brushes.PapayaWhip;
                e.Graphics.FillRectangle(new SolidBrush(Color.SeaGreen), e.Bounds);
            }

            e.Graphics.DrawString(comboBox.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds);
            e.DrawFocusRectangle();
        }

        private void ScheduleCB_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            e.ItemHeight = comboBox.Font.Height;
        }

        private void AuthBtn_Click(object sender, EventArgs e)
        {
            Hide();
            authForm.Show();
        }

        private void AuthBtn_MouseEnter(object sender, EventArgs e)
        {
            AuthBtn.Font = new Font(AuthBtn.Font, FontStyle.Underline);
            AuthBtn.ForeColor = Color.SeaGreen;
        }

        private void AuthBtn_MouseLeave(object sender, EventArgs e)
        {
            AuthBtn.Font = new Font(AuthBtn.Font, FontStyle.Regular);
            AuthBtn.ForeColor = Color.Black;
        }

        private void LeaveAccountBtn_Click(object sender, EventArgs e)
        {
            CurrentUser.login = String.Empty;
            CurrentUser.name = String.Empty;
            if (CurrentUser.login != String.Empty)
            {
                CurrentUserLabel.Text = $"Вы авторизовались как {CurrentUser.login}";
            }
            else
            {
                CurrentUserLabel.Text = "Вы не авторизованы";
                AuthBtn.Enabled = true;
                LeaveAccountBtn.Enabled = false;
            }
        }

        private void LeaveAccountBtn_MouseEnter(object sender, EventArgs e)
        {
            LeaveAccountBtn.Font = new Font(LeaveAccountBtn.Font, FontStyle.Underline);
            LeaveAccountBtn.ForeColor = Color.SeaGreen;
        }

        private void LeaveAccountBtn_MouseLeave(object sender, EventArgs e)
        {
            LeaveAccountBtn.Font = new Font(LeaveAccountBtn.Font, FontStyle.Regular);
            LeaveAccountBtn.ForeColor = Color.Black;
        }
    }
}
