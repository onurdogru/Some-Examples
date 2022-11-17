using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AtYarisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        decimal yatirilanPara;   //ENES


        private void btnBASLA_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            //pbAT1.Left += 50;

            //pbAT1.Right = 10; //Bir tool'un sadece sol (left) ve alt (bottom) özelliklerine değer ataması gerçekleştirilir. Sağ (right) ve üst (top) değerleri sadece okunabilir. (Read only)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Atlar finish çizgisine doğru hareket edecekler. 
            // Ancak hangi atın ilk önce finish çizgisine geleceğine bilemeyeceğiz.

            pbAT1.Left += rnd.Next(10,30);  //ENES DC
            PbAT2.Left += rnd.Next(10,30);
            pbAT3.Left += rnd.Next(10,30);

            if(BackColor == Color.Red)
            {
                pbAT1.Left += rnd.Next(5, 5);
            }
            else if(BackColor == Color.Yellow)
            {
                PbAT2.Left += rnd.Next(4,4);
            }
            else if (BackColor == Color.Orange)
            {
                pbAT3.Left += rnd.Next(3,9);
                {

                }
            }
            //Kazanma Durumu

            if(pbAT1.Right>=lblFINISH.Left)
            { 
                timer1.Stop();
               DialogResult dr=  MessageBox.Show("1.at kazandı! \n Tekrar Oynamak İster misin ?" , "Oyun Bitti! " , MessageBoxButtons.YesNo, MessageBoxIcon.Information); 

                if (dr ==DialogResult.Yes)

                {
                    pbAT1.Left = 12;
                    PbAT2.Left = 12;
                    pbAT3.Left = 12;
                }
                else
                {
                    Application.Exit();
                }
            }
            else if (PbAT2.Right>=lblFINISH.Left)
            {
                timer1.Stop();
                DialogResult dr= MessageBox.Show("2.at kazandı ! \n Tekrar Oynamak İster misin?" , "Oyun Bitti!" , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    pbAT1.Left = 12;
                    PbAT2.Left = 12;
                    pbAT3.Left = 12;
                }
                else
                {
                    Application.Exit();
                }
            } 
            else if (pbAT3.Right >= lblFINISH.Left)
            {
                timer1.Stop();
                DialogResult dr = MessageBox.Show("3.at kazandı ! \n Tekrar Oynamak İster misin?", "Oyun Bitti!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                    {
                    pbAT1.Left = 12;
                    PbAT2.Left = 12;
                    pbAT3.Left = 12;
                }
                else
                {
                    Application.Exit();
                }

                //SPİKER

                
                // Uygulama start olduğunda üç farklı zemin renginden bir tanesini tanımlansın bunlar; Kahverengi, yeşil ve gri olsun.
                // Zemin kahverengi ise 1.at Kazansın
                // Zemin yeşil ise 2.at kazansın
                // Zemin gri ise 3. at kazansın

                //Yatır Butonuna tıklanmadan yarış başlamayacak.!
            }
            if (pbAT1.Right > PbAT2.Right && pbAT1.Right > pbAT3.Right)
            {
                lblSPIKER.Text = "1.At Önde Gidiyor, Şampiyonluk Geliyor !!!";

            }
            else if (PbAT2.Right > pbAT1.Right && PbAT2.Right > pbAT3.Right)
            {
                lblSPIKER.Text = "2.At Önde Gidiyor, Son Kulvarda !!! ";
            }
            else
            {
                lblSPIKER.Text = "3.at Önde Gidiyor";
            }
        }








        private void Form1_Load(object sender, EventArgs e) //ENES
        {
            Random background = new Random();
            int colors = background.Next(1, 4);

            if (colors==1)
                {
                BackColor = Color.Red;
            }
            else if (colors==2)
                {
                BackColor = Color.Yellow;
            }
            else if (colors==3)
            {
                BackColor= Color.Orange;
            }
            
            btnBASLA.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal yatirilanPara = numericUpDown1.Value;
            btnBASLA.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal yatirilanPara = numericUpDown2.Value;
            btnBASLA.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal yatirilanPara = numericUpDown3.Value;
            btnBASLA.Enabled = true;
        }

        private void lblSPIKER_Click(object sender, EventArgs e)
        {

        }
    }
}
