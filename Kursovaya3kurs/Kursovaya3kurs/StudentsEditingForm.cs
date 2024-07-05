using Kursovaya3kurs.classes;
using Microsoft.Data.SqlClient;
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
    public partial class StudentsEditingForm : Form
    {
        public StudentsEditingForm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudentsEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void StudentAddBtn_Click(object sender, EventArgs e)
        {
            if (StudFioTB.Text != String.Empty && StudGroupCB.SelectedIndex != -1)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    var selectedgroup = (Group)StudGroupCB.SelectedItem;
                    if (selectedgroup != null)
                    {
                        try
                        {
                            var stud = new Student { Fio = StudFioTB.Text, GroupId = selectedgroup.GroupId };
                            db.students.Add(stud);
                            db.SaveChanges();
                            StudFioTB.Text = String.Empty;
                            StudGroupCB.SelectedIndex = 0;
                            var students = db.students
                                .Include(s => s.Group)
                                .GroupBy(s => s.Fio)
                                .ToList();
                            StudentsLB.DataSource = null;
                            StudentsLB.DataSource = students;
                        }
                        catch (DbUpdateException ex)
                        {
                            if (ex.InnerException.Message.Contains("Нарушено \"IX_students\" ограничения UNIQUE KEY"))
                            {
                                MessageBox.Show("Студент с таким номером студенческого бмлета уже есть.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show(ex.Message, "Возникала неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void GroupAddBtn_Click(object sender, EventArgs e)
        {
            if (GroupNameTB.Text != String.Empty && GroupTutorTB.Text != String.Empty)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    Group group = new Group { GroupName = GroupNameTB.Text, Tutor = GroupTutorTB.Text };

                    db.groups.Add(group);
                    db.SaveChanges();
                    GroupNameTB.Text = String.Empty;
                    GroupTutorTB.Text = String.Empty;
                    var groups = db.groups
                        .OrderBy(s => s.GroupName)
                        .ToList();
                    var groupscb = db.groups.ToList();
                    StudGroupCB.DataSource = null;
                    StudGroupCB.DataSource = groupscb;
                    GroupsLB.DataSource = null;
                    GroupsLB.DataSource = groups;
                }
            }
            else
            {
                return;
            }
        }

        private void StudentsEditingForm_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var groups = db.groups.ToList();
                var groupscb = db.groups.ToList();
                var students = db.students
                    .OrderBy(s => s.Fio)
                    .ToList();
                StudentsLB.DataSource = students;
                GroupsLB.DataSource = groups;
                StudGroupCB.DataSource = groupscb;
            }
        }

        private void DelStudentBtn_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var selectedStudent = (Student)StudentsLB.SelectedItem;
                if (selectedStudent != null)
                {
                    var itemToRemove = db.students.SingleOrDefault(Student => Student.StudentId == selectedStudent.StudentId);
                    if (itemToRemove != null)
                    {
                        db.students.Remove(itemToRemove);
                        db.SaveChanges();
                        var students = db.students
                            .Include(s => s.Group)
                            .OrderBy(s => s.Fio)
                            .ToList();
                        StudentsLB.DataSource = null;
                        StudentsLB.DataSource = students;
                    }
                }
            }
        }

        private void DeleteGroupBtn_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var selectedGroup = (Group)GroupsLB.SelectedItem;
                if (selectedGroup != null)
                {
                    var itemToRemove = db.groups.SingleOrDefault(Group => Group.GroupId == selectedGroup.GroupId);
                    if (itemToRemove != null)
                    {
                        DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить эту группу? Все студенты, входящие в неё, также будут удалены.", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            db.groups.Remove(itemToRemove);
                            db.SaveChanges();
                            var groups = db.groups
                                .OrderBy(s => s.GroupName)
                                .ToList();
                            var groupscb = db.groups
                                .OrderBy(s => s.GroupName)
                                .ToList();
                            var students = db.students
                                .OrderBy(s => s.Fio)
                                .ToList();
                            StudGroupCB.DataSource = null;
                            StudGroupCB.DataSource = groupscb;
                            GroupsLB.DataSource = null;
                            GroupsLB.DataSource = groups;
                            StudentsLB.DataSource = null;
                            StudentsLB.DataSource = students;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
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

        private void StudGroupCB_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            e.ItemHeight = comboBox.Font.Height;
        }

        private void StudGroupCB_DrawItem(object sender, DrawItemEventArgs e)
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
    }
}
