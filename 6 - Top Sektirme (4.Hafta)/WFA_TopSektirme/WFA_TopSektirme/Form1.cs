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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // MessageBox.Show(e.ToString());

            //MessageBox.Show(e.KeyCode.ToString());

            //bool isA = e.KeyCode == Keys.A;
            //if (isA)
            //{
                //MessageBox.Show("A tuşu aktif");
            //}

           // if (e.KeyCode == Keys.Left)
            //{
             //   pBTOP.Left -= 5;
            //}

            //int hizYatay = 40;
            //int hizDikey = 40;
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

                case Keys.W:
                   timer2.Start();
                    break;

                case Keys.S:
                    timer1.Stop();
                    break;

                case Keys S:
                    timer2.Stop();
                    break;


            }
        }
        int hizYatay = 40;
        int hizDikey = 40;
        //int hizYukari = 40;
        //int hizAşaği = 40;

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
            /*
            pBTOPP.Top -= hizYukari;

            if (pBTOPP.Bottom >= this.Bottom)
            {
                hizYukari = -40;
                pBTOPP.Top += hizAşaği;
            }

            */
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.Left = 0 (Örneğin burda sol tarafı "0" olarak alırız.
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pBTOPP.Top += hizDikey;
            if (pBTOPP.Bottom >= this.Height)
            {
                hizDikey -= 40;
            }
            else if (pBTOPP.Top <= 0)
            {
                hizYatay += 40;
            }
        }
    }
}
