using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SinavOgrenciSistemi.Models;

namespace SinavOgrenciSistemi
{
    public partial class FormTemelEF : Form
    {
        // SORU 1: Form seviyesinde DbContext örneği
        dbSinavOgrenciEntities db = new dbSinavOgrenciEntities();

        public FormTemelEF()
        {
            InitializeComponent();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            db.Dispose();
            base.OnFormClosed(e);
        }

        // SORU 2: Tüm öğrencileri listeleme
        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            var ogrenciler = db.TBLOGRENCI
                .Select(o => new
                {
                    o.OgrenciID,
                    o.OgrenciAd,
                    o.OgrenciSoyad,
                    KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüpsüz",
                    o.KulupID
                })
                .ToList();
            dataGridView1.DataSource = ogrenciler;
        }

        // SORU 3: OgrenciFoto alanını gizleme
        private void btnOgrenciListeleGizli_Click(object sender, EventArgs e)
        {
            var ogrenciler = db.TBLOGRENCI
                .Select(o => new
                {
                    o.OgrenciID,
                    o.OgrenciAd,
                    o.OgrenciSoyad,
                    KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüpsüz",
                    o.KulupID
                })
                .ToList();
            dataGridView1.DataSource = ogrenciler;
        }

        // SORU 4: Dersleri listeleme (EF)
        private void btnDersListeleEF_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TBLDERSLER.ToList();
        }

        // SORU 5: ADO.NET ile listeleme (karşılaştırma)
        private void btnDersListeleADO_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=.;Database=dbSinavOgrenci;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM TBLDERSLER", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // MouseEnter ve MouseLeave event handler'ları
        private void btnOgrenciListele_MouseEnter(object sender, EventArgs e)
        {
            btnOgrenciListele.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void btnOgrenciListele_MouseLeave(object sender, EventArgs e)
        {
            btnOgrenciListele.BackColor = Color.FromArgb(52, 152, 219);
        }

        private void btnOgrenciListeleGizli_MouseEnter(object sender, EventArgs e)
        {
            btnOgrenciListeleGizli.BackColor = Color.FromArgb(39, 174, 96);
        }

        private void btnOgrenciListeleGizli_MouseLeave(object sender, EventArgs e)
        {
            btnOgrenciListeleGizli.BackColor = Color.FromArgb(46, 204, 113);
        }

        private void btnDersListeleEF_MouseEnter(object sender, EventArgs e)
        {
            btnDersListeleEF.BackColor = Color.FromArgb(142, 68, 173);
        }

        private void btnDersListeleEF_MouseLeave(object sender, EventArgs e)
        {
            btnDersListeleEF.BackColor = Color.FromArgb(155, 89, 182);
        }

        private void btnDersListeleADO_MouseEnter(object sender, EventArgs e)
        {
            btnDersListeleADO.BackColor = Color.FromArgb(243, 156, 18);
        }

        private void btnDersListeleADO_MouseLeave(object sender, EventArgs e)
        {
            btnDersListeleADO.BackColor = Color.FromArgb(241, 196, 15);
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

