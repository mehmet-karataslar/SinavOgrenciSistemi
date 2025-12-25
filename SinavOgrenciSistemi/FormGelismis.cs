using System;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using SinavOgrenciSistemi.DTOs;
using SinavOgrenciSistemi.Models;

namespace SinavOgrenciSistemi
{
    public partial class FormGelismis : Form
    {
        dbSinavOgrenciEntities db = new dbSinavOgrenciEntities();

        public FormGelismis()
        {
            InitializeComponent();
        }

        private void FormGelismis_Load(object sender, EventArgs e)
        {
            cmbKulup.DataSource = db.TBLKULUPLER.ToList();
            cmbKulup.ValueMember = "KULUPID";
            cmbKulup.DisplayMember = "KULUPAD";

            cmbDers.DataSource = db.TBLDERSLER.ToList();
            cmbDers.ValueMember = "DERSID";
            cmbDers.DisplayMember = "DERSAD";
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }

        // SORU 30: SP ile kontrollü not ekleme
        private void btnSPNotEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int ogrenciID = Convert.ToInt32(txtOgrenciID.Text);
                int dersID = Convert.ToInt32(cmbDers.SelectedValue);
                int sinav1 = Convert.ToInt32(txtSinav1.Text);
                int sinav2 = Convert.ToInt32(txtSinav2.Text);
                int sinav3 = Convert.ToInt32(txtSinav3.Text);

                db.Database.ExecuteSqlCommand(
                    "EXEC sp_NotEkleKontrollu @OgrenciID, @DersID, @Sinav1, @Sinav2, @Sinav3",
                    new SqlParameter("@OgrenciID", ogrenciID),
                    new SqlParameter("@DersID", dersID),
                    new SqlParameter("@Sinav1", sinav1),
                    new SqlParameter("@Sinav2", sinav2),
                    new SqlParameter("@Sinav3", sinav3)
                );

                MessageBox.Show("Not başarıyla eklendi!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "SP Hatası",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // SORU 31: SP ile öğrenci detay raporu
        private void btnOgrenciDetay_Click(object sender, EventArgs e)
        {
            int ogrenciID = Convert.ToInt32(txtOgrenciID.Text);
            var sonuc = db.Database.SqlQuery<OgrenciDetay>(
                "EXEC sp_OgrenciDetayGetir @OgrenciID",
                new SqlParameter("@OgrenciID", ogrenciID)
            ).ToList();
            dataGridView1.DataSource = sonuc;
        }

        // SORU 32: SP ile ders başarı raporu
        private void btnDersBasariSP_Click(object sender, EventArgs e)
        {
            int dersID = Convert.ToInt32(cmbDers.SelectedValue);
            var sonuc = db.Database.SqlQuery<DersBasariRapor>(
                "EXEC sp_DersBasariRaporu @DersID",
                new SqlParameter("@DersID", dersID)
            ).FirstOrDefault();

            if (sonuc != null)
            {
                MessageBox.Show($@"Toplam Öğrenci: {sonuc.ToplamOgrenci}
Geçen: {sonuc.GecenSayisi}
Kalan: {sonuc.KalanSayisi}
Başarı %: {sonuc.BasariYuzdesi:F2}
En Yüksek: {sonuc.EnYuksekOrtalama}
En Başarılı: {sonuc.EnBasariliOgrenci}");
            }
        }

        // SORU 33: SP ile not güncelleme
        private void btnSPNotGuncelle_Click(object sender, EventArgs e)
        {
            int notID = Convert.ToInt32(txtNotID.Text);
            int s1 = Convert.ToInt32(txtSinav1.Text);
            int s2 = Convert.ToInt32(txtSinav2.Text);
            int s3 = Convert.ToInt32(txtSinav3.Text);

            var sonuc = db.Database.SqlQuery<TBLNOTLAR>(
                "EXEC sp_NotGuncelle @NotID, @S1, @S2, @S3",
                new SqlParameter("@NotID", notID),
                new SqlParameter("@S1", s1),
                new SqlParameter("@S2", s2),
                new SqlParameter("@S3", s3)
            ).ToList();

            dataGridView1.DataSource = sonuc;
            MessageBox.Show("Not güncellendi!");
        }

        // SORU 34: Toplu silme
        private void btnTopluSil_Click(object sender, EventArgs e)
        {
            int kulupID = Convert.ToInt32(cmbKulup.SelectedValue);
            var sonuc = db.Database.SqlQuery<int>(
                "EXEC sp_TopluSil @KulupID",
                new SqlParameter("@KulupID", kulupID)
            ).FirstOrDefault();
            MessageBox.Show($"{sonuc} kayıt silindi!");
        }

        // SORU 35: Scalar Function
        private void btnScalarFunction_Click(object sender, EventArgs e)
        {
            int ogrenciID = Convert.ToInt32(txtOgrenciID.Text);
            var sonuc = db.Database.SqlQuery<decimal>(
                "SELECT dbo.fn_GenelBasariPuani(@OgrenciID)",
                new SqlParameter("@OgrenciID", ogrenciID)
            ).FirstOrDefault();
            MessageBox.Show($"Genel Başarı Puanı: {sonuc:F2}");
        }

        // SORU 36: Table-Valued Function
        private void btnTVFDersNot_Click(object sender, EventArgs e)
        {
            int dersID = Convert.ToInt32(cmbDers.SelectedValue);
            var sonuc = db.Database.SqlQuery<DersNotListesi>(
                "SELECT * FROM dbo.fn_DersNotListesi(@DersID)",
                new SqlParameter("@DersID", dersID)
            ).ToList();
            dataGridView1.DataSource = sonuc;
        }

        // SORU 37: Çok parametreli TVF
        private void btnCokParametreliTVF_Click(object sender, EventArgs e)
        {
            decimal minOrt = Convert.ToDecimal(txtMinOrtalama.Text);
            decimal maxOrt = Convert.ToDecimal(txtMaxOrtalama.Text);
            object dersID = cmbDers.SelectedValue != null ? (object)Convert.ToInt32(cmbDers.SelectedValue) : DBNull.Value;
            object durum = chkGecti.Checked ? (object)1 : (chkKaldi.Checked ? (object)0 : DBNull.Value);

            var sonuc = db.Database.SqlQuery<NotFiltreSonuc>(
                "SELECT * FROM dbo.fn_NotFiltrele(@Min, @Max, @Ders, @Durum)",
                new SqlParameter("@Min", minOrt),
                new SqlParameter("@Max", maxOrt),
                new SqlParameter("@Ders", dersID),
                new SqlParameter("@Durum", durum)
            ).ToList();
            dataGridView1.DataSource = sonuc;
        }

        // SORU 38: Kulüp başarı oranı
        private void btnKulupDashboard_Click(object sender, EventArgs e)
        {
            var sonuc = db.Database.SqlQuery<KulupBasari>(
                "SELECT * FROM dbo.fn_KulupBasariOrani()"
            ).ToList();
            dataGridView1.DataSource = sonuc;
        }

        // SORU 39: Zayıf öğrenciler
        private void btnZayifOgrenciler_Click(object sender, EventArgs e)
        {
            var sonuc = db.Database.SqlQuery<ZayifOgrenci>(
                "SELECT * FROM dbo.fn_ZayifOgrenciler()"
            ).ToList();
            dataGridView1.DataSource = sonuc;
        }

        // SORU 40: Öğrenci not özeti
        private void btnOgrenciNotOzet_Click(object sender, EventArgs e)
        {
            int ogrenciID = Convert.ToInt32(txtOgrenciID.Text);
            var sonuc = db.Database.SqlQuery<OgrenciNotOzetDTO>(
                "SELECT * FROM dbo.fn_OgrenciNotOzet(@OgrenciID)",
                new SqlParameter("@OgrenciID", ogrenciID)
            ).ToList();

            dataGridView1.DataSource = sonuc;
            if (sonuc.Any())
            {
                var ozet = sonuc.First();
                lblToplamDers.Text = $"Toplam Ders: {ozet.ToplamDers}";
                lblGecenDers.Text = $"Geçen: {ozet.GecenDers}";
                lblKalanDers.Text = $"Kalan: {ozet.KalanDers}";
                lblGenelOrt.Text = $"Genel Ort: {ozet.GenelOrt:F2}";
            }
        }

        // SORU 41: Transaction - Çok adımlı kayıt
        private void btnCokAdimliKayit_Click(object sender, EventArgs e)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var yeniOgrenci = new TBLOGRENCI
                    {
                        OgrenciAd = txtOgrenciAd.Text,
                        OgrenciSoyad = txtOgrenciSoyad.Text,
                        KulupID = Convert.ToInt32(cmbKulup.SelectedValue)
                    };
                    db.TBLOGRENCI.Add(yeniOgrenci);
                    db.SaveChanges();

                    var dersler = db.TBLDERSLER.Take(3).ToList();
                    foreach (var ders in dersler)
                    {
                        var yeniNot = new TBLNOTLAR
                        {
                            OGRENCI = yeniOgrenci.OgrenciID,
                            DERS = ders.DERSID,
                            SINAV1 = 0,
                            SINAV2 = 0,
                            SINAV3 = 0,
                            ORTALAMA = 0,
                            DURUM = false
                        };
                        db.TBLNOTLAR.Add(yeniNot);
                    }
                    db.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show("Öğrenci ve notlar başarıyla eklendi!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        // SORU 42: TransactionScope ile toplu güncelleme
        private void btnTopluNotGuncelle_Click(object sender, EventArgs e)
        {
            var guncellenecekNotlar = db.TBLNOTLAR.Take(10).ToList();
            using (var scope = new TransactionScope())
            {
                try
                {
                    foreach (var not in guncellenecekNotlar)
                    {
                        not.SINAV1 = (not.SINAV1 ?? 0) + 5;
                        if (not.SINAV1 > 100) not.SINAV1 = 100;
                        not.ORTALAMA = (not.SINAV1 + not.SINAV2 + not.SINAV3) / 3.0m;
                        not.DURUM = not.ORTALAMA >= 50;
                    }
                    db.SaveChanges();
                    scope.Complete();
                    MessageBox.Show($"{guncellenecekNotlar.Count} not güncellendi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        // SORU 43: Çok tablolu transaction
        private void btnCokTabloTransaction_Click(object sender, EventArgs e)
        {
            int ogrenciID = Convert.ToInt32(txtOgrenciID.Text);
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var ogrenci = db.TBLOGRENCI.Find(ogrenciID);
                    if (ogrenci == null) throw new Exception("Öğrenci bulunamadı!");

                    var notlar = db.TBLNOTLAR.Where(n => n.OGRENCI == ogrenciID).ToList();
                    db.TBLNOTLAR.RemoveRange(notlar);
                    db.TBLOGRENCI.Remove(ogrenci);
                    db.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show("İşlem başarıyla tamamlandı!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        // SORU 44: Transaction + SP
        private void btnTransactionSP_Click(object sender, EventArgs e)
        {
            int ogrenciID = Convert.ToInt32(txtOgrenciID.Text);
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.Database.ExecuteSqlCommand(
                        "EXEC sp_OgrenciTamSil @OgrenciID",
                        new SqlParameter("@OgrenciID", ogrenciID)
                    );
                    transaction.Commit();
                    MessageBox.Show("Öğrenci ve tüm kayıtları silindi!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"SP Hatası: {ex.Message}");
                }
            }
        }

        // SORU 45: Transaction + File Check
        private void btnFotoGuncelle_Click(object sender, EventArgs e)
        {
            int ogrenciID = Convert.ToInt32(txtOgrenciID.Text);
            string yeniFotoYolu = txtFotoYol.Text;
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    if (!string.IsNullOrEmpty(yeniFotoYolu) && !File.Exists(yeniFotoYolu))
                    {
                        throw new FileNotFoundException("Fotoğraf dosyası bulunamadı!", yeniFotoYolu);
                    }
                    var ogrenci = db.TBLOGRENCI.Find(ogrenciID);
                    if (ogrenci == null) throw new Exception("Öğrenci bulunamadı!");
                    ogrenci.OgrenciFoto = yeniFotoYolu;
                    db.SaveChanges();
                    transaction.Commit();
                    MessageBox.Show("Fotoğraf başarıyla güncellendi!");
                }
                catch (FileNotFoundException ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Dosya bulunamadı: {ex.FileName}");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGeri_MouseEnter(object sender, EventArgs e)
        {
            btnGeri.BackColor = Color.FromArgb(127, 140, 141);
        }

        private void btnGeri_MouseLeave(object sender, EventArgs e)
        {
            btnGeri.BackColor = Color.FromArgb(149, 165, 166);
        }

        private void DynamicButton_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Color originalColor)
            {
                button.BackColor = Color.FromArgb(
                    Math.Max(0, originalColor.R - 15),
                    Math.Max(0, originalColor.G - 15),
                    Math.Max(0, originalColor.B - 15)
                );
            }
        }

        private void DynamicButton_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Color originalColor)
            {
                button.BackColor = originalColor;
            }
        }
    }
}

