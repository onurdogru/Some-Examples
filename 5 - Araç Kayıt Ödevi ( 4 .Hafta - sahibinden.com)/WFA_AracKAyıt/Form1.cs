using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_AracKAyıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //COMBOBOX ÇAĞIRMA
           // int secili = comboBox1.SelectedIndex;
           // MessageBox.Show(secili.ToString()); 

          //  MessageBox.Show (comboBox1.SelectedItem.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbMARKA.Text)
            {
                case "Renault":
                    comboMODEL.Items.Add("Clio");
                    comboMODEL.Items.Add("Megane");
                    break;

                case "Audi":
                    comboMODEL.Items.Add("Q7");
                    comboMODEL.Items.Add("A7");
                    break;

                case "Tesla":
                    comboMODEL.Items.Add("X");
                    comboMODEL.Items.Add("S");
                    break;

                case "Tofaş":
                    comboMODEL.Items.Add("Kartal SLX");
                    comboMODEL.Items.Add("Murat 131");
                    break;

                case "Opel":
                    comboMODEL.Items.Add("Astra");
                    comboMODEL.Items.Add("Vectra");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            ListViewItem lvi = new ListViewItem();  //instance

            lvi.Text = "audi";               //0
            lvi.SubItems.Add("Q7");          //1
            lvi.SubItems.Add("Benzin");       //2
            lvi.SubItems.Add("Otomatik");     //3

            //COMBOBOX TANIMLAMA
            //comboBox1.Items.Add("Mercedes");
            //comboBox1.Items.Add("Audi");
            listView1.Items.Add(lvi);
            */
            //UYGULAMA ÇALIŞTIRILDIĞINDA yukaridaki markaları doldurun
            //

            //MARKA
            
            cmbMARKA.Items.Add("Tofaş");
            cmbMARKA.Items.Add("Renault");
            cmbMARKA.Items.Add("Audi");
            cmbMARKA.Items.Add("Opel");
            cmbMARKA.Items.Add("Tesla");
           

            //MODEL


            //comboMODEL.Items.Add("Clio");
            //comboMODEL.Items.Add("Megane");
            //comboMODEL.Items.Add("X");


            //YAKIT
            cmbYAK.Items.Add("Benzin");
            cmbYAK.Items.Add("Dizel");
            cmbYAK.Items.Add("Elektrik");


            //VİTES
            cmbVt.Items.Add("Düz");
            cmbVt.Items.Add("Otomatik");



        }

        private void btnEKLE_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false; //Sub itemlerda still işlemi dahil etmek istiyorsak bu işlemi false olarak yapmamız gerekmektedir.
            lvi.Text = cmbMARKA.Text;
            lvi.SubItems.Add(comboMODEL.Text);
            lvi.SubItems.Add(cmbYAK.Text);
            lvi.SubItems.Add(cmbVt.Text);
            //lvi.SubItems.Add(button1.BackColor.ToString()); //RENKİ ATLADIĞIMIZ İÇİN BÖYLE YAZDIK
            lvi.SubItems.Add("");
            lvi.SubItems[4].BackColor = button1.BackColor;
            lvi.SubItems.Add(dateTimePicker1.Value.Year.ToString()); //BURADA SADECE YIL GÖRÜNÜR.

            listView1.Items.Add(lvi);

           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           DialogResult dr= colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //MessageBox.Show("Renk Seçildi");
                button1.BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("İptal Edildi");
            }
        }

        private void btnSIL_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dr= MessageBox.Show("Silmek İstediğine Emin misin", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (dr == DialogResult.Yes)
                {

                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi");
                }
                //MessageBox.Show("Emin misin")
                listView1.Items.Remove(listView1.SelectedItems[0]);
                lblADET.Text = listView1.Items.Count.ToString();
            }
            else
            {
                MessageBox.Show("İtem Yok");
            }
        }
    }
}
