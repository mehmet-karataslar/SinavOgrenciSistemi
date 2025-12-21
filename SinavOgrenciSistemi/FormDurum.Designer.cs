using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinavOgrenciSistemi
{
    partial class FormDurum
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private DataGridView dgvGecenler;
        private DataGridView dgvKalanlar;
        private Button btnDurumListesi;
        private Button btnGecenKalan;
        private Button btnGeri;
        private Label lblBaslik;
        private Label lblGecenler;
        private Label lblKalanlar;
        private Panel panelHeader;
        private Panel panelButtons;
        private Panel panelData;
        private SplitContainer splitContainer1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new DataGridView();
            this.dgvGecenler = new DataGridView();
            this.dgvKalanlar = new DataGridView();
            this.btnDurumListesi = new Button();
            this.btnGecenKalan = new Button();
            this.btnGeri = new Button();
            this.lblBaslik = new Label();
            this.lblGecenler = new Label();
            this.lblKalanlar = new Label();
            this.panelHeader = new Panel();
            this.panelButtons = new Panel();
            this.panelData = new Panel();
            this.splitContainer1 = new SplitContainer();
            this.panelHeader.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecenler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKalanlar)).BeginInit();
            this.SuspendLayout();
            
            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(231, 76, 60);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Height = 80;
            this.panelHeader.Padding = new Padding(20);
            this.panelHeader.Controls.Add(this.lblBaslik);
            
            // lblBaslik
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblBaslik.ForeColor = Color.White;
            this.lblBaslik.Location = new Point(20, 25);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new Size(400, 30);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Durum Hesaplama ve Anonim Tipleme";
            
            // panelButtons
            this.panelButtons.BackColor = Color.FromArgb(236, 240, 241);
            this.panelButtons.Dock = DockStyle.Top;
            this.panelButtons.Height = 80;
            this.panelButtons.Padding = new Padding(20, 15, 20, 15);
            this.panelButtons.Controls.Add(this.btnGeri);
            this.panelButtons.Controls.Add(this.btnGecenKalan);
            this.panelButtons.Controls.Add(this.btnDurumListesi);
            
            // btnDurumListesi
            this.btnDurumListesi.BackColor = Color.FromArgb(52, 152, 219);
            this.btnDurumListesi.FlatAppearance.BorderSize = 0;
            this.btnDurumListesi.FlatStyle = FlatStyle.Flat;
            this.btnDurumListesi.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnDurumListesi.ForeColor = Color.White;
            this.btnDurumListesi.Location = new Point(20, 15);
            this.btnDurumListesi.Name = "btnDurumListesi";
            this.btnDurumListesi.Size = new Size(250, 50);
            this.btnDurumListesi.TabIndex = 1;
            this.btnDurumListesi.Text = "Soru 29: Durum Listesi";
            this.btnDurumListesi.UseVisualStyleBackColor = false;
            this.btnDurumListesi.Click += new System.EventHandler(this.btnDurumListesi_Click);
            this.btnDurumListesi.MouseEnter += (s, e) => { btnDurumListesi.BackColor = Color.FromArgb(41, 128, 185); };
            this.btnDurumListesi.MouseLeave += (s, e) => { btnDurumListesi.BackColor = Color.FromArgb(52, 152, 219); };
            
            // btnGecenKalan
            this.btnGecenKalan.BackColor = Color.FromArgb(46, 204, 113);
            this.btnGecenKalan.FlatAppearance.BorderSize = 0;
            this.btnGecenKalan.FlatStyle = FlatStyle.Flat;
            this.btnGecenKalan.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnGecenKalan.ForeColor = Color.White;
            this.btnGecenKalan.Location = new Point(280, 15);
            this.btnGecenKalan.Name = "btnGecenKalan";
            this.btnGecenKalan.Size = new Size(250, 50);
            this.btnGecenKalan.TabIndex = 2;
            this.btnGecenKalan.Text = "Soru 30: Geçen/Kalan Ayrı";
            this.btnGecenKalan.UseVisualStyleBackColor = false;
            this.btnGecenKalan.Click += new System.EventHandler(this.btnGecenKalan_Click);
            this.btnGecenKalan.MouseEnter += (s, e) => { btnGecenKalan.BackColor = Color.FromArgb(39, 174, 96); };
            this.btnGecenKalan.MouseLeave += (s, e) => { btnGecenKalan.BackColor = Color.FromArgb(46, 204, 113); };
            
            // btnGeri
            this.btnGeri.BackColor = Color.FromArgb(149, 165, 166);
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = FlatStyle.Flat;
            this.btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnGeri.ForeColor = Color.White;
            this.btnGeri.Location = new Point(540, 15);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new Size(100, 50);
            this.btnGeri.TabIndex = 3;
            this.btnGeri.Text = "← Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            this.btnGeri.MouseEnter += (s, e) => { btnGeri.BackColor = Color.FromArgb(127, 140, 141); };
            this.btnGeri.MouseLeave += (s, e) => { btnGeri.BackColor = Color.FromArgb(149, 165, 166); };
            
            // panelData
            this.panelData.BackColor = Color.White;
            this.panelData.Dock = DockStyle.Fill;
            this.panelData.Padding = new Padding(15);
            this.panelData.Controls.Add(this.splitContainer1);
            this.panelData.Controls.Add(this.dataGridView1);
            
            // dataGridView1
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.GridColor = Color.FromArgb(236, 240, 241);
            this.dataGridView1.Location = new Point(15, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.dataGridView1.EnableHeadersVisualStyles = false;
            
            // splitContainer1
            this.splitContainer1.Dock = DockStyle.Fill;
            this.splitContainer1.Location = new Point(15, 15);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = Orientation.Horizontal;
            this.splitContainer1.Size = new Size(970, 500);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.Visible = false;
            
            // splitContainer1.Panel1
            this.splitContainer1.Panel1.BackColor = Color.White;
            this.splitContainer1.Panel1.Padding = new Padding(10);
            this.splitContainer1.Panel1.Controls.Add(this.dgvGecenler);
            this.splitContainer1.Panel1.Controls.Add(this.lblGecenler);
            
            // lblGecenler
            this.lblGecenler.AutoSize = true;
            this.lblGecenler.Dock = DockStyle.Top;
            this.lblGecenler.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblGecenler.ForeColor = Color.FromArgb(39, 174, 96);
            this.lblGecenler.Location = new Point(10, 10);
            this.lblGecenler.Name = "lblGecenler";
            this.lblGecenler.Padding = new Padding(0, 0, 0, 5);
            this.lblGecenler.Size = new Size(85, 25);
            this.lblGecenler.TabIndex = 5;
            this.lblGecenler.Text = "✓ GEÇENLER";
            
            // dgvGecenler
            this.dgvGecenler.AllowUserToAddRows = false;
            this.dgvGecenler.AllowUserToDeleteRows = false;
            this.dgvGecenler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGecenler.BackgroundColor = Color.White;
            this.dgvGecenler.BorderStyle = BorderStyle.None;
            this.dgvGecenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGecenler.Dock = DockStyle.Fill;
            this.dgvGecenler.GridColor = Color.FromArgb(236, 240, 241);
            this.dgvGecenler.Location = new Point(10, 35);
            this.dgvGecenler.Name = "dgvGecenler";
            this.dgvGecenler.ReadOnly = true;
            this.dgvGecenler.RowHeadersWidth = 30;
            this.dgvGecenler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvGecenler.TabIndex = 6;
            this.dgvGecenler.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240);
            this.dgvGecenler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(39, 174, 96);
            this.dgvGecenler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvGecenler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.dgvGecenler.EnableHeadersVisualStyles = false;
            
            // splitContainer1.Panel2
            this.splitContainer1.Panel2.BackColor = Color.White;
            this.splitContainer1.Panel2.Padding = new Padding(10);
            this.splitContainer1.Panel2.Controls.Add(this.dgvKalanlar);
            this.splitContainer1.Panel2.Controls.Add(this.lblKalanlar);
            
            // lblKalanlar
            this.lblKalanlar.AutoSize = true;
            this.lblKalanlar.Dock = DockStyle.Top;
            this.lblKalanlar.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblKalanlar.ForeColor = Color.FromArgb(192, 57, 43);
            this.lblKalanlar.Location = new Point(10, 10);
            this.lblKalanlar.Name = "lblKalanlar";
            this.lblKalanlar.Padding = new Padding(0, 0, 0, 5);
            this.lblKalanlar.Size = new Size(80, 25);
            this.lblKalanlar.TabIndex = 7;
            this.lblKalanlar.Text = "✗ KALANLAR";
            
            // dgvKalanlar
            this.dgvKalanlar.AllowUserToAddRows = false;
            this.dgvKalanlar.AllowUserToDeleteRows = false;
            this.dgvKalanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKalanlar.BackgroundColor = Color.White;
            this.dgvKalanlar.BorderStyle = BorderStyle.None;
            this.dgvKalanlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKalanlar.Dock = DockStyle.Fill;
            this.dgvKalanlar.GridColor = Color.FromArgb(236, 240, 241);
            this.dgvKalanlar.Location = new Point(10, 35);
            this.dgvKalanlar.Name = "dgvKalanlar";
            this.dgvKalanlar.ReadOnly = true;
            this.dgvKalanlar.RowHeadersWidth = 30;
            this.dgvKalanlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvKalanlar.TabIndex = 8;
            this.dgvKalanlar.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 240, 240);
            this.dgvKalanlar.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 57, 43);
            this.dgvKalanlar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvKalanlar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.dgvKalanlar.EnableHeadersVisualStyles = false;
            
            // FormDurum
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 650);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(900, 600);
            this.Name = "FormDurum";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Durum Hesaplama (Soru 29-30)";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGecenler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKalanlar)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
