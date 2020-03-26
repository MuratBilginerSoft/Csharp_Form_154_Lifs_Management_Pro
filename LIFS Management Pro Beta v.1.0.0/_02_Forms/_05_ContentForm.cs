using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    public partial class _05_ContentForm : LIFS_Management_Pro_Beta_v._1._0._0._02_Forms._00_InheritForm
    {
        #region Parameters

        #endregion

        public _05_ContentForm()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            _00_Databases._01_LIFSAcademyDataContext LFAD = new _00_Databases._01_LIFSAcademyDataContext();

            if (ComboSubject.Text=="" && TextTitle.text=="" && TextUserNo.text=="" && TextQCNum.text=="" && DatePickerFirst.Value.ToShortDateString()== "1.01.1975" && DatePickerLast.Value.ToShortDateString() == "1.01.1975" && DatePickerRev1.Value.ToShortDateString() == "1.01.1975" && DatePickerRev2.Value.ToShortDateString() == "1.01.1975")
            {
                DataGridContent.DataSource = LFAD.LIFSCONTENT;
            }

            else if (ComboSubject.Text == "" && TextTitle.text == "" && TextUserNo.text != "" && TextQCNum.text == "" && DatePickerFirst.Value.ToShortDateString() == "1.01.1975" && DatePickerLast.Value.ToShortDateString() == "1.01.1975" && DatePickerRev1.Value.ToShortDateString() == "1.01.1975" && DatePickerRev2.Value.ToShortDateString() == "1.01.1975")
            {
                var Query = LFAD.LIFSCONTENT.Where(s => s.USERID == Convert.ToInt32(TextUserNo.text)).Select(s => s);
                DataGridContent.DataSource = Query;
            }

            else if (ComboSubject.Text == "" && TextTitle.text == "" && TextUserNo.text == "" && TextQCNum.text != "" && DatePickerFirst.Value.ToShortDateString() == "1.01.1975" && DatePickerLast.Value.ToShortDateString() == "1.01.1975" && DatePickerRev1.Value.ToShortDateString() == "1.01.1975" && DatePickerRev2.Value.ToShortDateString() == "1.01.1975")
            {
                var Query = LFAD.LIFSCONTENT.Where(s => s.QUALITYCONTROL == Convert.ToInt32(TextQCNum.text)).Select(s => s);
                DataGridContent.DataSource = Query;
            }

            else if (ComboSubject.Text == "" && TextTitle.text == "" && TextUserNo.text != "" && TextQCNum.text != "" && DatePickerFirst.Value.ToShortDateString() == "1.01.1975" && DatePickerLast.Value.ToShortDateString() == "1.01.1975" && DatePickerRev1.Value.ToShortDateString() == "1.01.1975" && DatePickerRev2.Value.ToShortDateString() == "1.01.1975")
            {
                var Query = LFAD.LIFSCONTENT.Where(s => s.QUALITYCONTROL == Convert.ToInt32(TextQCNum.text) && s.USERID == Convert.ToInt32(TextUserNo.text)).Select(s => s);
                DataGridContent.DataSource = Query;
            }

            else if (ComboSubject.Text != "" && TextTitle.text == "" && TextUserNo.text == "" && TextQCNum.text == "" && DatePickerFirst.Value.ToShortDateString() == "1.01.1975" && DatePickerLast.Value.ToShortDateString() == "1.01.1975" && DatePickerRev1.Value.ToShortDateString() == "1.01.1975" && DatePickerRev2.Value.ToShortDateString() == "1.01.1975")
            {
                var Query = LFAD.LIFSCONTENT.Where(s => s.SUBJECT == ComboSubject.Text).Select(s => s);
                DataGridContent.DataSource = Query;
            }
        }

        private void _05_ContentForm_Load(object sender, EventArgs e)
        {
            _00_Databases._01_LIFSAcademyDataContext LFAD = new _00_Databases._01_LIFSAcademyDataContext();

            var Subject = LFAD.LIFSSUBJECT.Select(s => s);

            foreach (var item in Subject)
            {
                ComboSubject.Items.Add(item.SUBJECTNAME);
            }
        }

        private void DataGridContent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RichTextContent.Text = DataGridContent.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception)
            {

                
            }
           
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ComboSubject.Text = "";
            TextUserNo.text = "";
            TextTitle.text = "";
            TextQCNum.text = "";
        
            DatePickerFirst.Value = Convert.ToDateTime("1.01.1975");
            DatePickerLast.Value = Convert.ToDateTime("1.01.1975");
            DatePickerRev1.Value = Convert.ToDateTime("1.01.1975");
            DatePickerRev2.Value = Convert.ToDateTime("1.01.1975");

        }
    }
}
