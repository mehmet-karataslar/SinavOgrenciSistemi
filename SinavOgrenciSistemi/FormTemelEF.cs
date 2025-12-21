using System;
using System.Data;
using System.Data.SqlClient;
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
            dataGridView1.DataSource = db.TBLOGRENCI.ToList();
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
    }
}

