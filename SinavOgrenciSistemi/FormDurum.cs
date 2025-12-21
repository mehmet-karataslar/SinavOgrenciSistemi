using System;
using System.Linq;
using System.Windows.Forms;
using SinavOgrenciSistemi.Models;

namespace SinavOgrenciSistemi
{
    public partial class FormDurum : Form
    {
        dbSinavOgrenciEntities db = new dbSinavOgrenciEntities();

        public FormDurum()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }

        // SORU 29: Anonim tip ile durum listesi
        private void btnDurumListesi_Click(object sender, EventArgs e)
        {
            var liste = db.TBLNOTLAR
                .Select(n => new
                {
                    Ogrenci = n.TBLOGRENCI.OgrenciAd + " " + n.TBLOGRENCI.OgrenciSoyad,
                    n.ORTALAMA,
                    Durum = n.DURUM == true ? "GEÇTİ" : "KALDI"
                })
                .ToList();
            dataGridView1.DataSource = liste;
            
            // Ana DataGridView'i göster, SplitContainer'ı gizle
            dataGridView1.Visible = true;
            splitContainer1.Visible = false;
        }

        // SORU 30: Geçen ve kalan öğrencileri ayrı listeleme
        private void btnGecenKalan_Click(object sender, EventArgs e)
        {
            // Geçen öğrenciler
            var gecenler = db.TBLNOTLAR
                .Where(n => n.DURUM == true)
                .Select(n => new
                {
                    Ogrenci = n.TBLOGRENCI.OgrenciAd + " " + n.TBLOGRENCI.OgrenciSoyad,
                    DersAdi = n.TBLDERSLER.DERSAD,
                    n.ORTALAMA
                })
                .ToList();

            // Kalan öğrenciler
            var kalanlar = db.TBLNOTLAR
                .Where(n => n.DURUM == false)
                .Select(n => new
                {
                    Ogrenci = n.TBLOGRENCI.OgrenciAd + " " + n.TBLOGRENCI.OgrenciSoyad,
                    DersAdi = n.TBLDERSLER.DERSAD,
                    n.ORTALAMA
                })
                .ToList();

            // İki ayrı DataGridView'e bağlama
            dgvGecenler.DataSource = gecenler;
            dgvKalanlar.DataSource = kalanlar;
            
            // SplitContainer'ı göster, ana DataGridView'i gizle
            dataGridView1.Visible = false;
            splitContainer1.Visible = true;
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

