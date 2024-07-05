namespace Kursovaya3kurs
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            MonthlyIncomeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            CurrentYearTB = new TextBox();
            NextYearBtn = new Button();
            PrevYearBtn = new Button();
            BackBtn = new Button();
            MonthlyIncomeLV = new ListView();
            MonthColumn = new ColumnHeader();
            MonthlyIncomeColumn = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)MonthlyIncomeChart).BeginInit();
            SuspendLayout();
            // 
            // MonthlyIncomeChart
            // 
            MonthlyIncomeChart.BackColor = Color.PapayaWhip;
            MonthlyIncomeChart.BorderlineColor = Color.SeaGreen;
            MonthlyIncomeChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            MonthlyIncomeChart.BorderlineWidth = 2;
            chartArea1.Name = "ChartArea1";
            MonthlyIncomeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            MonthlyIncomeChart.Legends.Add(legend1);
            MonthlyIncomeChart.Location = new Point(12, 12);
            MonthlyIncomeChart.Name = "MonthlyIncomeChart";
            MonthlyIncomeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            MonthlyIncomeChart.Series.Add(series1);
            MonthlyIncomeChart.Size = new Size(776, 304);
            MonthlyIncomeChart.TabIndex = 0;
            MonthlyIncomeChart.Text = "chart1";
            // 
            // CurrentYearTB
            // 
            CurrentYearTB.BackColor = Color.PapayaWhip;
            CurrentYearTB.ForeColor = Color.SeaGreen;
            CurrentYearTB.Location = new Point(358, 324);
            CurrentYearTB.Name = "CurrentYearTB";
            CurrentYearTB.ReadOnly = true;
            CurrentYearTB.ShortcutsEnabled = false;
            CurrentYearTB.Size = new Size(100, 23);
            CurrentYearTB.TabIndex = 1;
            CurrentYearTB.TabStop = false;
            CurrentYearTB.TextAlign = HorizontalAlignment.Center;
            // 
            // NextYearBtn
            // 
            NextYearBtn.BackColor = Color.SeaGreen;
            NextYearBtn.ForeColor = Color.PapayaWhip;
            NextYearBtn.Location = new Point(464, 323);
            NextYearBtn.Name = "NextYearBtn";
            NextYearBtn.Size = new Size(75, 23);
            NextYearBtn.TabIndex = 2;
            NextYearBtn.Text = ">>";
            NextYearBtn.UseVisualStyleBackColor = false;
            NextYearBtn.Click += NextYearBtn_Click;
            // 
            // PrevYearBtn
            // 
            PrevYearBtn.BackColor = Color.SeaGreen;
            PrevYearBtn.ForeColor = Color.PapayaWhip;
            PrevYearBtn.Location = new Point(277, 324);
            PrevYearBtn.Name = "PrevYearBtn";
            PrevYearBtn.Size = new Size(75, 23);
            PrevYearBtn.TabIndex = 3;
            PrevYearBtn.Text = "<<";
            PrevYearBtn.UseVisualStyleBackColor = false;
            PrevYearBtn.Click += PrevYearBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.SeaGreen;
            BackBtn.ForeColor = Color.PapayaWhip;
            BackBtn.Location = new Point(277, 431);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(262, 23);
            BackBtn.TabIndex = 4;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // MonthlyIncomeLV
            // 
            MonthlyIncomeLV.BackColor = Color.PapayaWhip;
            MonthlyIncomeLV.BorderStyle = BorderStyle.FixedSingle;
            MonthlyIncomeLV.Columns.AddRange(new ColumnHeader[] { MonthColumn, MonthlyIncomeColumn });
            MonthlyIncomeLV.ForeColor = Color.SeaGreen;
            MonthlyIncomeLV.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            MonthlyIncomeLV.Location = new Point(12, 324);
            MonthlyIncomeLV.Name = "MonthlyIncomeLV";
            MonthlyIncomeLV.Size = new Size(259, 130);
            MonthlyIncomeLV.TabIndex = 6;
            MonthlyIncomeLV.UseCompatibleStateImageBehavior = false;
            MonthlyIncomeLV.View = View.Details;
            // 
            // MonthColumn
            // 
            MonthColumn.Text = "Месяц";
            MonthColumn.Width = 105;
            // 
            // MonthlyIncomeColumn
            // 
            MonthlyIncomeColumn.Text = "Доход (BYN)";
            MonthlyIncomeColumn.TextAlign = HorizontalAlignment.Center;
            MonthlyIncomeColumn.Width = 133;
            // 
            // ChartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 460);
            Controls.Add(MonthlyIncomeLV);
            Controls.Add(BackBtn);
            Controls.Add(PrevYearBtn);
            Controls.Add(NextYearBtn);
            Controls.Add(CurrentYearTB);
            Controls.Add(MonthlyIncomeChart);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Просмотр графиков";
            FormClosing += ChartForm_FormClosing;
            Load += ChartForm_Load;
            ((System.ComponentModel.ISupportInitialize)MonthlyIncomeChart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart MonthlyIncomeChart;
        private TextBox CurrentYearTB;
        private Button NextYearBtn;
        private Button PrevYearBtn;
        private Button BackBtn;
        private ListView MonthlyIncomeLV;
        private ColumnHeader MonthColumn;
        private ColumnHeader MonthlyIncomeColumn;
    }
}