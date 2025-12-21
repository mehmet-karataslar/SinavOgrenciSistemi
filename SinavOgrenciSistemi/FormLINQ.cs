using System;
using System.Drawing;
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
                    o.OgrenciSoyad,
                    KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüpsüz"
                })
                .ToList();

            dataGridView1.DataSource = sonuc;
        }

        // SORU 20: Ada göre artan sıralama
        private void btnArtanSirala_Click(object sender, EventArgs e)
        {
            var ogrenciler = db.TBLOGRENCI
                .OrderBy(o => o.OgrenciAd)
                .Select(o => new
                {
                    o.OgrenciID,
                    o.OgrenciAd,
                    o.OgrenciSoyad,
                    KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüpsüz"
                })
                .ToList();
            dataGridView1.DataSource = ogrenciler;
        }

        // SORU 21: Soyada göre azalan sıralama
        private void btnAzalanSirala_Click(object sender, EventArgs e)
        {
            var ogrenciler = db.TBLOGRENCI
                .OrderByDescending(o => o.OgrenciSoyad)
                .Select(o => new
                {
                    o.OgrenciID,
                    o.OgrenciAd,
                    o.OgrenciSoyad,
                    KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüpsüz"
                })
                .ToList();
            dataGridView1.DataSource = ogrenciler;
        }

        // SORU 22: İlk 3 öğrenci (Take)
        private void btnIlkUc_Click(object sender, EventArgs e)
        {
            var ogrenciler = db.TBLOGRENCI
                .OrderBy(o => o.OgrenciID)
                .Take(3)
                .Select(o => new
                {
                    o.OgrenciID,
                    o.OgrenciAd,
                    o.OgrenciSoyad,
                    KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüpsüz"
                })
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
                    KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüpsüz"
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
                    o.OgrenciSoyad,
                    KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüpsüz"
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
                    o.OgrenciSoyad,
                    KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüpsüz"
                })
                .ToList();
            dataGridView1.DataSource = ogrenciler;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // MouseEnter ve MouseLeave event handler'ları
        private void btnGeri_MouseEnter(object sender, EventArgs e)
        {
            btnGeri.BackColor = Color.FromArgb(127, 140, 141);
        }

        private void btnGeri_MouseLeave(object sender, EventArgs e)
        {
            btnGeri.BackColor = Color.FromArgb(149, 165, 166);
        }

        private void btnArtanSirala_MouseEnter(object sender, EventArgs e)
        {
            btnArtanSirala.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void btnArtanSirala_MouseLeave(object sender, EventArgs e)
        {
            btnArtanSirala.BackColor = Color.FromArgb(52, 152, 219);
        }

        private void btnAzalanSirala_MouseEnter(object sender, EventArgs e)
        {
            btnAzalanSirala.BackColor = Color.FromArgb(39, 174, 96);
        }

        private void btnAzalanSirala_MouseLeave(object sender, EventArgs e)
        {
            btnAzalanSirala.BackColor = Color.FromArgb(46, 204, 113);
        }

        private void btnIlkUc_MouseEnter(object sender, EventArgs e)
        {
            btnIlkUc.BackColor = Color.FromArgb(142, 68, 173);
        }

        private void btnIlkUc_MouseLeave(object sender, EventArgs e)
        {
            btnIlkUc.BackColor = Color.FromArgb(155, 89, 182);
        }

        private void btnIdIleGetir_MouseEnter(object sender, EventArgs e)
        {
            btnIdIleGetir.BackColor = Color.FromArgb(211, 84, 0);
        }

        private void btnIdIleGetir_MouseLeave(object sender, EventArgs e)
        {
            btnIdIleGetir.BackColor = Color.FromArgb(230, 126, 34);
        }

        private void btnAileBaslayan_MouseEnter(object sender, EventArgs e)
        {
            btnAileBaslayan.BackColor = Color.FromArgb(22, 160, 133);
        }

        private void btnAileBaslayan_MouseLeave(object sender, EventArgs e)
        {
            btnAileBaslayan.BackColor = Color.FromArgb(26, 188, 156);
        }

        private void btnNileBiten_MouseEnter(object sender, EventArgs e)
        {
            btnNileBiten.BackColor = Color.FromArgb(192, 57, 43);
        }

        private void btnNileBiten_MouseLeave(object sender, EventArgs e)
        {
            btnNileBiten.BackColor = Color.FromArgb(231, 76, 60);
        }
    }
}

