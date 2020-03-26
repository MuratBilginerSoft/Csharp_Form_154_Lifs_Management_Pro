namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    partial class _08_AddTermCardForm
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
            this.ComboSubject = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextTitle = new System.Windows.Forms.TextBox();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.RichTextContent = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridContent = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AddBtn = new System.Windows.Forms.PictureBox();
            this.PanelHeader.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PanelContent.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).BeginInit();
            this.SuspendLayout();
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
            this.PanelHeader.Controls.Add(this.AddBtn);
            this.PanelHeader.Controls.Add(this.tableLayoutPanel1);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1288, 69);
            this.PanelHeader.TabIndex = 40;
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
            // TextTitle
            // 
            this.TextTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextTitle.Location = new System.Drawing.Point(295, 26);
            this.TextTitle.Name = "TextTitle";
            this.TextTitle.Size = new System.Drawing.Size(326, 22);
            this.TextTitle.TabIndex = 35;
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
            this.PanelContent.TabIndex = 41;
            // 
            // RichTextContent
            // 
            this.RichTextContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextContent.Location = new System.Drawing.Point(5, 43);
            this.RichTextContent.Name = "RichTextContent";
            this.RichTextContent.Size = new System.Drawing.Size(1278, 320);
            this.RichTextContent.TabIndex = 39;
            this.RichTextContent.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.DataGridContent);
            this.panel1.Location = new System.Drawing.Point(0, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 381);
            this.panel1.TabIndex = 42;
            // 
            // DataGridContent
            // 
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
            this.DataGridContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridContent.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.DataGridContent.Location = new System.Drawing.Point(0, 0);
            this.DataGridContent.Name = "DataGridContent";
            this.DataGridContent.Size = new System.Drawing.Size(1288, 381);
            this.DataGridContent.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.Image = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources.appbar_add;
            this.AddBtn.Location = new System.Drawing.Point(632, 23);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(30, 30);
            this.AddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddBtn.TabIndex = 39;
            this.AddBtn.TabStop = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            this.AddBtn.MouseLeave += new System.EventHandler(this.AddBtn_MouseLeave);
            this.AddBtn.MouseHover += new System.EventHandler(this.AddBtn_MouseHover);
            // 
            // _08_AddTermCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1288, 858);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelHeader);
            this.Name = "_08_AddTermCardForm";
            this.Load += new System.EventHandler(this._08_AddTermCardForm_Load);
            this.Controls.SetChildIndex(this.PanelHeader, 0);
            this.Controls.SetChildIndex(this.PanelContent, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.PanelHeader.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.PanelContent.ResumeLayout(false);
            this.PanelContent.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx ComboSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.PictureBox AddBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel PanelContent;
        private System.Windows.Forms.RichTextBox RichTextContent;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX DataGridContent;
        private System.Windows.Forms.TextBox TextTitle;
    }
}
