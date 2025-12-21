using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SinavOgrenciSistemi.Models;

namespace SinavOgrenciSistemi
{
    public partial class FormAggregate : Form
    {
        dbSinavOgrenciEntities db = new dbSinavOgrenciEntities();

        public FormAggregate()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }

        // SORU 26: SINAV1 notlarının toplamı
        private void btnSinav1Toplam_Click(object sender, EventArgs e)
        {
            var toplam = db.TBLNOTLAR.Sum(n => n.SINAV1 ?? 0);
            MessageBox.Show($"SINAV1 Notları Toplamı: {toplam}", "Toplam");
        }

        // SORU 27: SINAV1 notlarının ortalaması
        private void btnSinav1Ortalama_Click(object sender, EventArgs e)
        {
            var ortalama = db.TBLNOTLAR.Where(n => n.SINAV1 != null).Average(n => n.SINAV1.Value);
            MessageBox.Show($"SINAV1 Notları Ortalaması: {ortalama:F2}", "Ortalama");
        }

        // SORU 28: Ortalama üzeri not alan öğrenciler
        private void btnOrtalamaUzeri_Click(object sender, EventArgs e)
        {
            var ortalama = db.TBLNOTLAR.Where(n => n.SINAV1 != null).Average(n => n.SINAV1.Value);

            var ogrenciler = db.TBLNOTLAR
                .Where(n => n.SINAV1 != null && n.SINAV1 > ortalama)
                .Select(n => new
                {
                    OgrenciAdi = n.TBLOGRENCI.OgrenciAd + " " + n.TBLOGRENCI.OgrenciSoyad,
                    n.SINAV1,
                    Ortalama = ortalama
                })
                .ToList();

            dataGridView1.DataSource = ogrenciler;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // MouseEnter ve MouseLeave event handler'ları
        private void btnSinav1Toplam_MouseEnter(object sender, EventArgs e)
        {
            btnSinav1Toplam.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void btnSinav1Toplam_MouseLeave(object sender, EventArgs e)
        {
            btnSinav1Toplam.BackColor = Color.FromArgb(52, 152, 219);
        }

        private void btnSinav1Ortalama_MouseEnter(object sender, EventArgs e)
        {
            btnSinav1Ortalama.BackColor = Color.FromArgb(39, 174, 96);
        }

        private void btnSinav1Ortalama_MouseLeave(object sender, EventArgs e)
        {
            btnSinav1Ortalama.BackColor = Color.FromArgb(46, 204, 113);
        }

        private void btnOrtalamaUzeri_MouseEnter(object sender, EventArgs e)
        {
            btnOrtalamaUzeri.BackColor = Color.FromArgb(142, 68, 173);
        }

        private void btnOrtalamaUzeri_MouseLeave(object sender, EventArgs e)
        {
            btnOrtalamaUzeri.BackColor = Color.FromArgb(155, 89, 182);
        }

        private void btnGeri_MouseEnter(object sender, EventArgs e)
        {
            btnGeri.BackColor = Color.FromArgb(127, 140, 141);
        }

        private void btnGeri_MouseLeave(object sender, EventArgs e)
        {
            btnGeri.BackColor = Color.FromArgb(149, 165, 166);
        }
    }
}

