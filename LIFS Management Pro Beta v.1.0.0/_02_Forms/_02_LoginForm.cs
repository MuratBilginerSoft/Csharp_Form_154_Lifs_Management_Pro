using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    public partial class _02_LoginForm : Form
    {
        #region DLL Import

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        #region For Oval Shape Form

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        #endregion

        #endregion

        #region Definition

        public static string[] UserInfo = new string[9];

        _01_Classes._02_BusinessLayer BL = new _01_Classes._02_BusinessLayer();

        #endregion

        #region Parameters 

        string UserName, Password;

        #endregion

        #region Form Controls

        public _02_LoginForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 325, 440, 40, 40));
            InitializeComponent();
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PicMinus_MouseHover(object sender, EventArgs e)
        {
            BL.HoverPicColor((PictureBox)sender);
        }

        private void PicMinus_MouseLeave(object sender, EventArgs e)
        {
            BL.LeftPicColor((PictureBox)sender);
        }

        private void _02_LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void SignInBtn_Click_1(object sender, EventArgs e)
        {
            UserName = TextUserName.text;
            Password = TextPassword.text;

            _00_Databases._01_LIFSAcademyDataContext LFAD = new _00_Databases._01_LIFSAcademyDataContext();

            var User = LFAD.LIFSLOGIN.Where((w => w.USERNAME == UserName && w.PASSWORD == Password)).FirstOrDefault();

            if (User == null)
            {
                MessageBox.Show("Olmadı");
            }

            else if (UserName == User.USERNAME && Password == User.PASSWORD)
            {
                _03_MainForm MF = new _03_MainForm();

                UserInfo[0] = User.USERDID.ToString();
                UserInfo[1] = User.USERNAME.ToString();
                UserInfo[2] = User.PASSWORD.ToString();
                UserInfo[3] = User.AUTHORITY.ToString();
                UserInfo[4] = User.PROFIL.ToString();
                UserInfo[5] = User.NAME.ToString();
                UserInfo[6] = User.LASTNAME.ToString();

                _00_Databases.LIFSLOGIN User2 = LFAD.LIFSLOGIN.First(s => s.USERDID == Convert.ToInt32(UserInfo[0]));

                User2.ONLINESTATUS = 1;

                LFAD.SubmitChanges();

                UserInfo[7] = User.ONLINESTATUS.ToString();
                UserInfo[8] = User.USERAKA;

                this.Hide();
                MF.Show();
                

            }
        }

        #endregion
    }
}
