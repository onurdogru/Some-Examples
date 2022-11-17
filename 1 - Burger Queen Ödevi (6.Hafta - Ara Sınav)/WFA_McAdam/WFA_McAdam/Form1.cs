using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_McAdam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //GLOBAL AREA//

        

        decimal güncelcash = 0.00m;

        //
        decimal ketcapPara = 2.00m;
        decimal mayonezPara = 2.00m;
        decimal ranchPara = 2.00m;
        decimal aciSosPara = 2.00m;
        decimal buffaloPara = 2.00m;
        decimal hardalPara = 2.00m;

        //
        decimal ortaBoy = 3.00m;
        decimal büyükBoy = 5.00m;

        //

        decimal voper = 25.00m;
        decimal bikking = 35.00m;
        decimal lavukburger = 20.00m;

        //

        string ortaRadyo;
        string buyukRadyo;



        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMENU.Items.Add("Italian Burger Menu 25 €");
            cmbMENU.Items.Add("Big Queen Menu 35 €");
            cmbMENU.Items.Add("Chicken Menu 20 €");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ketcap = checkBox1.Checked;
            bool mayonez = checkBox2.Checked;
            bool ranch = checkBox3.Checked;
            bool buffalo = checkBox4.Checked;
            bool aciSos = checkBox5.Checked;
            bool hardal = checkBox6.Checked;

            bool ortanca = radioButton2.Checked;
            bool buyukOlan = radioButton3.Checked;

            decimal bolbol = numericUpDown1.Value;


            if (ketcap)
            {
                güncelcash = güncelcash + ketcapPara;
                listBox1.Items.Add("Ketchup 2 €");
                label13.Text = güncelcash.ToString();

            }

            if (mayonez)
            {
                güncelcash = güncelcash + mayonezPara;
                listBox1.Items.Add("Mayonnaise 2 €");
                label13.Text = güncelcash.ToString();
            }

            if (ranch)
            {
                güncelcash = güncelcash + ranchPara;
                listBox1.Items.Add("Ranch Sauce 2 €");
                label13.Text = güncelcash.ToString();
            }

            if (buffalo)
            {
                güncelcash = güncelcash + buffaloPara;
                listBox1.Items.Add("Buffalo Sauce 2 €");
                label13.Text = güncelcash.ToString();
            }
            if (aciSos)
            {
                güncelcash = güncelcash + aciSosPara;
                listBox1.Items.Add("Hot Sauce 2 €");
                label13.Text = güncelcash.ToString();
            }

            if(hardal)
            {
                güncelcash = güncelcash + hardalPara;
                listBox1.Items.Add("Mustard 2 €");
                label13.Text = güncelcash.ToString();
            }

            
            if (ortanca)
            {
                güncelcash = güncelcash + ortaBoy;
                listBox1.Items.Add("Medium Size Menu 3 €");
                label13.Text = güncelcash.ToString();
            }

            if (buyukOlan)
            {
                güncelcash = güncelcash + büyükBoy;
                listBox1.Items.Add("Big Size Menu 5 €");
                label13.Text = güncelcash.ToString();
            }

            switch (cmbMENU.Text)
            {
                case "Italian Burger Menu 25 €":  //yada (cmbMenu.Text == "Whooper")
                    güncelcash = güncelcash + voper;
                    listBox1.Items.Add("Italian Burger Menu 25 €");
                    label13.Text = güncelcash.ToString();

                    break;

                case "Big Queen Menu 35 €":
                    güncelcash = güncelcash + bikking;
                    listBox1.Items.Add("Big Queen Menu 35 €");
                    label13.Text = güncelcash.ToString();

                    break;

                case "Chicken Menu 20 €":
                    güncelcash = güncelcash + lavukburger;
                    listBox1.Items.Add("Chicken Menu 20 €");
                    label13.Text = (güncelcash.ToString());

                    break;

            }

            güncelcash = güncelcash * bolbol;
            listBox1.Items.Add("Your order has been received");
            listBox1.Items.Add("----------------------------");
            label13.Text = güncelcash.ToString();
            label14.Text = güncelcash.ToString();
            
             
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool ketcap = checkBox1.Checked;
            bool mayonez = checkBox2.Checked;
            bool ranch = checkBox3.Checked;
            bool buffalo = checkBox4.Checked;
            bool aciSos = checkBox5.Checked;
            bool hardal = checkBox6.Checked;

            bool ortanca = radioButton2.Checked;
            bool buyukOlan = radioButton3.Checked;

            decimal bolbol = numericUpDown1.Value;

            listBox2.Items.Add("Your bill is ready");
            listBox2.Items.Add("Totally:" + label13.Text + "€");
            listBox2.Items.Add("Enjoy! :)");


            if (ketcap)
            {
                
                listBox2.Items.Add("Ketchup 2 €");
               

            }

            if (mayonez)
            {
                
                listBox2.Items.Add("Mayonnaise 2 €");
          
            }

            if (ranch)
            {
               
                listBox2.Items.Add("Ranch Sauce 2 €");
               
            }

            if (buffalo)
            {
                
                listBox2.Items.Add("Buffalo Sauce 2 €");
            
            }
            if (aciSos)
            {

                listBox2.Items.Add("Hot Sauce 2 €");

            }

            if (hardal)
            {

                listBox2.Items.Add("Mustard 2 €");

            }


            if (ortanca)
            {

                listBox2.Items.Add("Medium Size Menu 3 €");

            }

            if (buyukOlan)
            {

                listBox2.Items.Add("Big Size Menu 5 €");

            }

            switch (cmbMENU.Text)
            {
                case "Italian Burger Menu 25 €":

                    listBox2.Items.Add("Italian Burger Menu 25 €");


                    break;

                case "Big Queen Menu 35 €":

                    listBox2.Items.Add("Big Queen Menu 35 €");


                    break;

                case "Chicken Menu 20 €":

                    listBox2.Items.Add("Chicken Menu 20 €");


                    break;

            }

            listBox2.Items.Add("----------------------------");
            //
            listBox1.Items.Clear();
            cmbMENU.Items.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;

            
 
  
            DialogResult dr= MessageBox.Show("Total Order Quantity :  " + numericUpDown1.Value +""+ "  Total Order Price : " + label13.Text + "€" + "    Do you want to complete your orders?", "", MessageBoxButtons.YesNo);

            label13.Text = "0 €";

            if (dr == DialogResult.Yes)
            {
                DialogResult dg = MessageBox.Show("Will you make your payment by credit card?", "", MessageBoxButtons.YesNo);

                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show("Please Wait for Bank Screen...");
                }

                else if (dg == DialogResult.No)
                {
                    MessageBox.Show("Please Prepare Your Money");
                }
            }
          

        }

        private void label14_Click(object sender, EventArgs e)
        {
            label14.Text = label13.Text;
        }
    }
}
