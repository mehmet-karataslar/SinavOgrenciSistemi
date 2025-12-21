using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinavOgrenciSistemi
{
    partial class FormNavigation
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button btnNotListele;
        private Button btnNotListeleDersAdi;
        private Button btnAdSoyadBirlestir;
        private Button btnOgrenciKulup;
        private Button btnUcTabloJoin;
        private Button btnOgrenciNotlari;
        private Button btnGeri;
        private TextBox txtOgrenciID;
        private Label lblOgrenciID;
        private Label lblBaslik;
        private Panel panelHeader;
        private Panel panelButtons;
        private Panel panelSearch;
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
            this.btnNotListele = new Button();
            this.btnNotListeleDersAdi = new Button();
            this.btnAdSoyadBirlestir = new Button();
            this.btnOgrenciKulup = new Button();
            this.btnUcTabloJoin = new Button();
            this.btnOgrenciNotlari = new Button();
            this.btnGeri = new Button();
            this.txtOgrenciID = new TextBox();
            this.lblOgrenciID = new Label();
            this.lblBaslik = new Label();
            this.panelHeader = new Panel();
            this.panelButtons = new Panel();
            this.panelSearch = new Panel();
            this.panelData = new Panel();
            this.panelHeader.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            
            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(46, 204, 113);
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
            this.lblBaslik.Size = new Size(450, 30);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Navigation Property & İlişkili Tablo Sorguları";
            
            // panelButtons
            this.panelButtons.BackColor = Color.FromArgb(236, 240, 241);
            this.panelButtons.Dock = DockStyle.Top;
            this.panelButtons.Height = 80;
            this.panelButtons.Padding = new Padding(15, 10, 15, 10);
            this.panelButtons.Controls.Add(this.btnGeri);
            this.panelButtons.Controls.Add(this.btnUcTabloJoin);
            this.panelButtons.Controls.Add(this.btnOgrenciKulup);
            this.panelButtons.Controls.Add(this.btnAdSoyadBirlestir);
            this.panelButtons.Controls.Add(this.btnNotListeleDersAdi);
            this.panelButtons.Controls.Add(this.btnNotListele);
            
            // btnNotListele
            this.btnNotListele.BackColor = Color.FromArgb(52, 152, 219);
            this.btnNotListele.FlatAppearance.BorderSize = 0;
            this.btnNotListele.FlatStyle = FlatStyle.Flat;
            this.btnNotListele.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnNotListele.ForeColor = Color.White;
            this.btnNotListele.Location = new Point(15, 10);
            this.btnNotListele.Name = "btnNotListele";
            this.btnNotListele.Size = new Size(130, 50);
            this.btnNotListele.TabIndex = 2;
            this.btnNotListele.Text = "Soru 6: Not Listele";
            this.btnNotListele.UseVisualStyleBackColor = false;
            this.btnNotListele.Click += new System.EventHandler(this.btnNotListele_Click);
            this.btnNotListele.MouseEnter += new System.EventHandler(this.btnNotListele_MouseEnter);
            this.btnNotListele.MouseLeave += new System.EventHandler(this.btnNotListele_MouseLeave);
            
            // btnNotListeleDersAdi
            this.btnNotListeleDersAdi.BackColor = Color.FromArgb(46, 204, 113);
            this.btnNotListeleDersAdi.FlatAppearance.BorderSize = 0;
            this.btnNotListeleDersAdi.FlatStyle = FlatStyle.Flat;
            this.btnNotListeleDersAdi.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnNotListeleDersAdi.ForeColor = Color.White;
            this.btnNotListeleDersAdi.Location = new Point(155, 10);
            this.btnNotListeleDersAdi.Name = "btnNotListeleDersAdi";
            this.btnNotListeleDersAdi.Size = new Size(130, 50);
            this.btnNotListeleDersAdi.TabIndex = 3;
            this.btnNotListeleDersAdi.Text = "Soru 7: Ders Adı ile";
            this.btnNotListeleDersAdi.UseVisualStyleBackColor = false;
            this.btnNotListeleDersAdi.Click += new System.EventHandler(this.btnNotListeleDersAdi_Click);
            this.btnNotListeleDersAdi.MouseEnter += new System.EventHandler(this.btnNotListeleDersAdi_MouseEnter);
            this.btnNotListeleDersAdi.MouseLeave += new System.EventHandler(this.btnNotListeleDersAdi_MouseLeave);
            
            // btnAdSoyadBirlestir
            this.btnAdSoyadBirlestir.BackColor = Color.FromArgb(155, 89, 182);
            this.btnAdSoyadBirlestir.FlatAppearance.BorderSize = 0;
            this.btnAdSoyadBirlestir.FlatStyle = FlatStyle.Flat;
            this.btnAdSoyadBirlestir.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnAdSoyadBirlestir.ForeColor = Color.White;
            this.btnAdSoyadBirlestir.Location = new Point(295, 10);
            this.btnAdSoyadBirlestir.Name = "btnAdSoyadBirlestir";
            this.btnAdSoyadBirlestir.Size = new Size(130, 50);
            this.btnAdSoyadBirlestir.TabIndex = 4;
            this.btnAdSoyadBirlestir.Text = "Soru 9: Ad+Soyad";
            this.btnAdSoyadBirlestir.UseVisualStyleBackColor = false;
            this.btnAdSoyadBirlestir.Click += new System.EventHandler(this.btnAdSoyadBirlestir_Click);
            this.btnAdSoyadBirlestir.MouseEnter += new System.EventHandler(this.btnAdSoyadBirlestir_MouseEnter);
            this.btnAdSoyadBirlestir.MouseLeave += new System.EventHandler(this.btnAdSoyadBirlestir_MouseLeave);
            
            // btnOgrenciKulup
            this.btnOgrenciKulup.BackColor = Color.FromArgb(241, 196, 15);
            this.btnOgrenciKulup.FlatAppearance.BorderSize = 0;
            this.btnOgrenciKulup.FlatStyle = FlatStyle.Flat;
            this.btnOgrenciKulup.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnOgrenciKulup.ForeColor = Color.White;
            this.btnOgrenciKulup.Location = new Point(435, 10);
            this.btnOgrenciKulup.Name = "btnOgrenciKulup";
            this.btnOgrenciKulup.Size = new Size(140, 50);
            this.btnOgrenciKulup.TabIndex = 5;
            this.btnOgrenciKulup.Text = "Soru 10: Öğrenci-Kulüp";
            this.btnOgrenciKulup.UseVisualStyleBackColor = false;
            this.btnOgrenciKulup.Click += new System.EventHandler(this.btnOgrenciKulup_Click);
            this.btnOgrenciKulup.MouseEnter += new System.EventHandler(this.btnOgrenciKulup_MouseEnter);
            this.btnOgrenciKulup.MouseLeave += new System.EventHandler(this.btnOgrenciKulup_MouseLeave);
            
            // btnUcTabloJoin
            this.btnUcTabloJoin.BackColor = Color.FromArgb(230, 126, 34);
            this.btnUcTabloJoin.FlatAppearance.BorderSize = 0;
            this.btnUcTabloJoin.FlatStyle = FlatStyle.Flat;
            this.btnUcTabloJoin.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnUcTabloJoin.ForeColor = Color.White;
            this.btnUcTabloJoin.Location = new Point(585, 10);
            this.btnUcTabloJoin.Name = "btnUcTabloJoin";
            this.btnUcTabloJoin.Size = new Size(130, 50);
            this.btnUcTabloJoin.TabIndex = 6;
            this.btnUcTabloJoin.Text = "Soru 11: Üç Tablo";
            this.btnUcTabloJoin.UseVisualStyleBackColor = false;
            this.btnUcTabloJoin.Click += new System.EventHandler(this.btnUcTabloJoin_Click);
            this.btnUcTabloJoin.MouseEnter += new System.EventHandler(this.btnUcTabloJoin_MouseEnter);
            this.btnUcTabloJoin.MouseLeave += new System.EventHandler(this.btnUcTabloJoin_MouseLeave);
            
            // btnGeri
            this.btnGeri.BackColor = Color.FromArgb(149, 165, 166);
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = FlatStyle.Flat;
            this.btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnGeri.ForeColor = Color.White;
            this.btnGeri.Location = new Point(725, 10);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new Size(100, 50);
            this.btnGeri.TabIndex = 10;
            this.btnGeri.Text = "← Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            this.btnGeri.MouseEnter += new System.EventHandler(this.btnGeri_MouseEnter);
            this.btnGeri.MouseLeave += new System.EventHandler(this.btnGeri_MouseLeave);
            
            // panelSearch
            this.panelSearch.BackColor = Color.White;
            this.panelSearch.Dock = DockStyle.Top;
            this.panelSearch.Height = 60;
            this.panelSearch.Padding = new Padding(20, 15, 20, 15);
            this.panelSearch.Controls.Add(this.btnOgrenciNotlari);
            this.panelSearch.Controls.Add(this.txtOgrenciID);
            this.panelSearch.Controls.Add(this.lblOgrenciID);
            
            // lblOgrenciID
            this.lblOgrenciID.AutoSize = true;
            this.lblOgrenciID.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblOgrenciID.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblOgrenciID.Location = new Point(20, 20);
            this.lblOgrenciID.Name = "lblOgrenciID";
            this.lblOgrenciID.Size = new Size(85, 19);
            this.lblOgrenciID.TabIndex = 7;
            this.lblOgrenciID.Text = "Öğrenci ID:";
            
            // txtOgrenciID
            this.txtOgrenciID.BorderStyle = BorderStyle.FixedSingle;
            this.txtOgrenciID.Font = new Font("Segoe UI", 10F, GraphicsUnit.Point);
            this.txtOgrenciID.Location = new Point(110, 18);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new Size(120, 25);
            this.txtOgrenciID.TabIndex = 8;
            
            // btnOgrenciNotlari
            this.btnOgrenciNotlari.BackColor = Color.FromArgb(26, 188, 156);
            this.btnOgrenciNotlari.FlatAppearance.BorderSize = 0;
            this.btnOgrenciNotlari.FlatStyle = FlatStyle.Flat;
            this.btnOgrenciNotlari.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnOgrenciNotlari.ForeColor = Color.White;
            this.btnOgrenciNotlari.Location = new Point(240, 15);
            this.btnOgrenciNotlari.Name = "btnOgrenciNotlari";
            this.btnOgrenciNotlari.Size = new Size(160, 30);
            this.btnOgrenciNotlari.TabIndex = 9;
            this.btnOgrenciNotlari.Text = "Soru 12: Öğrenci Notları";
            this.btnOgrenciNotlari.UseVisualStyleBackColor = false;
            this.btnOgrenciNotlari.Click += new System.EventHandler(this.btnOgrenciNotlari_Click);
            this.btnOgrenciNotlari.MouseEnter += new System.EventHandler(this.btnOgrenciNotlari_MouseEnter);
            this.btnOgrenciNotlari.MouseLeave += new System.EventHandler(this.btnOgrenciNotlari_MouseLeave);
            
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
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.dataGridView1.EnableHeadersVisualStyles = false;
            
            // FormNavigation
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 650);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(1000, 600);
            this.Name = "FormNavigation";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Navigation Property & İlişkiler (Soru 6-12)";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
