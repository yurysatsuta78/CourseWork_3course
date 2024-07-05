namespace Kursovaya3kurs
{
    partial class PaidVisitsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaidVisitsForm));
            BackBtn = new Button();
            PriceTB = new TextBox();
            SportObjCB = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            AddPaidVisitBtn = new Button();
            ScheduleCB = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.SeaGreen;
            BackBtn.ForeColor = Color.PapayaWhip;
            BackBtn.Location = new Point(12, 173);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(295, 23);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // PriceTB
            // 
            PriceTB.BackColor = Color.PapayaWhip;
            PriceTB.ForeColor = Color.SeaGreen;
            PriceTB.Location = new Point(12, 115);
            PriceTB.Name = "PriceTB";
            PriceTB.Size = new Size(295, 23);
            PriceTB.TabIndex = 1;
            PriceTB.KeyPress += PriceTB_KeyPress;
            // 
            // SportObjCB
            // 
            SportObjCB.BackColor = Color.PapayaWhip;
            SportObjCB.DrawMode = DrawMode.OwnerDrawVariable;
            SportObjCB.DropDownStyle = ComboBoxStyle.DropDownList;
            SportObjCB.FormattingEnabled = true;
            SportObjCB.Location = new Point(12, 27);
            SportObjCB.Name = "SportObjCB";
            SportObjCB.Size = new Size(295, 24);
            SportObjCB.TabIndex = 2;
            SportObjCB.DrawItem += ScheduleCB_DrawItem;
            SportObjCB.MeasureItem += ScheduleCB_MeasureItem;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 15);
            label1.TabIndex = 3;
            label1.Text = "Спортивный объект";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(295, 15);
            label2.TabIndex = 4;
            label2.Text = "Оплата за посещение (BYN)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddPaidVisitBtn
            // 
            AddPaidVisitBtn.BackColor = Color.SeaGreen;
            AddPaidVisitBtn.ForeColor = Color.PapayaWhip;
            AddPaidVisitBtn.Location = new Point(12, 144);
            AddPaidVisitBtn.Name = "AddPaidVisitBtn";
            AddPaidVisitBtn.Size = new Size(295, 23);
            AddPaidVisitBtn.TabIndex = 6;
            AddPaidVisitBtn.Text = "Отметить посещение";
            AddPaidVisitBtn.UseVisualStyleBackColor = false;
            AddPaidVisitBtn.Click += AddPaidVisitBtn_Click;
            // 
            // ScheduleCB
            // 
            ScheduleCB.BackColor = Color.PapayaWhip;
            ScheduleCB.DrawMode = DrawMode.OwnerDrawVariable;
            ScheduleCB.DropDownStyle = ComboBoxStyle.DropDownList;
            ScheduleCB.FormattingEnabled = true;
            ScheduleCB.Location = new Point(12, 71);
            ScheduleCB.Name = "ScheduleCB";
            ScheduleCB.Size = new Size(295, 24);
            ScheduleCB.TabIndex = 7;
            ScheduleCB.DrawItem += ScheduleCB_DrawItem;
            ScheduleCB.MeasureItem += ScheduleCB_MeasureItem;
            // 
            // label3
            // 
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(295, 15);
            label3.TabIndex = 8;
            label3.Text = "Время";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaidVisitsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(319, 206);
            Controls.Add(label3);
            Controls.Add(ScheduleCB);
            Controls.Add(AddPaidVisitBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SportObjCB);
            Controls.Add(PriceTB);
            Controls.Add(BackBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PaidVisitsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Платные занятия";
            FormClosing += PaidVisitsForm_FormClosing;
            Load += PaidVisitsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private TextBox PriceTB;
        private ComboBox SportObjCB;
        private Label label1;
        private Label label2;
        private Button AddPaidVisitBtn;
        private ComboBox ScheduleCB;
        private Label label3;
    }
}