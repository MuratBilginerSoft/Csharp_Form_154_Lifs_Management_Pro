namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    partial class _00_InheritForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00_InheritForm));
            this.PanelInfo = new System.Windows.Forms.Panel();
            this.PanelColor = new System.Windows.Forms.Panel();
            this.LblInfo = new System.Windows.Forms.Label();
            this.PanelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelInfo
            // 
            this.PanelInfo.BackColor = System.Drawing.Color.Purple;
            this.PanelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelInfo.Controls.Add(this.PanelColor);
            this.PanelInfo.Controls.Add(this.LblInfo);
            this.PanelInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelInfo.Location = new System.Drawing.Point(0, 829);
            this.PanelInfo.Name = "PanelInfo";
            this.PanelInfo.Size = new System.Drawing.Size(1288, 29);
            this.PanelInfo.TabIndex = 5;
            // 
            // PanelColor
            // 
            this.PanelColor.BackColor = System.Drawing.Color.Transparent;
            this.PanelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelColor.Location = new System.Drawing.Point(4, 3);
            this.PanelColor.Name = "PanelColor";
            this.PanelColor.Size = new System.Drawing.Size(20, 20);
            this.PanelColor.TabIndex = 0;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblInfo.ForeColor = System.Drawing.Color.White;
            this.LblInfo.Location = new System.Drawing.Point(29, 5);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(39, 17);
            this.LblInfo.TabIndex = 6;
            this.LblInfo.Text = "Hazır";
            // 
            // _00_InheritForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1288, 858);
            this.Controls.Add(this.PanelInfo);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "_00_InheritForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_00_InheritForm";
            this.Load += new System.EventHandler(this._00_InheritForm_Load);
            this.PanelInfo.ResumeLayout(false);
            this.PanelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelInfo;
        public System.Windows.Forms.Panel PanelColor;
        public System.Windows.Forms.Label LblInfo;
    }
}