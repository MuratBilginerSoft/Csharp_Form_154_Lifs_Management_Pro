using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIFS_Management_Pro_Beta_v._1._0._0._01_Classes
{
    public class _02_BusinessLayer
    {
        #region Definitions

        _01_Classes._01_DataAccessLayer DL = new _01_DataAccessLayer();
        _00_Databases._01_LIFSAcademyDataContext LIFS = new _00_Databases._01_LIFSAcademyDataContext();

        #endregion

        #region Data LIFSUSER
        
       
        #endregion

        #region Data LıfsSubject

        public void DataSubjectSelect(DataGridView DGV)
        {
            DGV.DataSource = from x in LIFS.LIFSSUBJECT
                             select x;
        }

        public void DataContentSelect(DataGridView DGV)
        {
            DGV.DataSource = from x in LIFS.LIFSCONTENT
                             select x;
        }

        public void DataLıfsLogSelect()
        {
            var LIFSLog = from x in LIFS.LIFSLOG
                          select x;
        }

        public void DataSubjectInsert(DataGridView DGV, int SI, string S, int UI, DateTime DT, int REV)
        {
            _00_Databases.LIFSSUBJECT AddSubject = new _00_Databases.LIFSSUBJECT();

            AddSubject.SUBJECTID = SI;
            AddSubject.SUBJECTNAME = S;
            AddSubject.USERID = UI;
            AddSubject.ADDDATE = DT;
            AddSubject.REVISION = REV;

            LIFS.LIFSSUBJECT.InsertOnSubmit(AddSubject);
            LIFS.SubmitChanges();

            DataSubjectSelect(DGV);
        }

        public void DataLogInsert(int UI, string I, DateTime DT, string UAK)
        {

            _00_Databases.LIFSLOG AddLog = new _00_Databases.LIFSLOG();

            AddLog.USERID = UI;
            AddLog.INFO = I;
            AddLog.DATE = DT;
            AddLog.USERAKA = UAK;

            LIFS.LIFSLOG.InsertOnSubmit(AddLog);

            LIFS.SubmitChanges();

            DataLıfsLogSelect();
        }
        #endregion

        #region Open Form In Panel

        public void OFIP(Panel Panel, Form Form)
        {
            Panel.Controls.Clear();
            Form.TopLevel = false;
            Panel.Controls.Add(Form);
            Form.Show();
            Form.Dock = DockStyle.Fill;
            Form.BringToFront();
        }

        public void OFIP2(Panel Panel, Form Form)
        {
            Panel.Controls.Clear();
            Form.TopLevel = false;
            Panel.Controls.Add(Form);
            Form.Show();
            Form.BringToFront();
        }


        #endregion

        #region PictureBox Color

        public void HoverPicColor(PictureBox Pic)
        {
            Pic.BackColor = Color.SlateGray;
        }

        public void LeftPicColor(PictureBox Pic)
        {
            Pic.BackColor = Color.Transparent;
        }

        #endregion

        #region Information

        public void LabelInfo(Label LBL, string INFO)
        {
            LBL.Text = INFO;
        }

        public void LabelInfo(Label LBL)
        {
            LBL.Text = "Hazır";
        }

        public void InfoColorStandart(Panel PNL)
        {
            PNL.BackColor = Color.Transparent;
        }

        public void InfoColorWarning(Panel PNL)
        {
            PNL.BackColor = Color.Yellow;
        }

        public void InfoColorError(Panel PNL)
        {
            PNL.BackColor = Color.Red;
        }

        public void InfoColorSuccess(Panel PNL)
        {
            PNL.BackColor = Color.White;
        }

        #endregion 


    }
}
