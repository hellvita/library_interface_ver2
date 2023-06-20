
namespace library_interface_ver2
{
    partial class BookFullDescriptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookFullDescriptionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox_bookCover = new System.Windows.Forms.PictureBox();
            this.label_bookName = new System.Windows.Forms.Label();
            this.label_bookAuthor = new System.Windows.Forms.Label();
            this.label_publicationYear = new System.Windows.Forms.Label();
            this.label_type_genre = new System.Windows.Forms.Label();
            this.label_fullDescription = new System.Windows.Forms.Label();
            this.button_downloadBook = new System.Windows.Forms.Button();
            this.button_toBook = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(176)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.button_toBook);
            this.panel1.Controls.Add(this.button_downloadBook);
            this.panel1.Controls.Add(this.label_fullDescription);
            this.panel1.Controls.Add(this.label_type_genre);
            this.panel1.Controls.Add(this.label_publicationYear);
            this.panel1.Controls.Add(this.label_bookAuthor);
            this.panel1.Controls.Add(this.label_bookName);
            this.panel1.Controls.Add(this.pictureBox_bookCover);
            this.panel1.Controls.Add(this.button_back);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 932);
            this.panel1.TabIndex = 0;
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_back.Location = new System.Drawing.Point(14, 15);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(57, 47);
            this.button_back.TabIndex = 7;
            this.button_back.Text = "←";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // pictureBox_bookCover
            // 
            this.pictureBox_bookCover.Image = global::library_interface_ver2.Properties.Resources.book41;
            this.pictureBox_bookCover.Location = new System.Drawing.Point(33, 100);
            this.pictureBox_bookCover.Name = "pictureBox_bookCover";
            this.pictureBox_bookCover.Size = new System.Drawing.Size(323, 439);
            this.pictureBox_bookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_bookCover.TabIndex = 8;
            this.pictureBox_bookCover.TabStop = false;
            // 
            // label_bookName
            // 
            this.label_bookName.AutoSize = true;
            this.label_bookName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_bookName.Location = new System.Drawing.Point(397, 100);
            this.label_bookName.Name = "label_bookName";
            this.label_bookName.Size = new System.Drawing.Size(314, 45);
            this.label_bookName.TabIndex = 9;
            this.label_bookName.Text = "Онови філософії";
            // 
            // label_bookAuthor
            // 
            this.label_bookAuthor.AutoSize = true;
            this.label_bookAuthor.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_bookAuthor.Location = new System.Drawing.Point(397, 158);
            this.label_bookAuthor.Name = "label_bookAuthor";
            this.label_bookAuthor.Size = new System.Drawing.Size(309, 31);
            this.label_bookAuthor.TabIndex = 10;
            this.label_bookAuthor.Text = "Автор: Сергій Симоненко";
            // 
            // label_publicationYear
            // 
            this.label_publicationYear.AutoSize = true;
            this.label_publicationYear.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_publicationYear.Location = new System.Drawing.Point(397, 203);
            this.label_publicationYear.Name = "label_publicationYear";
            this.label_publicationYear.Size = new System.Drawing.Size(194, 27);
            this.label_publicationYear.TabIndex = 11;
            this.label_publicationYear.Text = "Рік видання: 2019";
            // 
            // label_type_genre
            // 
            this.label_type_genre.AutoSize = true;
            this.label_type_genre.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_type_genre.Location = new System.Drawing.Point(397, 241);
            this.label_type_genre.Name = "label_type_genre";
            this.label_type_genre.Size = new System.Drawing.Size(313, 27);
            this.label_type_genre.TabIndex = 12;
            this.label_type_genre.Text = "Фахова література, філософія";
            // 
            // label_fullDescription
            // 
            this.label_fullDescription.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_fullDescription.Location = new System.Drawing.Point(397, 286);
            this.label_fullDescription.Name = "label_fullDescription";
            this.label_fullDescription.Size = new System.Drawing.Size(955, 627);
            this.label_fullDescription.TabIndex = 13;
            this.label_fullDescription.Text = resources.GetString("label_fullDescription.Text");
            // 
            // button_downloadBook
            // 
            this.button_downloadBook.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_downloadBook.Location = new System.Drawing.Point(33, 572);
            this.button_downloadBook.Name = "button_downloadBook";
            this.button_downloadBook.Size = new System.Drawing.Size(323, 70);
            this.button_downloadBook.TabIndex = 14;
            this.button_downloadBook.Text = "Завантажити";
            this.button_downloadBook.UseVisualStyleBackColor = true;
            // 
            // button_toBook
            // 
            this.button_toBook.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_toBook.Location = new System.Drawing.Point(33, 671);
            this.button_toBook.Name = "button_toBook";
            this.button_toBook.Size = new System.Drawing.Size(323, 70);
            this.button_toBook.TabIndex = 15;
            this.button_toBook.Text = "Забронювати";
            this.button_toBook.UseVisualStyleBackColor = true;
            // 
            // BookFullDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 956);
            this.Controls.Add(this.panel1);
            this.Name = "BookFullDescriptionForm";
            this.Text = "BookFullDescriptionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.PictureBox pictureBox_bookCover;
        private System.Windows.Forms.Label label_bookAuthor;
        private System.Windows.Forms.Label label_bookName;
        private System.Windows.Forms.Label label_publicationYear;
        private System.Windows.Forms.Label label_type_genre;
        private System.Windows.Forms.Button button_toBook;
        private System.Windows.Forms.Button button_downloadBook;
        private System.Windows.Forms.Label label_fullDescription;
    }
}