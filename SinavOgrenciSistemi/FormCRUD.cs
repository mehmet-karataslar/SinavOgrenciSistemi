using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using SinavOgrenciSistemi.Models;

namespace SinavOgrenciSistemi
{
    public partial class FormCRUD : Form
    {
        dbSinavOgrenciEntities db = new dbSinavOgrenciEntities();

        public FormCRUD()
        {
            InitializeComponent();
        }

        private void FormCRUD_Load(object sender, EventArgs e)
        {
            // ComboBox'ları doldur
            cmbKulup.DataSource = db.TBLKULUPLER.ToList();
            cmbKulup.ValueMember = "KULUPID";
            cmbKulup.DisplayMember = "KULUPAD";
            
            OgrenciListesiGuncelle();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }

        // SORU 13: Öğrenci ekleme
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOgrenciAd.Text) || string.IsNullOrEmpty(txtOgrenciSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad alanları zorunludur!");
                return;
            }

            TBLOGRENCI yeniOgrenci = new TBLOGRENCI
            {
                OgrenciAd = txtOgrenciAd.Text,
                OgrenciSoyad = txtOgrenciSoyad.Text,
                OgrenciFoto = string.IsNullOrEmpty(txtFotoYol.Text) ? null : txtFotoYol.Text,
                KulupID = cmbKulup.SelectedValue != null ? (int?)Convert.ToInt32(cmbKulup.SelectedValue) : null
            };

            db.TBLOGRENCI.Add(yeniOgrenci);
            db.SaveChanges();

            MessageBox.Show("Öğrenci başarıyla eklendi!");
            OgrenciListesiGuncelle();
            Temizle();
        }

        // SORU 14: DataGridView otomatik güncelleme
        private void OgrenciListesiGuncelle()
        {
            dataGridView1.DataSource = db.TBLOGRENCI
                .Select(o => new
                {
                    o.OgrenciID,
                    o.OgrenciAd,
                    o.OgrenciSoyad,
                    KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüp Yok"
                })
                .ToList();
        }

        // SORU 15: Öğrenci silme
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOgrenciID.Text))
            {
                MessageBox.Show("Öğrenci ID giriniz!");
                return;
            }

            int ogrenciID;
            if (!int.TryParse(txtOgrenciID.Text, out ogrenciID))
            {
                MessageBox.Show("Geçerli bir ID giriniz!");
                return;
            }

            var silinecek = db.TBLOGRENCI.Find(ogrenciID);

            if (silinecek == null)
            {
                MessageBox.Show("Bu ID'ye sahip öğrenci bulunamadı!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Önce öğrencinin notlarını sil
            var notlar = db.TBLNOTLAR.Where(n => n.OGRENCI == ogrenciID).ToList();
            db.TBLNOTLAR.RemoveRange(notlar);

            db.TBLOGRENCI.Remove(silinecek);
            db.SaveChanges();

            MessageBox.Show("Öğrenci başarıyla silindi!");
            OgrenciListesiGuncelle();
            Temizle();
        }

        // SORU 16: Öğrenci güncelleme
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOgrenciID.Text))
            {
                MessageBox.Show("Öğrenci ID giriniz!");
                return;
            }

            int ogrenciID = Convert.ToInt32(txtOgrenciID.Text);

            // SORU 17: Güncelleme öncesi varlık kontrolü
            if (!OgrenciVarMi(ogrenciID))
            {
                MessageBox.Show("Bu ID'ye sahip öğrenci bulunamadı!");
                return;
            }

            var ogrenci = db.TBLOGRENCI.Find(ogrenciID);
            ogrenci.OgrenciAd = txtOgrenciAd.Text;
            ogrenci.OgrenciSoyad = txtOgrenciSoyad.Text;
            ogrenci.OgrenciFoto = txtFotoYol.Text;
            ogrenci.KulupID = cmbKulup.SelectedValue != null ? (int?)Convert.ToInt32(cmbKulup.SelectedValue) : null;

            db.SaveChanges();

            MessageBox.Show("Öğrenci başarıyla güncellendi!");
            OgrenciListesiGuncelle();
        }

        // SORU 17: Güncelleme öncesi varlık kontrolü
        private bool OgrenciVarMi(int ogrenciID)
        {
            return db.TBLOGRENCI.Any(o => o.OgrenciID == ogrenciID);
        }

        // SORU 18: EntityState gösterimi
        private void btnEntityStateGoster_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOgrenciID.Text))
            {
                MessageBox.Show("Öğrenci ID giriniz!");
                return;
            }

            int ogrenciID = Convert.ToInt32(txtOgrenciID.Text);
            var ogrenci = db.TBLOGRENCI.Find(ogrenciID);

            if (ogrenci == null)
            {
                MessageBox.Show("Öğrenci bulunamadı!");
                return;
            }

            var state = db.Entry(ogrenci).State;
            string mesaj = $"EntityState: {state}\n\n";
            mesaj += "1. Unchanged: Değişmemiş kayıt\n";
            mesaj += "2. Modified: Değiştirilmiş kayıt (UPDATE)\n";
            mesaj += "3. Added: Yeni eklenen kayıt (INSERT)\n";
            mesaj += "4. Deleted: Silinmiş kayıt (DELETE)\n";
            mesaj += "5. Detached: Bağlantısız entity";

            MessageBox.Show(mesaj, "EntityState Açıklaması");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtOgrenciID.Text = row.Cells["OgrenciID"].Value.ToString();
                txtOgrenciAd.Text = row.Cells["OgrenciAd"].Value.ToString();
                txtOgrenciSoyad.Text = row.Cells["OgrenciSoyad"].Value.ToString();
            }
        }

        private void Temizle()
        {
            txtOgrenciID.Clear();
            txtOgrenciAd.Clear();
            txtOgrenciSoyad.Clear();
            txtFotoYol.Clear();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

