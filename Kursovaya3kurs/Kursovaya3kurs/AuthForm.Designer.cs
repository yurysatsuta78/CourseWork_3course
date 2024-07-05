namespace Kursovaya3kurs
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            label1 = new Label();
            label2 = new Label();
            LoginTB = new TextBox();
            PasswordTB = new TextBox();
            AuthBtn = new Button();
            label3 = new Label();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(12, 58);
            label1.Name = "label1";
            label1.Size = new Size(302, 15);
            label1.TabIndex = 0;
            label1.Text = "Логин";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(302, 15);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginTB
            // 
            LoginTB.BackColor = Color.PapayaWhip;
            LoginTB.ForeColor = Color.SeaGreen;
            LoginTB.Location = new Point(12, 76);
            LoginTB.Name = "LoginTB";
            LoginTB.Size = new Size(302, 23);
            LoginTB.TabIndex = 2;
            // 
            // PasswordTB
            // 
            PasswordTB.BackColor = Color.PapayaWhip;
            PasswordTB.ForeColor = Color.SeaGreen;
            PasswordTB.Location = new Point(12, 120);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PasswordChar = '*';
            PasswordTB.Size = new Size(302, 23);
            PasswordTB.TabIndex = 3;
            // 
            // AuthBtn
            // 
            AuthBtn.BackColor = Color.SeaGreen;
            AuthBtn.ForeColor = Color.PapayaWhip;
            AuthBtn.Location = new Point(12, 165);
            AuthBtn.Name = "AuthBtn";
            AuthBtn.Size = new Size(302, 23);
            AuthBtn.TabIndex = 4;
            AuthBtn.Text = "Авторизоваться";
            AuthBtn.UseVisualStyleBackColor = false;
            AuthBtn.Click += AuthBtn_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(12, 3);
            label3.Name = "label3";
            label3.Size = new Size(302, 49);
            label3.TabIndex = 5;
            label3.Text = "Авторизуйтесь";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.SeaGreen;
            BackBtn.ForeColor = Color.PapayaWhip;
            BackBtn.Location = new Point(12, 194);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(302, 23);
            BackBtn.TabIndex = 6;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(326, 232);
            Controls.Add(BackBtn);
            Controls.Add(label3);
            Controls.Add(AuthBtn);
            Controls.Add(PasswordTB);
            Controls.Add(LoginTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Окно авторизации";
            FormClosing += AuthForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox LoginTB;
        private TextBox PasswordTB;
        private Button AuthBtn;
        private Label label3;
        private Button BackBtn;
    }
}