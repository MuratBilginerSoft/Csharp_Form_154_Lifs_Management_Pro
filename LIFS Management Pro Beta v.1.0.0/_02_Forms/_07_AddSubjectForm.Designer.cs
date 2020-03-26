namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    partial class _07_AddSubjectForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextSubjectId = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.TextSubjectName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.DataGridSubject = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AddBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Subject ID";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Subject Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextSubjectId
            // 
            this.TextSubjectId.BorderColor = System.Drawing.Color.SeaGreen;
            this.TextSubjectId.Location = new System.Drawing.Point(2, 37);
            this.TextSubjectId.Name = "TextSubjectId";
            this.TextSubjectId.Size = new System.Drawing.Size(245, 21);
            this.TextSubjectId.TabIndex = 36;
            // 
            // TextSubjectName
            // 
            this.TextSubjectName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TextSubjectName.Location = new System.Drawing.Point(256, 38);
            this.TextSubjectName.Name = "TextSubjectName";
            this.TextSubjectName.Size = new System.Drawing.Size(245, 21);
            this.TextSubjectName.TabIndex = 37;
            // 
            // DataGridSubject
            // 
            this.DataGridSubject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.DataGridSubject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridSubject.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridSubject.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataGridSubject.Location = new System.Drawing.Point(2, 79);
            this.DataGridSubject.Name = "DataGridSubject";
            this.DataGridSubject.Size = new System.Drawing.Size(767, 320);
            this.DataGridSubject.TabIndex = 39;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.Image = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources.appbar_add;
            this.AddBtn.Location = new System.Drawing.Point(504, 31);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(30, 30);
            this.AddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddBtn.TabIndex = 38;
            this.AddBtn.TabStop = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            this.AddBtn.MouseLeave += new System.EventHandler(this.AddBtn_MouseLeave);
            this.AddBtn.MouseHover += new System.EventHandler(this.AddBtn_MouseHover);
            // 
            // _07_AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(769, 430);
            this.Controls.Add(this.DataGridSubject);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.TextSubjectName);
            this.Controls.Add(this.TextSubjectId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "_07_AddSubjectForm";
            this.Load += new System.EventHandler(this._07_AddSubjectForm_Load);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TextSubjectId, 0);
            this.Controls.SetChildIndex(this.TextSubjectName, 0);
            this.Controls.SetChildIndex(this.AddBtn, 0);
            this.Controls.SetChildIndex(this.DataGridSubject, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TextSubjectId;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TextSubjectName;
        private System.Windows.Forms.PictureBox AddBtn;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataGridSubject;
    }
}
