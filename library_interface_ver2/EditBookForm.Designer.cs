
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
            this.panel_gridview = new System.Windows.Forms.Panel();
            this.dataGV_books = new System.Windows.Forms.DataGridView();
            this.panel_editLabels = new System.Windows.Forms.Panel();
            this.button_clearFields = new System.Windows.Forms.Button();
            this.comboBox_bookGenres = new System.Windows.Forms.ComboBox();
            this.comboBox_subject_areas = new System.Windows.Forms.ComboBox();
            this.comboBox_books_subjects = new System.Windows.Forms.ComboBox();
            this.label_electronCopy = new System.Windows.Forms.Label();
            this.textBox_electronCopy = new System.Windows.Forms.TextBox();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.label_cover = new System.Windows.Forms.Label();
            this.textBox_cover = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.label_language = new System.Windows.Forms.Label();
            this.textBox_year = new System.Windows.Forms.TextBox();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.label_year = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.label_author = new System.Windows.Forms.Label();
            this.label_genre = new System.Windows.Forms.Label();
            this.comboBox_disciplines = new System.Windows.Forms.ComboBox();
            this.label_bookName = new System.Windows.Forms.Label();
            this.comboBox_bookTypes = new System.Windows.Forms.ComboBox();
            this.textBox_bookName = new System.Windows.Forms.TextBox();
            this.label_bookType = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label_fullname = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_mainBcg.SuspendLayout();
            this.panel_gridview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_books)).BeginInit();
            this.panel_editLabels.SuspendLayout();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_mainBcg
            // 
            this.panel_mainBcg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(112)))), ((int)(((byte)(95)))));
            this.panel_mainBcg.Controls.Add(this.panel_gridview);
            this.panel_mainBcg.Controls.Add(this.panel_editLabels);
            this.panel_mainBcg.Controls.Add(this.panel_header);
            this.panel_mainBcg.Location = new System.Drawing.Point(13, 13);
            this.panel_mainBcg.Name = "panel_mainBcg";
            this.panel_mainBcg.Size = new System.Drawing.Size(1771, 1030);
            this.panel_mainBcg.TabIndex = 0;
            // 
            // panel_gridview
            // 
            this.panel_gridview.Controls.Add(this.dataGV_books);
            this.panel_gridview.Location = new System.Drawing.Point(3, 394);
            this.panel_gridview.Name = "panel_gridview";
            this.panel_gridview.Size = new System.Drawing.Size(1760, 633);
            this.panel_gridview.TabIndex = 15;
            // 
            // dataGV_books
            // 
            this.dataGV_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_books.Location = new System.Drawing.Point(16, 3);
            this.dataGV_books.Name = "dataGV_books";
            this.dataGV_books.ReadOnly = true;
            this.dataGV_books.RowHeadersWidth = 51;
            this.dataGV_books.RowTemplate.Height = 29;
            this.dataGV_books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGV_books.Size = new System.Drawing.Size(1741, 627);
            this.dataGV_books.TabIndex = 0;
            // 
            // panel_editLabels
            // 
            this.panel_editLabels.Controls.Add(this.button_clearFields);
            this.panel_editLabels.Controls.Add(this.comboBox_bookGenres);
            this.panel_editLabels.Controls.Add(this.comboBox_subject_areas);
            this.panel_editLabels.Controls.Add(this.comboBox_books_subjects);
            this.panel_editLabels.Controls.Add(this.label_electronCopy);
            this.panel_editLabels.Controls.Add(this.textBox_electronCopy);
            this.panel_editLabels.Controls.Add(this.label_description);
            this.panel_editLabels.Controls.Add(this.textBox_description);
            this.panel_editLabels.Controls.Add(this.label2);
            this.panel_editLabels.Controls.Add(this.textBox_amount);
            this.panel_editLabels.Controls.Add(this.label_cover);
            this.panel_editLabels.Controls.Add(this.textBox_cover);
            this.panel_editLabels.Controls.Add(this.button_delete);
            this.panel_editLabels.Controls.Add(this.button_edit);
            this.panel_editLabels.Controls.Add(this.button_search);
            this.panel_editLabels.Controls.Add(this.label_language);
            this.panel_editLabels.Controls.Add(this.textBox_year);
            this.panel_editLabels.Controls.Add(this.comboBox_language);
            this.panel_editLabels.Controls.Add(this.label_year);
            this.panel_editLabels.Controls.Add(this.textBox_author);
            this.panel_editLabels.Controls.Add(this.label_author);
            this.panel_editLabels.Controls.Add(this.label_genre);
            this.panel_editLabels.Controls.Add(this.comboBox_disciplines);
            this.panel_editLabels.Controls.Add(this.label_bookName);
            this.panel_editLabels.Controls.Add(this.comboBox_bookTypes);
            this.panel_editLabels.Controls.Add(this.textBox_bookName);
            this.panel_editLabels.Controls.Add(this.label_bookType);
            this.panel_editLabels.Location = new System.Drawing.Point(3, 138);
            this.panel_editLabels.Name = "panel_editLabels";
            this.panel_editLabels.Size = new System.Drawing.Size(1760, 250);
            this.panel_editLabels.TabIndex = 14;
            // 
            // button_clearFields
            // 
            this.button_clearFields.AutoSize = true;
            this.button_clearFields.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_clearFields.Location = new System.Drawing.Point(1591, 36);
            this.button_clearFields.Name = "button_clearFields";
            this.button_clearFields.Size = new System.Drawing.Size(59, 53);
            this.button_clearFields.TabIndex = 38;
            this.button_clearFields.Text = "⟲";
            this.button_clearFields.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_clearFields.UseVisualStyleBackColor = true;
            this.button_clearFields.Click += new System.EventHandler(this.button_clearFields_Click);
            // 
            // comboBox_bookGenres
            // 
            this.comboBox_bookGenres.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_bookGenres.FormattingEnabled = true;
            this.comboBox_bookGenres.Location = new System.Drawing.Point(928, 42);
            this.comboBox_bookGenres.Name = "comboBox_bookGenres";
            this.comboBox_bookGenres.Size = new System.Drawing.Size(315, 39);
            this.comboBox_bookGenres.TabIndex = 37;
            // 
            // comboBox_subject_areas
            // 
            this.comboBox_subject_areas.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_subject_areas.FormattingEnabled = true;
            this.comboBox_subject_areas.Location = new System.Drawing.Point(928, 42);
            this.comboBox_subject_areas.Name = "comboBox_subject_areas";
            this.comboBox_subject_areas.Size = new System.Drawing.Size(315, 39);
            this.comboBox_subject_areas.TabIndex = 36;
            // 
            // comboBox_books_subjects
            // 
            this.comboBox_books_subjects.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_books_subjects.FormattingEnabled = true;
            this.comboBox_books_subjects.Location = new System.Drawing.Point(928, 43);
            this.comboBox_books_subjects.Name = "comboBox_books_subjects";
            this.comboBox_books_subjects.Size = new System.Drawing.Size(315, 39);
            this.comboBox_books_subjects.TabIndex = 35;
            // 
            // label_electronCopy
            // 
            this.label_electronCopy.AutoSize = true;
            this.label_electronCopy.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_electronCopy.Location = new System.Drawing.Point(1329, 93);
            this.label_electronCopy.Name = "label_electronCopy";
            this.label_electronCopy.Size = new System.Drawing.Size(198, 27);
            this.label_electronCopy.TabIndex = 34;
            this.label_electronCopy.Text = "Електронна копія:";
            // 
            // textBox_electronCopy
            // 
            this.textBox_electronCopy.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_electronCopy.Location = new System.Drawing.Point(1329, 124);
            this.textBox_electronCopy.Name = "textBox_electronCopy";
            this.textBox_electronCopy.Size = new System.Drawing.Size(389, 38);
            this.textBox_electronCopy.TabIndex = 33;
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_description.Location = new System.Drawing.Point(16, 170);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(72, 27);
            this.label_description.TabIndex = 32;
            this.label_description.Text = "Опис:";
            // 
            // textBox_description
            // 
            this.textBox_description.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_description.Location = new System.Drawing.Point(16, 200);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(1481, 38);
            this.textBox_description.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1252, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 27);
            this.label2.TabIndex = 30;
            this.label2.Text = "Кількість примірників:";
            // 
            // textBox_amount
            // 
            this.textBox_amount.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_amount.Location = new System.Drawing.Point(1254, 43);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(243, 38);
            this.textBox_amount.TabIndex = 29;
            // 
            // label_cover
            // 
            this.label_cover.AutoSize = true;
            this.label_cover.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_cover.Location = new System.Drawing.Point(932, 93);
            this.label_cover.Name = "label_cover";
            this.label_cover.Size = new System.Drawing.Size(143, 27);
            this.label_cover.TabIndex = 28;
            this.label_cover.Text = "Обкладинка:";
            // 
            // textBox_cover
            // 
            this.textBox_cover.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_cover.Location = new System.Drawing.Point(932, 124);
            this.textBox_cover.Name = "textBox_cover";
            this.textBox_cover.Size = new System.Drawing.Size(389, 38);
            this.textBox_cover.TabIndex = 27;
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(1688, 186);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(55, 52);
            this.button_delete.TabIndex = 26;
            this.button_delete.Text = "🗑️";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.AutoSize = true;
            this.button_edit.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_edit.Location = new System.Drawing.Point(1686, 36);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(57, 53);
            this.button_edit.TabIndex = 24;
            this.button_edit.Text = "✏️";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_search
            // 
            this.button_search.AutoSize = true;
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_search.Location = new System.Drawing.Point(1591, 186);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(59, 53);
            this.button_search.TabIndex = 23;
            this.button_search.Text = "👁";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // label_language
            // 
            this.label_language.AutoSize = true;
            this.label_language.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_language.Location = new System.Drawing.Point(736, 93);
            this.label_language.Name = "label_language";
            this.label_language.Size = new System.Drawing.Size(162, 27);
            this.label_language.TabIndex = 22;
            this.label_language.Text = "Мова видання:";
            // 
            // textBox_year
            // 
            this.textBox_year.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_year.Location = new System.Drawing.Point(525, 125);
            this.textBox_year.Name = "textBox_year";
            this.textBox_year.Size = new System.Drawing.Size(205, 38);
            this.textBox_year.TabIndex = 21;
            // 
            // comboBox_language
            // 
            this.comboBox_language.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Location = new System.Drawing.Point(736, 123);
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.Size = new System.Drawing.Size(190, 39);
            this.comboBox_language.TabIndex = 20;
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_year.Location = new System.Drawing.Point(525, 94);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(171, 27);
            this.label_year.TabIndex = 19;
            this.label_year.Text = "Рік публцікації:";
            // 
            // textBox_author
            // 
            this.textBox_author.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_author.Location = new System.Drawing.Point(16, 124);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(503, 38);
            this.textBox_author.TabIndex = 18;
            // 
            // label_author
            // 
            this.label_author.AutoSize = true;
            this.label_author.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_author.Location = new System.Drawing.Point(16, 94);
            this.label_author.Name = "label_author";
            this.label_author.Size = new System.Drawing.Size(79, 27);
            this.label_author.TabIndex = 17;
            this.label_author.Text = "Автор:";
            // 
            // label_genre
            // 
            this.label_genre.AutoSize = true;
            this.label_genre.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_genre.Location = new System.Drawing.Point(928, 13);
            this.label_genre.Name = "label_genre";
            this.label_genre.Size = new System.Drawing.Size(177, 27);
            this.label_genre.TabIndex = 16;
            this.label_genre.Text = "Жанр/Тематика:";
            // 
            // comboBox_disciplines
            // 
            this.comboBox_disciplines.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_disciplines.FormattingEnabled = true;
            this.comboBox_disciplines.Location = new System.Drawing.Point(928, 43);
            this.comboBox_disciplines.Name = "comboBox_disciplines";
            this.comboBox_disciplines.Size = new System.Drawing.Size(315, 39);
            this.comboBox_disciplines.TabIndex = 15;
            // 
            // label_bookName
            // 
            this.label_bookName.AutoSize = true;
            this.label_bookName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_bookName.Location = new System.Drawing.Point(419, 13);
            this.label_bookName.Name = "label_bookName";
            this.label_bookName.Size = new System.Drawing.Size(143, 27);
            this.label_bookName.TabIndex = 14;
            this.label_bookName.Text = "Повна назва:";
            // 
            // comboBox_bookTypes
            // 
            this.comboBox_bookTypes.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_bookTypes.FormattingEnabled = true;
            this.comboBox_bookTypes.Location = new System.Drawing.Point(16, 43);
            this.comboBox_bookTypes.Name = "comboBox_bookTypes";
            this.comboBox_bookTypes.Size = new System.Drawing.Size(397, 39);
            this.comboBox_bookTypes.TabIndex = 11;
            // 
            // textBox_bookName
            // 
            this.textBox_bookName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_bookName.Location = new System.Drawing.Point(419, 44);
            this.textBox_bookName.Name = "textBox_bookName";
            this.textBox_bookName.Size = new System.Drawing.Size(503, 38);
            this.textBox_bookName.TabIndex = 12;
            // 
            // label_bookType
            // 
            this.label_bookType.AutoSize = true;
            this.label_bookType.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_bookType.Location = new System.Drawing.Point(16, 13);
            this.label_bookType.Name = "label_bookType";
            this.label_bookType.Size = new System.Drawing.Size(171, 27);
            this.label_bookType.TabIndex = 13;
            this.label_bookType.Text = "Тип літератури:";
            // 
            // panel_header
            // 
            this.panel_header.Controls.Add(this.label3);
            this.panel_header.Controls.Add(this.label_fullname);
            this.panel_header.Controls.Add(this.label_position);
            this.panel_header.Controls.Add(this.button_back);
            this.panel_header.Controls.Add(this.pictureBox1);
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Location = new System.Drawing.Point(0, 13);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1763, 110);
            this.panel_header.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1265, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 57);
            this.label3.TabIndex = 10;
            this.label3.Text = "Каталог бібліотеки";
            // 
            // label_fullname
            // 
            this.label_fullname.AutoSize = true;
            this.label_fullname.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_fullname.Location = new System.Drawing.Point(654, 47);
            this.label_fullname.Name = "label_fullname";
            this.label_fullname.Size = new System.Drawing.Size(384, 35);
            this.label_fullname.TabIndex = 9;
            this.label_fullname.Text = "Стобенська Олеся Іванівна";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label_position.Location = new System.Drawing.Point(654, 16);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(247, 31);
            this.label_position.TabIndex = 8;
            this.label_position.Text = "Права бібіліотекаря:";
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
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1788, 1055);
            this.Controls.Add(this.panel_mainBcg);
            this.Name = "EditBookForm";
            this.Text = "EditBookForm";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            this.panel_mainBcg.ResumeLayout(false);
            this.panel_gridview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_books)).EndInit();
            this.panel_editLabels.ResumeLayout(false);
            this.panel_editLabels.PerformLayout();
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
        private System.Windows.Forms.Label label_fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_bookTypes;
        private System.Windows.Forms.Panel panel_editLabels;
        private System.Windows.Forms.Label label_bookName;
        private System.Windows.Forms.TextBox textBox_bookName;
        private System.Windows.Forms.Label label_bookType;
        private System.Windows.Forms.Label label_author;
        private System.Windows.Forms.Label label_genre;
        private System.Windows.Forms.ComboBox comboBox_disciplines;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.TextBox textBox_year;
        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.Label label_language;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Panel panel_gridview;
        private System.Windows.Forms.Label label_electronCopy;
        private System.Windows.Forms.TextBox textBox_electronCopy;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Label label_cover;
        private System.Windows.Forms.TextBox textBox_cover;
        private System.Windows.Forms.ComboBox comboBox_bookGenres;
        private System.Windows.Forms.ComboBox comboBox_subject_areas;
        private System.Windows.Forms.ComboBox comboBox_books_subjects;
        private System.Windows.Forms.DataGridView dataGV_books;
        private System.Windows.Forms.Button button_clearFields;
    }
}