using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04032025
{
    public partial class frmSayiTahmin : Form
    {
        int tahminEdilecekSayi;
        int hak;
        public frmSayiTahmin()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtTahmin.Text);
            if (sayi > tahminEdilecekSayi)
            {
                lblSonuc.Text = "Daha küçük bir sayı giriniz.";
                hak = hak - 1;
            }
            else if (sayi < tahminEdilecekSayi)
            {
                lblSonuc.Text = "Daha büyük bir sayı giriniz.";
                hak = hak - 1;
            }
            else
            {
                lblSonuc.Text = "Tebrikler bildiniz";
            }
            lblHak.Text = "Kalan Hak : " + hak;
            if (hak == 0)
            {
                lblSonuc.Text = "Game Over";
                btnTahmin.Enabled = false;
                btnBaslat.Visible = true;
            }

        }

        private void frmSayiTahmin_Load(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            Random random = new Random();
            tahminEdilecekSayi = random.Next(100);
            lblSonuc.Text = "Oyun başladı. 0 ile 100 arasında bir sayı tahmin ediniz.";
            hak = 5;
            btnTahmin.Enabled = true;
            btnBaslat.Visible = false;
            lblHak.Text = "Kalan Hak : " + hak;
        }
    }
}
