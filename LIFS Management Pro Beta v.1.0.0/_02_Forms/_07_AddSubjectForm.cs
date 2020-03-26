using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    public partial class _07_AddSubjectForm : LIFS_Management_Pro_Beta_v._1._0._0._02_Forms._00_InheritForm
    {
        #region Definitions

        _01_Classes._02_BusinessLayer BL = new _01_Classes._02_BusinessLayer();
        _02_Forms._03_MainForm MF = new _03_MainForm();
        

        #endregion

        public _07_AddSubjectForm()
        {
            InitializeComponent();
        }

        private void _07_AddSubjectForm_Load(object sender, EventArgs e)
        {
            BL.DataSubjectSelect(DataGridSubject);
        }

        public void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                BL.DataSubjectInsert(DataGridSubject, Convert.ToInt32(TextSubjectId.Text), TextSubjectName.Text, 101, DateTime.Now, 0);

                BL.DataLogInsert(Convert.ToInt32(_02_Forms._02_LoginForm.UserInfo[0]), TextSubjectName.Text+" İsimli Yeni Konu Kaydı Yapıldı",DateTime.Now, _02_Forms._02_LoginForm.UserInfo[8]);

                BL.LabelInfo(LblInfo, "Kayıt Başarılı");
                BL.InfoColorSuccess(PanelColor);
                BL.DataSubjectSelect(DataGridSubject);
            }
            catch (Exception)
            {
                BL.LabelInfo(LblInfo, "Kayıt Gerçekleşmedi");
                BL.InfoColorError(PanelColor);
            }
           
        }

        private void AddBtn_MouseHover(object sender, EventArgs e)
        {
            BL.HoverPicColor(AddBtn);
        }

        private void AddBtn_MouseLeave(object sender, EventArgs e)
        {
            BL.LeftPicColor(AddBtn);
        }
    }
}
