namespace Kursovaya3kurs
{
    partial class ScheduleEditingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleEditingForm));
            ScheduleTimeTB = new TextBox();
            SportObjectTB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ScheduleAddBtn = new Button();
            SportObjectAddBtn = new Button();
            ScheduleLB = new ListBox();
            SportObjectsLB = new ListBox();
            DelScheduleBtn = new Button();
            DelSportObjBtn = new Button();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // ScheduleTimeTB
            // 
            ScheduleTimeTB.BackColor = Color.PapayaWhip;
            ScheduleTimeTB.ForeColor = Color.SeaGreen;
            ScheduleTimeTB.Location = new Point(12, 27);
            ScheduleTimeTB.Name = "ScheduleTimeTB";
            ScheduleTimeTB.Size = new Size(225, 23);
            ScheduleTimeTB.TabIndex = 0;
            ScheduleTimeTB.KeyPress += ScheduleTimeTB_KeyPress;
            // 
            // SportObjectTB
            // 
            SportObjectTB.BackColor = Color.PapayaWhip;
            SportObjectTB.ForeColor = Color.SeaGreen;
            SportObjectTB.Location = new Point(281, 27);
            SportObjectTB.Name = "SportObjectTB";
            SportObjectTB.Size = new Size(225, 23);
            SportObjectTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(225, 15);
            label1.TabIndex = 2;
            label1.Text = "Добавить новое время посещения";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(281, 9);
            label2.Name = "label2";
            label2.Size = new Size(225, 15);
            label2.TabIndex = 3;
            label2.Text = "Добавить новый спортивный объект";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ScheduleAddBtn
            // 
            ScheduleAddBtn.BackColor = Color.SeaGreen;
            ScheduleAddBtn.ForeColor = Color.PapayaWhip;
            ScheduleAddBtn.Location = new Point(12, 56);
            ScheduleAddBtn.Name = "ScheduleAddBtn";
            ScheduleAddBtn.Size = new Size(225, 23);
            ScheduleAddBtn.TabIndex = 4;
            ScheduleAddBtn.Text = "Добавить";
            ScheduleAddBtn.UseVisualStyleBackColor = false;
            ScheduleAddBtn.Click += ScheduleAddBtn_Click;
            // 
            // SportObjectAddBtn
            // 
            SportObjectAddBtn.BackColor = Color.SeaGreen;
            SportObjectAddBtn.ForeColor = Color.PapayaWhip;
            SportObjectAddBtn.Location = new Point(281, 56);
            SportObjectAddBtn.Name = "SportObjectAddBtn";
            SportObjectAddBtn.Size = new Size(225, 23);
            SportObjectAddBtn.TabIndex = 5;
            SportObjectAddBtn.Text = "Добавить";
            SportObjectAddBtn.UseVisualStyleBackColor = false;
            SportObjectAddBtn.Click += SportObjectAddBtn_Click;
            // 
            // ScheduleLB
            // 
            ScheduleLB.BackColor = Color.PapayaWhip;
            ScheduleLB.DrawMode = DrawMode.OwnerDrawVariable;
            ScheduleLB.FormattingEnabled = true;
            ScheduleLB.ItemHeight = 15;
            ScheduleLB.Location = new Point(12, 85);
            ScheduleLB.Name = "ScheduleLB";
            ScheduleLB.Size = new Size(225, 199);
            ScheduleLB.TabIndex = 6;
            ScheduleLB.DrawItem += ScheduleLB_DrawItem;
            ScheduleLB.MeasureItem += ScheduleLB_MeasureItem;
            // 
            // SportObjectsLB
            // 
            SportObjectsLB.BackColor = Color.PapayaWhip;
            SportObjectsLB.DrawMode = DrawMode.OwnerDrawVariable;
            SportObjectsLB.FormattingEnabled = true;
            SportObjectsLB.ItemHeight = 15;
            SportObjectsLB.Location = new Point(281, 85);
            SportObjectsLB.Name = "SportObjectsLB";
            SportObjectsLB.Size = new Size(225, 199);
            SportObjectsLB.TabIndex = 7;
            SportObjectsLB.DrawItem += ScheduleLB_DrawItem;
            SportObjectsLB.MeasureItem += ScheduleLB_MeasureItem;
            // 
            // DelScheduleBtn
            // 
            DelScheduleBtn.BackColor = Color.SeaGreen;
            DelScheduleBtn.ForeColor = Color.PapayaWhip;
            DelScheduleBtn.Location = new Point(12, 290);
            DelScheduleBtn.Name = "DelScheduleBtn";
            DelScheduleBtn.Size = new Size(225, 23);
            DelScheduleBtn.TabIndex = 8;
            DelScheduleBtn.Text = "Удалить выбранное время";
            DelScheduleBtn.UseVisualStyleBackColor = false;
            DelScheduleBtn.Click += DelScheduleBtn_Click;
            // 
            // DelSportObjBtn
            // 
            DelSportObjBtn.BackColor = Color.SeaGreen;
            DelSportObjBtn.ForeColor = Color.PapayaWhip;
            DelSportObjBtn.Location = new Point(281, 290);
            DelSportObjBtn.Name = "DelSportObjBtn";
            DelSportObjBtn.Size = new Size(225, 23);
            DelSportObjBtn.TabIndex = 9;
            DelSportObjBtn.Text = "Удалить выбранный объект";
            DelSportObjBtn.UseVisualStyleBackColor = false;
            DelSportObjBtn.Click += DelSportObjBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.SeaGreen;
            BackBtn.ForeColor = Color.PapayaWhip;
            BackBtn.Location = new Point(12, 319);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(494, 29);
            BackBtn.TabIndex = 10;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // ScheduleEditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(518, 358);
            Controls.Add(BackBtn);
            Controls.Add(DelSportObjBtn);
            Controls.Add(DelScheduleBtn);
            Controls.Add(SportObjectsLB);
            Controls.Add(ScheduleLB);
            Controls.Add(SportObjectAddBtn);
            Controls.Add(ScheduleAddBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SportObjectTB);
            Controls.Add(ScheduleTimeTB);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ScheduleEditingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактор расписания";
            FormClosing += ScheduleEditingForm_FormClosing;
            Load += ScheduleEditingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ScheduleTimeTB;
        private TextBox SportObjectTB;
        private Label label1;
        private Label label2;
        private Button ScheduleAddBtn;
        private Button SportObjectAddBtn;
        private ListBox ScheduleLB;
        private ListBox SportObjectsLB;
        private Button DelScheduleBtn;
        private Button DelSportObjBtn;
        private Button BackBtn;
    }
}