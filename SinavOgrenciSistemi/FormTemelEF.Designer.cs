using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinavOgrenciSistemi
{
    partial class FormTemelEF
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button btnOgrenciListele;
        private Button btnOgrenciListeleGizli;
        private Button btnDersListeleEF;
        private Button btnDersListeleADO;
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
            this.btnOgrenciListele = new Button();
            this.btnOgrenciListeleGizli = new Button();
            this.btnDersListeleEF = new Button();
            this.btnDersListeleADO = new Button();
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
            this.panelHeader.BackColor = Color.FromArgb(52, 152, 219);
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
            this.lblBaslik.Size = new Size(380, 30);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Temel Entity Framework İşlemleri";
            
            // panelButtons
            this.panelButtons.BackColor = Color.FromArgb(236, 240, 241);
            this.panelButtons.Dock = DockStyle.Top;
            this.panelButtons.Height = 80;
            this.panelButtons.Padding = new Padding(15);
            this.panelButtons.Controls.Add(this.btnGeri);
            this.panelButtons.Controls.Add(this.btnDersListeleADO);
            this.panelButtons.Controls.Add(this.btnDersListeleEF);
            this.panelButtons.Controls.Add(this.btnOgrenciListeleGizli);
            this.panelButtons.Controls.Add(this.btnOgrenciListele);
            
            // btnOgrenciListele
            this.btnOgrenciListele.BackColor = Color.FromArgb(52, 152, 219);
            this.btnOgrenciListele.FlatAppearance.BorderSize = 0;
            this.btnOgrenciListele.FlatStyle = FlatStyle.Flat;
            this.btnOgrenciListele.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnOgrenciListele.ForeColor = Color.White;
            this.btnOgrenciListele.Location = new Point(15, 15);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new Size(150, 50);
            this.btnOgrenciListele.TabIndex = 2;
            this.btnOgrenciListele.Text = "Soru 2: Öğrenci Listele";
            this.btnOgrenciListele.UseVisualStyleBackColor = false;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            this.btnOgrenciListele.MouseEnter += new System.EventHandler(this.btnOgrenciListele_MouseEnter);
            this.btnOgrenciListele.MouseLeave += new System.EventHandler(this.btnOgrenciListele_MouseLeave);
            
            // btnOgrenciListeleGizli
            this.btnOgrenciListeleGizli.BackColor = Color.FromArgb(46, 204, 113);
            this.btnOgrenciListeleGizli.FlatAppearance.BorderSize = 0;
            this.btnOgrenciListeleGizli.FlatStyle = FlatStyle.Flat;
            this.btnOgrenciListeleGizli.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnOgrenciListeleGizli.ForeColor = Color.White;
            this.btnOgrenciListeleGizli.Location = new Point(175, 15);
            this.btnOgrenciListeleGizli.Name = "btnOgrenciListeleGizli";
            this.btnOgrenciListeleGizli.Size = new Size(150, 50);
            this.btnOgrenciListeleGizli.TabIndex = 3;
            this.btnOgrenciListeleGizli.Text = "Soru 3: Foto Gizli Listele";
            this.btnOgrenciListeleGizli.UseVisualStyleBackColor = false;
            this.btnOgrenciListeleGizli.Click += new System.EventHandler(this.btnOgrenciListeleGizli_Click);
            this.btnOgrenciListeleGizli.MouseEnter += new System.EventHandler(this.btnOgrenciListeleGizli_MouseEnter);
            this.btnOgrenciListeleGizli.MouseLeave += new System.EventHandler(this.btnOgrenciListeleGizli_MouseLeave);
            
            // btnDersListeleEF
            this.btnDersListeleEF.BackColor = Color.FromArgb(155, 89, 182);
            this.btnDersListeleEF.FlatAppearance.BorderSize = 0;
            this.btnDersListeleEF.FlatStyle = FlatStyle.Flat;
            this.btnDersListeleEF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnDersListeleEF.ForeColor = Color.White;
            this.btnDersListeleEF.Location = new Point(335, 15);
            this.btnDersListeleEF.Name = "btnDersListeleEF";
            this.btnDersListeleEF.Size = new Size(150, 50);
            this.btnDersListeleEF.TabIndex = 4;
            this.btnDersListeleEF.Text = "Soru 4: Ders Listele (EF)";
            this.btnDersListeleEF.UseVisualStyleBackColor = false;
            this.btnDersListeleEF.Click += new System.EventHandler(this.btnDersListeleEF_Click);
            this.btnDersListeleEF.MouseEnter += new System.EventHandler(this.btnDersListeleEF_MouseEnter);
            this.btnDersListeleEF.MouseLeave += new System.EventHandler(this.btnDersListeleEF_MouseLeave);
            
            // btnDersListeleADO
            this.btnDersListeleADO.BackColor = Color.FromArgb(241, 196, 15);
            this.btnDersListeleADO.FlatAppearance.BorderSize = 0;
            this.btnDersListeleADO.FlatStyle = FlatStyle.Flat;
            this.btnDersListeleADO.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnDersListeleADO.ForeColor = Color.White;
            this.btnDersListeleADO.Location = new Point(495, 15);
            this.btnDersListeleADO.Name = "btnDersListeleADO";
            this.btnDersListeleADO.Size = new Size(150, 50);
            this.btnDersListeleADO.TabIndex = 5;
            this.btnDersListeleADO.Text = "Soru 5: Ders Listele (ADO.NET)";
            this.btnDersListeleADO.UseVisualStyleBackColor = false;
            this.btnDersListeleADO.Click += new System.EventHandler(this.btnDersListeleADO_Click);
            this.btnDersListeleADO.MouseEnter += new System.EventHandler(this.btnDersListeleADO_MouseEnter);
            this.btnDersListeleADO.MouseLeave += new System.EventHandler(this.btnDersListeleADO_MouseLeave);
            
            // btnGeri
            this.btnGeri.BackColor = Color.FromArgb(149, 165, 166);
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = FlatStyle.Flat;
            this.btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnGeri.ForeColor = Color.White;
            this.btnGeri.Location = new Point(655, 15);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new Size(100, 50);
            this.btnGeri.TabIndex = 6;
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
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.dataGridView1.EnableHeadersVisualStyles = false;
            
            // FormTemelEF
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 600);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(800, 500);
            this.Name = "FormTemelEF";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Temel Entity Framework İşlemleri (Soru 1-5)";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
