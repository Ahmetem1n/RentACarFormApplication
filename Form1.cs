using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarFormApplication
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
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void subeTanimlamaMenu_Click(object sender, EventArgs e)
        {
            Subeler subeler = new Subeler();
            subeler.Show();
        }

        private void kullaniciTanimlamaMenu_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.Show();
        }

        private void aracTanimlamaMenu_Click(object sender, EventArgs e)
        {
            AracEkleDuzenle aracEkleDuzenle = new AracEkleDuzenle();
            aracEkleDuzenle.Show();
        }

        private void musteriTanimlamaMenu_Click(object sender, EventArgs e)
        {
            MusteriEkleDuzenle musteriEkleDuzenle = new MusteriEkleDuzenle();
            musteriEkleDuzenle.Show();
        }

        private void aracRezerveEtMenu_Click(object sender, EventArgs e)
        {
            RezervasyonEkleDuzenle rezervasyonEkleDuzenle = new RezervasyonEkleDuzenle();
            rezervasyonEkleDuzenle.Show();
        }

        private void aracKiralaMenu_Click(object sender, EventArgs e)
        {
            AracKirala aracKirala = new AracKirala();
            aracKirala.Show();
        }

        private void araciBakimaAlMenu_Click(object sender, EventArgs e)
        {
            AraciBakimaAl araciBakimaAl = new AraciBakimaAl();
            araciBakimaAl.Show();
        }

        private void araclarMenu_Click(object sender, EventArgs e)
        {
            Araclar araclar = new Araclar();
            araclar.Show();
        }

        private void musterilerMenu_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
        }

        private void rezervasyonlarMenu_Click(object sender, EventArgs e)
        {
            Rezervasyonlar rezervasyonlar = new Rezervasyonlar();
            rezervasyonlar.Show();
        }

        private void musteriIstatistikleriMenu_Click(object sender, EventArgs e)
        {
            MusteriIstatistikleri musteriIstatistikleri = new MusteriIstatistikleri();
            musteriIstatistikleri.Show();
        }

        private void aracIstatistikleriMenu_Click(object sender, EventArgs e)
        {
            AracIstatistikleri aracIstatistikleri = new AracIstatistikleri();
            aracIstatistikleri.Show();
        }

        private void bakimIstatistikleriMenu_Click(object sender, EventArgs e)
        {
            BakimIstatistikleri bakimIstatistikleri = new BakimIstatistikleri();
            bakimIstatistikleri.Show();
        }

        private void teslimataGoreAraclarMenu_Click(object sender, EventArgs e)
        {
            TeslimataGoreAraclar teslimataGoreAraclar = new TeslimataGoreAraclar();
            teslimataGoreAraclar.Show();
        }
    }
}
