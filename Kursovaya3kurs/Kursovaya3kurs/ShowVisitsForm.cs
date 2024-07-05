using Kursovaya3kurs.classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya3kurs
{
    public partial class ShowVisitsForm : Form
    {
        public ShowVisitsForm()
        {
            InitializeComponent();
        }

        private void ShowVisitsForm_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var students = db.students
                    .OrderBy(s => s.Fio)
                    .Include(s => s.Group)
                    .ToList();
                foreach (var student in students)
                {
                    StudentsLB.Items.Add(student);
                }
            }
        }

        private void ShowVisitsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
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

        private void StudentsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (StudentsLB.SelectedItem != null)
                {
                    var from = FromDP.Value;
                    var to = ToDP.Value;
                    var selectedstudent = (Student)StudentsLB.SelectedItem;
                    var fromtovisits = db.visits
                        .OrderBy(s => s.Date)
                        .Where(s => s.Student.StudentId == selectedstudent.StudentId)
                        .Where(s => s.Date > from && s.Date < to)
                        .ToList();
                    VisitsLB.Items.Clear();
                    foreach (var fromtovisit in fromtovisits)
                    {
                        string visitinfo = $"{fromtovisit.SportObjectName}. {fromtovisit.Date.ToString("dd/MM/yyyy")}. Отметил: {fromtovisit.ViewerFio}";
                        VisitsLB.Items.Add(visitinfo);
                    }
                }
            }
        }

        private void FromDP_ValueChanged(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (StudentsLB.SelectedItem != null)
                {
                    var from = FromDP.Value;
                    var to = ToDP.Value;
                    var selectedstudent = (Student)StudentsLB.SelectedItem;
                    var fromtovisits = db.visits
                        .OrderBy(s => s.Date)
                        .Where(s => s.Student.StudentId == selectedstudent.StudentId)
                        .Where(s => s.Date > from && s.Date < to)
                        .ToList();
                    VisitsLB.Items.Clear();
                    foreach (var fromtovisit in fromtovisits)
                    {
                        string visitinfo = $"{fromtovisit.SportObjectName}. {fromtovisit.Date.ToString("dd/MM/yyyy")}. Отметил: {fromtovisit.ViewerFio}";
                        VisitsLB.Items.Add(visitinfo);
                    }
                }
            }
        }

        private void ToDP_ValueChanged(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                if (StudentsLB.SelectedItem != null)
                {
                    var from = FromDP.Value;
                    var to = ToDP.Value;
                    var selectedstudent = (Student)StudentsLB.SelectedItem;
                    var fromtovisits = db.visits
                        .OrderBy(s => s.Date)
                        .Where(s => s.Student.StudentId == selectedstudent.StudentId)
                        .Where(s => s.Date > from && s.Date < to)
                        .ToList();
                    VisitsLB.Items.Clear();
                    foreach (var fromtovisit in fromtovisits)
                    {
                        string visitinfo = $"{fromtovisit.SportObjectName}. {fromtovisit.Date.ToString("dd/MM/yyyy")}. Отметил: {fromtovisit.ViewerFio}";
                        VisitsLB.Items.Add(visitinfo);
                    }
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudentsLB_DrawItem(object sender, DrawItemEventArgs e)
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

        private void StudentsLB_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            e.ItemHeight = listBox.Font.Height;
        }
    }
}
