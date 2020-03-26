using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    public partial class _04_HomeForm : LIFS_Management_Pro_Beta_v._1._0._0._02_Forms._00_InheritForm
    {
        #region Definition

        _01_Classes._02_BusinessLayer BL = new _01_Classes._02_BusinessLayer();

        _00_Databases._01_LIFSAcademyDataContext LIFS = new _00_Databases._01_LIFSAcademyDataContext();

        #endregion

        #region Parameters

        int i = 0;
        int j = 0;

        #endregion

        #region Methods

        public void OnlineControl()
        {

            _00_Databases._01_LIFSAcademyDataContext LIFS = new _00_Databases._01_LIFSAcademyDataContext();

            var datauser = from x in LIFS.LIFSLOGIN
                           select x;

          

            i = 0;
            j = tableLayoutPanel1.RowCount - 1;

            foreach (var item in datauser)
            {
                tableLayoutPanel1.Controls[j - i].BackgroundImage = Image.FromFile(item.PROFIL);
                tableLayoutPanel2.Controls[j - i].Text = item.NAME + " " + item.LASTNAME;

                if (item.ONLINESTATUS == 0)
                {
                    tableLayoutPanel3.Controls[j - i].BackColor = Color.Red;
                }

                else
                {
                    tableLayoutPanel3.Controls[j - i].BackColor = Color.RoyalBlue;
                }

                i++;
            }

            LIFS.Dispose();
        }

        public void ScoreTable()
        {
            var ScoreTable = from x in LIFS.LIFSUSERSCORE
                             orderby x.TOTALSCORE descending
                             select x;

            i = 0;
            j = tableLayoutPanel6.RowCount - 1;

            foreach (var item in ScoreTable)
            {
                var User = LIFS.LIFSLOGIN.Where(w => w.USERDID == item.USERID).FirstOrDefault();

                tableLayoutPanel6.Controls[j - i].BackgroundImage = Image.FromFile(User.PROFIL);
                tableLayoutPanel7.Controls[j - i].Text = item.NAME + " " + item.LASTNAME;
                tableLayoutPanel8.Controls[j - i].Text = item.TOTALSCORE.ToString();

                i++;
            }
        }

        #endregion

        public _04_HomeForm()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void _04_HomeForm_Load(object sender, EventArgs e)
        {
            OnlineControl();
            ScoreTable();

            var LIFSLog = (from x in LIFS.LIFSLOG  
                           orderby x.DATE descending
                          select x).Take(20);

            i = 0;
            j = tableLayoutPanel4.RowCount - 1;

            foreach (var item in LIFSLog)
            {
                tableLayoutPanel4.Controls[j - i].Text = item.USERAKA;
                tableLayoutPanel5.Controls[j - i].Text = item.INFO;

                i++;
            }

            var UserScore = LIFS.LIFSUSERSCORE.Where(w => w.USERID == Convert.ToInt32(_02_Forms._02_LoginForm.UserInfo[0])).FirstOrDefault();

            LblTSM.Text = UserScore.TERMSCORE.ToString();
            LblScore.Text = UserScore.TOTALSCORE.ToString();

            var TotalTerm = (from x in LIFS.LIFSUSERSCORE
                             select x.TERMSCORE).Sum();

            LblTT.Text = TotalTerm.Value.ToString();



        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {

        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
