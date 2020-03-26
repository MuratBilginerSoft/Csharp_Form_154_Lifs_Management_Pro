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
    public partial class _01_StarterForm : Form
    {
        #region DLL Import

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        #endregion

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

        #region Definition

        _02_LoginForm LF = new _02_LoginForm();

        Random r = new Random();

        #endregion

        #region Parameters

        int Index1 = 0; // Nokta Animasyonu Index Sayacı
        int Index2 = 0; // Formun Açık Kalma Sürecini Belirleyen Sayaç
        int Index3 = 0; // Form Artan Sayaç

        #endregion

        #region Form Controls

        public _01_StarterForm()
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 580, 360, 30, 30));
            InitializeComponent();
        }

        private void _09_StarterForm_Load(object sender, EventArgs e)
        {
            Index2 = r.Next(17, 45);
            TimerSaat.Start();
        }

        private void TimerSaat_Tick(object sender, EventArgs e)
        {
            if (Index3 < Index2)
            {
                Index3++;

                #region Point Animation

                Index1++;

                if (Index1 < 6)
                {
                    switch (Index1)
                    {
                        case 1: { LblNokta1.Visible = true; break; }

                        case 2: { LblNokta2.Visible = true; break; }

                        case 3: { LblNokta3.Visible = true; break; }

                        case 4: { LblNokta4.Visible = true; break; }

                        case 5: { LblNokta5.Visible = true; break; }

                    }

                }

                else if (Index1 < 17)
                {
                    TimerSaat.Interval = 150;

                    LblNokta5.Location = new Point(LblNokta5.Location.X + 30, 300);
                    LblNokta4.Location = new Point(LblNokta4.Location.X + 30, 300);
                    LblNokta3.Location = new Point(LblNokta3.Location.X + 30, 300);
                    LblNokta2.Location = new Point(LblNokta2.Location.X + 30, 300);
                    LblNokta1.Location = new Point(LblNokta1.Location.X + 30, 300);
                }

                else if (Index1 < 22)
                {
                    TimerSaat.Interval = 250;

                    switch (Index1)
                    {
                        case 17: { LblNokta1.Visible = false; break; }

                        case 18: { LblNokta2.Visible = false; break; }

                        case 19: { LblNokta3.Visible = false; break; }

                        case 20: { LblNokta4.Visible = false; break; }

                        case 21:
                            {
                                LblNokta5.Visible = false;

                                Index1 = 0;

                                LblNokta1.Location = new Point(10, 300);
                                LblNokta2.Location = new Point(45, 300);
                                LblNokta3.Location = new Point(80, 300);
                                LblNokta4.Location = new Point(115, 300);
                                LblNokta5.Location = new Point(140, 300);

                                break;
                            }
                    }
                }

                #endregion
            }

            else
            {
                this.Close();
            }
        }

        #endregion
    }
}
