namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    partial class _09_UpdateSubjectForm
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
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.TextSubjectName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridSubject = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.UpdateBtn = new System.Windows.Forms.PictureBox();
            this.PanelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHeader
            // 
            this.PanelHeader.Controls.Add(this.UpdateBtn);
            this.PanelHeader.Controls.Add(this.TextSubjectName);
            this.PanelHeader.Controls.Add(this.label1);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(796, 63);
            this.PanelHeader.TabIndex = 6;
            // 
            // TextSubjectName
            // 
            this.TextSubjectName.BorderColor = System.Drawing.Color.SeaGreen;
            this.TextSubjectName.Location = new System.Drawing.Point(7, 33);
            this.TextSubjectName.Name = "TextSubjectName";
            this.TextSubjectName.Size = new System.Drawing.Size(245, 21);
            this.TextSubjectName.TabIndex = 40;
            this.TextSubjectName.TextChanged += new System.EventHandler(this.TextSubjectName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Subject Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DataGridSubject
            // 
            this.DataGridSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.DataGridSubject.Location = new System.Drawing.Point(0, 69);
            this.DataGridSubject.Name = "DataGridSubject";
            this.DataGridSubject.Size = new System.Drawing.Size(796, 320);
            this.DataGridSubject.TabIndex = 7;
            this.DataGridSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSubject_CellClick);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.Image = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources.edit;
            this.UpdateBtn.Location = new System.Drawing.Point(255, 26);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(30, 30);
            this.UpdateBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpdateBtn.TabIndex = 41;
            this.UpdateBtn.TabStop = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            this.UpdateBtn.MouseLeave += new System.EventHandler(this.UpdateBtn_MouseLeave);
            this.UpdateBtn.MouseHover += new System.EventHandler(this.UpdateBtn_MouseHover);
            // 
            // _09_UpdateSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(796, 420);
            this.Controls.Add(this.DataGridSubject);
            this.Controls.Add(this.PanelHeader);
            this.Name = "_09_UpdateSubjectForm";
            this.Load += new System.EventHandler(this._09_UpdateSubjectForm_Load);
            this.Controls.SetChildIndex(this.PanelHeader, 0);
            this.Controls.SetChildIndex(this.DataGridSubject, 0);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHeader;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataGridSubject;
        private System.Windows.Forms.PictureBox UpdateBtn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox TextSubjectName;
        private System.Windows.Forms.Label label1;
    }
}
