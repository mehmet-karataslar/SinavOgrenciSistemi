using System;
using System.Windows.Forms;

namespace SinavOgrenciSistemi
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnTemelEF_Click(object sender, EventArgs e)
        {
            FormTemelEF form = new FormTemelEF();
            form.ShowDialog();
        }

        private void btnNavigation_Click(object sender, EventArgs e)
        {
            FormNavigation form = new FormNavigation();
            form.ShowDialog();
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            FormCRUD form = new FormCRUD();
            form.ShowDialog();
        }

        private void btnLINQ_Click(object sender, EventArgs e)
        {
            FormLINQ form = new FormLINQ();
            form.ShowDialog();
        }

        private void btnAggregate_Click(object sender, EventArgs e)
        {
            FormAggregate form = new FormAggregate();
            form.ShowDialog();
        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            FormDurum form = new FormDurum();
            form.ShowDialog();
        }

        private void btnGelismis_Click(object sender, EventArgs e)
        {
            FormGelismis form = new FormGelismis();
            form.ShowDialog();
        }
    }
}

