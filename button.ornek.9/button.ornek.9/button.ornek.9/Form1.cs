using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._9
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

        private void btnToplam_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            sonuc = sayi1 + sayi2;

            lblSonuc.Text=sonuc.ToString();
              

        }

        private void lblSayi1_Click(object sender, EventArgs e)
        {

        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            sonuc = sayi1 - sayi2;

            lblSonuc.Text = sonuc.ToString();

        }

        private void lblSonuc_Click(object sender, EventArgs e)
        {

        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            sonuc = sayi1 * sayi2;

            lblSonuc.Text = sonuc.ToString();
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc;
            sayi1 = Convert.ToSingle(txtSayi1.Text);
            sayi2 = Convert.ToSingle(txtSayi2.Text);
            sonuc = sayi1 / sayi2;

            lblSonuc.Text = sonuc.ToString();
        }
    }
}
