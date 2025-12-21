using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinavOgrenciSistemi
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnTemelEF;
        private Button btnNavigation;
        private Button btnCRUD;
        private Button btnLINQ;
        private Button btnAggregate;
        private Button btnDurum;
        private Button btnGelismis;
        private Label lblBaslik;
        private Panel panelHeader;
        private Panel panelContent;
        private Label lblAltBaslik;

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
            this.components = new System.ComponentModel.Container();
            this.btnTemelEF = new Button();
            this.btnNavigation = new Button();
            this.btnCRUD = new Button();
            this.btnLINQ = new Button();
            this.btnAggregate = new Button();
            this.btnDurum = new Button();
            this.btnGelismis = new Button();
            this.lblBaslik = new Label();
            this.lblAltBaslik = new Label();
            this.panelHeader = new Panel();
            this.panelContent = new Panel();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            
            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(41, 128, 185);
            this.panelHeader.Dock = DockStyle.Top;
            this.panelHeader.Controls.Add(this.lblAltBaslik);
            this.panelHeader.Controls.Add(this.lblBaslik);
            this.panelHeader.Height = 120;
            this.panelHeader.Padding = new Padding(20);
            
            // lblBaslik
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblBaslik.ForeColor = Color.White;
            this.lblBaslik.Location = new Point(20, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new Size(380, 45);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Sınav Öğrenci Sistemi";
            
            // lblAltBaslik
            this.lblAltBaslik.AutoSize = true;
            this.lblAltBaslik.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            this.lblAltBaslik.ForeColor = Color.FromArgb(236, 240, 241);
            this.lblAltBaslik.Location = new Point(20, 70);
            this.lblAltBaslik.Name = "lblAltBaslik";
            this.lblAltBaslik.Size = new Size(350, 20);
            this.lblAltBaslik.TabIndex = 1;
            this.lblAltBaslik.Text = "Entity Framework Ödev Uygulaması - 45 Soru";
            
            // panelContent
            this.panelContent.BackColor = Color.FromArgb(236, 240, 241);
            this.panelContent.Dock = DockStyle.Fill;
            this.panelContent.Padding = new Padding(30);
            this.panelContent.Controls.Add(this.btnGelismis);
            this.panelContent.Controls.Add(this.btnDurum);
            this.panelContent.Controls.Add(this.btnAggregate);
            this.panelContent.Controls.Add(this.btnLINQ);
            this.panelContent.Controls.Add(this.btnCRUD);
            this.panelContent.Controls.Add(this.btnNavigation);
            this.panelContent.Controls.Add(this.btnTemelEF);
            
            // btnTemelEF
            this.btnTemelEF.BackColor = Color.FromArgb(52, 152, 219);
            this.btnTemelEF.FlatAppearance.BorderSize = 0;
            this.btnTemelEF.FlatStyle = FlatStyle.Flat;
            this.btnTemelEF.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnTemelEF.ForeColor = Color.White;
            this.btnTemelEF.Location = new Point(30, 30);
            this.btnTemelEF.Name = "btnTemelEF";
            this.btnTemelEF.Size = new Size(280, 60);
            this.btnTemelEF.TabIndex = 1;
            this.btnTemelEF.Text = "1️⃣ Temel EF İşlemleri\r\n(Soru 1-5)";
            this.btnTemelEF.TextAlign = ContentAlignment.MiddleCenter;
            this.btnTemelEF.UseVisualStyleBackColor = false;
            this.btnTemelEF.Click += new EventHandler(this.btnTemelEF_Click);
            this.btnTemelEF.MouseEnter += (s, e) => { btnTemelEF.BackColor = Color.FromArgb(41, 128, 185); };
            this.btnTemelEF.MouseLeave += (s, e) => { btnTemelEF.BackColor = Color.FromArgb(52, 152, 219); };
            
            // btnNavigation
            this.btnNavigation.BackColor = Color.FromArgb(46, 204, 113);
            this.btnNavigation.FlatAppearance.BorderSize = 0;
            this.btnNavigation.FlatStyle = FlatStyle.Flat;
            this.btnNavigation.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnNavigation.ForeColor = Color.White;
            this.btnNavigation.Location = new Point(330, 30);
            this.btnNavigation.Name = "btnNavigation";
            this.btnNavigation.Size = new Size(280, 60);
            this.btnNavigation.TabIndex = 2;
            this.btnNavigation.Text = "2️⃣ Navigation & İlişkiler\r\n(Soru 6-12)";
            this.btnNavigation.TextAlign = ContentAlignment.MiddleCenter;
            this.btnNavigation.UseVisualStyleBackColor = false;
            this.btnNavigation.Click += new EventHandler(this.btnNavigation_Click);
            this.btnNavigation.MouseEnter += (s, e) => { btnNavigation.BackColor = Color.FromArgb(39, 174, 96); };
            this.btnNavigation.MouseLeave += (s, e) => { btnNavigation.BackColor = Color.FromArgb(46, 204, 113); };
            
            // btnCRUD
            this.btnCRUD.BackColor = Color.FromArgb(155, 89, 182);
            this.btnCRUD.FlatAppearance.BorderSize = 0;
            this.btnCRUD.FlatStyle = FlatStyle.Flat;
            this.btnCRUD.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnCRUD.ForeColor = Color.White;
            this.btnCRUD.Location = new Point(630, 30);
            this.btnCRUD.Name = "btnCRUD";
            this.btnCRUD.Size = new Size(280, 60);
            this.btnCRUD.TabIndex = 3;
            this.btnCRUD.Text = "3️⃣ CRUD İşlemleri\r\n(Soru 13-18)";
            this.btnCRUD.TextAlign = ContentAlignment.MiddleCenter;
            this.btnCRUD.UseVisualStyleBackColor = false;
            this.btnCRUD.Click += new EventHandler(this.btnCRUD_Click);
            this.btnCRUD.MouseEnter += (s, e) => { btnCRUD.BackColor = Color.FromArgb(142, 68, 173); };
            this.btnCRUD.MouseLeave += (s, e) => { btnCRUD.BackColor = Color.FromArgb(155, 89, 182); };
            
            // btnLINQ
            this.btnLINQ.BackColor = Color.FromArgb(241, 196, 15);
            this.btnLINQ.FlatAppearance.BorderSize = 0;
            this.btnLINQ.FlatStyle = FlatStyle.Flat;
            this.btnLINQ.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnLINQ.ForeColor = Color.White;
            this.btnLINQ.Location = new Point(30, 110);
            this.btnLINQ.Name = "btnLINQ";
            this.btnLINQ.Size = new Size(280, 60);
            this.btnLINQ.TabIndex = 4;
            this.btnLINQ.Text = "4️⃣ LINQ Filtreleme\r\n(Soru 19-25)";
            this.btnLINQ.TextAlign = ContentAlignment.MiddleCenter;
            this.btnLINQ.UseVisualStyleBackColor = false;
            this.btnLINQ.Click += new EventHandler(this.btnLINQ_Click);
            this.btnLINQ.MouseEnter += (s, e) => { btnLINQ.BackColor = Color.FromArgb(243, 156, 18); };
            this.btnLINQ.MouseLeave += (s, e) => { btnLINQ.BackColor = Color.FromArgb(241, 196, 15); };
            
            // btnAggregate
            this.btnAggregate.BackColor = Color.FromArgb(230, 126, 34);
            this.btnAggregate.FlatAppearance.BorderSize = 0;
            this.btnAggregate.FlatStyle = FlatStyle.Flat;
            this.btnAggregate.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnAggregate.ForeColor = Color.White;
            this.btnAggregate.Location = new Point(330, 110);
            this.btnAggregate.Name = "btnAggregate";
            this.btnAggregate.Size = new Size(280, 60);
            this.btnAggregate.TabIndex = 5;
            this.btnAggregate.Text = "5️⃣ Toplam/Ortalama\r\n(Soru 26-28)";
            this.btnAggregate.TextAlign = ContentAlignment.MiddleCenter;
            this.btnAggregate.UseVisualStyleBackColor = false;
            this.btnAggregate.Click += new EventHandler(this.btnAggregate_Click);
            this.btnAggregate.MouseEnter += (s, e) => { btnAggregate.BackColor = Color.FromArgb(211, 84, 0); };
            this.btnAggregate.MouseLeave += (s, e) => { btnAggregate.BackColor = Color.FromArgb(230, 126, 34); };
            
            // btnDurum
            this.btnDurum.BackColor = Color.FromArgb(231, 76, 60);
            this.btnDurum.FlatAppearance.BorderSize = 0;
            this.btnDurum.FlatStyle = FlatStyle.Flat;
            this.btnDurum.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnDurum.ForeColor = Color.White;
            this.btnDurum.Location = new Point(630, 110);
            this.btnDurum.Name = "btnDurum";
            this.btnDurum.Size = new Size(280, 60);
            this.btnDurum.TabIndex = 6;
            this.btnDurum.Text = "6️⃣ Durum Hesaplama\r\n(Soru 29-30)";
            this.btnDurum.TextAlign = ContentAlignment.MiddleCenter;
            this.btnDurum.UseVisualStyleBackColor = false;
            this.btnDurum.Click += new EventHandler(this.btnDurum_Click);
            this.btnDurum.MouseEnter += (s, e) => { btnDurum.BackColor = Color.FromArgb(192, 57, 43); };
            this.btnDurum.MouseLeave += (s, e) => { btnDurum.BackColor = Color.FromArgb(231, 76, 60); };
            
            // btnGelismis
            this.btnGelismis.BackColor = Color.FromArgb(26, 188, 156);
            this.btnGelismis.FlatAppearance.BorderSize = 0;
            this.btnGelismis.FlatStyle = FlatStyle.Flat;
            this.btnGelismis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnGelismis.ForeColor = Color.White;
            this.btnGelismis.Location = new Point(330, 190);
            this.btnGelismis.Name = "btnGelismis";
            this.btnGelismis.Size = new Size(280, 70);
            this.btnGelismis.TabIndex = 7;
            this.btnGelismis.Text = "7️⃣ Gelişmiş Özellikler\r\nSP/Functions/Transactions\r\n(Soru 30-45)";
            this.btnGelismis.TextAlign = ContentAlignment.MiddleCenter;
            this.btnGelismis.UseVisualStyleBackColor = false;
            this.btnGelismis.Click += new EventHandler(this.btnGelismis_Click);
            this.btnGelismis.MouseEnter += (s, e) => { btnGelismis.BackColor = Color.FromArgb(22, 160, 133); };
            this.btnGelismis.MouseLeave += (s, e) => { btnGelismis.BackColor = Color.FromArgb(26, 188, 156); };
            
            // FormMain
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(940, 300);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(940, 300);
            this.Name = "FormMain";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sınav Öğrenci Sistemi - Ana Menü";
            this.WindowState = FormWindowState.Normal;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
