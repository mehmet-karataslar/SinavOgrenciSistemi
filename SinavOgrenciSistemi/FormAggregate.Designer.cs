using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinavOgrenciSistemi
{
    partial class FormAggregate
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button btnSinav1Toplam;
        private Button btnSinav1Ortalama;
        private Button btnOrtalamaUzeri;
        private Button btnGeri;
        private Label lblBaslik;
        private Panel panelHeader;
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
            this.btnSinav1Toplam = new Button();
            this.btnSinav1Ortalama = new Button();
            this.btnOrtalamaUzeri = new Button();
            this.btnGeri = new Button();
            this.lblBaslik = new Label();
            this.panelHeader = new Panel();
            this.panelButtons = new Panel();
            this.panelData = new Panel();
            this.panelHeader.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            
            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(230, 126, 34);
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
            this.lblBaslik.Text = "TOPLAM - ORTALAMA - MAX - MIN";
            
            // panelButtons
            this.panelButtons.BackColor = Color.FromArgb(236, 240, 241);
            this.panelButtons.Dock = DockStyle.Top;
            this.panelButtons.Height = 80;
            this.panelButtons.Padding = new Padding(20, 15, 20, 15);
            this.panelButtons.Controls.Add(this.btnGeri);
            this.panelButtons.Controls.Add(this.btnOrtalamaUzeri);
            this.panelButtons.Controls.Add(this.btnSinav1Ortalama);
            this.panelButtons.Controls.Add(this.btnSinav1Toplam);
            
            // btnSinav1Toplam
            this.btnSinav1Toplam.BackColor = Color.FromArgb(52, 152, 219);
            this.btnSinav1Toplam.FlatAppearance.BorderSize = 0;
            this.btnSinav1Toplam.FlatStyle = FlatStyle.Flat;
            this.btnSinav1Toplam.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnSinav1Toplam.ForeColor = Color.White;
            this.btnSinav1Toplam.Location = new Point(20, 15);
            this.btnSinav1Toplam.Name = "btnSinav1Toplam";
            this.btnSinav1Toplam.Size = new Size(220, 50);
            this.btnSinav1Toplam.TabIndex = 1;
            this.btnSinav1Toplam.Text = "Soru 26: SINAV1 Toplamı";
            this.btnSinav1Toplam.UseVisualStyleBackColor = false;
            this.btnSinav1Toplam.Click += new System.EventHandler(this.btnSinav1Toplam_Click);
            this.btnSinav1Toplam.MouseEnter += new System.EventHandler(this.btnSinav1Toplam_MouseEnter);
            this.btnSinav1Toplam.MouseLeave += new System.EventHandler(this.btnSinav1Toplam_MouseLeave);
            
            // btnSinav1Ortalama
            this.btnSinav1Ortalama.BackColor = Color.FromArgb(46, 204, 113);
            this.btnSinav1Ortalama.FlatAppearance.BorderSize = 0;
            this.btnSinav1Ortalama.FlatStyle = FlatStyle.Flat;
            this.btnSinav1Ortalama.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnSinav1Ortalama.ForeColor = Color.White;
            this.btnSinav1Ortalama.Location = new Point(250, 15);
            this.btnSinav1Ortalama.Name = "btnSinav1Ortalama";
            this.btnSinav1Ortalama.Size = new Size(220, 50);
            this.btnSinav1Ortalama.TabIndex = 2;
            this.btnSinav1Ortalama.Text = "Soru 27: SINAV1 Ortalaması";
            this.btnSinav1Ortalama.UseVisualStyleBackColor = false;
            this.btnSinav1Ortalama.Click += new System.EventHandler(this.btnSinav1Ortalama_Click);
            this.btnSinav1Ortalama.MouseEnter += new System.EventHandler(this.btnSinav1Ortalama_MouseEnter);
            this.btnSinav1Ortalama.MouseLeave += new System.EventHandler(this.btnSinav1Ortalama_MouseLeave);
            
            // btnOrtalamaUzeri
            this.btnOrtalamaUzeri.BackColor = Color.FromArgb(155, 89, 182);
            this.btnOrtalamaUzeri.FlatAppearance.BorderSize = 0;
            this.btnOrtalamaUzeri.FlatStyle = FlatStyle.Flat;
            this.btnOrtalamaUzeri.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnOrtalamaUzeri.ForeColor = Color.White;
            this.btnOrtalamaUzeri.Location = new Point(480, 15);
            this.btnOrtalamaUzeri.Name = "btnOrtalamaUzeri";
            this.btnOrtalamaUzeri.Size = new Size(220, 50);
            this.btnOrtalamaUzeri.TabIndex = 3;
            this.btnOrtalamaUzeri.Text = "Soru 28: Ortalama Üzeri";
            this.btnOrtalamaUzeri.UseVisualStyleBackColor = false;
            this.btnOrtalamaUzeri.Click += new System.EventHandler(this.btnOrtalamaUzeri_Click);
            this.btnOrtalamaUzeri.MouseEnter += new System.EventHandler(this.btnOrtalamaUzeri_MouseEnter);
            this.btnOrtalamaUzeri.MouseLeave += new System.EventHandler(this.btnOrtalamaUzeri_MouseLeave);
            
            // btnGeri
            this.btnGeri.BackColor = Color.FromArgb(149, 165, 166);
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = FlatStyle.Flat;
            this.btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnGeri.ForeColor = Color.White;
            this.btnGeri.Location = new Point(710, 15);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new Size(100, 50);
            this.btnGeri.TabIndex = 4;
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
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 126, 34);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.dataGridView1.EnableHeadersVisualStyles = false;
            
            // FormAggregate
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 600);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(900, 500);
            this.Name = "FormAggregate";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Toplam/Ortalama (Soru 26-28)";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
