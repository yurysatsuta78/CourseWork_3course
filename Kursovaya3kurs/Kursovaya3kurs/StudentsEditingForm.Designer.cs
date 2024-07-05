namespace Kursovaya3kurs
{
    partial class StudentsEditingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsEditingForm));
            StudentAddBtn = new Button();
            GroupAddBtn = new Button();
            DelStudentBtn = new Button();
            DeleteGroupBtn = new Button();
            BackBtn = new Button();
            GroupNameTB = new TextBox();
            GroupTutorTB = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            StudFioTB = new TextBox();
            label6 = new Label();
            StudentsLB = new ListBox();
            GroupsLB = new ListBox();
            StudGroupCB = new ComboBox();
            GB1 = new GroupBox();
            GB2 = new GroupBox();
            GB1.SuspendLayout();
            GB2.SuspendLayout();
            SuspendLayout();
            // 
            // StudentAddBtn
            // 
            StudentAddBtn.BackColor = Color.SeaGreen;
            StudentAddBtn.ForeColor = Color.PapayaWhip;
            StudentAddBtn.Location = new Point(6, 117);
            StudentAddBtn.Name = "StudentAddBtn";
            StudentAddBtn.Size = new Size(229, 23);
            StudentAddBtn.TabIndex = 5;
            StudentAddBtn.Text = "Добавить";
            StudentAddBtn.UseVisualStyleBackColor = false;
            StudentAddBtn.Click += StudentAddBtn_Click;
            // 
            // GroupAddBtn
            // 
            GroupAddBtn.BackColor = Color.SeaGreen;
            GroupAddBtn.ForeColor = Color.PapayaWhip;
            GroupAddBtn.Location = new Point(6, 117);
            GroupAddBtn.Name = "GroupAddBtn";
            GroupAddBtn.Size = new Size(229, 23);
            GroupAddBtn.TabIndex = 6;
            GroupAddBtn.Text = "Добавить";
            GroupAddBtn.UseVisualStyleBackColor = false;
            GroupAddBtn.Click += GroupAddBtn_Click;
            // 
            // DelStudentBtn
            // 
            DelStudentBtn.BackColor = Color.SeaGreen;
            DelStudentBtn.ForeColor = Color.PapayaWhip;
            DelStudentBtn.Location = new Point(6, 306);
            DelStudentBtn.Name = "DelStudentBtn";
            DelStudentBtn.Size = new Size(229, 23);
            DelStudentBtn.TabIndex = 9;
            DelStudentBtn.Text = "Удалить выбранного студента";
            DelStudentBtn.UseVisualStyleBackColor = false;
            DelStudentBtn.Click += DelStudentBtn_Click;
            // 
            // DeleteGroupBtn
            // 
            DeleteGroupBtn.BackColor = Color.SeaGreen;
            DeleteGroupBtn.ForeColor = Color.PapayaWhip;
            DeleteGroupBtn.Location = new Point(6, 306);
            DeleteGroupBtn.Name = "DeleteGroupBtn";
            DeleteGroupBtn.Size = new Size(229, 23);
            DeleteGroupBtn.TabIndex = 10;
            DeleteGroupBtn.Text = "Удалить выбранную группу";
            DeleteGroupBtn.UseVisualStyleBackColor = false;
            DeleteGroupBtn.Click += DeleteGroupBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.SeaGreen;
            BackBtn.ForeColor = Color.PapayaWhip;
            BackBtn.Location = new Point(12, 363);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(494, 29);
            BackBtn.TabIndex = 11;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // GroupNameTB
            // 
            GroupNameTB.BackColor = Color.PapayaWhip;
            GroupNameTB.ForeColor = Color.SeaGreen;
            GroupNameTB.Location = new Point(6, 44);
            GroupNameTB.Name = "GroupNameTB";
            GroupNameTB.Size = new Size(229, 23);
            GroupNameTB.TabIndex = 12;
            // 
            // GroupTutorTB
            // 
            GroupTutorTB.BackColor = Color.PapayaWhip;
            GroupTutorTB.ForeColor = Color.SeaGreen;
            GroupTutorTB.Location = new Point(6, 88);
            GroupTutorTB.Name = "GroupTutorTB";
            GroupTutorTB.Size = new Size(229, 23);
            GroupTutorTB.TabIndex = 13;
            // 
            // label3
            // 
            label3.Location = new Point(6, 26);
            label3.Name = "label3";
            label3.Size = new Size(229, 15);
            label3.TabIndex = 14;
            label3.Text = "Название группы";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(6, 70);
            label4.Name = "label4";
            label4.Size = new Size(229, 15);
            label4.TabIndex = 15;
            label4.Text = "Куратор";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Location = new Point(6, 26);
            label5.Name = "label5";
            label5.Size = new Size(229, 15);
            label5.TabIndex = 16;
            label5.Text = "ФИО студента";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudFioTB
            // 
            StudFioTB.BackColor = Color.PapayaWhip;
            StudFioTB.ForeColor = Color.SeaGreen;
            StudFioTB.Location = new Point(6, 44);
            StudFioTB.Name = "StudFioTB";
            StudFioTB.Size = new Size(229, 23);
            StudFioTB.TabIndex = 17;
            // 
            // label6
            // 
            label6.Location = new Point(6, 70);
            label6.Name = "label6";
            label6.Size = new Size(229, 15);
            label6.TabIndex = 18;
            label6.Text = "Группа";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentsLB
            // 
            StudentsLB.BackColor = Color.PapayaWhip;
            StudentsLB.DrawMode = DrawMode.OwnerDrawVariable;
            StudentsLB.FormattingEnabled = true;
            StudentsLB.ItemHeight = 15;
            StudentsLB.Location = new Point(6, 146);
            StudentsLB.Name = "StudentsLB";
            StudentsLB.Size = new Size(229, 154);
            StudentsLB.TabIndex = 22;
            StudentsLB.DrawItem += StudentsLB_DrawItem;
            StudentsLB.MeasureItem += StudentsLB_MeasureItem;
            // 
            // GroupsLB
            // 
            GroupsLB.BackColor = Color.PapayaWhip;
            GroupsLB.DrawMode = DrawMode.OwnerDrawVariable;
            GroupsLB.FormattingEnabled = true;
            GroupsLB.ItemHeight = 15;
            GroupsLB.Location = new Point(6, 146);
            GroupsLB.Name = "GroupsLB";
            GroupsLB.Size = new Size(229, 154);
            GroupsLB.TabIndex = 23;
            GroupsLB.DrawItem += StudentsLB_DrawItem;
            GroupsLB.MeasureItem += StudentsLB_MeasureItem;
            // 
            // StudGroupCB
            // 
            StudGroupCB.BackColor = Color.PapayaWhip;
            StudGroupCB.DrawMode = DrawMode.OwnerDrawVariable;
            StudGroupCB.DropDownStyle = ComboBoxStyle.DropDownList;
            StudGroupCB.ForeColor = Color.SeaGreen;
            StudGroupCB.FormattingEnabled = true;
            StudGroupCB.Location = new Point(6, 88);
            StudGroupCB.Name = "StudGroupCB";
            StudGroupCB.Size = new Size(229, 24);
            StudGroupCB.TabIndex = 24;
            StudGroupCB.DrawItem += StudGroupCB_DrawItem;
            StudGroupCB.MeasureItem += StudGroupCB_MeasureItem;
            // 
            // GB1
            // 
            GB1.Controls.Add(label5);
            GB1.Controls.Add(StudGroupCB);
            GB1.Controls.Add(StudentsLB);
            GB1.Controls.Add(StudFioTB);
            GB1.Controls.Add(label6);
            GB1.Controls.Add(StudentAddBtn);
            GB1.Controls.Add(DelStudentBtn);
            GB1.Location = new Point(12, 9);
            GB1.Name = "GB1";
            GB1.Size = new Size(241, 348);
            GB1.TabIndex = 25;
            GB1.TabStop = false;
            GB1.Text = "Новый студент";
            // 
            // GB2
            // 
            GB2.Controls.Add(label3);
            GB2.Controls.Add(GroupNameTB);
            GB2.Controls.Add(GroupsLB);
            GB2.Controls.Add(DeleteGroupBtn);
            GB2.Controls.Add(label4);
            GB2.Controls.Add(GroupTutorTB);
            GB2.Controls.Add(GroupAddBtn);
            GB2.Location = new Point(265, 9);
            GB2.Name = "GB2";
            GB2.Size = new Size(241, 348);
            GB2.TabIndex = 26;
            GB2.TabStop = false;
            GB2.Text = "Новая группа";
            // 
            // StudentsEditingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(520, 404);
            Controls.Add(GB2);
            Controls.Add(GB1);
            Controls.Add(BackBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "StudentsEditingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактор списка студентов";
            FormClosing += StudentsEditingForm_FormClosing;
            Load += StudentsEditingForm_Load;
            GB1.ResumeLayout(false);
            GB1.PerformLayout();
            GB2.ResumeLayout(false);
            GB2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button StudentAddBtn;
        private Button GroupAddBtn;
        private Button DelStudentBtn;
        private Button DeleteGroupBtn;
        private Button BackBtn;
        private TextBox GroupNameTB;
        private TextBox GroupTutorTB;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox StudFioTB;
        private Label label6;
        private ListBox StudentsLB;
        private ListBox GroupsLB;
        private ComboBox StudGroupCB;
        private GroupBox GB1;
        private GroupBox GB2;
    }
}