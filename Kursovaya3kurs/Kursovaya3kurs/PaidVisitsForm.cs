using Kursovaya3kurs.classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya3kurs
{
    public partial class PaidVisitsForm : Form
    {
        public PaidVisitsForm()
        {
            InitializeComponent();
        }

        private void PaidVisitsForm_Load(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {

                var schedule = db.schedules.ToList();
                schedule.Sort(new TimeComparer());
                var sportObjects = db.sportObjects.ToList();
                ScheduleCB.DataSource = schedule;
                SportObjCB.DataSource = sportObjects;
            }
        }

        private void PaidVisitsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPaidVisitBtn_Click(object sender, EventArgs e)
        {
            if (ScheduleCB.SelectedIndex != -1 && SportObjCB.SelectedIndex != -1 && PriceTB.Text != System.String.Empty)
            {
                using (ApplicationContext db = new ApplicationContext())
                {
                    PaidVisits paidvisit = new PaidVisits { ScheduleTime = ScheduleCB.Text, SportObjectName = SportObjCB.Text, Date = DateTime.Today, Price = Convert.ToDouble(PriceTB.Text) };
                    db.paidVisits.Add(paidvisit);
                    db.SaveChanges();
                    MessageBox.Show("Платное посещение отмечено!");
                    PriceTB.Text = String.Empty;
                }
            }
            else
            {
                return;
            }
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

        private void PriceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
            {
                e.Handled = true;
            }
        }
    }
}
