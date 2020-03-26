namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    partial class _02_LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_02_LoginForm));
            this.TextUserName = new ns1.BunifuTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.PicMinus = new System.Windows.Forms.PictureBox();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.TextPassword = new ns1.BunifuTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.SignInBtn = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.PicMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.SuspendLayout();
            // 
            // TextUserName
            // 
            this.TextUserName.BackColor = System.Drawing.Color.White;
            this.TextUserName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextUserName.BackgroundImage")));
            this.TextUserName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TextUserName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TextUserName.Icon = ((System.Drawing.Image)(resources.GetObject("TextUserName.Icon")));
            this.TextUserName.Location = new System.Drawing.Point(21, 161);
            this.TextUserName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Size = new System.Drawing.Size(288, 47);
            this.TextUserName.TabIndex = 10;
            this.TextUserName.text = "mbilginer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "USERNAME";
            // 
            // PicMinus
            // 
            this.PicMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicMinus.BackColor = System.Drawing.Color.Transparent;
            this.PicMinus.Image = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources._04_LIFS_Minus;
            this.PicMinus.Location = new System.Drawing.Point(259, 7);
            this.PicMinus.Name = "PicMinus";
            this.PicMinus.Size = new System.Drawing.Size(25, 25);
            this.PicMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicMinus.TabIndex = 2;
            this.PicMinus.TabStop = false;
            this.PicMinus.Click += new System.EventHandler(this.PicMinus_Click);
            this.PicMinus.MouseLeave += new System.EventHandler(this.PicMinus_MouseLeave);
            this.PicMinus.MouseHover += new System.EventHandler(this.PicMinus_MouseHover);
            // 
            // PicClose
            // 
            this.PicClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PicClose.BackColor = System.Drawing.Color.Transparent;
            this.PicClose.Image = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources._03_LIFS_Close;
            this.PicClose.Location = new System.Drawing.Point(289, 7);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(25, 25);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicClose.TabIndex = 1;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.PicClose_Click);
            this.PicClose.MouseLeave += new System.EventHandler(this.PicMinus_MouseLeave);
            this.PicClose.MouseHover += new System.EventHandler(this.PicMinus_MouseHover);
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackgroundImage = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources._06_LIFS_Key;
            this.ovalShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ovalShape1.BorderColor = System.Drawing.Color.Transparent;
            this.ovalShape1.Location = new System.Drawing.Point(117, 33);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.Size = new System.Drawing.Size(90, 90);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(325, 440);
            this.shapeContainer1.TabIndex = 9;
            this.shapeContainer1.TabStop = false;
            // 
            // TextPassword
            // 
            this.TextPassword.BackColor = System.Drawing.Color.White;
            this.TextPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextPassword.BackgroundImage")));
            this.TextPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TextPassword.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TextPassword.Icon = ((System.Drawing.Image)(resources.GetObject("TextPassword.Icon")));
            this.TextPassword.Location = new System.Drawing.Point(17, 256);
            this.TextPassword.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(292, 47);
            this.TextPassword.TabIndex = 13;
            this.TextPassword.text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "PASSWORD";
            // 
            // SignInBtn
            // 
            this.SignInBtn.ActiveBorderThickness = 1;
            this.SignInBtn.ActiveCornerRadius = 20;
            this.SignInBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.SignInBtn.ActiveForecolor = System.Drawing.Color.White;
            this.SignInBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SignInBtn.BackColor = System.Drawing.Color.Fuchsia;
            this.SignInBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignInBtn.BackgroundImage")));
            this.SignInBtn.ButtonText = "SIGN IN";
            this.SignInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.ForeColor = System.Drawing.Color.Black;
            this.SignInBtn.IdleBorderThickness = 1;
            this.SignInBtn.IdleCornerRadius = 20;
            this.SignInBtn.IdleFillColor = System.Drawing.Color.White;
            this.SignInBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SignInBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SignInBtn.Location = new System.Drawing.Point(15, 328);
            this.SignInBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(292, 59);
            this.SignInBtn.TabIndex = 14;
            this.SignInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click_1);
            // 
            // _02_LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = global::LIFS_Management_Pro_Beta_v._1._0._0.Properties.Resources._10_Menüler_Pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(325, 440);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.TextPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextUserName);
            this.Controls.Add(this.PicMinus);
            this.Controls.Add(this.PicClose);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "_02_LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_02_LoginForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this._02_LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private System.Windows.Forms.PictureBox PicClose;
        private System.Windows.Forms.PictureBox PicMinus;
        private ns1.BunifuTextbox TextUserName;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private ns1.BunifuTextbox TextPassword;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuThinButton2 SignInBtn;
    }
}