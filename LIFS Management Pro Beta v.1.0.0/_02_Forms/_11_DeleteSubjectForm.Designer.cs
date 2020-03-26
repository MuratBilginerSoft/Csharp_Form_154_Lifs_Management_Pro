namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    partial class _11_DeleteSubjectForm
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
            this.DataGridSubject = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.TextSubjectName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSubject)).BeginInit();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridSubject
            // 
            this.DataGridSubject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
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
            this.DataGridSubject.Location = new System.Drawing.Point(0, 74);
            this.DataGridSubject.Name = "DataGridSubject";
            this.DataGridSubject.Size = new System.Drawing.Size(695, 318);
            this.DataGridSubject.TabIndex = 6;
            this.DataGridSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSubject_CellClick);
            // 
            // TextSubjectName
            // 
            this.TextSubjectName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TextSubjectName.Location = new System.Drawing.Point(8, 38);
            this.TextSubjectName.Name = "TextSubjectName";
            this.TextSubjectName.Size = new System.Drawing.Size(245, 21);
            this.TextSubjectName.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Subject Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.TextSubjectName);
            this.PanelHeader.Controls.Add(this.DeleteBtn);
            this.PanelHeader.Controls.Add(this.label1);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(695, 68);
            this.PanelHeader.TabIndex = 45;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.Image = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources.delete;
            this.DeleteBtn.Location = new System.Drawing.Point(257, 31);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(30, 30);
            this.DeleteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeleteBtn.TabIndex = 44;
            this.DeleteBtn.TabStop = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            this.DeleteBtn.MouseLeave += new System.EventHandler(this.DeleteBtn_MouseLeave);
            this.DeleteBtn.MouseHover += new System.EventHandler(this.DeleteBtn_MouseHover);
            // 
            // _11_DeleteSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(695, 425);
            this.Controls.Add(this.PanelHeader);
            this.Controls.Add(this.DataGridSubject);
            this.Name = "_11_DeleteSubjectForm";
            this.Load += new System.EventHandler(this._11_DeleteSubjectForm_Load);
            this.Controls.SetChildIndex(this.DataGridSubject, 0);
            this.Controls.SetChildIndex(this.PanelHeader, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSubject)).EndInit();
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DataGridSubject;
        private System.Windows.Forms.PictureBox DeleteBtn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TextSubjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelHeader;
    }
}
