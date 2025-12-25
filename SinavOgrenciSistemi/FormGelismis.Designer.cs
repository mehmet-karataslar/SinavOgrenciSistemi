using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinavOgrenciSistemi
{
    partial class FormGelismis
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl1;
        private TabPage tabSP;
        private TabPage tabFunctions;
        private TabPage tabTransactions;
        private DataGridView dataGridView1;
        private TextBox txtOgrenciID;
        private TextBox txtOgrenciAd;
        private TextBox txtOgrenciSoyad;
        private TextBox txtFotoYol;
        private TextBox txtSinav1;
        private TextBox txtSinav2;
        private TextBox txtSinav3;
        private TextBox txtNotID;
        private TextBox txtMinOrtalama;
        private TextBox txtMaxOrtalama;
        private ComboBox cmbKulup;
        private ComboBox cmbDers;
        private CheckBox chkGecti;
        private CheckBox chkKaldi;
        private Button btnSPNotEkle;
        private Button btnOgrenciDetay;
        private Button btnDersBasariSP;
        private Button btnSPNotGuncelle;
        private Button btnTopluSil;
        private Button btnScalarFunction;
        private Button btnTVFDersNot;
        private Button btnCokParametreliTVF;
        private Button btnKulupDashboard;
        private Button btnZayifOgrenciler;
        private Button btnOgrenciNotOzet;
        private Button btnCokAdimliKayit;
        private Button btnTopluNotGuncelle;
        private Button btnCokTabloTransaction;
        private Button btnTransactionSP;
        private Button btnFotoGuncelle;
        private Button btnGeri;
        private Label lblOgrenciID;
        private Label lblDers;
        private Label lblKulup;
        private Label lblSinav1;
        private Label lblSinav2;
        private Label lblSinav3;
        private Label lblNotID;
        private Label lblMinOrtalama;
        private Label lblMaxOrtalama;
        private Label lblToplamDers;
        private Label lblGecenDers;
        private Label lblKalanDers;
        private Label lblGenelOrt;
        private Label lblBaslik;
        private Panel panelHeader;
        private Panel panelData;
        private GroupBox groupBoxSP;
        private GroupBox groupBoxFunctions;
        private GroupBox groupBoxTransactions;
        private FlowLayoutPanel flowPanelSP;
        private FlowLayoutPanel flowPanelFunctions;
        private FlowLayoutPanel flowPanelTransactions;

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
            this.tabControl1 = new TabControl();
            this.tabSP = new TabPage();
            this.tabFunctions = new TabPage();
            this.tabTransactions = new TabPage();
            this.dataGridView1 = new DataGridView();
            this.txtOgrenciID = new TextBox();
            this.txtOgrenciAd = new TextBox();
            this.txtOgrenciSoyad = new TextBox();
            this.txtFotoYol = new TextBox();
            this.txtSinav1 = new TextBox();
            this.txtSinav2 = new TextBox();
            this.txtSinav3 = new TextBox();
            this.txtNotID = new TextBox();
            this.txtMinOrtalama = new TextBox();
            this.txtMaxOrtalama = new TextBox();
            this.cmbKulup = new ComboBox();
            this.cmbDers = new ComboBox();
            this.chkGecti = new CheckBox();
            this.chkKaldi = new CheckBox();
            this.btnSPNotEkle = new Button();
            this.btnOgrenciDetay = new Button();
            this.btnDersBasariSP = new Button();
            this.btnSPNotGuncelle = new Button();
            this.btnTopluSil = new Button();
            this.btnScalarFunction = new Button();
            this.btnTVFDersNot = new Button();
            this.btnCokParametreliTVF = new Button();
            this.btnKulupDashboard = new Button();
            this.btnZayifOgrenciler = new Button();
            this.btnOgrenciNotOzet = new Button();
            this.btnCokAdimliKayit = new Button();
            this.btnTopluNotGuncelle = new Button();
            this.btnCokTabloTransaction = new Button();
            this.btnTransactionSP = new Button();
            this.btnFotoGuncelle = new Button();
            this.btnGeri = new Button();
            this.lblOgrenciID = new Label();
            this.lblDers = new Label();
            this.lblKulup = new Label();
            this.lblSinav1 = new Label();
            this.lblSinav2 = new Label();
            this.lblSinav3 = new Label();
            this.lblNotID = new Label();
            this.lblMinOrtalama = new Label();
            this.lblMaxOrtalama = new Label();
            this.lblToplamDers = new Label();
            this.lblGecenDers = new Label();
            this.lblKalanDers = new Label();
            this.lblGenelOrt = new Label();
            this.lblBaslik = new Label();
            this.panelHeader = new Panel();
            this.panelData = new Panel();
            this.groupBoxSP = new GroupBox();
            this.groupBoxFunctions = new GroupBox();
            this.groupBoxTransactions = new GroupBox();
            this.flowPanelSP = new FlowLayoutPanel();
            this.flowPanelFunctions = new FlowLayoutPanel();
            this.flowPanelTransactions = new FlowLayoutPanel();
            this.panelHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSP.SuspendLayout();
            this.tabFunctions.SuspendLayout();
            this.tabTransactions.SuspendLayout();
            this.groupBoxSP.SuspendLayout();
            this.groupBoxFunctions.SuspendLayout();
            this.groupBoxTransactions.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            
            // panelHeader
            this.panelHeader.BackColor = Color.FromArgb(26, 188, 156);
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
            this.lblBaslik.Size = new Size(500, 30);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Gelişmiş: SP/Functions/Transactions (Soru 30-45)";
            
            // tabControl1
            this.tabControl1.Appearance = TabAppearance.FlatButtons;
            this.tabControl1.Dock = DockStyle.Fill;
            this.tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.tabControl1.ItemSize = new Size(200, 40);
            this.tabControl1.Location = new Point(0, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new Size(1200, 450);
            this.tabControl1.SizeMode = TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Controls.Add(this.tabSP);
            this.tabControl1.Controls.Add(this.tabFunctions);
            this.tabControl1.Controls.Add(this.tabTransactions);
            
            // tabSP
            this.tabSP.BackColor = Color.FromArgb(236, 240, 241);
            this.tabSP.Controls.Add(this.groupBoxSP);
            this.tabSP.Location = new Point(4, 44);
            this.tabSP.Name = "tabSP";
            this.tabSP.Padding = new Padding(3);
            this.tabSP.Size = new Size(1192, 402);
            this.tabSP.TabIndex = 0;
            this.tabSP.Text = "📊 Stored Procedures";
            this.tabSP.UseVisualStyleBackColor = true;
            
            // groupBoxSP
            this.groupBoxSP.BackColor = Color.White;
            this.groupBoxSP.Dock = DockStyle.Fill;
            this.groupBoxSP.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.groupBoxSP.ForeColor = Color.FromArgb(44, 62, 80);
            this.groupBoxSP.Padding = new Padding(20);
            this.groupBoxSP.Controls.Add(this.flowPanelSP);
            this.groupBoxSP.Text = "Stored Procedure İşlemleri";
            
            // flowPanelSP
            this.flowPanelSP.AutoScroll = true;
            this.flowPanelSP.Dock = DockStyle.Fill;
            this.flowPanelSP.FlowDirection = FlowDirection.TopDown;
            this.flowPanelSP.WrapContents = false;
            this.flowPanelSP.Padding = new Padding(10);
            
            // SP kontrolleri ekle
            AddSPControls();
            
            // tabFunctions
            this.tabFunctions.BackColor = Color.FromArgb(236, 240, 241);
            this.tabFunctions.Controls.Add(this.groupBoxFunctions);
            this.tabFunctions.Location = new Point(4, 44);
            this.tabFunctions.Name = "tabFunctions";
            this.tabFunctions.Padding = new Padding(3);
            this.tabFunctions.Size = new Size(1192, 402);
            this.tabFunctions.TabIndex = 1;
            this.tabFunctions.Text = "⚙️ Functions";
            this.tabFunctions.UseVisualStyleBackColor = true;
            
            // groupBoxFunctions
            this.groupBoxFunctions.BackColor = Color.White;
            this.groupBoxFunctions.Dock = DockStyle.Fill;
            this.groupBoxFunctions.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.groupBoxFunctions.ForeColor = Color.FromArgb(44, 62, 80);
            this.groupBoxFunctions.Padding = new Padding(20);
            this.groupBoxFunctions.Controls.Add(this.flowPanelFunctions);
            this.groupBoxFunctions.Text = "Function İşlemleri";
            
            // flowPanelFunctions
            this.flowPanelFunctions.AutoScroll = true;
            this.flowPanelFunctions.Dock = DockStyle.Fill;
            this.flowPanelFunctions.FlowDirection = FlowDirection.TopDown;
            this.flowPanelFunctions.WrapContents = false;
            this.flowPanelFunctions.Padding = new Padding(10);
            
            // Functions kontrolleri ekle
            AddFunctionControls();
            
            // tabTransactions
            this.tabTransactions.BackColor = Color.FromArgb(236, 240, 241);
            this.tabTransactions.Controls.Add(this.groupBoxTransactions);
            this.tabTransactions.Location = new Point(4, 44);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.Padding = new Padding(3);
            this.tabTransactions.Size = new Size(1192, 402);
            this.tabTransactions.TabIndex = 2;
            this.tabTransactions.Text = "🔄 Transactions";
            this.tabTransactions.UseVisualStyleBackColor = true;
            
            // groupBoxTransactions
            this.groupBoxTransactions.BackColor = Color.White;
            this.groupBoxTransactions.Dock = DockStyle.Fill;
            this.groupBoxTransactions.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            this.groupBoxTransactions.ForeColor = Color.FromArgb(44, 62, 80);
            this.groupBoxTransactions.Padding = new Padding(20);
            this.groupBoxTransactions.Controls.Add(this.flowPanelTransactions);
            this.groupBoxTransactions.Text = "Transaction İşlemleri";
            
            // flowPanelTransactions
            this.flowPanelTransactions.AutoScroll = true;
            this.flowPanelTransactions.Dock = DockStyle.Fill;
            this.flowPanelTransactions.FlowDirection = FlowDirection.TopDown;
            this.flowPanelTransactions.WrapContents = false;
            this.flowPanelTransactions.Padding = new Padding(10);
            
            // Transaction kontrolleri ekle
            AddTransactionControls();
            
            // panelData
            this.panelData.BackColor = Color.White;
            this.panelData.Dock = DockStyle.Bottom;
            this.panelData.Height = 300;
            this.panelData.Padding = new Padding(15);
            this.panelData.Controls.Add(this.dataGridView1);
            this.panelData.Controls.Add(this.btnGeri);
            
            // btnGeri
            this.btnGeri.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnGeri.BackColor = Color.FromArgb(149, 165, 166);
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatStyle = FlatStyle.Flat;
            this.btnGeri.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            this.btnGeri.ForeColor = Color.White;
            this.btnGeri.Location = new Point(1085, 15);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new Size(100, 35);
            this.btnGeri.TabIndex = 15;
            this.btnGeri.Text = "← Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            this.btnGeri.MouseEnter += new System.EventHandler(this.btnGeri_MouseEnter);
            this.btnGeri.MouseLeave += new System.EventHandler(this.btnGeri_MouseLeave);
            
            // dataGridView1
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = Color.White;
            this.dataGridView1.BorderStyle = BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.GridColor = Color.FromArgb(236, 240, 241);
            this.dataGridView1.Location = new Point(15, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 188, 156);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.dataGridView1.EnableHeadersVisualStyles = false;
            
            // FormGelismis
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1200, 830);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MinimumSize = new Size(1000, 700);
            this.Name = "FormGelismis";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Gelişmiş: SP/Functions/Transactions (Soru 30-45)";
            this.Load += new System.EventHandler(this.FormGelismis_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSP.ResumeLayout(false);
            this.tabFunctions.ResumeLayout(false);
            this.tabTransactions.ResumeLayout(false);
            this.groupBoxSP.ResumeLayout(false);
            this.groupBoxFunctions.ResumeLayout(false);
            this.groupBoxTransactions.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
        
        private void AddSPControls()
        {
            // Ortak kontroller
            var panelOrtak = new Panel { Height = 50, Dock = DockStyle.Top, Padding = new Padding(10) };
            panelOrtak.Controls.Add(new Label { Text = "Öğrenci ID:", Location = new Point(10, 15), AutoSize = true });
            this.txtOgrenciID = new TextBox { Location = new Point(100, 12), Size = new Size(100, 23), BorderStyle = BorderStyle.FixedSingle };
            panelOrtak.Controls.Add(this.txtOgrenciID);
            panelOrtak.Controls.Add(new Label { Text = "Ders:", Location = new Point(220, 15), AutoSize = true });
            this.cmbDers = new ComboBox { Location = new Point(260, 12), Size = new Size(200, 23), DropDownStyle = ComboBoxStyle.DropDownList, FlatStyle = FlatStyle.Flat };
            panelOrtak.Controls.Add(this.cmbDers);
            this.flowPanelSP.Controls.Add(panelOrtak);
            
            // Butonlar
            this.btnSPNotEkle = CreateButton(this.flowPanelSP, "Soru 30: SP Not Ekle", Color.FromArgb(52, 152, 219), btnSPNotEkle_Click);
            this.btnOgrenciDetay = CreateButton(this.flowPanelSP, "Soru 31: Öğrenci Detay", Color.FromArgb(46, 204, 113), btnOgrenciDetay_Click);
            this.btnDersBasariSP = CreateButton(this.flowPanelSP, "Soru 32: Ders Başarı Raporu", Color.FromArgb(155, 89, 182), btnDersBasariSP_Click);
            this.btnSPNotGuncelle = CreateButton(this.flowPanelSP, "Soru 33: SP Not Güncelle", Color.FromArgb(241, 196, 15), btnSPNotGuncelle_Click);
            this.btnTopluSil = CreateButton(this.flowPanelSP, "Soru 34: Toplu Sil", Color.FromArgb(231, 76, 60), btnTopluSil_Click);
        }
        
        private void AddFunctionControls()
        {
            this.btnScalarFunction = CreateButton(this.flowPanelFunctions, "Soru 35: Scalar Function", Color.FromArgb(52, 152, 219), btnScalarFunction_Click);
            this.btnTVFDersNot = CreateButton(this.flowPanelFunctions, "Soru 36: TVF Ders Not", Color.FromArgb(46, 204, 113), btnTVFDersNot_Click);
            this.btnCokParametreliTVF = CreateButton(this.flowPanelFunctions, "Soru 37: Çok Parametreli TVF", Color.FromArgb(155, 89, 182), btnCokParametreliTVF_Click);
            this.btnKulupDashboard = CreateButton(this.flowPanelFunctions, "Soru 38: Kulüp Dashboard", Color.FromArgb(241, 196, 15), btnKulupDashboard_Click);
            this.btnZayifOgrenciler = CreateButton(this.flowPanelFunctions, "Soru 39: Zayıf Öğrenciler", Color.FromArgb(230, 126, 34), btnZayifOgrenciler_Click);
            this.btnOgrenciNotOzet = CreateButton(this.flowPanelFunctions, "Soru 40: Öğrenci Not Özeti", Color.FromArgb(26, 188, 156), btnOgrenciNotOzet_Click);
        }
        
        private void AddTransactionControls()
        {
            this.btnCokAdimliKayit = CreateButton(this.flowPanelTransactions, "Soru 41: Çok Adımlı Kayıt", Color.FromArgb(52, 152, 219), btnCokAdimliKayit_Click);
            this.btnTopluNotGuncelle = CreateButton(this.flowPanelTransactions, "Soru 42: Toplu Not Güncelle", Color.FromArgb(46, 204, 113), btnTopluNotGuncelle_Click);
            this.btnCokTabloTransaction = CreateButton(this.flowPanelTransactions, "Soru 43: Çok Tablo Transaction", Color.FromArgb(155, 89, 182), btnCokTabloTransaction_Click);
            this.btnTransactionSP = CreateButton(this.flowPanelTransactions, "Soru 44: Transaction + SP", Color.FromArgb(241, 196, 15), btnTransactionSP_Click);
            this.btnFotoGuncelle = CreateButton(this.flowPanelTransactions, "Soru 45: Transaction + File Check", Color.FromArgb(231, 76, 60), btnFotoGuncelle_Click);
        }
        
        private Button CreateButton(FlowLayoutPanel panel, string text, Color color, EventHandler clickHandler)
        {
            Button button = new Button
            {
                BackColor = color,
                FlatAppearance = { BorderSize = 0 },
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                Size = new Size(300, 45),
                Text = text,
                UseVisualStyleBackColor = false,
                Tag = color
            };
            button.Click += clickHandler;
            button.MouseEnter += new System.EventHandler(this.DynamicButton_MouseEnter);
            button.MouseLeave += new System.EventHandler(this.DynamicButton_MouseLeave);
            panel.Controls.Add(button);
            return button;
        }
    }
}
