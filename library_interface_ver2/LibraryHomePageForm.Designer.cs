
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
            this.panel_bookSearch = new System.Windows.Forms.Panel();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_bookTypes = new System.Windows.Forms.ComboBox();
            this.comboBox_bookGenres = new System.Windows.Forms.ComboBox();
            this.comboBox_subject_areas = new System.Windows.Forms.ComboBox();
            this.comboBox_books_subjects = new System.Windows.Forms.ComboBox();
            this.comboBox_disciplines = new System.Windows.Forms.ComboBox();
            this.panel_mainbcg.SuspendLayout();
            this.panel_title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_bookSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_mainbcg
            // 
            this.panel_mainbcg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(176)))), ((int)(((byte)(156)))));
            this.panel_mainbcg.Controls.Add(this.panel_bookSearch);
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
            // panel_bookSearch
            // 
            this.panel_bookSearch.Controls.Add(this.comboBox_disciplines);
            this.panel_bookSearch.Controls.Add(this.comboBox_books_subjects);
            this.panel_bookSearch.Controls.Add(this.comboBox_subject_areas);
            this.panel_bookSearch.Controls.Add(this.comboBox_bookGenres);
            this.panel_bookSearch.Controls.Add(this.comboBox_bookTypes);
            this.panel_bookSearch.Controls.Add(this.button_search);
            this.panel_bookSearch.Controls.Add(this.textBox_search);
            this.panel_bookSearch.Location = new System.Drawing.Point(13, 166);
            this.panel_bookSearch.Name = "panel_bookSearch";
            this.panel_bookSearch.Size = new System.Drawing.Size(1721, 146);
            this.panel_bookSearch.TabIndex = 1;
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_search.Location = new System.Drawing.Point(85, 17);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(1440, 53);
            this.textBox_search.TabIndex = 0;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_search.Location = new System.Drawing.Point(1552, 17);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(66, 53);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "🔍";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // comboBox_bookTypes
            // 
            this.comboBox_bookTypes.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_bookTypes.FormattingEnabled = true;
            this.comboBox_bookTypes.Location = new System.Drawing.Point(85, 85);
            this.comboBox_bookTypes.Name = "comboBox_bookTypes";
            this.comboBox_bookTypes.Size = new System.Drawing.Size(397, 39);
            this.comboBox_bookTypes.TabIndex = 2;
            // 
            // comboBox_bookGenres
            // 
            this.comboBox_bookGenres.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_bookGenres.FormattingEnabled = true;
            this.comboBox_bookGenres.Location = new System.Drawing.Point(497, 85);
            this.comboBox_bookGenres.Name = "comboBox_bookGenres";
            this.comboBox_bookGenres.Size = new System.Drawing.Size(315, 39);
            this.comboBox_bookGenres.TabIndex = 3;
            // 
            // comboBox_subject_areas
            // 
            this.comboBox_subject_areas.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_subject_areas.FormattingEnabled = true;
            this.comboBox_subject_areas.Location = new System.Drawing.Point(497, 85);
            this.comboBox_subject_areas.Name = "comboBox_subject_areas";
            this.comboBox_subject_areas.Size = new System.Drawing.Size(315, 39);
            this.comboBox_subject_areas.TabIndex = 4;
            // 
            // comboBox_books_subjects
            // 
            this.comboBox_books_subjects.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_books_subjects.FormattingEnabled = true;
            this.comboBox_books_subjects.Location = new System.Drawing.Point(497, 85);
            this.comboBox_books_subjects.Name = "comboBox_books_subjects";
            this.comboBox_books_subjects.Size = new System.Drawing.Size(315, 39);
            this.comboBox_books_subjects.TabIndex = 5;
            // 
            // comboBox_disciplines
            // 
            this.comboBox_disciplines.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_disciplines.FormattingEnabled = true;
            this.comboBox_disciplines.Location = new System.Drawing.Point(497, 85);
            this.comboBox_disciplines.Name = "comboBox_disciplines";
            this.comboBox_disciplines.Size = new System.Drawing.Size(315, 39);
            this.comboBox_disciplines.TabIndex = 6;
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
            this.panel_bookSearch.ResumeLayout(false);
            this.panel_bookSearch.PerformLayout();
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
        private System.Windows.Forms.Panel panel_bookSearch;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_bookTypes;
        private System.Windows.Forms.ComboBox comboBox_bookGenres;
        private System.Windows.Forms.ComboBox comboBox_subject_areas;
        private System.Windows.Forms.ComboBox comboBox_books_subjects;
        private System.Windows.Forms.ComboBox comboBox_disciplines;
    }
}