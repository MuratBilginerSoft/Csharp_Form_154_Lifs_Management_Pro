namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    partial class PanelMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelForm = new System.Windows.Forms.Panel();
            this.PanelLine = new System.Windows.Forms.Panel();
            this.PanelSideBar = new System.Windows.Forms.Panel();
            this.DeleteInfoCardBtn = new ns1.BunifuFlatButton();
            this.DeleteSubjectBtn = new ns1.BunifuFlatButton();
            this.bunifuSeparator3 = new ns1.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateCardBtn = new ns1.BunifuFlatButton();
            this.UpdateSubBtn = new ns1.BunifuFlatButton();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddICBtn = new ns1.BunifuFlatButton();
            this.AddSubjectBtn = new ns1.BunifuFlatButton();
            this.PanelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblInfo
            // 
            this.LblInfo.Location = new System.Drawing.Point(28, 5);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "ADD CONTENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelHeader.Controls.Add(this.label1);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(1288, 42);
            this.PanelHeader.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PanelForm);
            this.panel1.Controls.Add(this.PanelLine);
            this.panel1.Controls.Add(this.PanelSideBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 787);
            this.panel1.TabIndex = 30;
            // 
            // PanelForm
            // 
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(227, 0);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.Size = new System.Drawing.Size(1061, 787);
            this.PanelForm.TabIndex = 35;
            // 
            // PanelLine
            // 
            this.PanelLine.BackColor = System.Drawing.Color.LawnGreen;
            this.PanelLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLine.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLine.Location = new System.Drawing.Point(224, 0);
            this.PanelLine.Name = "PanelLine";
            this.PanelLine.Size = new System.Drawing.Size(3, 787);
            this.PanelLine.TabIndex = 29;
            // 
            // PanelSideBar
            // 
            this.PanelSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.PanelSideBar.Controls.Add(this.DeleteInfoCardBtn);
            this.PanelSideBar.Controls.Add(this.DeleteSubjectBtn);
            this.PanelSideBar.Controls.Add(this.bunifuSeparator3);
            this.PanelSideBar.Controls.Add(this.label4);
            this.PanelSideBar.Controls.Add(this.UpdateCardBtn);
            this.PanelSideBar.Controls.Add(this.UpdateSubBtn);
            this.PanelSideBar.Controls.Add(this.bunifuSeparator2);
            this.PanelSideBar.Controls.Add(this.bunifuSeparator1);
            this.PanelSideBar.Controls.Add(this.label3);
            this.PanelSideBar.Controls.Add(this.label2);
            this.PanelSideBar.Controls.Add(this.AddICBtn);
            this.PanelSideBar.Controls.Add(this.AddSubjectBtn);
            this.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSideBar.Location = new System.Drawing.Point(0, 0);
            this.PanelSideBar.Name = "PanelSideBar";
            this.PanelSideBar.Size = new System.Drawing.Size(224, 787);
            this.PanelSideBar.TabIndex = 31;
            // 
            // DeleteInfoCardBtn
            // 
            this.DeleteInfoCardBtn.Activecolor = System.Drawing.Color.Purple;
            this.DeleteInfoCardBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteInfoCardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteInfoCardBtn.BorderRadius = 0;
            this.DeleteInfoCardBtn.ButtonText = "Delete Information Card";
            this.DeleteInfoCardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteInfoCardBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DeleteInfoCardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DeleteInfoCardBtn.Iconimage = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources.appbar_add;
            this.DeleteInfoCardBtn.Iconimage_right = null;
            this.DeleteInfoCardBtn.Iconimage_right_Selected = null;
            this.DeleteInfoCardBtn.Iconimage_Selected = null;
            this.DeleteInfoCardBtn.IconMarginLeft = 0;
            this.DeleteInfoCardBtn.IconMarginRight = 0;
            this.DeleteInfoCardBtn.IconRightVisible = true;
            this.DeleteInfoCardBtn.IconRightZoom = 0D;
            this.DeleteInfoCardBtn.IconVisible = true;
            this.DeleteInfoCardBtn.IconZoom = 50D;
            this.DeleteInfoCardBtn.IsTab = false;
            this.DeleteInfoCardBtn.Location = new System.Drawing.Point(3, 457);
            this.DeleteInfoCardBtn.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.DeleteInfoCardBtn.Name = "DeleteInfoCardBtn";
            this.DeleteInfoCardBtn.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteInfoCardBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.DeleteInfoCardBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DeleteInfoCardBtn.selected = false;
            this.DeleteInfoCardBtn.Size = new System.Drawing.Size(220, 34);
            this.DeleteInfoCardBtn.TabIndex = 9;
            this.DeleteInfoCardBtn.Text = "Delete Information Card";
            this.DeleteInfoCardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteInfoCardBtn.Textcolor = System.Drawing.Color.White;
            this.DeleteInfoCardBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteInfoCardBtn.Click += new System.EventHandler(this.DeleteInfoCardBtn_Click);
            // 
            // DeleteSubjectBtn
            // 
            this.DeleteSubjectBtn.Activecolor = System.Drawing.Color.Purple;
            this.DeleteSubjectBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteSubjectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteSubjectBtn.BorderRadius = 0;
            this.DeleteSubjectBtn.ButtonText = "Delete Subject";
            this.DeleteSubjectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteSubjectBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DeleteSubjectBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DeleteSubjectBtn.Iconimage = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources.appbar_add;
            this.DeleteSubjectBtn.Iconimage_right = null;
            this.DeleteSubjectBtn.Iconimage_right_Selected = null;
            this.DeleteSubjectBtn.Iconimage_Selected = null;
            this.DeleteSubjectBtn.IconMarginLeft = 0;
            this.DeleteSubjectBtn.IconMarginRight = 0;
            this.DeleteSubjectBtn.IconRightVisible = true;
            this.DeleteSubjectBtn.IconRightZoom = 0D;
            this.DeleteSubjectBtn.IconVisible = true;
            this.DeleteSubjectBtn.IconZoom = 50D;
            this.DeleteSubjectBtn.IsTab = false;
            this.DeleteSubjectBtn.Location = new System.Drawing.Point(3, 411);
            this.DeleteSubjectBtn.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this.DeleteSubjectBtn.Name = "DeleteSubjectBtn";
            this.DeleteSubjectBtn.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.DeleteSubjectBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.DeleteSubjectBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DeleteSubjectBtn.selected = false;
            this.DeleteSubjectBtn.Size = new System.Drawing.Size(220, 34);
            this.DeleteSubjectBtn.TabIndex = 8;
            this.DeleteSubjectBtn.Text = "Delete Subject";
            this.DeleteSubjectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteSubjectBtn.Textcolor = System.Drawing.Color.White;
            this.DeleteSubjectBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSubjectBtn.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(6, 386);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(216, 16);
            this.bunifuSeparator3.TabIndex = 7;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Delete";
            // 
            // UpdateCardBtn
            // 
            this.UpdateCardBtn.Activecolor = System.Drawing.Color.Purple;
            this.UpdateCardBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateCardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateCardBtn.BorderRadius = 0;
            this.UpdateCardBtn.ButtonText = "Update Information Card";
            this.UpdateCardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateCardBtn.DisabledColor = System.Drawing.Color.Gray;
            this.UpdateCardBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.UpdateCardBtn.Iconimage = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources.appbar_add;
            this.UpdateCardBtn.Iconimage_right = null;
            this.UpdateCardBtn.Iconimage_right_Selected = null;
            this.UpdateCardBtn.Iconimage_Selected = null;
            this.UpdateCardBtn.IconMarginLeft = 0;
            this.UpdateCardBtn.IconMarginRight = 0;
            this.UpdateCardBtn.IconRightVisible = true;
            this.UpdateCardBtn.IconRightZoom = 0D;
            this.UpdateCardBtn.IconVisible = true;
            this.UpdateCardBtn.IconZoom = 50D;
            this.UpdateCardBtn.IsTab = false;
            this.UpdateCardBtn.Location = new System.Drawing.Point(3, 284);
            this.UpdateCardBtn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.UpdateCardBtn.Name = "UpdateCardBtn";
            this.UpdateCardBtn.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateCardBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.UpdateCardBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.UpdateCardBtn.selected = false;
            this.UpdateCardBtn.Size = new System.Drawing.Size(220, 34);
            this.UpdateCardBtn.TabIndex = 5;
            this.UpdateCardBtn.Text = "Update Information Card";
            this.UpdateCardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateCardBtn.Textcolor = System.Drawing.Color.White;
            this.UpdateCardBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCardBtn.Click += new System.EventHandler(this.UpdateCardBtn_Click);
            // 
            // UpdateSubBtn
            // 
            this.UpdateSubBtn.Activecolor = System.Drawing.Color.Purple;
            this.UpdateSubBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateSubBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpdateSubBtn.BorderRadius = 0;
            this.UpdateSubBtn.ButtonText = "Update Subject";
            this.UpdateSubBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateSubBtn.DisabledColor = System.Drawing.Color.Gray;
            this.UpdateSubBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.UpdateSubBtn.Iconimage = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources.appbar_add;
            this.UpdateSubBtn.Iconimage_right = null;
            this.UpdateSubBtn.Iconimage_right_Selected = null;
            this.UpdateSubBtn.Iconimage_Selected = null;
            this.UpdateSubBtn.IconMarginLeft = 0;
            this.UpdateSubBtn.IconMarginRight = 0;
            this.UpdateSubBtn.IconRightVisible = true;
            this.UpdateSubBtn.IconRightZoom = 0D;
            this.UpdateSubBtn.IconVisible = true;
            this.UpdateSubBtn.IconZoom = 50D;
            this.UpdateSubBtn.IsTab = false;
            this.UpdateSubBtn.Location = new System.Drawing.Point(3, 237);
            this.UpdateSubBtn.Margin = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.UpdateSubBtn.Name = "UpdateSubBtn";
            this.UpdateSubBtn.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.UpdateSubBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.UpdateSubBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.UpdateSubBtn.selected = false;
            this.UpdateSubBtn.Size = new System.Drawing.Size(220, 34);
            this.UpdateSubBtn.TabIndex = 4;
            this.UpdateSubBtn.Text = "Update Subject";
            this.UpdateSubBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateSubBtn.Textcolor = System.Drawing.Color.White;
            this.UpdateSubBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSubBtn.Click += new System.EventHandler(this.UpdateSubBtn_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(5, 217);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(216, 16);
            this.bunifuSeparator2.TabIndex = 3;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(5, 53);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(213, 13);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add";
            // 
            // AddICBtn
            // 
            this.AddICBtn.Activecolor = System.Drawing.Color.Purple;
            this.AddICBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddICBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddICBtn.BorderRadius = 0;
            this.AddICBtn.ButtonText = "Add Information Card";
            this.AddICBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddICBtn.DisabledColor = System.Drawing.Color.Gray;
            this.AddICBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.AddICBtn.Iconimage = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources.appbar_add;
            this.AddICBtn.Iconimage_right = null;
            this.AddICBtn.Iconimage_right_Selected = null;
            this.AddICBtn.Iconimage_Selected = null;
            this.AddICBtn.IconMarginLeft = 0;
            this.AddICBtn.IconMarginRight = 0;
            this.AddICBtn.IconRightVisible = true;
            this.AddICBtn.IconRightZoom = 0D;
            this.AddICBtn.IconVisible = true;
            this.AddICBtn.IconZoom = 50D;
            this.AddICBtn.IsTab = false;
            this.AddICBtn.Location = new System.Drawing.Point(4, 115);
            this.AddICBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.AddICBtn.Name = "AddICBtn";
            this.AddICBtn.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.AddICBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.AddICBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.AddICBtn.selected = false;
            this.AddICBtn.Size = new System.Drawing.Size(220, 34);
            this.AddICBtn.TabIndex = 0;
            this.AddICBtn.Text = "Add Information Card";
            this.AddICBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddICBtn.Textcolor = System.Drawing.Color.White;
            this.AddICBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddICBtn.Click += new System.EventHandler(this.AddICBtn_Click);
            // 
            // AddSubjectBtn
            // 
            this.AddSubjectBtn.Activecolor = System.Drawing.Color.Purple;
            this.AddSubjectBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.AddSubjectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddSubjectBtn.BorderRadius = 0;
            this.AddSubjectBtn.ButtonText = "Add Subject";
            this.AddSubjectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSubjectBtn.DisabledColor = System.Drawing.Color.Gray;
            this.AddSubjectBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.AddSubjectBtn.Iconimage = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources.appbar_add;
            this.AddSubjectBtn.Iconimage_right = null;
            this.AddSubjectBtn.Iconimage_right_Selected = null;
            this.AddSubjectBtn.Iconimage_Selected = null;
            this.AddSubjectBtn.IconMarginLeft = 0;
            this.AddSubjectBtn.IconMarginRight = 0;
            this.AddSubjectBtn.IconRightVisible = true;
            this.AddSubjectBtn.IconRightZoom = 0D;
            this.AddSubjectBtn.IconVisible = true;
            this.AddSubjectBtn.IconZoom = 50D;
            this.AddSubjectBtn.IsTab = false;
            this.AddSubjectBtn.Location = new System.Drawing.Point(4, 70);
            this.AddSubjectBtn.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.AddSubjectBtn.Name = "AddSubjectBtn";
            this.AddSubjectBtn.Normalcolor = System.Drawing.Color.DeepSkyBlue;
            this.AddSubjectBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.AddSubjectBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.AddSubjectBtn.selected = false;
            this.AddSubjectBtn.Size = new System.Drawing.Size(220, 34);
            this.AddSubjectBtn.TabIndex = 1;
            this.AddSubjectBtn.Text = "Add Subject";
            this.AddSubjectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddSubjectBtn.Textcolor = System.Drawing.Color.White;
            this.AddSubjectBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubjectBtn.Click += new System.EventHandler(this.AddSubjectBtn_Click);
            // 
            // PanelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(1288, 858);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelHeader);
            this.Name = "PanelMain";
            this.Controls.SetChildIndex(this.PanelHeader, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.PanelSideBar.ResumeLayout(false);
            this.PanelSideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelForm;
        private System.Windows.Forms.Panel PanelLine;
        private System.Windows.Forms.Panel PanelSideBar;
        private ns1.BunifuFlatButton AddICBtn;
        private ns1.BunifuFlatButton AddSubjectBtn;
        private ns1.BunifuFlatButton DeleteInfoCardBtn;
        private ns1.BunifuFlatButton DeleteSubjectBtn;
        private ns1.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuFlatButton UpdateCardBtn;
        private ns1.BunifuFlatButton UpdateSubBtn;
        private ns1.BunifuSeparator bunifuSeparator2;
        private ns1.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
