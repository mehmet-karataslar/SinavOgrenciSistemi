using System;
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
    }
}

