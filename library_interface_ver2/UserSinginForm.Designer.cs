
namespace library_interface_ver2
{
    partial class UserSinginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_pwd_tip = new System.Windows.Forms.Label();
            this.label_email_tip = new System.Windows.Forms.Label();
            this.label_phone_tip = new System.Windows.Forms.Label();
            this.label_fname_tip = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_user_email = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_user_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_user_pwd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_user_fname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.label_pwd_tip);
            this.panel1.Controls.Add(this.label_email_tip);
            this.panel1.Controls.Add(this.label_phone_tip);
            this.panel1.Controls.Add(this.label_fname_tip);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 653);
            this.panel1.TabIndex = 2;
            // 
            // label_pwd_tip
            // 
            this.label_pwd_tip.AutoSize = true;
            this.label_pwd_tip.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_pwd_tip.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_pwd_tip.Location = new System.Drawing.Point(535, 478);
            this.label_pwd_tip.Name = "label_pwd_tip";
            this.label_pwd_tip.Size = new System.Drawing.Size(741, 62);
            this.label_pwd_tip.TabIndex = 10;
            this.label_pwd_tip.Text = "Пароль має містити принаймні 5 символів (максимум 20). \r\nДопускається лише викори" +
    "стання цифр та латинських літер";
            this.label_pwd_tip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_email_tip
            // 
            this.label_email_tip.AutoSize = true;
            this.label_email_tip.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_email_tip.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_email_tip.Location = new System.Drawing.Point(535, 382);
            this.label_email_tip.Name = "label_email_tip";
            this.label_email_tip.Size = new System.Drawing.Size(661, 31);
            this.label_email_tip.TabIndex = 9;
            this.label_email_tip.Text = "Введіть адресу Вашої електронної поштової скриньки";
            this.label_email_tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_phone_tip
            // 
            this.label_phone_tip.AutoSize = true;
            this.label_phone_tip.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_phone_tip.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_phone_tip.Location = new System.Drawing.Point(535, 260);
            this.label_phone_tip.Name = "label_phone_tip";
            this.label_phone_tip.Size = new System.Drawing.Size(512, 62);
            this.label_phone_tip.TabIndex = 8;
            this.label_phone_tip.Text = "Введіть Ваш актуальний номер телефону.\r\n(Наприклад: +380 000 000 00 00)";
            this.label_phone_tip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_fname_tip
            // 
            this.label_fname_tip.AutoSize = true;
            this.label_fname_tip.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_fname_tip.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_fname_tip.Location = new System.Drawing.Point(535, 142);
            this.label_fname_tip.Name = "label_fname_tip";
            this.label_fname_tip.Size = new System.Drawing.Size(775, 62);
            this.label_fname_tip.TabIndex = 7;
            this.label_fname_tip.Text = "Введіть повністю своє ПІБ. Ці дані повинні бути достовірними\r\n(як у Вашому паспор" +
    "ті)";
            this.label_fname_tip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.Location = new System.Drawing.Point(24, 23);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(57, 47);
            this.button_back.TabIndex = 6;
            this.button_back.Text = "←";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_user_email);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(33, 342);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(480, 86);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Поштова скринька";
            // 
            // textBox_user_email
            // 
            this.textBox_user_email.Location = new System.Drawing.Point(6, 37);
            this.textBox_user_email.Name = "textBox_user_email";
            this.textBox_user_email.Size = new System.Drawing.Size(468, 38);
            this.textBox_user_email.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_user_phone);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(33, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 86);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Номер телефону";
            // 
            // textBox_user_phone
            // 
            this.textBox_user_phone.Location = new System.Drawing.Point(6, 37);
            this.textBox_user_phone.Name = "textBox_user_phone";
            this.textBox_user_phone.Size = new System.Drawing.Size(468, 38);
            this.textBox_user_phone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(407, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "~Реєстрація в бібліотеці Hisentia~";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_user_pwd);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(33, 454);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(480, 86);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Придумайте пароль";
            // 
            // textBox_user_pwd
            // 
            this.textBox_user_pwd.Location = new System.Drawing.Point(6, 37);
            this.textBox_user_pwd.Name = "textBox_user_pwd";
            this.textBox_user_pwd.Size = new System.Drawing.Size(468, 38);
            this.textBox_user_pwd.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_user_fname);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(33, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ПІБ";
            // 
            // textBox_user_fname
            // 
            this.textBox_user_fname.Location = new System.Drawing.Point(6, 37);
            this.textBox_user_fname.Name = "textBox_user_fname";
            this.textBox_user_fname.Size = new System.Drawing.Size(468, 38);
            this.textBox_user_fname.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(500, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(416, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "ЗАРЕЄСТРУВАТИСЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserSinginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 677);
            this.Controls.Add(this.panel1);
            this.Name = "UserSinginForm";
            this.Text = "Створення облікового запису";
            this.Load += new System.EventHandler(this.UserSinginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_user_pwd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_user_fname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_user_phone;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox_user_email;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label_fname_tip;
        private System.Windows.Forms.Label label_phone_tip;
        private System.Windows.Forms.Label label_pwd_tip;
        private System.Windows.Forms.Label label_email_tip;
    }
}