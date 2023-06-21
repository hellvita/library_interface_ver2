
namespace library_interface_ver2
{
    partial class EditBookForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_back = new System.Windows.Forms.Button();
            this.label_position = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_mainBcg.SuspendLayout();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_mainBcg
            // 
            this.panel_mainBcg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(95)))));
            this.panel_mainBcg.Controls.Add(this.panel_header);
            this.panel_mainBcg.Location = new System.Drawing.Point(13, 13);
            this.panel_mainBcg.Name = "panel_mainBcg";
            this.panel_mainBcg.Size = new System.Drawing.Size(1442, 734);
            this.panel_mainBcg.TabIndex = 0;
            // 
            // panel_header
            // 
            this.panel_header.Controls.Add(this.label3);
            this.panel_header.Controls.Add(this.label2);
            this.panel_header.Controls.Add(this.label_position);
            this.panel_header.Controls.Add(this.button_back);
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Location = new System.Drawing.Point(0, 13);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1437, 110);
            this.panel_header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pristina", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(43)))), ((int)(((byte)(35)))));
            this.label1.Location = new System.Drawing.Point(102, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 88);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hisentia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::library_interface_ver2.Properties.Resources.lib_icon;
            this.pictureBox1.Location = new System.Drawing.Point(311, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.Location = new System.Drawing.Point(19, 25);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(57, 47);
            this.button_back.TabIndex = 7;
            this.button_back.Text = "←";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label_position.Location = new System.Drawing.Point(465, 12);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(247, 31);
            this.label_position.TabIndex = 8;
            this.label_position.Text = "Права бібіліотекаря:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(465, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Стобенська Олеся Іванівна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(913, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 57);
            this.label3.TabIndex = 10;
            this.label3.Text = "Каталог бібліотеки";
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1462, 755);
            this.Controls.Add(this.panel_mainBcg);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
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
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}