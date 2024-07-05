using Kursovaya3kurs.classes;
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
    public partial class ScheduleEditingForm : Form
    {
        public ScheduleEditingForm()
        {
            InitializeComponent();
        }

        private void ScheduleAddBtn_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Schedule sch = new Schedule { ScheduleTime = ScheduleTimeTB.Text };

                db.schedules.Add(sch);
                db.SaveChanges();
                ScheduleTimeTB.Text = String.Empty;
                var schedule = db.schedules.ToList();
                schedule.Sort(new TimeComparer());
                ScheduleLB.DataSource = null;
                ScheduleLB.DataSource = schedule;
            }
        }

        private void SportObjectAddBtn_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                SportObject sportObject = new SportObject { SportObjectName = SportObjectTB.Text };

                db.sportObjects.Add(sportObject);
                db.SaveChanges();
                SportObjectTB.Text = String.Empty;
                var sportObjects = db.sportObjects.ToList();
                SportObjectsLB.DataSource = null;
                SportObjectsLB.DataSource = sportObjects;
            }
        }

        private void ScheduleEditingForm_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var schedule = db.schedules.ToList();

                schedule.Sort(new TimeComparer());

                var sportObjects = db.sportObjects.ToList();
                ScheduleLB.DataSource = schedule;
                SportObjectsLB.DataSource = sportObjects;
            }
        }

        private void DelScheduleBtn_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                Schedule selectedItem = (Schedule)ScheduleLB.SelectedItem;
                if (selectedItem != null)
                {
                    var itemToRemove = db.schedules.SingleOrDefault(Schedule => Schedule.ScheduleId == selectedItem.ScheduleId);
                    if (itemToRemove != null)
                    {
                        db.schedules.Remove(itemToRemove);
                        db.SaveChanges();
                        var schedule = db.schedules.ToList();
                        schedule.Sort(new TimeComparer());
                        ScheduleLB.DataSource = null;
                        ScheduleLB.DataSource = schedule;
                    }
                }
            }
        }

        private void DelSportObjBtn_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                SportObject selectedItem = (SportObject)SportObjectsLB.SelectedItem;
                if (selectedItem != null)
                {
                    var itemToRemove = db.sportObjects.SingleOrDefault(SportObject => SportObject.SportObjectId == selectedItem.SportObjectId);
                    if (itemToRemove != null)
                    {
                        db.sportObjects.Remove(itemToRemove);
                        db.SaveChanges();
                        var sportObjects = db.sportObjects.ToList();
                        SportObjectsLB.DataSource = null;
                        SportObjectsLB.DataSource = sportObjects;
                    }
                }
            }
        }

        private void ScheduleEditingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ScheduleLB_DrawItem(object sender, DrawItemEventArgs e)
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

        private void ScheduleLB_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            ListBox listBox = (ListBox)sender;
            e.ItemHeight = listBox.Font.Height;
        }

        private void ScheduleTimeTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
