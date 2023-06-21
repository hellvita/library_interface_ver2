
namespace library_interface_ver2
{
    partial class ApplyBookChangesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplyBookChangesForm));
            this.panel_mainbcg = new System.Windows.Forms.Panel();
            this.panel_deletingLabels = new System.Windows.Forms.Panel();
            this.textBox_typeID = new System.Windows.Forms.TextBox();
            this.textBox_bookID = new System.Windows.Forms.TextBox();
            this.label_typeID = new System.Windows.Forms.Label();
            this.label_bookID = new System.Windows.Forms.Label();
            this.panel_deletingTip = new System.Windows.Forms.Panel();
            this.label_deletingTip = new System.Windows.Forms.Label();
            this.button_cancle = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.panel_mainbcg.SuspendLayout();
            this.panel_deletingLabels.SuspendLayout();
            this.panel_deletingTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_mainbcg
            // 
            this.panel_mainbcg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(126)))), ((int)(((byte)(116)))));
            this.panel_mainbcg.Controls.Add(this.panel_deletingLabels);
            this.panel_mainbcg.Controls.Add(this.panel_deletingTip);
            this.panel_mainbcg.Controls.Add(this.button_cancle);
            this.panel_mainbcg.Controls.Add(this.button_delete);
            this.panel_mainbcg.Location = new System.Drawing.Point(12, 12);
            this.panel_mainbcg.Name = "panel_mainbcg";
            this.panel_mainbcg.Size = new System.Drawing.Size(726, 493);
            this.panel_mainbcg.TabIndex = 1;
            // 
            // panel_deletingLabels
            // 
            this.panel_deletingLabels.Controls.Add(this.textBox_typeID);
            this.panel_deletingLabels.Controls.Add(this.textBox_bookID);
            this.panel_deletingLabels.Controls.Add(this.label_typeID);
            this.panel_deletingLabels.Controls.Add(this.label_bookID);
            this.panel_deletingLabels.Location = new System.Drawing.Point(4, 260);
            this.panel_deletingLabels.Name = "panel_deletingLabels";
            this.panel_deletingLabels.Size = new System.Drawing.Size(708, 150);
            this.panel_deletingLabels.TabIndex = 3;
            // 
            // textBox_typeID
            // 
            this.textBox_typeID.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_typeID.Location = new System.Drawing.Point(450, 51);
            this.textBox_typeID.Name = "textBox_typeID";
            this.textBox_typeID.Size = new System.Drawing.Size(255, 53);
            this.textBox_typeID.TabIndex = 3;
            this.textBox_typeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_bookID
            // 
            this.textBox_bookID.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_bookID.Location = new System.Drawing.Point(4, 51);
            this.textBox_bookID.Name = "textBox_bookID";
            this.textBox_bookID.Size = new System.Drawing.Size(255, 53);
            this.textBox_bookID.TabIndex = 2;
            this.textBox_bookID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_typeID
            // 
            this.label_typeID.AutoSize = true;
            this.label_typeID.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_typeID.Location = new System.Drawing.Point(465, 17);
            this.label_typeID.Name = "label_typeID";
            this.label_typeID.Size = new System.Drawing.Size(226, 31);
            this.label_typeID.TabIndex = 1;
            this.label_typeID.Text = "BOOK_TYPE_ID";
            // 
            // label_bookID
            // 
            this.label_bookID.AutoSize = true;
            this.label_bookID.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_bookID.Location = new System.Drawing.Point(61, 17);
            this.label_bookID.Name = "label_bookID";
            this.label_bookID.Size = new System.Drawing.Size(139, 31);
            this.label_bookID.TabIndex = 0;
            this.label_bookID.Text = "BOOK_ID";
            // 
            // panel_deletingTip
            // 
            this.panel_deletingTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.panel_deletingTip.Controls.Add(this.label_deletingTip);
            this.panel_deletingTip.Location = new System.Drawing.Point(3, 15);
            this.panel_deletingTip.Name = "panel_deletingTip";
            this.panel_deletingTip.Size = new System.Drawing.Size(709, 239);
            this.panel_deletingTip.TabIndex = 2;
            // 
            // label_deletingTip
            // 
            this.label_deletingTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(120)))), ((int)(((byte)(116)))));
            this.label_deletingTip.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_deletingTip.Location = new System.Drawing.Point(0, 0);
            this.label_deletingTip.Name = "label_deletingTip";
            this.label_deletingTip.Size = new System.Drawing.Size(706, 239);
            this.label_deletingTip.TabIndex = 0;
            this.label_deletingTip.Text = resources.GetString("label_deletingTip.Text");
            this.label_deletingTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_cancle
            // 
            this.button_cancle.AutoSize = true;
            this.button_cancle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_cancle.Location = new System.Drawing.Point(154, 426);
            this.button_cancle.Name = "button_cancle";
            this.button_cancle.Size = new System.Drawing.Size(155, 51);
            this.button_cancle.TabIndex = 1;
            this.button_cancle.Text = "Скасувати";
            this.button_cancle.UseVisualStyleBackColor = true;
            this.button_cancle.Click += new System.EventHandler(this.button_cancle_Click);
            // 
            // button_delete
            // 
            this.button_delete.AutoSize = true;
            this.button_delete.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_delete.Location = new System.Drawing.Point(386, 426);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(155, 51);
            this.button_delete.TabIndex = 0;
            this.button_delete.Text = "Змінити";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // ApplyBookChangesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(742, 517);
            this.Controls.Add(this.panel_mainbcg);
            this.Name = "ApplyBookChangesForm";
            this.Text = "ApplyBookChangesForm";
            this.Load += new System.EventHandler(this.ApplyBookChangesForm_Load);
            this.panel_mainbcg.ResumeLayout(false);
            this.panel_mainbcg.PerformLayout();
            this.panel_deletingLabels.ResumeLayout(false);
            this.panel_deletingLabels.PerformLayout();
            this.panel_deletingTip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_mainbcg;
        private System.Windows.Forms.Panel panel_deletingLabels;
        private System.Windows.Forms.TextBox textBox_typeID;
        private System.Windows.Forms.TextBox textBox_bookID;
        private System.Windows.Forms.Label label_typeID;
        private System.Windows.Forms.Label label_bookID;
        private System.Windows.Forms.Panel panel_deletingTip;
        private System.Windows.Forms.Label label_deletingTip;
        private System.Windows.Forms.Button button_cancle;
        private System.Windows.Forms.Button button_delete;
    }
}