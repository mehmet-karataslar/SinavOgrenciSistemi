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
            this.btnTemelEF = new System.Windows.Forms.Button();
            this.btnNavigation = new System.Windows.Forms.Button();
            this.btnCRUD = new System.Windows.Forms.Button();
            this.btnLINQ = new System.Windows.Forms.Button();
            this.btnAggregate = new System.Windows.Forms.Button();
            this.btnDurum = new System.Windows.Forms.Button();
            this.btnGelismis = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblAltBaslik = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemelEF
            // 
            this.btnTemelEF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnTemelEF.FlatAppearance.BorderSize = 0;
            this.btnTemelEF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemelEF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTemelEF.ForeColor = System.Drawing.Color.White;
            this.btnTemelEF.Location = new System.Drawing.Point(13, 44);
            this.btnTemelEF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTemelEF.Name = "btnTemelEF";
            this.btnTemelEF.Size = new System.Drawing.Size(463, 127);
            this.btnTemelEF.TabIndex = 1;
            this.btnTemelEF.Text = "Temel EF İşlemleri\r\n(Soru 1-5)";
            this.btnTemelEF.UseVisualStyleBackColor = false;
            this.btnTemelEF.Click += new System.EventHandler(this.btnTemelEF_Click);
            this.btnTemelEF.MouseEnter += new System.EventHandler(this.btnTemelEF_MouseEnter);
            this.btnTemelEF.MouseLeave += new System.EventHandler(this.btnTemelEF_MouseLeave);
            // 
            // btnNavigation
            // 
            this.btnNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnNavigation.FlatAppearance.BorderSize = 0;
            this.btnNavigation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavigation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNavigation.ForeColor = System.Drawing.Color.White;
            this.btnNavigation.Location = new System.Drawing.Point(525, 44);
            this.btnNavigation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavigation.Name = "btnNavigation";
            this.btnNavigation.Size = new System.Drawing.Size(463, 127);
            this.btnNavigation.TabIndex = 2;
            this.btnNavigation.Text = "Navigation & İlişkiler\r\n(Soru 6-12)";
            this.btnNavigation.UseVisualStyleBackColor = false;
            this.btnNavigation.Click += new System.EventHandler(this.btnNavigation_Click);
            this.btnNavigation.MouseEnter += new System.EventHandler(this.btnNavigation_MouseEnter);
            this.btnNavigation.MouseLeave += new System.EventHandler(this.btnNavigation_MouseLeave);
            // 
            // btnCRUD
            // 
            this.btnCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnCRUD.FlatAppearance.BorderSize = 0;
            this.btnCRUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCRUD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCRUD.ForeColor = System.Drawing.Color.White;
            this.btnCRUD.Location = new System.Drawing.Point(1065, 44);
            this.btnCRUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCRUD.Name = "btnCRUD";
            this.btnCRUD.Size = new System.Drawing.Size(463, 127);
            this.btnCRUD.TabIndex = 3;
            this.btnCRUD.Text = "CRUD İşlemleri\r\n(Soru 13-18)";
            this.btnCRUD.UseVisualStyleBackColor = false;
            this.btnCRUD.Click += new System.EventHandler(this.btnCRUD_Click);
            this.btnCRUD.MouseEnter += new System.EventHandler(this.btnCRUD_MouseEnter);
            this.btnCRUD.MouseLeave += new System.EventHandler(this.btnCRUD_MouseLeave);
            // 
            // btnLINQ
            // 
            this.btnLINQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnLINQ.FlatAppearance.BorderSize = 0;
            this.btnLINQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLINQ.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLINQ.ForeColor = System.Drawing.Color.White;
            this.btnLINQ.Location = new System.Drawing.Point(13, 243);
            this.btnLINQ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLINQ.Name = "btnLINQ";
            this.btnLINQ.Size = new System.Drawing.Size(463, 127);
            this.btnLINQ.TabIndex = 4;
            this.btnLINQ.Text = "LINQ Filtreleme\r\n(Soru 19-25)";
            this.btnLINQ.UseVisualStyleBackColor = false;
            this.btnLINQ.Click += new System.EventHandler(this.btnLINQ_Click);
            this.btnLINQ.MouseEnter += new System.EventHandler(this.btnLINQ_MouseEnter);
            this.btnLINQ.MouseLeave += new System.EventHandler(this.btnLINQ_MouseLeave);
            // 
            // btnAggregate
            // 
            this.btnAggregate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnAggregate.FlatAppearance.BorderSize = 0;
            this.btnAggregate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAggregate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAggregate.ForeColor = System.Drawing.Color.White;
            this.btnAggregate.Location = new System.Drawing.Point(525, 243);
            this.btnAggregate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAggregate.Name = "btnAggregate";
            this.btnAggregate.Size = new System.Drawing.Size(463, 127);
            this.btnAggregate.TabIndex = 5;
            this.btnAggregate.Text = "Toplam/Ortalama\r\n(Soru 26-28)";
            this.btnAggregate.UseVisualStyleBackColor = false;
            this.btnAggregate.Click += new System.EventHandler(this.btnAggregate_Click);
            this.btnAggregate.MouseEnter += new System.EventHandler(this.btnAggregate_MouseEnter);
            this.btnAggregate.MouseLeave += new System.EventHandler(this.btnAggregate_MouseLeave);
            // 
            // btnDurum
            // 
            this.btnDurum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDurum.FlatAppearance.BorderSize = 0;
            this.btnDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurum.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDurum.ForeColor = System.Drawing.Color.White;
            this.btnDurum.Location = new System.Drawing.Point(1065, 243);
            this.btnDurum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDurum.Name = "btnDurum";
            this.btnDurum.Size = new System.Drawing.Size(463, 127);
            this.btnDurum.TabIndex = 6;
            this.btnDurum.Text = "Durum Hesaplama\r\n(Soru 29-30)";
            this.btnDurum.UseVisualStyleBackColor = false;
            this.btnDurum.Click += new System.EventHandler(this.btnDurum_Click);
            this.btnDurum.MouseEnter += new System.EventHandler(this.btnDurum_MouseEnter);
            this.btnDurum.MouseLeave += new System.EventHandler(this.btnDurum_MouseLeave);
            // 
            // btnGelismis
            // 
            this.btnGelismis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnGelismis.FlatAppearance.BorderSize = 0;
            this.btnGelismis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelismis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGelismis.ForeColor = System.Drawing.Color.White;
            this.btnGelismis.Location = new System.Drawing.Point(525, 477);
            this.btnGelismis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGelismis.Name = "btnGelismis";
            this.btnGelismis.Size = new System.Drawing.Size(463, 140);
            this.btnGelismis.TabIndex = 7;
            this.btnGelismis.Text = "Gelişmiş Özellikler\r\nSP/Functions/Transactions\r\n(Soru 30-45)";
            this.btnGelismis.UseVisualStyleBackColor = false;
            this.btnGelismis.Click += new System.EventHandler(this.btnGelismis_Click);
            this.btnGelismis.MouseEnter += new System.EventHandler(this.btnGelismis_MouseEnter);
            this.btnGelismis.MouseLeave += new System.EventHandler(this.btnGelismis_MouseLeave);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(26, 27);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(518, 65);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Sınav Öğrenci Sistemi";
            // 
            // lblAltBaslik
            // 
            this.lblAltBaslik.AutoSize = true;
            this.lblAltBaslik.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAltBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.lblAltBaslik.Location = new System.Drawing.Point(26, 93);
            this.lblAltBaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAltBaslik.Name = "lblAltBaslik";
            this.lblAltBaslik.Size = new System.Drawing.Size(453, 30);
            this.lblAltBaslik.TabIndex = 1;
            this.lblAltBaslik.Text = "Entity Framework Ödev Uygulaması - 45 Soru";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelHeader.Controls.Add(this.lblAltBaslik);
            this.panelHeader.Controls.Add(this.lblBaslik);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(26, 27, 26, 27);
            this.panelHeader.Size = new System.Drawing.Size(1543, 160);
            this.panelHeader.TabIndex = 1;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelContent.Controls.Add(this.btnGelismis);
            this.panelContent.Controls.Add(this.btnDurum);
            this.panelContent.Controls.Add(this.btnAggregate);
            this.panelContent.Controls.Add(this.btnLINQ);
            this.panelContent.Controls.Add(this.btnCRUD);
            this.panelContent.Controls.Add(this.btnNavigation);
            this.panelContent.Controls.Add(this.btnTemelEF);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 160);
            this.panelContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(39, 40, 39, 40);
            this.panelContent.Size = new System.Drawing.Size(1543, 638);
            this.panelContent.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1543, 798);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1202, 381);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sınav Öğrenci Sistemi - Ana Menü";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
