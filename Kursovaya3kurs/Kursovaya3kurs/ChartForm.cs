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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kursovaya3kurs
{
    public partial class ChartForm : Form
    {
        public ChartForm()
        {
            InitializeComponent();
        }

        private void ChartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void ChartForm_Load(object sender, EventArgs e)
        {
            //Чтобы по умолчанию всегда выбирался текущий год
            CurrentYearTB.Text = DateTime.Now.Year.ToString();


            using (ApplicationContext db = new ApplicationContext())
            {
                //Получение списка с доходом за каждый месяц
                var incomeData = db.paidVisits
                    .Where(s => s.Date.Year == Convert.ToInt32(CurrentYearTB.Text))
                    .GroupBy(v => new { v.Date.Year, v.Date.Month })
                    .Select(g => new
                    {
                        Month = g.Key.Month,
                        Year = g.Key.Year,
                        TotalIncome = g.Sum(v => v.Price),
                        MaxIncome = g.Sum(v => v.Price)
                    })
                    .ToList();

                //Получение максимального ежемесячного дохода для выбора масштаба в графике
                var maxincome = db.paidVisits
                    .Where(s => s.Date.Year == Convert.ToInt32(CurrentYearTB.Text))
                    .GroupBy(v => v.Date.Month)
                    .Select(g => g.Sum(v => v.Price))
                    .ToList()
                    .DefaultIfEmpty(0)
                    .Max();

                //Заполнение серии номерами месяцев и соответсвующими ежемесячными доходами
                MonthlyIncomeChart.Series.Clear();
                Series monthlyIncome = new Series();
                for (int i = 1; i <= 12; i++)
                {
                    if (!incomeData.Any(p => p.Month == i))
                    {
                        monthlyIncome.Points.AddXY(i, 0);
                    }
                    else
                    {
                        foreach (var income in incomeData)
                        {
                            if (income.Month == i)
                            {
                                monthlyIncome.Points.AddXY(income.Month, income.TotalIncome);
                            }
                        }
                    }
                }

                //Настройка графика
                MonthlyIncomeChart.Series.Add(monthlyIncome);
                monthlyIncome.IsVisibleInLegend = false;
                MonthlyIncomeChart.Titles.Clear();
                MonthlyIncomeChart.Titles.Add($"Ежемесячный доход за {CurrentYearTB.Text} год");

                MonthlyIncomeChart.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false;
                MonthlyIncomeChart.ChartAreas[0].AxisX.Title = "Номер месяца";
                MonthlyIncomeChart.ChartAreas[0].AxisY.Title = "Белорусских рублей";

                //Автовыбор масштаба в графике
                MonthlyIncomeChart.ChartAreas[0].AxisY.Maximum = 300;
                if (maxincome > 300) 
                {
                    int scale = (int)(Math.Truncate(maxincome / 100) + 1) * 100;
                    if (scale % 200 != 0)
                    {
                        scale = scale + 100;
                    }
                    MonthlyIncomeChart.ChartAreas[0].AxisY.Maximum = scale;
                }

                //Отображения информации из графика в ListView
                for (int i = 1; i <= 12; i++)
                {
                    if (!incomeData.Any(p => p.Month == i))
                    {
                        ListViewItem item = new ListViewItem(new DateTime(1, i, 1).ToString("MMMM"));
                        item.SubItems.Add("0");
                        MonthlyIncomeLV.Items.Add(item);
                    }
                    else
                    {
                        foreach (var income in incomeData)
                        {
                            if (income.Month == i)
                            {
                                ListViewItem item = new ListViewItem(new DateTime(1, income.Month, 1).ToString("MMMM"));
                                item.SubItems.Add(income.TotalIncome.ToString());
                                MonthlyIncomeLV.Items.Add(item);
                            }
                        }
                    }
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Всё то же самое, что и в методе Load
        private void NextYearBtn_Click(object sender, EventArgs e)
        {
            int currentYear = Convert.ToInt32(CurrentYearTB.Text);
            currentYear++;
            CurrentYearTB.Text = currentYear.ToString();
            using (ApplicationContext db = new ApplicationContext())
            {
                var incomeData = db.paidVisits
                    .Where(s => s.Date.Year == Convert.ToInt32(CurrentYearTB.Text))
                    .GroupBy(v => new { v.Date.Year, v.Date.Month })
                    .Select(g => new
                    {
                        Month = g.Key.Month,
                        Year = g.Key.Year,
                        TotalIncome = g.Sum(v => v.Price),
                    })
                    .ToList();

                var maxincome = db.paidVisits
                    .Where(s => s.Date.Year == Convert.ToInt32(CurrentYearTB.Text))
                    .GroupBy(v => new { v.Date.Year, v.Date.Month })
                    .Select(g => g.Sum(v => v.Price))
                    .ToList()
                    .DefaultIfEmpty(0)
                    .Max();

                MonthlyIncomeChart.Series.Clear();
                Series monthlyIncome = new Series();
                for (int i = 1; i <= 12; i++)
                {
                    if (!incomeData.Any(p => p.Month == i))
                    {
                        monthlyIncome.Points.AddXY(i, 0);
                    }
                    else
                    {
                        foreach (var income in incomeData)
                        {
                            if (income.Month == i)
                            {
                                monthlyIncome.Points.AddXY(income.Month, income.TotalIncome);
                            }
                        }
                    }
                }

                MonthlyIncomeChart.Series.Add(monthlyIncome);
                monthlyIncome.IsVisibleInLegend = false;
                MonthlyIncomeChart.Titles.Clear();
                MonthlyIncomeChart.Titles.Add($"Ежемесячный доход за {CurrentYearTB.Text} год");

                MonthlyIncomeChart.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false;
                MonthlyIncomeChart.ChartAreas[0].AxisX.Title = "Номер месяца";
                MonthlyIncomeChart.ChartAreas[0].AxisY.Title = "Белорусских рублей";
                MonthlyIncomeChart.ChartAreas[0].AxisY.Maximum = 300;
                if (maxincome > 300)
                {
                    int scale = (int)(Math.Truncate(maxincome / 100) + 1) * 100;
                    if (scale % 200 != 0)
                    {
                        scale = scale + 100;
                    }
                    MonthlyIncomeChart.ChartAreas[0].AxisY.Maximum = scale;
                }


                MonthlyIncomeLV.Items.Clear();
                for (int i = 1; i <= 12; i++)
                {
                    if (!incomeData.Any(p => p.Month == i))
                    {
                        ListViewItem item = new ListViewItem(new DateTime(1, i, 1).ToString("MMMM"));
                        item.SubItems.Add("0");
                        MonthlyIncomeLV.Items.Add(item);
                    }
                    else
                    {
                        foreach (var income in incomeData)
                        {
                            if (income.Month == i)
                            {
                                ListViewItem item = new ListViewItem(new DateTime(1, income.Month, 1).ToString("MMMM"));
                                item.SubItems.Add(income.TotalIncome.ToString());
                                MonthlyIncomeLV.Items.Add(item);
                            }
                        }
                    }
                }
            }
        }

        //Всё то же самое, что и в методе Load
        private void PrevYearBtn_Click(object sender, EventArgs e)
        {
            int currentYear = Convert.ToInt32(CurrentYearTB.Text);
            if (currentYear > 0)
            {
                currentYear--;
                CurrentYearTB.Text = currentYear.ToString();
                using (ApplicationContext db = new ApplicationContext())
                {
                    var incomeData = db.paidVisits
                        .Where(s => s.Date.Year == Convert.ToInt32(CurrentYearTB.Text))
                        .GroupBy(v => new { v.Date.Year, v.Date.Month })
                        .Select(g => new
                        {
                            Month = g.Key.Month,
                            Year = g.Key.Year,
                            TotalIncome = g.Sum(v => v.Price),
                        })
                        .ToList();

                    var maxincome = db.paidVisits
                        .Where(s => s.Date.Year == Convert.ToInt32(CurrentYearTB.Text))
                        .GroupBy(v => new { v.Date.Year, v.Date.Month })
                        .Select(g => g.Sum(v => v.Price))
                        .ToList()
                        .DefaultIfEmpty(0)
                        .Max();

                    MonthlyIncomeChart.Series.Clear();
                    Series monthlyIncome = new Series();
                    for (int i = 1; i <= 12; i++)
                    {
                        if (!incomeData.Any(p => p.Month == i))
                        {
                            monthlyIncome.Points.AddXY(i, 0);
                        }
                        else
                        {
                            foreach (var income in incomeData)
                            {
                                if (income.Month == i)
                                {
                                    monthlyIncome.Points.AddXY(income.Month, income.TotalIncome);
                                }
                            }
                        }
                    }

                    MonthlyIncomeChart.Series.Add(monthlyIncome);
                    monthlyIncome.IsVisibleInLegend = false;
                    MonthlyIncomeChart.Titles.Clear();
                    MonthlyIncomeChart.Titles.Add($"Ежемесячный доход за {CurrentYearTB.Text} год");

                    MonthlyIncomeChart.ChartAreas[0].AxisX.LabelStyle.IsEndLabelVisible = false;
                    MonthlyIncomeChart.ChartAreas[0].AxisX.Title = "Номер месяца";
                    MonthlyIncomeChart.ChartAreas[0].AxisY.Title = "Белорусских рублей";
                    MonthlyIncomeChart.ChartAreas[0].AxisY.Maximum = 300;
                    if (maxincome > 300)
                    {
                        int scale = (int)(Math.Truncate(maxincome / 100) + 1) * 100;
                        if (scale % 200 != 0) 
                        {
                            scale = scale + 100;
                        }
                        MonthlyIncomeChart.ChartAreas[0].AxisY.Maximum = scale;
                    }


                    MonthlyIncomeLV.Items.Clear();
                    for (int i = 1; i <= 12; i++)
                    {
                        if (!incomeData.Any(p => p.Month == i))
                        {
                            ListViewItem item = new ListViewItem(new DateTime(1, i, 1).ToString("MMMM"));
                            item.SubItems.Add("0");
                            MonthlyIncomeLV.Items.Add(item);
                        }
                        else
                        {
                            foreach (var income in incomeData)
                            {
                                if (income.Month == i)
                                {
                                    ListViewItem item = new ListViewItem(new DateTime(1, income.Month, 1).ToString("MMMM"));
                                    item.SubItems.Add(income.TotalIncome.ToString());
                                    MonthlyIncomeLV.Items.Add(item);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
