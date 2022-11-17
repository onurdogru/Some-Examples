using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Dolap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Kiyafetler> kiyafetlerListesi = new List<Kiyafetler>();
        decimal toplamPara;

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             uygulama açıldığında;
 3 adet ayakkabı
 3 adet tshirt
 3 adet pantolon
 3 adet mont

tanımlayarak ilgili list boxlarda özellikleri ile listeleyin. Kullanıcı listbox içerisinde tanımlı olan item'a çift tıkladıktan sonra lstSepet'e seçili olan item özellikleri ile eklensin ve toplam tutar'a ilgili ürünün fiyatı dahil edilsin.

alışverişi tamamla butonuna basıldıktan sonra lstSepet içerisinde bulunan itemlar listview içerisinde göserilsin ve lstSepet temizlensin.

listboxlar içerisinde fiyatlar kdv hariç sepete eklenildiğinde kdv dahil olarak hem gösterilecek hem de hesaplanacak.
             */

            //AYAKKABI
            Ayakkabi ayakkabi1 = new Ayakkabi();
            ayakkabi1.Marka = "Puma";
            ayakkabi1.Model = "Krampon";
            ayakkabi1.Fiyat = 400;

            Ayakkabi ayakkabi2 = new Ayakkabi();
            ayakkabi2.Marka = "Lescoon";
            ayakkabi2.Model = "Basketbol Ayakkabısı";
            ayakkabi2.Fiyat = 450;

            Ayakkabi ayakkabi3 = new Ayakkabi();
            ayakkabi3.Marka = "Slazenger";
            ayakkabi3.Model = "Tenis Ayakkabısı";
            ayakkabi3.Fiyat = 480;

            //TİŞÖRT
            Tisort tisort1 = new Tisort();
            tisort1.Marka = "Koton";
            tisort1.Model = "V-Yaka";
            tisort1.Fiyat = 185;

            Tisort tisort2 = new Tisort();
            tisort2.Marka = "Zara";
            tisort2.Model = "Bol Kesim";
            tisort2.Fiyat = 175;

            Tisort tisort3 = new Tisort();
            tisort3.Marka = "PullBear";
            tisort3.Model = "Dar Kesim";
            tisort3.Fiyat = 115;

            //PANTOLON
            Pantolon pantolon1 = new Pantolon();
            pantolon1.Marka = "Mavi";
            pantolon1.Model = "Siyah Kot";
            pantolon1.Fiyat = 150;

            Pantolon pantolon2 = new Pantolon();
            pantolon2.Marka = "Leke";
            pantolon2.Model = "Mavi Kot";
            pantolon2.Fiyat = 180;

            Pantolon pantolon3 = new Pantolon();
            pantolon3.Marka = "LC Waikiki";
            pantolon3.Model = "Keten Kot";
            pantolon3.Fiyat = 195;

            //MONT
            Mont mont1 = new Mont();
            mont1.Marka = "DeFacto";
            mont1.Model = "Bomber Ceket";
            mont1.Fiyat = 250;

            Mont mont2 = new Mont();
            mont2.Marka = "H&M";
            mont2.Model = "Şişme Mont";
            mont2.Fiyat = 350;

            Mont mont3 = new Mont();
            mont3.Marka = "Berscka";
            mont3.Model = "Kapşonlu Mont";
            mont3.Fiyat = 150;


            kiyafetlerListesi.Add(ayakkabi1);
            kiyafetlerListesi.Add(tisort1);
            kiyafetlerListesi.Add(pantolon1);
            kiyafetlerListesi.Add(mont1);
            //
            kiyafetlerListesi.Add(ayakkabi2);
            kiyafetlerListesi.Add(tisort2);
            kiyafetlerListesi.Add(pantolon2);
            kiyafetlerListesi.Add(mont2);
            //
            kiyafetlerListesi.Add(ayakkabi3);
            kiyafetlerListesi.Add(tisort3);
            kiyafetlerListesi.Add(pantolon3);
            kiyafetlerListesi.Add(mont3);


            foreach (Kiyafetler kiyafet in kiyafetlerListesi)
            {
                if (kiyafet is Ayakkabi)
                {
                    Ayakkabi ayakkab1 = (Ayakkabi)kiyafet;
                    lstAyakkabi.Items.Add(ayakkab1);

                }
                else if (kiyafet is Mont)
                {
                    Mont m0nt = (Mont)kiyafet;
                    lstMont.Items.Add(m0nt);
                }
                else if (kiyafet is Pantolon)
                {
                    Pantolon pantol0n = (Pantolon)kiyafet;
                    lstPantolon.Items.Add(pantol0n);
                }

                else if (kiyafet is Tisort)
                {
                    Tisort tis0rt = (Tisort)kiyafet;
                    lstTshirt.Items.Add(tis0rt);
                }
            }
        }

        private void lstAyakkabi_DoubleClick(object sender, EventArgs e)
        {

            Ayakkabi seciliAyakkabi = (Ayakkabi)lstAyakkabi.SelectedItem;
            lstSepet.Items.Add(seciliAyakkabi);
            toplamPara += seciliAyakkabi.Fiyat;
            lblToplamTutar.Text = toplamPara.ToString("C2");
        }


        private void lstTshirt_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tisort seciliTisort = (Tisort)lstTshirt.SelectedItem;
            lstSepet.Items.Add(seciliTisort);
            toplamPara += seciliTisort.Fiyat;
            lblToplamTutar.Text = toplamPara.ToString("C2");



        }

        private void lstMont_SelectedIndexChanged(object sender, EventArgs e)
        {
            Mont seciliMont = (Mont)lstMont.SelectedItem;
            lstSepet.Items.Add(seciliMont);
            toplamPara += seciliMont.Fiyat;
            lblToplamTutar.Text = toplamPara.ToString("C2");
        }

        private void lstPantolon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pantolon seciliPantolon = (Pantolon)lstPantolon.SelectedItem;
            lstSepet.Items.Add(seciliPantolon);
            toplamPara += seciliPantolon.Fiyat;
            lblToplamTutar.Text = toplamPara.ToString("C2");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Kiyafetler kiyafet in lstSepet.Items) 
            {
                if (kiyafet is Ayakkabi)
                {
                    Ayakkabi ayakkabi = (Ayakkabi)kiyafet;
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = ayakkabi.Marka;
                    lvi.SubItems.Add("Ayakkabı");
                    lvi.SubItems.Add(DateTime.Now.ToString());
                    lvi.SubItems.Add(ayakkabi.Fiyat.ToString("C2"));
                    listView1.Items.Add(lvi);

                }
                
                else if (kiyafet is Tisort)
                {
                    Tisort tisort = (Tisort)kiyafet;
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = tisort.Marka;
                    lvi.SubItems.Add("Tişört");
                    lvi.SubItems.Add(DateTime.Now.ToString());
                    lvi.SubItems.Add(tisort.Fiyat.ToString("C"));
                    listView1.Items.Add(lvi);
                }

                else if (kiyafet is Pantolon)
                {
                    Pantolon pantolon = (Pantolon)kiyafet;
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = pantolon.Marka;
                    lvi.SubItems.Add("Pantolon");
                    lvi.SubItems.Add(DateTime.Now.ToString());
                    lvi.SubItems.Add(pantolon.Fiyat.ToString("C"));
                    listView1.Items.Add(lvi);


                }
                else if (kiyafet is Mont)
                {
                    Mont mont = (Mont)kiyafet;
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = mont.Marka;
                    lvi.SubItems.Add("Mont");
                    lvi.SubItems.Add(DateTime.Now.ToString());
                    lvi.SubItems.Add(mont.Fiyat.ToString("C"));
                    listView1.Items.Add(lvi);
                }
               
                
            }
            lstSepet.Items.Clear();

        }
    }
}
