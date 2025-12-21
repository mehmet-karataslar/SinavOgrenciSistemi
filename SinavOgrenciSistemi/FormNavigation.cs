using System;
using System.Drawing;
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

        // MouseEnter ve MouseLeave event handler'ları
        private void btnNotListele_MouseEnter(object sender, EventArgs e)
        {
            btnNotListele.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void btnNotListele_MouseLeave(object sender, EventArgs e)
        {
            btnNotListele.BackColor = Color.FromArgb(52, 152, 219);
        }

        private void btnNotListeleDersAdi_MouseEnter(object sender, EventArgs e)
        {
            btnNotListeleDersAdi.BackColor = Color.FromArgb(39, 174, 96);
        }

        private void btnNotListeleDersAdi_MouseLeave(object sender, EventArgs e)
        {
            btnNotListeleDersAdi.BackColor = Color.FromArgb(46, 204, 113);
        }

        private void btnAdSoyadBirlestir_MouseEnter(object sender, EventArgs e)
        {
            btnAdSoyadBirlestir.BackColor = Color.FromArgb(142, 68, 173);
        }

        private void btnAdSoyadBirlestir_MouseLeave(object sender, EventArgs e)
        {
            btnAdSoyadBirlestir.BackColor = Color.FromArgb(155, 89, 182);
        }

        private void btnOgrenciKulup_MouseEnter(object sender, EventArgs e)
        {
            btnOgrenciKulup.BackColor = Color.FromArgb(243, 156, 18);
        }

        private void btnOgrenciKulup_MouseLeave(object sender, EventArgs e)
        {
            btnOgrenciKulup.BackColor = Color.FromArgb(241, 196, 15);
        }

        private void btnUcTabloJoin_MouseEnter(object sender, EventArgs e)
        {
            btnUcTabloJoin.BackColor = Color.FromArgb(211, 84, 0);
        }

        private void btnUcTabloJoin_MouseLeave(object sender, EventArgs e)
        {
            btnUcTabloJoin.BackColor = Color.FromArgb(230, 126, 34);
        }

        private void btnOgrenciNotlari_MouseEnter(object sender, EventArgs e)
        {
            btnOgrenciNotlari.BackColor = Color.FromArgb(22, 160, 133);
        }

        private void btnOgrenciNotlari_MouseLeave(object sender, EventArgs e)
        {
            btnOgrenciNotlari.BackColor = Color.FromArgb(26, 188, 156);
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

