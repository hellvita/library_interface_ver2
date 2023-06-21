
namespace library_interface_ver2
{
    partial class LibrarianHomePageForm
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
            this.panel_mainBcg = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel_mainBcg.SuspendLayout();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_mainBcg
            // 
            this.panel_mainBcg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(99)))), ((int)(((byte)(120)))));
            this.panel_mainBcg.Controls.Add(this.panel_header);
            this.panel_mainBcg.Location = new System.Drawing.Point(12, 12);
            this.panel_mainBcg.Name = "panel_mainBcg";
            this.panel_mainBcg.Size = new System.Drawing.Size(1135, 640);
            this.panel_mainBcg.TabIndex = 0;
            // 
            // panel_header
            // 
            this.panel_header.Controls.Add(this.button_exit);
            this.panel_header.Controls.Add(this.label2);
            this.panel_header.Controls.Add(this.label_position);
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Location = new System.Drawing.Point(3, 14);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1129, 110);
            this.panel_header.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(417, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Стобенська Олеся Іванівна";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label_position.Location = new System.Drawing.Point(417, 12);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(247, 31);
            this.label_position.TabIndex = 3;
            this.label_position.Text = "Права бібіліотекаря:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::library_interface_ver2.Properties.Resources.lib_icon;
            this.pictureBox1.Location = new System.Drawing.Point(254, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hisentia";
            // 
            // button_exit
            // 
            this.button_exit.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_exit.Location = new System.Drawing.Point(1030, 33);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(63, 48);
            this.button_exit.TabIndex = 6;
            this.button_exit.Text = "🚪";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // LibrarianHomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 664);
            this.Controls.Add(this.panel_mainBcg);
            this.Name = "LibrarianHomePageForm";
            this.Text = "LibrarianHomePageForm";
            this.Load += new System.EventHandler(this.LibrarianHomePageForm_Load);
            this.panel_mainBcg.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_mainBcg;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Button button_exit;
    }
}