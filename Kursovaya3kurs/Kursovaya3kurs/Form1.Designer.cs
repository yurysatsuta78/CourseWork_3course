namespace Kursovaya3kurs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            StudentIdCardNumberTB = new TextBox();
            SportObjCB = new ComboBox();
            ScheduleCB = new ComboBox();
            AddVisitBtn = new Button();
            ScheduleEditingBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            StudentsLB = new ListBox();
            label4 = new Label();
            TodayVisitsLB = new ListBox();
            label5 = new Label();
            VisitsShowBtn = new Button();
            StudentEditingBtn = new Button();
            PaidVisitsBtn = new Button();
            ShowPaidVisitsChartBtn = new Button();
            GB1 = new GroupBox();
            GB2 = new GroupBox();
            GB3 = new GroupBox();
            LeaveAccountBtn = new Label();
            CurrentUserLabel = new Label();
            AuthBtn = new Label();
            GB1.SuspendLayout();
            GB2.SuspendLayout();
            GB3.SuspendLayout();
            SuspendLayout();
            // 
            // StudentIdCardNumberTB
            // 
            StudentIdCardNumberTB.BackColor = Color.PapayaWhip;
            StudentIdCardNumberTB.ForeColor = Color.SeaGreen;
            StudentIdCardNumberTB.Location = new Point(6, 124);
            StudentIdCardNumberTB.Name = "StudentIdCardNumberTB";
            StudentIdCardNumberTB.Size = new Size(283, 23);
            StudentIdCardNumberTB.TabIndex = 3;
            StudentIdCardNumberTB.TextChanged += StudentIdCardNumberTB_TextChanged;
            // 
            // SportObjCB
            // 
            SportObjCB.BackColor = Color.PapayaWhip;
            SportObjCB.DrawMode = DrawMode.OwnerDrawVariable;
            SportObjCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SportObjCB.FormattingEnabled = true;
            SportObjCB.Items.AddRange(new object[] { "Ледовая арена", "Тренажёрный зал", "Стадион", "Бассейн" });
            SportObjCB.Location = new Point(6, 36);
            SportObjCB.Name = "SportObjCB";
            SportObjCB.Size = new Size(283, 24);
            SportObjCB.TabIndex = 1;
            SportObjCB.DrawItem += ScheduleCB_DrawItem;
            SportObjCB.MeasureItem += ScheduleCB_MeasureItem;
            // 
            // ScheduleCB
            // 
            ScheduleCB.BackColor = Color.PapayaWhip;
            ScheduleCB.DrawMode = DrawMode.OwnerDrawVariable;
            ScheduleCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ScheduleCB.ForeColor = SystemColors.WindowText;
            ScheduleCB.FormattingEnabled = true;
            ScheduleCB.Location = new Point(6, 80);
            ScheduleCB.Name = "ScheduleCB";
            ScheduleCB.Size = new Size(283, 24);
            ScheduleCB.TabIndex = 2;
            ScheduleCB.DrawItem += ScheduleCB_DrawItem;
            ScheduleCB.MeasureItem += ScheduleCB_MeasureItem;
            // 
            // AddVisitBtn
            // 
            AddVisitBtn.BackColor = Color.SeaGreen;
            AddVisitBtn.ForeColor = Color.PapayaWhip;
            AddVisitBtn.Location = new Point(6, 500);
            AddVisitBtn.Name = "AddVisitBtn";
            AddVisitBtn.Size = new Size(283, 23);
            AddVisitBtn.TabIndex = 6;
            AddVisitBtn.Text = "Отметить посещение";
            AddVisitBtn.UseVisualStyleBackColor = false;
            AddVisitBtn.Click += AddVisitBtn_Click;
            // 
            // ScheduleEditingBtn
            // 
            ScheduleEditingBtn.BackColor = Color.SeaGreen;
            ScheduleEditingBtn.ForeColor = Color.PapayaWhip;
            ScheduleEditingBtn.Location = new Point(6, 108);
            ScheduleEditingBtn.Name = "ScheduleEditingBtn";
            ScheduleEditingBtn.Size = new Size(283, 51);
            ScheduleEditingBtn.TabIndex = 9;
            ScheduleEditingBtn.Text = "Редактор расписания";
            ScheduleEditingBtn.UseVisualStyleBackColor = false;
            ScheduleEditingBtn.Click += ScheduleEditingBtn_Click;
            // 
            // label1
            // 
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(283, 15);
            label1.TabIndex = 7;
            label1.Text = "Спортивный объект";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(283, 15);
            label2.TabIndex = 8;
            label2.Text = "Время";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(6, 106);
            label3.Name = "label3";
            label3.Size = new Size(283, 15);
            label3.TabIndex = 9;
            label3.Text = "Номер студенческого билета или ФИО";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentsLB
            // 
            StudentsLB.BackColor = Color.PapayaWhip;
            StudentsLB.DrawMode = DrawMode.OwnerDrawVariable;
            StudentsLB.FormattingEnabled = true;
            StudentsLB.ItemHeight = 15;
            StudentsLB.Location = new Point(6, 171);
            StudentsLB.Name = "StudentsLB";
            StudentsLB.Size = new Size(283, 184);
            StudentsLB.TabIndex = 4;
            StudentsLB.TabStop = false;
            StudentsLB.DrawItem += TodayVisitsLB_DrawItem;
            StudentsLB.MeasureItem += TodayVisitsLB_MeasureItem;
            StudentsLB.SelectedIndexChanged += StudentsLB_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Location = new Point(6, 150);
            label4.Name = "label4";
            label4.Size = new Size(283, 18);
            label4.TabIndex = 11;
            label4.Text = "Список студентов";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TodayVisitsLB
            // 
            TodayVisitsLB.BackColor = Color.PapayaWhip;
            TodayVisitsLB.DrawMode = DrawMode.OwnerDrawVariable;
            TodayVisitsLB.FormattingEnabled = true;
            TodayVisitsLB.ItemHeight = 15;
            TodayVisitsLB.Location = new Point(6, 376);
            TodayVisitsLB.Name = "TodayVisitsLB";
            TodayVisitsLB.SelectionMode = SelectionMode.None;
            TodayVisitsLB.Size = new Size(283, 109);
            TodayVisitsLB.TabIndex = 5;
            TodayVisitsLB.TabStop = false;
            TodayVisitsLB.DrawItem += TodayVisitsLB_DrawItem;
            TodayVisitsLB.MeasureItem += TodayVisitsLB_MeasureItem;
            // 
            // label5
            // 
            label5.Location = new Point(6, 358);
            label5.Name = "label5";
            label5.Size = new Size(283, 15);
            label5.TabIndex = 13;
            label5.Text = "Студент посетил сегодня";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VisitsShowBtn
            // 
            VisitsShowBtn.BackColor = Color.SeaGreen;
            VisitsShowBtn.ForeColor = Color.PapayaWhip;
            VisitsShowBtn.Location = new Point(6, 222);
            VisitsShowBtn.Name = "VisitsShowBtn";
            VisitsShowBtn.Size = new Size(283, 51);
            VisitsShowBtn.TabIndex = 11;
            VisitsShowBtn.Text = "Посмотреть посещаемость студентов";
            VisitsShowBtn.UseVisualStyleBackColor = false;
            VisitsShowBtn.Click += VisitsShowBtn_Click;
            // 
            // StudentEditingBtn
            // 
            StudentEditingBtn.BackColor = Color.SeaGreen;
            StudentEditingBtn.ForeColor = Color.PapayaWhip;
            StudentEditingBtn.Location = new Point(6, 165);
            StudentEditingBtn.Name = "StudentEditingBtn";
            StudentEditingBtn.Size = new Size(283, 51);
            StudentEditingBtn.TabIndex = 10;
            StudentEditingBtn.Text = "Редактор списка студентов";
            StudentEditingBtn.UseVisualStyleBackColor = false;
            StudentEditingBtn.Click += StudentEditingBtn_Click;
            // 
            // PaidVisitsBtn
            // 
            PaidVisitsBtn.BackColor = Color.SeaGreen;
            PaidVisitsBtn.ForeColor = Color.PapayaWhip;
            PaidVisitsBtn.Location = new Point(6, 472);
            PaidVisitsBtn.Name = "PaidVisitsBtn";
            PaidVisitsBtn.Size = new Size(283, 51);
            PaidVisitsBtn.TabIndex = 13;
            PaidVisitsBtn.Text = "Платные занятия";
            PaidVisitsBtn.UseVisualStyleBackColor = false;
            PaidVisitsBtn.Click += PaidVisitsBtn_Click;
            // 
            // ShowPaidVisitsChartBtn
            // 
            ShowPaidVisitsChartBtn.BackColor = Color.SeaGreen;
            ShowPaidVisitsChartBtn.ForeColor = Color.PapayaWhip;
            ShowPaidVisitsChartBtn.Location = new Point(6, 279);
            ShowPaidVisitsChartBtn.Name = "ShowPaidVisitsChartBtn";
            ShowPaidVisitsChartBtn.Size = new Size(283, 51);
            ShowPaidVisitsChartBtn.TabIndex = 12;
            ShowPaidVisitsChartBtn.Text = "Показать графики";
            ShowPaidVisitsChartBtn.UseVisualStyleBackColor = false;
            ShowPaidVisitsChartBtn.Click += ShowPaidVisitsChartBtn_Click;
            // 
            // GB1
            // 
            GB1.BackColor = Color.Transparent;
            GB1.Controls.Add(label1);
            GB1.Controls.Add(SportObjCB);
            GB1.Controls.Add(label2);
            GB1.Controls.Add(ScheduleCB);
            GB1.Controls.Add(label3);
            GB1.Controls.Add(TodayVisitsLB);
            GB1.Controls.Add(AddVisitBtn);
            GB1.Controls.Add(label5);
            GB1.Controls.Add(StudentIdCardNumberTB);
            GB1.Controls.Add(label4);
            GB1.Controls.Add(StudentsLB);
            GB1.Location = new Point(12, 12);
            GB1.Name = "GB1";
            GB1.Size = new Size(295, 529);
            GB1.TabIndex = 18;
            GB1.TabStop = false;
            // 
            // GB2
            // 
            GB2.BackColor = Color.Transparent;
            GB2.Controls.Add(GB3);
            GB2.Controls.Add(ScheduleEditingBtn);
            GB2.Controls.Add(VisitsShowBtn);
            GB2.Controls.Add(ShowPaidVisitsChartBtn);
            GB2.Controls.Add(StudentEditingBtn);
            GB2.Controls.Add(PaidVisitsBtn);
            GB2.Location = new Point(313, 12);
            GB2.Name = "GB2";
            GB2.Size = new Size(295, 529);
            GB2.TabIndex = 19;
            GB2.TabStop = false;
            // 
            // GB3
            // 
            GB3.Controls.Add(LeaveAccountBtn);
            GB3.Controls.Add(CurrentUserLabel);
            GB3.Controls.Add(AuthBtn);
            GB3.Location = new Point(28, 10);
            GB3.Name = "GB3";
            GB3.Size = new Size(240, 94);
            GB3.TabIndex = 21;
            GB3.TabStop = false;
            // 
            // LeaveAccountBtn
            // 
            LeaveAccountBtn.Enabled = false;
            LeaveAccountBtn.Location = new Point(97, 65);
            LeaveAccountBtn.Name = "LeaveAccountBtn";
            LeaveAccountBtn.Size = new Size(47, 15);
            LeaveAccountBtn.TabIndex = 8;
            LeaveAccountBtn.Text = "Выйти";
            LeaveAccountBtn.TextAlign = ContentAlignment.MiddleCenter;
            LeaveAccountBtn.Click += LeaveAccountBtn_Click;
            LeaveAccountBtn.MouseEnter += LeaveAccountBtn_MouseEnter;
            LeaveAccountBtn.MouseLeave += LeaveAccountBtn_MouseLeave;
            // 
            // CurrentUserLabel
            // 
            CurrentUserLabel.Location = new Point(6, 19);
            CurrentUserLabel.Name = "CurrentUserLabel";
            CurrentUserLabel.Size = new Size(228, 15);
            CurrentUserLabel.TabIndex = 19;
            CurrentUserLabel.Text = "Вы не авторизованы";
            CurrentUserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AuthBtn
            // 
            AuthBtn.Location = new Point(71, 43);
            AuthBtn.Name = "AuthBtn";
            AuthBtn.Size = new Size(99, 15);
            AuthBtn.TabIndex = 7;
            AuthBtn.Text = "Авторизоваться";
            AuthBtn.TextAlign = ContentAlignment.MiddleCenter;
            AuthBtn.Click += AuthBtn_Click;
            AuthBtn.MouseEnter += AuthBtn_MouseEnter;
            AuthBtn.MouseLeave += AuthBtn_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(620, 552);
            Controls.Add(GB2);
            Controls.Add(GB1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учёт посещения спортивных объектов ПолесГУ";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            GB1.ResumeLayout(false);
            GB1.PerformLayout();
            GB2.ResumeLayout(false);
            GB3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox StudentIdCardNumberTB;
        private ComboBox SportObjCB;
        private ComboBox ScheduleCB;
        private Button AddVisitBtn;
        private Button ScheduleEditingBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox StudentsLB;
        private Label label4;
        private ListBox TodayVisitsLB;
        private Label label5;
        private Button VisitsShowBtn;
        private Button StudentEditingBtn;
        private Button PaidVisitsBtn;
        private Button ShowPaidVisitsChartBtn;
        private GroupBox GB1;
        private GroupBox GB2;
        private Label CurrentUserLabel;
        private Label AuthBtn;
        private GroupBox GB3;
        private Label LeaveAccountBtn;
    }
}
