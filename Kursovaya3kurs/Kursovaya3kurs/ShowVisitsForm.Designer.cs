namespace Kursovaya3kurs
{
    partial class ShowVisitsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowVisitsForm));
            StudentIdCardNumberTB = new TextBox();
            label1 = new Label();
            StudentsLB = new ListBox();
            label4 = new Label();
            FromDP = new DateTimePicker();
            ToDP = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            VisitsLB = new ListBox();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // StudentIdCardNumberTB
            // 
            StudentIdCardNumberTB.BackColor = Color.PapayaWhip;
            StudentIdCardNumberTB.ForeColor = Color.SeaGreen;
            StudentIdCardNumberTB.Location = new Point(12, 27);
            StudentIdCardNumberTB.Name = "StudentIdCardNumberTB";
            StudentIdCardNumberTB.Size = new Size(295, 23);
            StudentIdCardNumberTB.TabIndex = 0;
            StudentIdCardNumberTB.TextChanged += StudentIdCardNumberTB_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 15);
            label1.TabIndex = 1;
            label1.Text = "Номер студенческого билета или ФИО";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentsLB
            // 
            StudentsLB.BackColor = Color.PapayaWhip;
            StudentsLB.DrawMode = DrawMode.OwnerDrawVariable;
            StudentsLB.FormattingEnabled = true;
            StudentsLB.ItemHeight = 15;
            StudentsLB.Location = new Point(12, 71);
            StudentsLB.Name = "StudentsLB";
            StudentsLB.Size = new Size(295, 319);
            StudentsLB.TabIndex = 2;
            StudentsLB.DrawItem += StudentsLB_DrawItem;
            StudentsLB.MeasureItem += StudentsLB_MeasureItem;
            StudentsLB.SelectedIndexChanged += StudentsLB_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Location = new Point(12, 53);
            label4.Name = "label4";
            label4.Size = new Size(295, 15);
            label4.TabIndex = 12;
            label4.Text = "Список студентов";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FromDP
            // 
            FromDP.Location = new Point(327, 27);
            FromDP.Name = "FromDP";
            FromDP.Size = new Size(135, 23);
            FromDP.TabIndex = 13;
            FromDP.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            FromDP.ValueChanged += FromDP_ValueChanged;
            // 
            // ToDP
            // 
            ToDP.Location = new Point(528, 27);
            ToDP.Name = "ToDP";
            ToDP.Size = new Size(135, 23);
            ToDP.TabIndex = 14;
            ToDP.ValueChanged += ToDP_ValueChanged;
            // 
            // label2
            // 
            label2.Location = new Point(327, 9);
            label2.Name = "label2";
            label2.Size = new Size(135, 15);
            label2.TabIndex = 15;
            label2.Text = "От";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(528, 9);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 16;
            label3.Text = "До";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // VisitsLB
            // 
            VisitsLB.BackColor = Color.PapayaWhip;
            VisitsLB.DrawMode = DrawMode.OwnerDrawVariable;
            VisitsLB.FormattingEnabled = true;
            VisitsLB.ItemHeight = 15;
            VisitsLB.Location = new Point(327, 71);
            VisitsLB.Name = "VisitsLB";
            VisitsLB.Size = new Size(336, 319);
            VisitsLB.TabIndex = 17;
            VisitsLB.DrawItem += StudentsLB_DrawItem;
            VisitsLB.MeasureItem += StudentsLB_MeasureItem;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.SeaGreen;
            BackBtn.ForeColor = Color.PapayaWhip;
            BackBtn.Location = new Point(12, 417);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(651, 32);
            BackBtn.TabIndex = 18;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // ShowVisitsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(675, 466);
            Controls.Add(BackBtn);
            Controls.Add(VisitsLB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ToDP);
            Controls.Add(FromDP);
            Controls.Add(label4);
            Controls.Add(StudentsLB);
            Controls.Add(label1);
            Controls.Add(StudentIdCardNumberTB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ShowVisitsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Посещаемость студентов";
            FormClosing += ShowVisitsForm_FormClosing;
            Load += ShowVisitsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StudentIdCardNumberTB;
        private Label label1;
        private ListBox StudentsLB;
        private Label label4;
        private DateTimePicker FromDP;
        private DateTimePicker ToDP;
        private Label label2;
        private Label label3;
        private ListBox VisitsLB;
        private Button BackBtn;
    }
}