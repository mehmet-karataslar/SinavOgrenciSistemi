using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinavOgrenciSistemi
{
    partial class FormLINQ
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private TextBox txtOgrenciAd;
        private TextBox txtOgrenciID;
        private Button btnArtanSirala;
        private Button btnAzalanSirala;
        private Button btnIlkUc;
        private Button btnIdIleGetir;
        private Button btnAileBaslayan;
        private Button btnNileBiten;
        private Button btnGeri;
        private Label lblOgrenciAd;
        private Label lblOgrenciID;
        private Label lblBaslik;
        private Panel panelHeader;
        private Panel panelSearch;
        private Panel panelButtons;
        private Panel panelData;

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
            this.txtOgrenciAd = new TextBox();
            this.txtOgrenciID = new TextBox();
            this.btnArtanSirala = new Button();
            this.btnAzalanSirala = new Button();
            this.btnIlkUc = new Button();
            this.btnIdIleGetir = new Button();
            this.btnAileBaslayan = new Button();
            this.btnNileBiten = new Button();
            this.btnGeri = new Button();
            this.lblOgrenciAd = new Label();
            this.lblOgrenciID = new Label();
            this.lblBaslik = new Label();
            this.panelHeader = new Panel();
            this.panelSearch = new Panel();
            this.panelButtons = new Panel();
            this.panelData = new Panel();
            this.panelHeader.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            
            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(241, 196, 15);
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
            this.lblBaslik.Size = new Size(350, 30);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "LINQ Filtreleme - Arama - Sıralama";
            
            // panelSearch
            this.panelSearch.BackColor = Color.White;
            this.panelSearch.Dock = DockStyle.Top;
            this.panelSearch.Height = 60;
            this.panelSearch.Padding = new Padding(20, 15, 20, 15);
            this.panelSearch.Controls.Add(this.btnGeri);
            this.panelSearch.Controls.Add(this.txtOgrenciID);
            this.panelSearch.Controls.Add(this.lblOgrenciID);
            this.panelSearch.Controls.Add(this.txtOgrenciAd);
            this.panelSearch.Controls.Add(this.lblOgrenciAd);
            
            // lblOgrenciAd
            this.lblOgrenciAd.AutoSize = true;
            this.lblOgrenciAd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblOgrenciAd.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblOgrenciAd.Location = new Point(20, 20);
            this.lblOgrenciAd.Name = "lblOgrenciAd";
            this.lblOgrenciAd.Size = new Size(85, 19);
            this.lblOgrenciAd.TabIndex = 1;
            this.lblOgrenciAd.Text = "Öğrenci Adı:";
            
            // txtOgrenciAd
            this.txtOgrenciAd.BorderStyle = BorderStyle.FixedSingle;
            this.txtOgrenciAd.Font = new Font("Segoe UI", 10F, GraphicsUnit.Point);
            this.txtOgrenciAd.Location = new Point(110, 18);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new Size(180, 25);
            this.txtOgrenciAd.TabIndex = 2;
            this.txtOgrenciAd.TextChanged += new System.EventHandler(this.txtOgrenciAd_TextChanged);
            
            // lblOgrenciID
            this.lblOgrenciID.AutoSize = true;
            this.lblOgrenciID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblOgrenciID.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblOgrenciID.Location = new Point(300, 20);
            this.lblOgrenciID.Name = "lblOgrenciID";
            this.lblOgrenciID.Size = new Size(85, 19);
            this.lblOgrenciID.TabIndex = 3;
            this.lblOgrenciID.Text = "Öğrenci ID:";
            
            // txtOgrenciID
            this.txtOgrenciID.BorderStyle = BorderStyle.FixedSingle;
            this.txtOgrenciID.Font = new Font("Segoe UI", 10F, GraphicsUnit.Point);
            this.txtOgrenciID.Location = new Point(390, 18);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new Size(120, 25);
            this.txtOgrenciID.TabIndex = 4;
            
            // btnGeri
            this.btnGeri.BackColor = Color.FromArgb(149, 165, 166);
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = FlatStyle.Flat;
            this.btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnGeri.ForeColor = Color.White;
            this.btnGeri.Location = new Point(650, 15);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new Size(100, 30);
            this.btnGeri.TabIndex = 11;
            this.btnGeri.Text = "← Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            this.btnGeri.MouseEnter += new System.EventHandler(this.btnGeri_MouseEnter);
            this.btnGeri.MouseLeave += new System.EventHandler(this.btnGeri_MouseLeave);
            
            // panelButtons
            this.panelButtons.BackColor = Color.FromArgb(236, 240, 241);
            this.panelButtons.Dock = DockStyle.Top;
            this.panelButtons.Height = 80;
            this.panelButtons.Padding = new Padding(15, 10, 15, 10);
            this.panelButtons.Controls.Add(this.btnNileBiten);
            this.panelButtons.Controls.Add(this.btnAileBaslayan);
            this.panelButtons.Controls.Add(this.btnIdIleGetir);
            this.panelButtons.Controls.Add(this.btnIlkUc);
            this.panelButtons.Controls.Add(this.btnAzalanSirala);
            this.panelButtons.Controls.Add(this.btnArtanSirala);
            
            // btnArtanSirala
            this.btnArtanSirala.BackColor = Color.FromArgb(52, 152, 219);
            this.btnArtanSirala.FlatAppearance.BorderSize = 0;
            this.btnArtanSirala.FlatStyle = FlatStyle.Flat;
            this.btnArtanSirala.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnArtanSirala.ForeColor = Color.White;
            this.btnArtanSirala.Location = new Point(15, 10);
            this.btnArtanSirala.Name = "btnArtanSirala";
            this.btnArtanSirala.Size = new Size(120, 50);
            this.btnArtanSirala.TabIndex = 5;
            this.btnArtanSirala.Text = "Soru 20: Artan Sırala";
            this.btnArtanSirala.UseVisualStyleBackColor = false;
            this.btnArtanSirala.Click += new System.EventHandler(this.btnArtanSirala_Click);
            this.btnArtanSirala.MouseEnter += new System.EventHandler(this.btnArtanSirala_MouseEnter);
            this.btnArtanSirala.MouseLeave += new System.EventHandler(this.btnArtanSirala_MouseLeave);
            
            // btnAzalanSirala
            this.btnAzalanSirala.BackColor = Color.FromArgb(46, 204, 113);
            this.btnAzalanSirala.FlatAppearance.BorderSize = 0;
            this.btnAzalanSirala.FlatStyle = FlatStyle.Flat;
            this.btnAzalanSirala.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnAzalanSirala.ForeColor = Color.White;
            this.btnAzalanSirala.Location = new Point(145, 10);
            this.btnAzalanSirala.Name = "btnAzalanSirala";
            this.btnAzalanSirala.Size = new Size(120, 50);
            this.btnAzalanSirala.TabIndex = 6;
            this.btnAzalanSirala.Text = "Soru 21: Azalan Sırala";
            this.btnAzalanSirala.UseVisualStyleBackColor = false;
            this.btnAzalanSirala.Click += new System.EventHandler(this.btnAzalanSirala_Click);
            this.btnAzalanSirala.MouseEnter += new System.EventHandler(this.btnAzalanSirala_MouseEnter);
            this.btnAzalanSirala.MouseLeave += new System.EventHandler(this.btnAzalanSirala_MouseLeave);
            
            // btnIlkUc
            this.btnIlkUc.BackColor = Color.FromArgb(155, 89, 182);
            this.btnIlkUc.FlatAppearance.BorderSize = 0;
            this.btnIlkUc.FlatStyle = FlatStyle.Flat;
            this.btnIlkUc.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnIlkUc.ForeColor = Color.White;
            this.btnIlkUc.Location = new Point(275, 10);
            this.btnIlkUc.Name = "btnIlkUc";
            this.btnIlkUc.Size = new Size(120, 50);
            this.btnIlkUc.TabIndex = 7;
            this.btnIlkUc.Text = "Soru 22: İlk 3 Öğrenci";
            this.btnIlkUc.UseVisualStyleBackColor = false;
            this.btnIlkUc.Click += new System.EventHandler(this.btnIlkUc_Click);
            this.btnIlkUc.MouseEnter += new System.EventHandler(this.btnIlkUc_MouseEnter);
            this.btnIlkUc.MouseLeave += new System.EventHandler(this.btnIlkUc_MouseLeave);
            
            // btnIdIleGetir
            this.btnIdIleGetir.BackColor = Color.FromArgb(230, 126, 34);
            this.btnIdIleGetir.FlatAppearance.BorderSize = 0;
            this.btnIdIleGetir.FlatStyle = FlatStyle.Flat;
            this.btnIdIleGetir.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnIdIleGetir.ForeColor = Color.White;
            this.btnIdIleGetir.Location = new Point(405, 10);
            this.btnIdIleGetir.Name = "btnIdIleGetir";
            this.btnIdIleGetir.Size = new Size(120, 50);
            this.btnIdIleGetir.TabIndex = 8;
            this.btnIdIleGetir.Text = "Soru 23: ID ile Getir";
            this.btnIdIleGetir.UseVisualStyleBackColor = false;
            this.btnIdIleGetir.Click += new System.EventHandler(this.btnIdIleGetir_Click);
            this.btnIdIleGetir.MouseEnter += new System.EventHandler(this.btnIdIleGetir_MouseEnter);
            this.btnIdIleGetir.MouseLeave += new System.EventHandler(this.btnIdIleGetir_MouseLeave);
            
            // btnAileBaslayan
            this.btnAileBaslayan.BackColor = Color.FromArgb(26, 188, 156);
            this.btnAileBaslayan.FlatAppearance.BorderSize = 0;
            this.btnAileBaslayan.FlatStyle = FlatStyle.Flat;
            this.btnAileBaslayan.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnAileBaslayan.ForeColor = Color.White;
            this.btnAileBaslayan.Location = new Point(535, 10);
            this.btnAileBaslayan.Name = "btnAileBaslayan";
            this.btnAileBaslayan.Size = new Size(120, 50);
            this.btnAileBaslayan.TabIndex = 9;
            this.btnAileBaslayan.Text = "Soru 24: 'A' ile Başla";
            this.btnAileBaslayan.UseVisualStyleBackColor = false;
            this.btnAileBaslayan.Click += new System.EventHandler(this.btnAileBaslayan_Click);
            this.btnAileBaslayan.MouseEnter += new System.EventHandler(this.btnAileBaslayan_MouseEnter);
            this.btnAileBaslayan.MouseLeave += new System.EventHandler(this.btnAileBaslayan_MouseLeave);
            
            // btnNileBiten
            this.btnNileBiten.BackColor = Color.FromArgb(231, 76, 60);
            this.btnNileBiten.FlatAppearance.BorderSize = 0;
            this.btnNileBiten.FlatStyle = FlatStyle.Flat;
            this.btnNileBiten.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnNileBiten.ForeColor = Color.White;
            this.btnNileBiten.Location = new Point(665, 10);
            this.btnNileBiten.Name = "btnNileBiten";
            this.btnNileBiten.Size = new Size(120, 50);
            this.btnNileBiten.TabIndex = 10;
            this.btnNileBiten.Text = "Soru 25: 'n' ile Bit";
            this.btnNileBiten.UseVisualStyleBackColor = false;
            this.btnNileBiten.Click += new System.EventHandler(this.btnNileBiten_Click);
            this.btnNileBiten.MouseEnter += new System.EventHandler(this.btnNileBiten_MouseEnter);
            this.btnNileBiten.MouseLeave += new System.EventHandler(this.btnNileBiten_MouseLeave);
            
            // panelData
            this.panelData.BackColor = Color.White;
            this.panelData.Dock = DockStyle.Fill;
            this.panelData.Padding = new Padding(15);
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
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 196, 15);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.dataGridView1.EnableHeadersVisualStyles = false;
            
            // FormLINQ
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 600);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(900, 550);
            this.Name = "FormLINQ";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "LINQ Filtreleme (Soru 19-25)";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
