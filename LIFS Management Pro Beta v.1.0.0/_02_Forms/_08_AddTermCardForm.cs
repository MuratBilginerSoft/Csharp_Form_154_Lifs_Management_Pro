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
    public partial class _08_AddTermCardForm : LIFS_Management_Pro_Beta_v._1._0._0._02_Forms._00_InheritForm
    {
        #region Definitions

        _01_Classes._02_BusinessLayer BL = new _01_Classes._02_BusinessLayer();

        #endregion

        public _08_AddTermCardForm()
        {
            InitializeComponent();
        }

        private void _08_AddTermCardForm_Load(object sender, EventArgs e)
        {
            _00_Databases._01_LIFSAcademyDataContext LIFS = new _00_Databases._01_LIFSAcademyDataContext();

            BL.DataContentSelect(DataGridContent);

            var Subject = LIFS.LIFSSUBJECT.Select(s => s);

            foreach (var item in Subject)
            {
                ComboSubject.Items.Add(item.SUBJECTNAME);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                _00_Databases._01_LIFSAcademyDataContext LIFS = new _00_Databases._01_LIFSAcademyDataContext();
                _00_Databases.LIFSCONTENT Content = new _00_Databases.LIFSCONTENT();

                Content.SUBJECT = ComboSubject.Text;
                Content.TITLE = TextTitle.Text.ToUpper();
                Content.USERID = Convert.ToInt32(_02_LoginForm.UserInfo[0]);
                Content.ADDDATE = Convert.ToDateTime(DateTime.Now.ToLongDateString());
                Content.CONTETT = RichTextContent.Text;
                Content.QUALITYCONTROL = 0;
                Content.REV = 0;
                Content.REVDATE = null;

                LIFS.LIFSCONTENT.InsertOnSubmit(Content);
                LIFS.SubmitChanges();

                BL.LabelInfo(LblInfo, "Kayıt Başarılı");
                BL.InfoColorSuccess(PanelColor);

                BL.DataContentSelect(DataGridContent);

                ComboSubject.Text = "";
                TextTitle.Text = "";
                RichTextContent.Text = "";
            }
            catch (Exception)
            {
                BL.LabelInfo(LblInfo, "Kayıt Gerçekleşmedi");
                BL.InfoColorError(PanelColor);
            }
           
            
        }

        private void AddBtn_MouseHover(object sender, EventArgs e)
        {
            BL.HoverPicColor(AddBtn);
        }

        private void AddBtn_MouseLeave(object sender, EventArgs e)
        {
            BL.LeftPicColor(AddBtn);
        }
    }
}
