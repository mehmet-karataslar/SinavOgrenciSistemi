using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinavOgrenciSistemi
{
    partial class FormCRUD
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private TextBox txtOgrenciID;
        private TextBox txtOgrenciAd;
        private TextBox txtOgrenciSoyad;
        private TextBox txtFotoYol;
        private ComboBox cmbKulup;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnEntityStateGoster;
        private Button btnGeri;
        private Label lblOgrenciID;
        private Label lblOgrenciAd;
        private Label lblOgrenciSoyad;
        private Label lblFotoYol;
        private Label lblKulup;
        private Label lblBaslik;
        private Panel panelHeader;
        private Panel panelForm;
        private Panel panelButtons;
        private Panel panelData;
        private GroupBox groupBoxBilgiler;

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
            this.txtOgrenciID = new TextBox();
            this.txtOgrenciAd = new TextBox();
            this.txtOgrenciSoyad = new TextBox();
            this.txtFotoYol = new TextBox();
            this.cmbKulup = new ComboBox();
            this.btnEkle = new Button();
            this.btnSil = new Button();
            this.btnGuncelle = new Button();
            this.btnEntityStateGoster = new Button();
            this.btnGeri = new Button();
            this.lblOgrenciID = new Label();
            this.lblOgrenciAd = new Label();
            this.lblOgrenciSoyad = new Label();
            this.lblFotoYol = new Label();
            this.lblKulup = new Label();
            this.lblBaslik = new Label();
            this.panelHeader = new Panel();
            this.panelForm = new Panel();
            this.panelButtons = new Panel();
            this.panelData = new Panel();
            this.groupBoxBilgiler = new GroupBox();
            this.panelHeader.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.groupBoxBilgiler.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            
            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(155, 89, 182);
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
            this.lblBaslik.Size = new Size(300, 30);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "CRUD İşlemleri (Soru 13-18)";
            
            // panelForm
            this.panelForm.BackColor = Color.FromArgb(236, 240, 241);
            this.panelForm.Dock = DockStyle.Top;
            this.panelForm.Height = 200;
            this.panelForm.Padding = new Padding(20);
            this.panelForm.Controls.Add(this.groupBoxBilgiler);
            
            // groupBoxBilgiler
            this.groupBoxBilgiler.BackColor = Color.White;
            this.groupBoxBilgiler.Dock = DockStyle.Fill;
            this.groupBoxBilgiler.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.groupBoxBilgiler.ForeColor = Color.FromArgb(44, 62, 80);
            this.groupBoxBilgiler.Padding = new Padding(15);
            this.groupBoxBilgiler.Controls.Add(this.cmbKulup);
            this.groupBoxBilgiler.Controls.Add(this.lblKulup);
            this.groupBoxBilgiler.Controls.Add(this.txtFotoYol);
            this.groupBoxBilgiler.Controls.Add(this.lblFotoYol);
            this.groupBoxBilgiler.Controls.Add(this.txtOgrenciSoyad);
            this.groupBoxBilgiler.Controls.Add(this.lblOgrenciSoyad);
            this.groupBoxBilgiler.Controls.Add(this.txtOgrenciAd);
            this.groupBoxBilgiler.Controls.Add(this.lblOgrenciAd);
            this.groupBoxBilgiler.Controls.Add(this.txtOgrenciID);
            this.groupBoxBilgiler.Controls.Add(this.lblOgrenciID);
            this.groupBoxBilgiler.Text = "Öğrenci Bilgileri";
            
            // lblOgrenciID
            this.lblOgrenciID.AutoSize = true;
            this.lblOgrenciID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblOgrenciID.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblOgrenciID.Location = new Point(15, 30);
            this.lblOgrenciID.Name = "lblOgrenciID";
            this.lblOgrenciID.Size = new Size(75, 15);
            this.lblOgrenciID.TabIndex = 1;
            this.lblOgrenciID.Text = "Öğrenci ID:";
            
            // txtOgrenciID
            this.txtOgrenciID.BorderStyle = BorderStyle.FixedSingle;
            this.txtOgrenciID.Font = new Font("Segoe UI", 9F, GraphicsUnit.Point);
            this.txtOgrenciID.Location = new Point(95, 28);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new Size(120, 23);
            this.txtOgrenciID.TabIndex = 2;
            
            // lblOgrenciAd
            this.lblOgrenciAd.AutoSize = true;
            this.lblOgrenciAd.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblOgrenciAd.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblOgrenciAd.Location = new Point(15, 65);
            this.lblOgrenciAd.Name = "lblOgrenciAd";
            this.lblOgrenciAd.Size = new Size(75, 15);
            this.lblOgrenciAd.TabIndex = 3;
            this.lblOgrenciAd.Text = "Öğrenci Adı:";
            
            // txtOgrenciAd
            this.txtOgrenciAd.BorderStyle = BorderStyle.FixedSingle;
            this.txtOgrenciAd.Font = new Font("Segoe UI", 9F, GraphicsUnit.Point);
            this.txtOgrenciAd.Location = new Point(95, 63);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new Size(180, 23);
            this.txtOgrenciAd.TabIndex = 4;
            
            // lblOgrenciSoyad
            this.lblOgrenciSoyad.AutoSize = true;
            this.lblOgrenciSoyad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblOgrenciSoyad.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblOgrenciSoyad.Location = new Point(290, 65);
            this.lblOgrenciSoyad.Name = "lblOgrenciSoyad";
            this.lblOgrenciSoyad.Size = new Size(92, 15);
            this.lblOgrenciSoyad.TabIndex = 5;
            this.lblOgrenciSoyad.Text = "Öğrenci Soyadı:";
            
            // txtOgrenciSoyad
            this.txtOgrenciSoyad.BorderStyle = BorderStyle.FixedSingle;
            this.txtOgrenciSoyad.Font = new Font("Segoe UI", 9F, GraphicsUnit.Point);
            this.txtOgrenciSoyad.Location = new Point(388, 63);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new Size(180, 23);
            this.txtOgrenciSoyad.TabIndex = 6;
            
            // lblFotoYol
            this.lblFotoYol.AutoSize = true;
            this.lblFotoYol.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblFotoYol.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblFotoYol.Location = new Point(15, 100);
            this.lblFotoYol.Name = "lblFotoYol";
            this.lblFotoYol.Size = new Size(63, 15);
            this.lblFotoYol.TabIndex = 7;
            this.lblFotoYol.Text = "Fotoğraf:";
            
            // txtFotoYol
            this.txtFotoYol.BorderStyle = BorderStyle.FixedSingle;
            this.txtFotoYol.Font = new Font("Segoe UI", 9F, GraphicsUnit.Point);
            this.txtFotoYol.Location = new Point(95, 98);
            this.txtFotoYol.Name = "txtFotoYol";
            this.txtFotoYol.Size = new Size(320, 23);
            this.txtFotoYol.TabIndex = 8;
            
            // lblKulup
            this.lblKulup.AutoSize = true;
            this.lblKulup.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblKulup.ForeColor = Color.FromArgb(44, 62, 80);
            this.lblKulup.Location = new Point(430, 100);
            this.lblKulup.Name = "lblKulup";
            this.lblKulup.Size = new Size(45, 15);
            this.lblKulup.TabIndex = 9;
            this.lblKulup.Text = "Kulüp:";
            
            // cmbKulup
            this.cmbKulup.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbKulup.FlatStyle = FlatStyle.Flat;
            this.cmbKulup.Font = new Font("Segoe UI", 9F, GraphicsUnit.Point);
            this.cmbKulup.FormattingEnabled = true;
            this.cmbKulup.Location = new Point(481, 98);
            this.cmbKulup.Name = "cmbKulup";
            this.cmbKulup.Size = new Size(220, 23);
            this.cmbKulup.TabIndex = 10;
            
            // panelButtons
            this.panelButtons.BackColor = Color.FromArgb(236, 240, 241);
            this.panelButtons.Dock = DockStyle.Top;
            this.panelButtons.Height = 70;
            this.panelButtons.Padding = new Padding(15);
            this.panelButtons.Controls.Add(this.btnGeri);
            this.panelButtons.Controls.Add(this.btnEntityStateGoster);
            this.panelButtons.Controls.Add(this.btnGuncelle);
            this.panelButtons.Controls.Add(this.btnSil);
            this.panelButtons.Controls.Add(this.btnEkle);
            
            // btnEkle
            this.btnEkle.BackColor = Color.FromArgb(46, 204, 113);
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = FlatStyle.Flat;
            this.btnEkle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnEkle.ForeColor = Color.White;
            this.btnEkle.Location = new Point(15, 15);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new Size(120, 40);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "➕ Ekle (Soru 13)";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            this.btnEkle.MouseEnter += new System.EventHandler(this.btnEkle_MouseEnter);
            this.btnEkle.MouseLeave += new System.EventHandler(this.btnEkle_MouseLeave);
            
            // btnSil
            this.btnSil.BackColor = Color.FromArgb(231, 76, 60);
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = FlatStyle.Flat;
            this.btnSil.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnSil.ForeColor = Color.White;
            this.btnSil.Location = new Point(145, 15);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new Size(120, 40);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "🗑️ Sil (Soru 15)";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            this.btnSil.MouseEnter += new System.EventHandler(this.btnSil_MouseEnter);
            this.btnSil.MouseLeave += new System.EventHandler(this.btnSil_MouseLeave);
            
            // btnGuncelle
            this.btnGuncelle.BackColor = Color.FromArgb(52, 152, 219);
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = FlatStyle.Flat;
            this.btnGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnGuncelle.ForeColor = Color.White;
            this.btnGuncelle.Location = new Point(275, 15);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new Size(140, 40);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "✏️ Güncelle (Soru 16)";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            this.btnGuncelle.MouseEnter += new System.EventHandler(this.btnGuncelle_MouseEnter);
            this.btnGuncelle.MouseLeave += new System.EventHandler(this.btnGuncelle_MouseLeave);
            
            // btnEntityStateGoster
            this.btnEntityStateGoster.BackColor = Color.FromArgb(155, 89, 182);
            this.btnEntityStateGoster.FlatAppearance.BorderSize = 0;
            this.btnEntityStateGoster.FlatStyle = FlatStyle.Flat;
            this.btnEntityStateGoster.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnEntityStateGoster.ForeColor = Color.White;
            this.btnEntityStateGoster.Location = new Point(425, 15);
            this.btnEntityStateGoster.Name = "btnEntityStateGoster";
            this.btnEntityStateGoster.Size = new Size(180, 40);
            this.btnEntityStateGoster.TabIndex = 14;
            this.btnEntityStateGoster.Text = "ℹ️ EntityState (Soru 18)";
            this.btnEntityStateGoster.UseVisualStyleBackColor = false;
            this.btnEntityStateGoster.Click += new System.EventHandler(this.btnEntityStateGoster_Click);
            this.btnEntityStateGoster.MouseEnter += new System.EventHandler(this.btnEntityStateGoster_MouseEnter);
            this.btnEntityStateGoster.MouseLeave += new System.EventHandler(this.btnEntityStateGoster_MouseLeave);
            
            // btnGeri
            this.btnGeri.BackColor = Color.FromArgb(149, 165, 166);
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = FlatStyle.Flat;
            this.btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnGeri.ForeColor = Color.White;
            this.btnGeri.Location = new Point(615, 15);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new Size(100, 40);
            this.btnGeri.TabIndex = 15;
            this.btnGeri.Text = "← Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            this.btnGeri.MouseEnter += new System.EventHandler(this.btnGeri_MouseEnter);
            this.btnGeri.MouseLeave += new System.EventHandler(this.btnGeri_MouseLeave);
            
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
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(155, 89, 182);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.dataGridView1.EnableHeadersVisualStyles = false;
            
            // FormCRUD
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 650);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(900, 600);
            this.Name = "FormCRUD";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "CRUD İşlemleri (Soru 13-18)";
            this.Load += new System.EventHandler(this.FormCRUD_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.groupBoxBilgiler.ResumeLayout(false);
            this.groupBoxBilgiler.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
