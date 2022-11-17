using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HastaneRendevu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            Brans br = new Brans(txtBrans.Text);
       
           cmbBrans.Items.Add(br);
           comboBox1.Items.Add(br);
           MessageBox.Show("Branş Eklenmiştir.");
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doktor dr = new Doktor(txtDoktorAd.Text);
            dr.bransAd = (Brans)cmbBrans.SelectedItem;  //unboxing işlemi


            Doktor.doktorlarListesi.Add(dr);
            MessageBox.Show("Doktor Hastane Sistemine Yüklenmiştir.");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Doktor doctor in Doktor.doktorlarListesi)
            {
                if (doctor.bransAd==comboBox1.SelectedItem)
                {
                    comboBox2.Items.Add("Dr. "+doctor.doktorAd);
                }
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen Randevu Saatinizi Seçiniz.");

            if (dateTimePicker1.Value >= DateTime.Today)
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;

                button2.Click += Button2_Click;
                button3.Click += Button3_Click;
                button4.Click += Button4_Click;
                button5.Click += Button5_Click;
                button6.Click += Button6_Click;

            }
            else
            {
                MessageBox.Show("Yanlış Tarih Girdiniz !");
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tamamlamak istediğinize emin misiniz", "Hastane Randevu Onay Ekranı" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            button6.BackColor = Color.Red;
            MessageBox.Show("Lütfen Randevu Gününde ve Saatinde Hastanede Olunuz");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tamamlamak istediğinize emin misiniz", "Hastane Randevu Onay Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            button5.BackColor = Color.Red;
            MessageBox.Show("Lütfen Randevu Gününde ve Saatinde Hastanede Olunuz");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tamamlamak istediğinize emin misiniz", "Hastane Randevu Onay Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            button4.BackColor = Color.Red;
            MessageBox.Show("Lütfen Randevu Gününde ve Saatinde Hastanede Olunuz");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tamamlamak istediğinize emin misiniz", "Hastane Randevu Onay Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            button3.BackColor = Color.Red;
            MessageBox.Show("Lütfen Randevu Gününde ve Saatinde Hastanede Olunuz");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tamamlamak istediğinize emin misiniz", "Hastane Randevu Onay Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            button2.BackColor = Color.Red;
            MessageBox.Show("Lütfen Randevu Gününde ve Saatinde Hastanede Olunuz");
        }

        
    }
}
