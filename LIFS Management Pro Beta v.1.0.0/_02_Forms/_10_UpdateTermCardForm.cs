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
    public partial class _10_UpdateTermCardForm : LIFS_Management_Pro_Beta_v._1._0._0._02_Forms._00_InheritForm
    {
        #region Definitions

        _01_Classes._02_BusinessLayer BL = new _01_Classes._02_BusinessLayer();
        _00_Databases._01_LIFSAcademyDataContext LIFS = new _00_Databases._01_LIFSAcademyDataContext();

        #endregion

        public _10_UpdateTermCardForm()
        {
            InitializeComponent();
        }

        private void DataGridContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ComboSubject.Text= DataGridContent.CurrentRow.Cells[0].Value.ToString();
            TextTitle.Text= DataGridContent.CurrentRow.Cells[1].Value.ToString();
            RichTextContent.Text= DataGridContent.CurrentRow.Cells[2].Value.ToString();
        }

        

        private void _10_UpdateTermCardForm_Load(object sender, EventArgs e)
        {
            _00_Databases._01_LIFSAcademyDataContext LFAD = new _00_Databases._01_LIFSAcademyDataContext();

            DataGridContent.DataSource = from x in LIFS.LIFSCONTENT
                             select x;

            var Subject = LFAD.LIFSSUBJECT.Select(s => s);

            foreach (var item in Subject)
            {
                ComboSubject.Items.Add(item.SUBJECTNAME);
            }
        }

        private void UpdateBtn_MouseHover(object sender, EventArgs e)
        {
            BL.HoverPicColor(UpdateBtn);
        }

        private void UpdateBtn_MouseLeave(object sender, EventArgs e)
        {
            BL.LeftPicColor(UpdateBtn);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var Content = LIFS.LIFSCONTENT.First(s => s.TITLE == DataGridContent.CurrentRow.Cells[1].Value.ToString());

                Content.TITLE = TextTitle.Text;
                Content.REV = Content.REV + 1;
                Content.REVDATE = DateTime.Now;
                Content.REVUSERID = Convert.ToInt32(_02_LoginForm.UserInfo[0]);

                LIFS.SubmitChanges();

                BL.LabelInfo(LblInfo, "Güncelleme Başarılı");
                BL.InfoColorSuccess(PanelColor);

                DataGridContent.DataSource = from x in LIFS.LIFSCONTENT
                                             select x;

            }
            catch (Exception)
            {
                BL.LabelInfo(LblInfo, "Güncelleme Gerçekleşmedi");
                BL.InfoColorError(PanelColor);
            }
        }
    }
}
