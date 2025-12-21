using System;
using System.Drawing;
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

        // MouseEnter ve MouseLeave event handler'ları
        private void btnTemelEF_MouseEnter(object sender, EventArgs e)
        {
            btnTemelEF.BackColor = Color.FromArgb(41, 128, 185);
        }

        private void btnTemelEF_MouseLeave(object sender, EventArgs e)
        {
            btnTemelEF.BackColor = Color.FromArgb(52, 152, 219);
        }

        private void btnNavigation_MouseEnter(object sender, EventArgs e)
        {
            btnNavigation.BackColor = Color.FromArgb(39, 174, 96);
        }

        private void btnNavigation_MouseLeave(object sender, EventArgs e)
        {
            btnNavigation.BackColor = Color.FromArgb(46, 204, 113);
        }

        private void btnCRUD_MouseEnter(object sender, EventArgs e)
        {
            btnCRUD.BackColor = Color.FromArgb(142, 68, 173);
        }

        private void btnCRUD_MouseLeave(object sender, EventArgs e)
        {
            btnCRUD.BackColor = Color.FromArgb(155, 89, 182);
        }

        private void btnLINQ_MouseEnter(object sender, EventArgs e)
        {
            btnLINQ.BackColor = Color.FromArgb(243, 156, 18);
        }

        private void btnLINQ_MouseLeave(object sender, EventArgs e)
        {
            btnLINQ.BackColor = Color.FromArgb(241, 196, 15);
        }

        private void btnAggregate_MouseEnter(object sender, EventArgs e)
        {
            btnAggregate.BackColor = Color.FromArgb(211, 84, 0);
        }

        private void btnAggregate_MouseLeave(object sender, EventArgs e)
        {
            btnAggregate.BackColor = Color.FromArgb(230, 126, 34);
        }

        private void btnDurum_MouseEnter(object sender, EventArgs e)
        {
            btnDurum.BackColor = Color.FromArgb(192, 57, 43);
        }

        private void btnDurum_MouseLeave(object sender, EventArgs e)
        {
            btnDurum.BackColor = Color.FromArgb(231, 76, 60);
        }

        private void btnGelismis_MouseEnter(object sender, EventArgs e)
        {
            btnGelismis.BackColor = Color.FromArgb(22, 160, 133);
        }

        private void btnGelismis_MouseLeave(object sender, EventArgs e)
        {
            btnGelismis.BackColor = Color.FromArgb(26, 188, 156);
        }
    }
}

