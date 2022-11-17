using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_MarsGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // GLOBAL KISIMDA ANA PARAYI BELİRLEMEMİZ GEREKLİ !
        decimal güncelCash = 0.00m;
        decimal shieldCash = 20.0m;
        decimal staffCash = 15.0m;
        decimal potionCash = 30.0m;
        decimal TotalCash = 0.00m; 

        private void btnCek_Click(object sender, EventArgs e)
        {
            //PARA ÇEK BUTONUNDA ANA PARADAN ÇEKİLAN PARA ÇIKARILMASI GEREK VE GEREKLİ KISIMDA STRING ŞEKİLDE GÖSTERİLMESİ GEREKLİ !
            decimal cekilecekmiktar = nudCek.Value;
            güncelCash = güncelCash - cekilecekmiktar;
            lblTOPLAM.Text = güncelCash.ToString() + "MC";


            // IF - ELSE KISMI
            if (cekilecekmiktar > güncelCash)
            {
                MessageBox.Show("Please Install Mars Coin");
            }
            if (güncelCash==0)
            {
                MessageBox.Show("Please Install Mars Coin");
                btnCek.Enabled = false;
            }

            else
            {
                MessageBox.Show("Congratulations!");
                lstOZET.Items.Add("Buy Cash :" +cekilecekmiktar +  "  Total Cash :" +güncelCash);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // SİSTEM AÇILIRKEN GÖRÜNMESİNİ İSTEDİĞİMİZ PARA MİKTARI
            güncelCash = 1000;
            lblTOPLAM.Text = güncelCash.ToString()+"MC";
        }

        private void btnYATIR_Click(object sender, EventArgs e)
        {
            //PARA YATIR BUTONU İÇİNDE DECİMAL BİR DEĞİŞKEN BELİRLEDİK VE SONUCU LABELDA YAZMASI İÇİN TO STRING YAPTIK.
            decimal maxpara = 1000;
            decimal yatirilacakMiktar = nudYATIR.Value;
            güncelCash = güncelCash + yatirilacakMiktar;
            lblTOPLAM.Text = güncelCash.ToString() + "MC";


            // IF - ELSE KISMI
            if (yatirilacakMiktar > maxpara)
            {
                MessageBox.Show("Limit Exceeded");
            }
            if (yatirilacakMiktar < 5)
            {
                MessageBox.Show("Minimum Limit 5 Mars Coin");
            }
            else
            {
                MessageBox.Show("Congratulations!");
                lstOZET.Items.Add("Sell Cash :" +yatirilacakMiktar + "  Total Cash :" +güncelCash);
                btnCek.Enabled = true;
            }
            
        }

        private void btnITEMS_Click(object sender, EventArgs e)
        {
            //ITEMS PANELİNDEKİ İTEMLERİ GLOBALDA TANITMAM GEREKLİ. BU KISMA BOOL OLAN SATIRLAR YAZILMALI

            bool shield = chkShield.Checked;
            bool staff = chcStaff.Checked;
            bool potion = chcPOT.Checked;

            if (shield)
            {
                güncelCash = güncelCash - shieldCash;
                lstITEMS.Items.Add ("Dark Shield :"  +shieldCash.ToString() +"MC");
                lblTOPLAM.Text = güncelCash.ToString();
                lstOZET.Items.Add("Item : Dark Shield :" +shieldCash.ToString() +"MC");
                TotalCash += shieldCash;

            }

            if (staff)
            {
                güncelCash = güncelCash - staffCash;
                lstITEMS.Items.Add("Fire Staff :" +staffCash.ToString() +"MC");
                lblTOPLAM.Text = güncelCash.ToString();
                lstOZET.Items.Add("Item : Fire Staff :" + staffCash.ToString() + "MC");
                TotalCash += staffCash;
            }
           
            if (potion)
            {
                güncelCash = güncelCash - potionCash;
                lstITEMS.Items.Add("Oxygen Potion :" + potionCash.ToString() + "MC");
                lblTOPLAM.Text = güncelCash.ToString();
                lstOZET.Items.Add("Item : Oxygen Potion :" + potionCash.ToString() + "MC");
                TotalCash += potionCash;
            }

            lstOZET.Items.Add(TotalCash.ToString());
            TotalCash = 0;
        }
    }
}
