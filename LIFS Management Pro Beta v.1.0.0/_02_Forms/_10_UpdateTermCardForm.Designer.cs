namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    partial class _10_UpdateTermCardForm
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
            this.DataGridContent = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.RichTextContent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboSubject = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.TextTitle = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridContent)).BeginInit();
            this.PanelContent.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridContent
            // 
            this.DataGridContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridContent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.DataGridContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridContent.DefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridContent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataGridContent.Location = new System.Drawing.Point(0, 446);
            this.DataGridContent.Name = "DataGridContent";
            this.DataGridContent.Size = new System.Drawing.Size(1288, 377);
            this.DataGridContent.TabIndex = 42;
            this.DataGridContent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridContent_CellClick);
            // 
            // PanelContent
            // 
            this.PanelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelContent.Controls.Add(this.RichTextContent);
            this.PanelContent.Controls.Add(this.label3);
            this.PanelContent.Location = new System.Drawing.Point(0, 71);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1288, 369);
            this.PanelContent.TabIndex = 44;
            // 
            // RichTextContent
            // 
            this.RichTextContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.RichTextContent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RichTextContent.ForeColor = System.Drawing.Color.White;
            this.RichTextContent.Location = new System.Drawing.Point(5, 43);
            this.RichTextContent.Name = "RichTextContent";
            this.RichTextContent.Size = new System.Drawing.Size(1278, 320);
            this.RichTextContent.TabIndex = 39;
            this.RichTextContent.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Content";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelHeader.Controls.Add(this.UpdateBtn);
            this.PanelHeader.Controls.Add(this.tableLayoutPanel1);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1288, 69);
            this.PanelHeader.TabIndex = 43;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.90619F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.09381F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ComboSubject, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextTitle, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.02439F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.97561F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 61);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Subject";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComboSubject
            // 
            this.ComboSubject.DisplayMember = "Text";
            this.ComboSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboSubject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboSubject.FormattingEnabled = true;
            this.ComboSubject.ItemHeight = 14;
            this.ComboSubject.Location = new System.Drawing.Point(3, 26);
            this.ComboSubject.Name = "ComboSubject";
            this.ComboSubject.Size = new System.Drawing.Size(286, 20);
            this.ComboSubject.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ComboSubject.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextTitle
            // 
            this.TextTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextTitle.Location = new System.Drawing.Point(295, 26);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(326, 22);
            this.TextTitle.TabIndex = 35;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.Image = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources.edit;
            this.UpdateBtn.Location = new System.Drawing.Point(632, 23);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(30, 30);
            this.UpdateBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpdateBtn.TabIndex = 39;
            this.UpdateBtn.TabStop = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            this.UpdateBtn.MouseLeave += new System.EventHandler(this.UpdateBtn_MouseLeave);
            this.UpdateBtn.MouseHover += new System.EventHandler(this.UpdateBtn_MouseHover);
            // 
            // _10_UpdateTermCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1288, 858);
            this.Controls.Add(this.DataGridContent);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelHeader);
            this.Name = "_10_UpdateTermCardForm";
            this.Load += new System.EventHandler(this._10_UpdateTermCardForm_Load);
            this.Controls.SetChildIndex(this.PanelHeader, 0);
            this.Controls.SetChildIndex(this.PanelContent, 0);
            this.Controls.SetChildIndex(this.DataGridContent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridContent)).EndInit();
            this.PanelContent.ResumeLayout(false);
            this.PanelContent.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX DataGridContent;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.RichTextBox RichTextContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.PictureBox UpdateBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextTitle;
    }
}
