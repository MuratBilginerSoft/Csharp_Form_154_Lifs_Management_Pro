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
    public partial class _12_DeleteTermCardForm : LIFS_Management_Pro_Beta_v._1._0._0._02_Forms._00_InheritForm
    {

        #region Definitions

        _01_Classes._02_BusinessLayer BL = new _01_Classes._02_BusinessLayer();
        _00_Databases._01_LIFSAcademyDataContext LIFS = new _00_Databases._01_LIFSAcademyDataContext();

        #endregion

        public _12_DeleteTermCardForm()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var Content = LIFS.LIFSCONTENT.First(s => s.TITLE == DataGridContent.CurrentRow.Cells[1].Value.ToString());

                Content.TITLE = TextTitle.Text;
                Content.REV = Content.REV + 1;
                Content.REVDATE = DateTime.Now;
                Content.REVUSERID = Convert.ToInt32(_02_LoginForm.UserInfo[0]);

                LIFS.LIFSCONTENT.DeleteOnSubmit(Content);

                LIFS.SubmitChanges();

                BL.LabelInfo(LblInfo, "Silme İşlemi Başarılı");
                BL.InfoColorSuccess(PanelColor);

                DataGridContent.DataSource = from x in LIFS.LIFSCONTENT
                                             select x;

                ComboSubject.Text = "";
                TextTitle.Text = "";
                RichTextContent.Text = "";

            }
            catch (Exception)
            {
                BL.LabelInfo(LblInfo, "Silme İşlemi Gerçekleşmedi");
                BL.InfoColorError(PanelColor);
            }
        }

        private void DataGridContent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ComboSubject.Text = DataGridContent.CurrentRow.Cells[0].Value.ToString();
            TextTitle.Text = DataGridContent.CurrentRow.Cells[1].Value.ToString();
            RichTextContent.Text = DataGridContent.CurrentRow.Cells[2].Value.ToString();
        }

        private void _12_DeleteTermCardForm_Load(object sender, EventArgs e)
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

        private void DeleteBtn_MouseHover(object sender, EventArgs e)
        {
            BL.HoverPicColor(DeleteBtn);
        }

        private void DeleteBtn_MouseLeave(object sender, EventArgs e)
        {
            BL.LeftPicColor(DeleteBtn);
        }
    }
}
