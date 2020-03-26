using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    public partial class _09_UpdateSubjectForm : LIFS_Management_Pro_Beta_v._1._0._0._02_Forms._00_InheritForm
    {
        #region Definitions

        _01_Classes._02_BusinessLayer BL = new _01_Classes._02_BusinessLayer();
        _00_Databases._01_LIFSAcademyDataContext LIFS = new _00_Databases._01_LIFSAcademyDataContext();

        #endregion

        public _09_UpdateSubjectForm()
        {
            InitializeComponent();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var Subject = LIFS.LIFSSUBJECT.First(s => s.SUBJECTID == Convert.ToInt32(DataGridSubject.CurrentRow.Cells[0].Value.ToString()));

                Subject.SUBJECTNAME = TextSubjectName.Text;
                Subject.REVISION = Subject.REVISION + 1;
                Subject.REVDATE = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                Subject.REVUSERID = Convert.ToInt32(_02_LoginForm.UserInfo[0]);

                LIFS.SubmitChanges();

               
                BL.LabelInfo(LblInfo, "Güncelleme Başarılı");
                BL.InfoColorSuccess(PanelColor);

                DataGridSubject.DataSource = from x in LIFS.LIFSSUBJECT
                                 select x;
               
            }
            catch (Exception)
            {
                BL.LabelInfo(LblInfo, "Güncelleme Gerçekleşmedi");
                BL.InfoColorError(PanelColor);
            }

        }

        private void _09_UpdateSubjectForm_Load(object sender, EventArgs e)
        {
            DataGridSubject.DataSource = from x in LIFS.LIFSSUBJECT
                                         select x;
        }

        private void DataGridSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextSubjectName.Text = DataGridSubject.CurrentRow.Cells[1].Value.ToString();
        }

        private void UpdateBtn_MouseHover(object sender, EventArgs e)
        {
            BL.HoverPicColor(UpdateBtn);
        }

        private void UpdateBtn_MouseLeave(object sender, EventArgs e)
        {
            BL.LeftPicColor(UpdateBtn);
        }

        private void TextSubjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
