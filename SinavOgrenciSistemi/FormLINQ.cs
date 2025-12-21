using System;
using System.Linq;
using System.Windows.Forms;
using SinavOgrenciSistemi.Models;

namespace SinavOgrenciSistemi
{
    public partial class FormLINQ : Form
    {
        dbSinavOgrenciEntities db = new dbSinavOgrenciEntities();

        public FormLINQ()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }

        // SORU 19: TextChanged ile filtreleme
        private void txtOgrenciAd_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtOgrenciAd.Text;

            var sonuc = db.TBLOGRENCI
                .Where(o => o.OgrenciAd.Contains(aramaMetni))
                .Select(o => new
                {
                    o.OgrenciID,
                    o.OgrenciAd,
                    o.OgrenciSoyad
                })
                .ToList();

            dataGridView1.DataSource = sonuc;
        }

        // SORU 20: Ada göre artan sıralama
        private void btnArtanSirala_Click(object sender, EventArgs e)
        {
            var ogrenciler = db.TBLOGRENCI
                .OrderBy(o => o.OgrenciAd)
                .ToList();
            dataGridView1.DataSource = ogrenciler;
        }

        // SORU 21: Soyada göre azalan sıralama
        private void btnAzalanSirala_Click(object sender, EventArgs e)
        {
            var ogrenciler = db.TBLOGRENCI
                .OrderByDescending(o => o.OgrenciSoyad)
                .ToList();
            dataGridView1.DataSource = ogrenciler;
        }

        // SORU 22: İlk 3 öğrenci (Take)
        private void btnIlkUc_Click(object sender, EventArgs e)
        {
            var ogrenciler = db.TBLOGRENCI
                .OrderBy(o => o.OgrenciID)
                .Take(3)
                .ToList();
            dataGridView1.DataSource = ogrenciler;
        }

        // SORU 23: ID ile öğrenci getirme
        private void btnIdIleGetir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOgrenciID.Text))
            {
                MessageBox.Show("Öğrenci ID giriniz!");
                return;
            }

            int aramaID = Convert.ToInt32(txtOgrenciID.Text);
            var ogrenci = db.TBLOGRENCI
                .Where(o => o.OgrenciID == aramaID)
                .Select(o => new
                {
                    o.OgrenciID,
                    o.OgrenciAd,
                    o.OgrenciSoyad,
                    KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüp Yok"
                })
                .ToList();
            dataGridView1.DataSource = ogrenci;
        }

        // SORU 24: "A" ile başlayan öğrenciler
        private void btnAileBaslayan_Click(object sender, EventArgs e)
        {
            var ogrenciler = db.TBLOGRENCI
                .Where(o => o.OgrenciAd.StartsWith("A"))
                .Select(o => new
                {
                    o.OgrenciID,
                    o.OgrenciAd,
                    o.OgrenciSoyad
                })
                .ToList();
            dataGridView1.DataSource = ogrenciler;
        }

        // SORU 25: "n" ile biten öğrenciler
        private void btnNileBiten_Click(object sender, EventArgs e)
        {
            var ogrenciler = db.TBLOGRENCI
                .Where(o => o.OgrenciAd.EndsWith("n"))
                .Select(o => new
                {
                    o.OgrenciID,
                    o.OgrenciAd,
                    o.OgrenciSoyad
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

