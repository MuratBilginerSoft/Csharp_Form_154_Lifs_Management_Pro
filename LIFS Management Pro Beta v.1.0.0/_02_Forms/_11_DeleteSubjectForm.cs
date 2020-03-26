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
    public partial class _11_DeleteSubjectForm : LIFS_Management_Pro_Beta_v._1._0._0._02_Forms._00_InheritForm
    {
        #region Definitions

        _01_Classes._02_BusinessLayer BL = new _01_Classes._02_BusinessLayer();
        _00_Databases._01_LIFSAcademyDataContext LIFS = new _00_Databases._01_LIFSAcademyDataContext();

        #endregion

        public _11_DeleteSubjectForm()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var Subject2 = LIFS.LIFSSUBJECT.First(s => s.SUBJECTID == Convert.ToInt32(DataGridSubject.CurrentRow.Cells[0].Value.ToString()));

                LIFS.LIFSSUBJECT.DeleteOnSubmit(Subject2);

                LIFS.SubmitChanges();

                BL.LabelInfo(LblInfo, "Silme İşlemi Başarılı");
                BL.InfoColorSuccess(PanelColor);

                var Subject = from x in LIFS.LIFSSUBJECT
                              select x;

                DataGridSubject.DataSource = Subject;

            }
            catch (Exception)
            {
                BL.LabelInfo(LblInfo, "Silme İşlemi Gerçekleşmedi");
                BL.InfoColorError(PanelColor);
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

        private void _11_DeleteSubjectForm_Load(object sender, EventArgs e)
        {
            var Subject = from x in LIFS.LIFSSUBJECT
                          select x;

            DataGridSubject.DataSource = Subject;
        }

        private void DataGridSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           TextSubjectName.Text= DataGridSubject.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
