
namespace library_interface_ver2
{
    partial class AccDeleteConfirmForm
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
            this.button_cancle = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.button_cancle);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 251);
            this.panel1.TabIndex = 0;
            // 
            // button_cancle
            // 
            this.button_cancle.AutoSize = true;
            this.button_cancle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cancle.Location = new System.Drawing.Point(187, 197);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(190, 51);
            this.button_cancle.TabIndex = 2;
            this.button_cancle.Text = "Повернутися";
            this.button_cancle.UseVisualStyleBackColor = true;
            this.button_cancle.Click += new System.EventHandler(this.button_cancle_Click);
            // 
            // button_delete
            // 
            this.button_delete.AutoSize = true;
            this.button_delete.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(415, 197);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(155, 51);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Видалити";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 132);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ви дійсно хочете видалити свій обліковий запис у бібліотеці Hisentia?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccDeleteConfirmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 276);
            this.Controls.Add(this.panel1);
            this.Name = "AccDeleteConfirmForm";
            this.Text = "AccDeleteConfirmForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_cancle;
    }
}