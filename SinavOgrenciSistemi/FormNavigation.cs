using System;
using System.Linq;
using System.Windows.Forms;
using SinavOgrenciSistemi.Models;

namespace SinavOgrenciSistemi
{
    public partial class FormNavigation : Form
    {
        dbSinavOgrenciEntities db = new dbSinavOgrenciEntities();

        public FormNavigation()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }

        // SORU 6: TBLNOTLAR anonim tip ile listeleme
        private void btnNotListele_Click(object sender, EventArgs e)
        {
            var notlar = db.TBLNOTLAR
                .Select(n => new
                {
                    n.NOTID,
                    n.DERS,
                    n.SINAV1,
                    n.SINAV2,
                    n.SINAV3,
                    OgrenciAdi = n.TBLOGRENCI.OgrenciAd
                })
                .ToList();
            dataGridView1.DataSource = notlar;
        }

        // SORU 7: Navigation property ile ders adı getirme
        private void btnNotListeleDersAdi_Click(object sender, EventArgs e)
        {
            var notlar = db.TBLNOTLAR
                .Select(n => new
                {
                    n.NOTID,
                    DersAdi = n.TBLDERSLER.DERSAD,
                    n.SINAV1,
                    n.SINAV2,
                    n.SINAV3,
                    OgrenciAdi = n.TBLOGRENCI.OgrenciAd
                })
                .ToList();
            dataGridView1.DataSource = notlar;
        }

        // SORU 9: Ad + Soyad birleştirme
        private void btnAdSoyadBirlestir_Click(object sender, EventArgs e)
        {
            var ogrenciler = db.TBLOGRENCI
                .Select(o => new
                {
                    o.OgrenciID,
                    AdSoyad = o.OgrenciAd + " " + o.OgrenciSoyad,
                    o.KulupID
                })
                .ToList();
            dataGridView1.DataSource = ogrenciler;
        }

        // SORU 10: Öğrenci - Kulüp JOIN
        private void btnOgrenciKulup_Click(object sender, EventArgs e)
        {
            var liste = db.TBLOGRENCI
                .Select(o => new
                {
                    AdSoyad = o.OgrenciAd + " " + o.OgrenciSoyad,
                    KulupAdi = o.TBLKULUPLER.KULUPAD
                })
                .ToList();
            dataGridView1.DataSource = liste;
        }

        // SORU 11: Üç tablo birleştirme
        private void btnUcTabloJoin_Click(object sender, EventArgs e)
        {
            var liste = db.TBLNOTLAR
                .Select(n => new
                {
                    OgrenciAdi = n.TBLOGRENCI.OgrenciAd + " " + n.TBLOGRENCI.OgrenciSoyad,
                    DersAdi = n.TBLDERSLER.DERSAD,
                    n.ORTALAMA,
                    Durum = n.DURUM == true ? "GEÇTİ" : "KALDI"
                })
                .ToList();
            dataGridView1.DataSource = liste;
        }

        // SORU 12: Öğrencinin tüm notlarını navigation ile getirme
        private void btnOgrenciNotlari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOgrenciID.Text))
            {
                MessageBox.Show("Öğrenci ID giriniz!");
                return;
            }

            int ogrenciID = Convert.ToInt32(txtOgrenciID.Text);
            var ogrenci = db.TBLOGRENCI.Find(ogrenciID);
            
            if (ogrenci != null)
            {
                var notlar = ogrenci.TBLNOTLAR
                    .Select(n => new
                    {
                        DersAdi = n.TBLDERSLER.DERSAD,
                        n.SINAV1,
                        n.SINAV2,
                        n.SINAV3,
                        n.ORTALAMA,
                        Durum = n.DURUM == true ? "GEÇTİ" : "KALDI"
                    })
                    .ToList();
                dataGridView1.DataSource = notlar;
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı!");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

