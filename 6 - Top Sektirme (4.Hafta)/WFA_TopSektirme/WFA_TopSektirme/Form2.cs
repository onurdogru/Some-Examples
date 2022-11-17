using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TopSektirme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    pBTOPP.Left -= hizYatay;
                    break;

                case Keys.Up:
                    pBTOPP.Top -= hizDikey;
                    break;

                case Keys.Right:
                    pBTOPP.Left += hizYatay;
                    break;

                case Keys.Down:
                    pBTOPP.Top += hizDikey;
                    break;

                case Keys.D:
                    timer1.Start();
                    break;

                case Keys.S:
                    timer1.Stop();
                    break;


            }
        }
        int hizYatay = 40;
        int hizDikey = 40;
        private void timer1_Tick(object sender, EventArgs e)

        {
            pBTOPP.Left += hizYatay;

            if (pBTOPP.Right >= this.Right)
            {
                hizYatay = -40;
                pBTOPP.Left += hizYatay;
            }
            else if (pBTOPP.Left <= this.Left)
            {
                hizYatay = 40;
                pBTOPP.Left += hizYatay;
            }
        }
    }
}
