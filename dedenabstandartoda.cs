using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tatil_Rezervasyon_Otomasyonu
{
    public partial class dedenabstandartoda : Form
    {
        public dedenabstandartoda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secimyap sc = new secimyap();
            this.Hide();
            sc.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            otelDedeman od = new otelDedeman();
            this.Hide();
            od.Show();
        }

        private void otellerButton_Click(object sender, EventArgs e)
        {
            OtelAnasayfa oa = new OtelAnasayfa();
            this.Hide();
            oa.Show();
        }

        private void turlarButton_Click(object sender, EventArgs e)
        {
            TurAnaSayfa ta = new TurAnaSayfa();
            this.Hide();
            ta.Show();
        }

        private void kampanyalarButton_Click(object sender, EventArgs e)
        {
            kampanya ka = new kampanya();
            this.Hide();
            ka.Show();
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            GirişSayfaları gs = new GirişSayfaları();
            this.Hide();
            gs.Show();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            Anasayfa an = new Anasayfa();
            this.Hide();
            an.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Anasayfa an = new Anasayfa();
            this.Hide();
            an.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Açılabilir pencere\r\nBalkon\r\nBuzdolabı\r\nDuş\r\nDüz ekran TV\r\nElektrik su ısıtıcısı\r\nKablo TV\r\nKahve Makinesi\r\nKlima\r\nMerkezi ısıtma\r\nMikrodalga Fırın\r\nOda Kasası\r\nSaç kurutma makinası\r\nTelefon\r\nTelevizyon\r\nUydu TV\r\nWi-Fi\r\nÇalışma Masası\r\nÜcretsiz WiFi (odada)\r\nÜtü Masası");

        }
    }
}
