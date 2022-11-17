using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_KimBilir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 30;
        

        private void Form1_Load(object sender, EventArgs e)  // BU ALAN LİST BOX İÇİNE TÜM İSİM VE SOYİSİMLERİ YAZDIRDIĞIMIZ ALAN.
        {
            string[] isimler = { "AZAD MAJIDLI", "SILA ŞİRİN" , "UMUT YILBAŞ" , "SARUHAN MERT DEMİRAY" , "ONUR DOĞRU" , "Emre Bektaşoğlu" , "ENES SERENLİ" , "FURKAN SEMİH GÜNEŞ" , "KAAN ÜNAL" , "BAHADIR ARDA" , "MERT ÇINAR" , "BURAK UYSAL" , "AHMET CANER TAI" , "TUBA KARADUT BUĞDAY" , "MAHMURE OKAN" , "ARYA KAPIKIRAN" , "BERK BASAT" };

            string[] soyisimler = { "MAJIDLI", "ŞİRİN", "YILBAŞ", "DEMİRAY", "DOĞRU", "Bektaşoğlu", "SERENLİ", "GÜNEŞ", "ÜNAL", "ARDA", "ÇINAR", "UYSAL", "TAI", "BUĞDAY", "OKAN", " KAPIKIRAN", "BASAT" };

            foreach (string oppo in isimler) 
            {
                listBox1.Items.Add(oppo);
            }

        }

        private void button1_Click(object sender, EventArgs e) // BU ALAN LİSTVİEW İÇİNDE İŞLEM YAPTIĞIMIZ ALAN.
        {
            Random ogrenci = new Random();
            ListViewItem lvi = new ListViewItem();

            lvi.Text = listBox1.SelectedItem.ToString(); //BURADA ASLINDA LİSTBOXDAKİ İSİMLERİ LİV'E ATA, SONRADA LVİ'E ATANAN İSİMLERİ LİSTVİEW'DE GÖSTER SATIRLARI.
            listView1.Items.Add(lvi);

            timer1.Start();
          
            DialogResult dr = MessageBox.Show("Eklemek İstediğiniz Kişiye Puan Vermek İster Misin?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);



            if (dr == DialogResult.Yes)
            {
               
                lvi.SubItems.Add ("5".ToString());
                
                timer1.Stop();
                saniye = 30;
                label1.Text = saniye.ToString();
               
            }
            
        else
            {
                lvi.SubItems.Add("0".ToString());
            }

            timer1.Stop();
            saniye = 30;
            label1.Text = saniye.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Interval = 1000; //1000 = 1 sn
            saniye  --;
            label1.Text = saniye.ToString();
            if (saniye == 0)

            {
                timer1.Stop ();
                label1 .Text =  saniye.ToString();
            }

            
        }
    }
}
