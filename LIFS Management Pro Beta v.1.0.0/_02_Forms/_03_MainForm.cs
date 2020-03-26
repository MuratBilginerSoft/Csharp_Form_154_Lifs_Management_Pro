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
    public partial class _03_MainForm : Form
    {

        #region Definition

        _01_Classes._02_BusinessLayer BL = new _01_Classes._02_BusinessLayer();
        

        #endregion

        #region Parameters

        #endregion

        public _03_MainForm()
        {
            InitializeComponent();
            
        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            _00_Databases._01_LIFSAcademyDataContext LFAD = new _00_Databases._01_LIFSAcademyDataContext();

            _00_Databases.LIFSLOGIN User2 = LFAD.LIFSLOGIN.First(s => s.USERDID == Convert.ToInt32(_02_Forms._02_LoginForm.UserInfo[0]));

            User2.ONLINESTATUS = 0;

            LFAD.SubmitChanges();

            Application.Exit();
        }

        private void PicMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void _03_MainForm_Load(object sender, EventArgs e)
        {
            ShapeProfil.BackgroundImage = Image.FromFile(_02_LoginForm.UserInfo[4]);
            LabelName.Text = _02_LoginForm.UserInfo[5] + " " + _02_LoginForm.UserInfo[6];
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (((ns1.BunifuTileButton)sender).Name == "HomeBtn")
            {
                _04_HomeForm HF = new _04_HomeForm();
                BL.OFIP(PanelForm, HF);
            }

            else if (((ns1.BunifuTileButton)sender).Name == "ContentBtn")
            {
                _02_Forms._05_ContentForm CF = new _02_Forms._05_ContentForm();
                BL.OFIP(PanelForm, CF);
            }

            else if (((ns1.BunifuTileButton)sender).Name == "AddBtn")
            {
                _02_Forms.PanelMain ACF = new _02_Forms.PanelMain();
                BL.OFIP(PanelForm, ACF);
            }

            else if (((ns1.BunifuTileButton)sender).Name == "UpdateBtn")
            {
                _02_Forms.PanelMain ACF = new _02_Forms.PanelMain();
                BL.OFIP(PanelForm, ACF);
            }

            else if (((ns1.BunifuTileButton)sender).Name == "DeleteBtn")
            {
                _02_Forms.PanelMain ACF = new _02_Forms.PanelMain();
                BL.OFIP(PanelForm, ACF);
            }

            //else if (((ns1.BunifuTileButton)sender).Name == "QualityBtn")
            //{
            //    QualityControlForm QCF = new QualityControlForm();
            //    BL.OFIP(PanelForm, QCF);
            //}

            //else if (((ns1.BunifuTileButton)sender).Name == "AddUserBtn")
            //{
            //    AddUserForm AUF = new AddUserForm();
            //    BL.OFIP(PanelForm, AUF);
            //}

            //else if (((ns1.BunifuTileButton)sender).Name == "SettingsBtn")
            //{
            //    SettingsForm SF = new SettingsForm();
            //    BL.OFIP(PanelForm, SF);
            //}
        }
    }
}
