using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LIFS_Management_Pro_Beta_v._1._0._0._02_Forms
{
    public partial class PanelMain : LIFS_Management_Pro_Beta_v._1._0._0._02_Forms._00_InheritForm
    {
        #region Definition

        _01_Classes._02_BusinessLayer BL = new _01_Classes._02_BusinessLayer();

        #endregion

        #region Parameters

        int FormWidth, FormHeight;

        #endregion


        public PanelMain()
        {
            InitializeComponent();
        }

        private void AddICBtn_Click(object sender, EventArgs e)
        {
            _02_Forms._08_AddTermCardForm ATCF = new _08_AddTermCardForm();

            BL.OFIP(PanelForm, ATCF);
        }

        private void UpdateSubBtn_Click(object sender, EventArgs e)
        {
            _02_Forms._09_UpdateSubjectForm USF = new _09_UpdateSubjectForm();

            FormWidth = (PanelForm.Width - USF.Width) / 2;
            FormHeight = (PanelForm.Height - USF.Height) / 2;

            USF.Location = new Point(FormWidth, FormHeight);
            BL.OFIP2(PanelForm, USF);
        }

        private void UpdateCardBtn_Click(object sender, EventArgs e)
        {
            _02_Forms._10_UpdateTermCardForm UTCF = new _10_UpdateTermCardForm();

            BL.OFIP(PanelForm, UTCF);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            _02_Forms._11_DeleteSubjectForm DSF = new _11_DeleteSubjectForm();

            FormWidth = (PanelForm.Width - DSF.Width) / 2;
            FormHeight = (PanelForm.Height - DSF.Height) / 2;

            DSF.Location = new Point(FormWidth, FormHeight);
            BL.OFIP2(PanelForm, DSF);
        }

        private void DeleteInfoCardBtn_Click(object sender, EventArgs e)
        {
            _02_Forms._12_DeleteTermCardForm DTCF = new _12_DeleteTermCardForm();

            BL.OFIP(PanelForm, DTCF);
        }

        private void AddSubjectBtn_Click(object sender, EventArgs e)
        {
            _02_Forms._07_AddSubjectForm ASF = new _07_AddSubjectForm();

            FormWidth = (PanelForm.Width - ASF.Width) / 2;
            FormHeight = (PanelForm.Height - ASF.Height) / 2;

            ASF.Location = new Point(FormWidth, FormHeight);
            BL.OFIP2(PanelForm, ASF);
        }


    }
}
