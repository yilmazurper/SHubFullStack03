using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEgitimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //bu metot acilirken calisir
            for (int i = 0; i < 50; i++)
            {
                domainUpDown1.Items.Add(FontFamily.Families[i].Name);
            }
            comboBox1.DataSource = domainUpDown1.Items;
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked )
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = "Butona Tiklandi";

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtkullanici.Text == "Admin" && txtsifre.Text=="adm123")
            {
                label1.Text = "Hosgeldin Kral"; //label1 'e bunu yazdir
                groupBox1.Visible = false; //KULLANICI GIRIS FORMUNU GIZLE
            }
            else
            {
                MessageBox.Show("Giris Basarisiz"); // kisayolu mbox olan tab: ekrana mesaj vermemizi saglar
                groupBox1.Visible = false;

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) // ekrandaki numericupdown1 iismli nesenin degeri degistiginde calisacak olan metot
        {
            label1.Font= new Font(comboBox1.SelectedValue.ToString(), (float)numericUpDown1.Value); //ekranda labrl1 isimli elemanin nesnenin font degerini yeni fontla degistir. yeni fontu yine ekranda icine sistemdeki fontlari yuklwdigimiz combobox1 isimli nesnede secili olan fontu kullan, 2. parametrede ise bu yazi fontunun boyutunu numeric updown1 nesnesindeki secilen degerden alarak ayarla dedik 
        }

      
    }
}
