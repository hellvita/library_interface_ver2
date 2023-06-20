
namespace library_interface_ver2
{
    partial class LibraryHomePageForm
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
            this.panel_mainbcg = new System.Windows.Forms.Panel();
            this.panel_title = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_userID = new System.Windows.Forms.Label();
            this.button_userAcc = new System.Windows.Forms.Button();
            this.panel_mainbcg.SuspendLayout();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_mainbcg
            // 
            this.panel_mainbcg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(176)))), ((int)(((byte)(156)))));
            this.panel_mainbcg.Controls.Add(this.panel_title);
            this.panel_mainbcg.Location = new System.Drawing.Point(12, 12);
            this.panel_mainbcg.Name = "panel_mainbcg";
            this.panel_mainbcg.Size = new System.Drawing.Size(1753, 932);
            this.panel_mainbcg.TabIndex = 0;
            // 
            // panel_title
            // 
            this.panel_title.Controls.Add(this.button_userAcc);
            this.panel_title.Controls.Add(this.label_userID);
            this.panel_title.Controls.Add(this.label2);
            this.panel_title.Controls.Add(this.pictureBox1);
            this.panel_title.Controls.Add(this.label1);
            this.panel_title.Location = new System.Drawing.Point(13, 14);
            this.panel_title.Name = "panel_title";
            this.panel_title.Size = new System.Drawing.Size(1721, 125);
            this.panel_title.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hisentia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::library_interface_ver2.Properties.Resources.lib_icon;
            this.pictureBox1.Location = new System.Drawing.Point(249, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(814, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(853, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ласкаво просимо до нашої бібліотеки!";
            // 
            // label_userID
            // 
            this.label_userID.AutoSize = true;
            this.label_userID.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_userID.Location = new System.Drawing.Point(428, 21);
            this.label_userID.Name = "label_userID";
            this.label_userID.Size = new System.Drawing.Size(250, 31);
            this.label_userID.TabIndex = 3;
            this.label_userID.Text = "Користувач №12345";
            // 
            // button_userAcc
            // 
            this.button_userAcc.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_userAcc.Location = new System.Drawing.Point(428, 60);
            this.button_userAcc.Name = "button_userAcc";
            this.button_userAcc.Size = new System.Drawing.Size(250, 48);
            this.button_userAcc.TabIndex = 4;
            this.button_userAcc.Text = "Переглянути";
            this.button_userAcc.UseVisualStyleBackColor = true;
            // 
            // LibraryHomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1777, 956);
            this.Controls.Add(this.panel_mainbcg);
            this.Name = "LibraryHomePageForm";
            this.Text = "LibraryHomePageForm";
            this.Load += new System.EventHandler(this.LibraryHomePageForm_Load);
            this.panel_mainbcg.ResumeLayout(false);
            this.panel_title.ResumeLayout(false);
            this.panel_title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_mainbcg;
        private System.Windows.Forms.Panel panel_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_userAcc;
        private System.Windows.Forms.Label label_userID;
        private System.Windows.Forms.Label label2;
    }
}