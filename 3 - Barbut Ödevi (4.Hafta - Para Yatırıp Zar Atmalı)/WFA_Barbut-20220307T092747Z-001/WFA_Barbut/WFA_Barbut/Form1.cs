using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Barbut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal toplamPara;
        decimal toplamPuan1;
        decimal toplamPuan2;
        Random rnd = new Random();
        int rastgele1;
        int rastgele2;
        


        private void btnZar1_Click(object sender, EventArgs e)
        {
            
            rastgele1 = rnd.Next(1, 7);
            lblZar1.Text = rastgele1.ToString();
            btnZar1.Enabled = true;
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnZar1.Enabled = false;
            btnZar2.Enabled = false;
        }

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            decimal puanCek1 = nudParaCek.Value;
            toplamPuan1 -= puanCek1;
            lblBakiye.Text =toplamPuan1.ToString();

        }

        private void button3_Click(object sender, EventArgs e)  //BU SATIR OKEY
        {
            decimal moneyYatir1 = numericUpDown3.Value;
            listBox2.Items.Add("-Hesaba "+moneyYatir1  + " TL Para Yatırıldı, Şimdi Oyun Zamanı!");
            toplamPara += moneyYatir1;
            lblOrta.Text = toplamPara.ToString();
            btnZar1.Enabled = true;
            

        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            decimal puanYatir1 = nudParaYatir.Value;
            toplamPuan1 += puanYatir1;
            lblBakiye.Text = toplamPuan1.ToString();
            
        }

        private void button4_Click(object sender, EventArgs e) //BU SATIR OKEY
        {
            decimal moneyYatir2 = numericUpDown4.Value;
            listBox3.Items.Add("-Hesaba "+moneyYatir2 + " TL Para Yatırıldı, Şimdi Oyun Zamanı!");
            toplamPara += moneyYatir2;
            lblOrta.Text = toplamPara.ToString();    
            btnZar2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal puanCek2 = numericUpDown2.Value;
            toplamPuan2 -= puanCek2;
            label5.Text= toplamPuan2.ToString();
            
        }

        private void lblOrta_Click(object sender, EventArgs e)
        {

        }

        private void btnZar2_Click(object sender, EventArgs e)
        {
             Random rnd = new Random();
            rastgele2 = rnd.Next(1, 7);

            lblZar2.Text = rastgele2.ToString();
            btnZar2.Enabled = true;

            if (rastgele2 > rastgele1) 
                
            {
                lblSonuc.Text = "2.Oyuncu Kazandı";
                listBox1.Items.Add("2.Oyuncu Kazandı, Kazanılan Toplam Puan =" + toplamPara);
                label5.Text = lblOrta.Text.ToString();
                lblOrta.Text = "0";
            }

            if (rastgele2 < rastgele1)
                    {
                lblSonuc.Text = "1. Oyuncu Kazandı";
                listBox1.Items.Add("1.Oyuncu Kazandı, Kazanılan Toplam Puan =" +toplamPara);
                lblBakiye.Text = lblOrta.Text.ToString();
                lblOrta.Text = "0";
            }

            else 
                    {
                lblSonuc.Text = ("Berabere Kaldınız, Tekrar Zar Atınız!");

            }
        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {
            
        }

        private void nudParaCek_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal puanYatir2 = numericUpDown1.Value;
            toplamPuan2 += puanYatir2;
            label5.Text = toplamPuan2.ToString();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblBakiye_Click(object sender, EventArgs e)
        {

        }
    }
}
