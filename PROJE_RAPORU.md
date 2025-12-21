# 📊 Sınav Öğrenci Sistemi - Detaylı Proje Raporu

## 📋 İçindekiler
1. [Proje Genel Bilgileri](#proje-genel-bilgileri)
2. [Dosya Yapısı ve Amaçları](#dosya-yapısı-ve-amaçları)
3. [Form Detayları ve Özellikleri](#form-detayları-ve-özellikleri)
4. [Veritabanı Yapısı](#veritabanı-yapısı)
5. [Entity Framework Model](#entity-framework-model)
6. [DTO (Data Transfer Object) Sınıfları](#dto-data-transfer-object-sınıfları)
7. [Soru Bazında İşlevsellik](#soru-bazında-işlevsellik)
8. [Teknik Özellikler](#teknik-özellikler)

---

## 🎯 Proje Genel Bilgileri

**Proje Adı:** SinavOgrenciSistemi  
**Framework:** .NET Framework 4.8  
**ORM:** Entity Framework 6.4.4  
**Veritabanı:** SQL Server (dbSinavOgrenci)  
**Uygulama Tipi:** Windows Forms Application  
**Toplam Soru Sayısı:** 45 Soru  
**Form Sayısı:** 8 Form (1 Ana Menü + 7 İşlevsel Form)

---

## 📁 Dosya Yapısı ve Amaçları

### 🔹 Kök Dizin Dosyaları

#### **Program.cs**
- **Amaç:** Uygulamanın giriş noktası (Entry Point)
- **İşlevi:**
  - `Main()` metodu ile uygulamayı başlatır
  - Visual Styles'ı etkinleştirir
  - `FormMain` formunu çalıştırır
- **Kullanılan Teknolojiler:** Windows Forms Application Framework

#### **App.config**
- **Amaç:** Uygulama yapılandırma dosyası
- **İçerik:**
  - **Connection String:** `dbSinavOgrenciEntities`
    - Server: `.` (Local SQL Server)
    - Database: `dbSinavOgrenci`
    - Authentication: `Integrated Security=True` (Windows Authentication)
    - MultipleActiveResultSets: `True`
  - **Entity Framework Ayarları:**
    - Provider: `System.Data.SqlClient`
    - Default Connection Factory: `SqlConnectionFactory`
- **Önemli Not:** `Database.SetInitializer<dbSinavOgrenciEntities>(null);` ile otomatik migration devre dışı

#### **packages.config**
- **Amaç:** NuGet paket bağımlılıklarını listeler
- **Paketler:**
  - EntityFramework 6.4.4

#### **SinavOgrenciSistemi.csproj**
- **Amaç:** C# proje dosyası
- **Özellikler:**
  - Target Framework: .NET Framework 4.8
  - Root Namespace: `SinavOgrenciSistemi`
  - Assembly Name: `SinavOgrenciSistemi`
  - Referanslar: EntityFramework, System.ComponentModel.DataAnnotations

---

### 🔹 Models Klasörü (Entity Framework Model)

#### **dbSinavOgrenciEntities.cs**
- **Amaç:** Entity Framework DbContext sınıfı
- **İşlevi:**
  - Veritabanı bağlantısını yönetir
  - Tüm tabloları `DbSet<>` olarak tanımlar
  - Navigation property ilişkilerini Fluent API ile yapılandırır
- **DbSet'ler:**
  - `DbSet<TBLDERSLER> TBLDERSLER`
  - `DbSet<TBLKULUPLER> TBLKULUPLER`
  - `DbSet<TBLNOTLAR> TBLNOTLAR`
  - `DbSet<TBLOGRENCI> TBLOGRENCI`
- **Fluent API İlişkileri:**
  - `TBLDERSLER` → `TBLNOTLAR` (One-to-Many, Required)
  - `TBLKULUPLER` → `TBLOGRENCI` (One-to-Many, Optional)
  - `TBLOGRENCI` → `TBLNOTLAR` (One-to-Many, Required)
- **Özel Ayarlar:**
  - `Database.SetInitializer<dbSinavOgrenciEntities>(null);` - Migration devre dışı

#### **TBLOGRENCI.cs**
- **Amaç:** Öğrenci tablosu entity sınıfı
- **Özellikler:**
  - `OgrenciID` (Key, int)
  - `OgrenciAd` (Required, StringLength(50))
  - `OgrenciSoyad` (Required, StringLength(50))
  - `OgrenciFoto` (Optional, StringLength(250))
  - `KulupID` (Optional, int?)
- **Navigation Properties:**
  - `TBLKULUPLER TBLKULUPLER` (Many-to-One)
  - `ICollection<TBLNOTLAR> TBLNOTLAR` (One-to-Many)

#### **TBLNOTLAR.cs**
- **Amaç:** Notlar tablosu entity sınıfı
- **Özellikler:**
  - `NOTID` (Key, int)
  - `DERS` (Required, int) - Foreign Key to TBLDERSLER
  - `OGRENCI` (Required, int) - Foreign Key to TBLOGRENCI
  - `SINAV1`, `SINAV2`, `SINAV3` (Optional, int?)
  - `ORTALAMA` (Optional, decimal?)
  - `DURUM` (Optional, bool?) - 1=Geçti, 0=Kaldı
- **Navigation Properties:**
  - `TBLDERSLER TBLDERSLER` (Many-to-One)
  - `TBLOGRENCI TBLOGRENCI` (Many-to-One)

#### **TBLDERSLER.cs**
- **Amaç:** Dersler tablosu entity sınıfı
- **Özellikler:**
  - `DERSID` (Key, int)
  - `DERSAD` (Required, string)
- **Navigation Properties:**
  - `ICollection<TBLNOTLAR> TBLNOTLAR` (One-to-Many)

#### **TBLKULUPLER.cs**
- **Amaç:** Kulüpler tablosu entity sınıfı
- **Özellikler:**
  - `KULUPID` (Key, int)
  - `KULUPAD` (Required, string)
- **Navigation Properties:**
  - `ICollection<TBLOGRENCI> TBLOGRENCI` (One-to-Many)

---

### 🔹 DTOs Klasörü (Data Transfer Objects)

#### **OgrenciDetay.cs**
- **Amaç:** SP `sp_OgrenciDetayGetir` sonuçlarını map etmek için
- **Özellikler:**
  - `OgrenciAdSoyad`, `KulupAdi`, `DersAdi`
  - `SINAV1`, `SINAV2`, `SINAV3`, `ORTALAMA`
  - `Durum` (string)

#### **DersBasariRapor.cs**
- **Amaç:** SP `sp_DersBasariRaporu` sonuçlarını map etmek için
- **Özellikler:**
  - `ToplamOgrenci`, `GecenSayisi`, `KalanSayisi`
  - `BasariYuzdesi`, `EnYuksekOrtalama`, `EnBasariliOgrenci`

#### **DersNotListesi.cs**
- **Amaç:** TVF `fn_DersNotListesi` sonuçlarını map etmek için
- **Kullanım:** Belirli bir dersin tüm öğrenci notlarını listeler

#### **NotFiltreSonuc.cs**
- **Amaç:** TVF `fn_NotFiltrele` sonuçlarını map etmek için
- **Kullanım:** Çok parametreli filtreleme sonuçları

#### **KulupBasari.cs**
- **Amaç:** TVF `fn_KulupBasariOrani` sonuçlarını map etmek için
- **Kullanım:** Kulüplerin başarı oranlarını gösterir

#### **ZayifOgrenci.cs**
- **Amaç:** TVF `fn_ZayifOgrenciler` sonuçlarını map etmek için
- **Kullanım:** Zayıf başarı gösteren öğrencileri listeler

#### **OgrenciNotOzetDTO.cs**
- **Amaç:** TVF `fn_OgrenciNotOzet` sonuçlarını map etmek için
- **Özellikler:**
  - `ToplamDers`, `GecenDers`, `KalanDers`
  - `GenelOrt`, `EnYuksekNot`, `EnDusukNot`

---

## 🖼️ Form Detayları ve Özellikleri

### 🔹 FormMain (Ana Menü Formu)

**Dosyalar:**
- `FormMain.cs` - İş mantığı
- `FormMain.Designer.cs` - UI tasarımı
- `FormMain.resx` - Kaynak dosyası

**Amaç:** Ana navigasyon menüsü, tüm formlara erişim sağlar

**Tasarım Özellikleri:**
- **Header Panel:** Mavi renkli (Color.FromArgb(41, 128, 185))
- **Başlık:** "Sınav Öğrenci Sistemi" (Segoe UI, 24pt, Bold)
- **Alt Başlık:** "Entity Framework Ödev Uygulaması - 45 Soru"
- **Butonlar:** 7 adet renkli buton, her biri farklı formu açar
- **Responsive:** Minimum size: 940x300, Sizable form

**Butonlar ve Açtıkları Formlar:**
1. **1️⃣ Temel EF İşlemleri** (Mavi) → `FormTemelEF` (Soru 1-5)
2. **2️⃣ Navigation & İlişkiler** (Yeşil) → `FormNavigation` (Soru 6-12)
3. **3️⃣ CRUD İşlemleri** (Mor) → `FormCRUD` (Soru 13-18)
4. **4️⃣ LINQ Filtreleme** (Sarı) → `FormLINQ` (Soru 19-25)
5. **5️⃣ Toplam/Ortalama** (Turuncu) → `FormAggregate` (Soru 26-28)
6. **6️⃣ Durum Hesaplama** (Kırmızı) → `FormDurum` (Soru 29-30)
7. **7️⃣ Gelişmiş Özellikler** (Turkuaz) → `FormGelismis` (Soru 30-45)

**Event Handler'lar:**
- Her buton için `Click` event'i
- Her buton için `MouseEnter` ve `MouseLeave` event'leri (hover efekti)

**Kod Yapısı:**
```csharp
- btnTemelEF_Click() → FormTemelEF açılır (ShowDialog)
- btnNavigation_Click() → FormNavigation açılır
- btnCRUD_Click() → FormCRUD açılır
- btnLINQ_Click() → FormLINQ açılır
- btnAggregate_Click() → FormAggregate açılır
- btnDurum_Click() → FormDurum açılır
- btnGelismis_Click() → FormGelismis açılır
```

---

### 🔹 FormTemelEF (Temel Entity Framework İşlemleri)

**Dosyalar:**
- `FormTemelEF.cs` - İş mantığı
- `FormTemelEF.Designer.cs` - UI tasarımı
- `FormTemelEF.resx` - Kaynak dosyası

**Amaç:** Entity Framework'ün temel kullanımını gösterir (Soru 1-5)

**Tasarım Özellikleri:**
- **Header Panel:** Mavi (Color.FromArgb(52, 152, 219))
- **Butonlar Panel:** Açık gri arka plan
- **Data Panel:** Beyaz arka plan, DataGridView
- **Butonlar:** 5 adet renkli buton

**Kontroller:**
- `dataGridView1` - Sonuçları gösterir
- `btnOgrenciListele` - Soru 2
- `btnOgrenciListeleGizli` - Soru 3
- `btnDersListeleEF` - Soru 4
- `btnDersListeleADO` - Soru 5
- `btnGeri` - Ana menüye dönüş

**Soru 1: Form Seviyesinde DbContext**
- **Kod:** `dbSinavOgrenciEntities db = new dbSinavOgrenciEntities();`
- **Açıklama:** Form seviyesinde DbContext örneği oluşturulur
- **Yaşam Döngüsü:** Form açıldığında oluşturulur, `OnFormClosed`'da `Dispose()` edilir

**Soru 2: Öğrenci Listeleme**
- **Metod:** `btnOgrenciListele_Click()`
- **Kod:**
```csharp
var ogrenciler = db.TBLOGRENCI
    .Select(o => new {
        o.OgrenciID,
        o.OgrenciAd,
        o.OgrenciSoyad,
        KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüpsüz",
        o.KulupID
    })
    .ToList();
dataGridView1.DataSource = ogrenciler;
```
- **Özellikler:** Navigation property ile kulüp adı getirilir, anonim tip kullanılır

**Soru 3: Fotoğraf Alanını Gizleme**
- **Metod:** `btnOgrenciListeleGizli_Click()`
- **Kod:** `OgrenciFoto` alanı anonim tip içinde seçilmez, sadece ID, Ad, Soyad, Kulüp gösterilir
- **Amaç:** Belirli alanları gizleme örneği

**Soru 4: Dersleri EF ile Listeleme**
- **Metod:** `btnDersListeleEF_Click()`
- **Kod:** `dataGridView1.DataSource = db.TBLDERSLER.ToList();`
- **Özellikler:** Direkt entity listesi, navigation property kullanılmaz

**Soru 5: ADO.NET ile Listeleme (Karşılaştırma)**
- **Metod:** `btnDersListeleADO_Click()`
- **Kod:**
```csharp
using (SqlConnection con = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand("SELECT * FROM TBLDERSLER", con);
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    DataTable dt = new DataTable();
    da.Fill(dt);
    dataGridView1.DataSource = dt;
}
```
- **Amaç:** EF ile ADO.NET arasındaki farkı göstermek
- **Farklar:**
  - EF: LINQ sorguları, type-safe, navigation properties
  - ADO.NET: SQL string, DataTable, manuel mapping

---

### 🔹 FormNavigation (Navigation Property & İlişkiler)

**Dosyalar:**
- `FormNavigation.cs` - İş mantığı
- `FormNavigation.Designer.cs` - UI tasarımı
- `FormNavigation.resx` - Kaynak dosyası

**Amaç:** Navigation property kullanımını gösterir (Soru 6-12)

**Tasarım Özellikleri:**
- **Header Panel:** Yeşil (Color.FromArgb(46, 204, 113))
- **Butonlar Panel:** 6 adet renkli buton
- **Arama Panel:** Öğrenci ID girişi için TextBox
- **Data Panel:** DataGridView

**Kontroller:**
- `dataGridView1` - Ana sonuç listesi
- `txtOgrenciID` - Öğrenci ID girişi (Soru 12 için)
- `btnNotListele` - Soru 6
- `btnNotListeleDersAdi` - Soru 7
- `btnAdSoyadBirlestir` - Soru 9
- `btnOgrenciKulup` - Soru 10
- `btnUcTabloJoin` - Soru 11
- `btnOgrenciNotlari` - Soru 12

**Soru 6: TBLNOTLAR Anonim Tip ile Listeleme**
- **Metod:** `btnNotListele_Click()`
- **Kod:**
```csharp
var notlar = db.TBLNOTLAR
    .Select(n => new {
        n.NOTID,
        n.DERS,
        n.SINAV1, n.SINAV2, n.SINAV3,
        OgrenciAdi = n.TBLOGRENCI.OgrenciAd  // Navigation property
    })
    .ToList();
```
- **Özellikler:** Navigation property ile öğrenci adı getirilir

**Soru 7: Navigation Property ile Ders Adı**
- **Metod:** `btnNotListeleDersAdi_Click()`
- **Kod:**
```csharp
DersAdi = n.TBLDERSLER.DERSAD  // Navigation property
```
- **Amaç:** ID yerine ders adını göstermek

**Soru 8: Navigation Property Açıklaması**
- **Açıklama:** Navigation property, entity'ler arası ilişkileri temsil eder
- **Kullanım:** `n.TBLOGRENCI.OgrenciAd` gibi direkt erişim sağlar
- **Avantaj:** JOIN yazmaya gerek yok, EF otomatik yapar

**Soru 9: Ad + Soyad Birleştirme**
- **Metod:** `btnAdSoyadBirlestir_Click()`
- **Kod:**
```csharp
AdSoyad = o.OgrenciAd + " " + o.OgrenciSoyad
```
- **Özellikler:** String concatenation, anonim tip içinde

**Soru 10: Öğrenci - Kulüp JOIN**
- **Metod:** `btnOgrenciKulup_Click()`
- **Kod:**
```csharp
var liste = db.TBLOGRENCI
    .Select(o => new {
        AdSoyad = o.OgrenciAd + " " + o.OgrenciSoyad,
        KulupAdi = o.TBLKULUPLER.KULUPAD  // Navigation property
    })
    .ToList();
```
- **Özellikler:** Navigation property ile JOIN yapılır

**Soru 11: Üç Tablo Birleştirme**
- **Metod:** `btnUcTabloJoin_Click()`
- **Kod:**
```csharp
var liste = db.TBLNOTLAR
    .Select(n => new {
        OgrenciAdi = n.TBLOGRENCI.OgrenciAd + " " + n.TBLOGRENCI.OgrenciSoyad,
        DersAdi = n.TBLDERSLER.DERSAD,
        n.ORTALAMA,
        Durum = n.DURUM == true ? "GEÇTİ" : "KALDI"
    })
    .ToList();
```
- **Özellikler:** TBLNOTLAR → TBLOGRENCI → TBLDERSLER, üç tablo birleştirme

**Soru 12: Navigation Property ile Öğrenci Notları**
- **Metod:** `btnOgrenciNotlari_Click()`
- **Kod:**
```csharp
var ogrenci = db.TBLOGRENCI.Find(ogrenciID);
var notlar = ogrenci.TBLNOTLAR  // Navigation property collection
    .Select(n => new { ... })
    .ToList();
```
- **Özellikler:** `Find()` ile öğrenci bulunur, navigation property ile notlar getirilir

---

### 🔹 FormCRUD (CRUD İşlemleri)

**Dosyalar:**
- `FormCRUD.cs` - İş mantığı
- `FormCRUD.Designer.cs` - UI tasarımı
- `FormCRUD.resx` - Kaynak dosyası

**Amaç:** Create, Read, Update, Delete işlemlerini gösterir (Soru 13-18)

**Tasarım Özellikleri:**
- **Header Panel:** Mor (Color.FromArgb(155, 89, 182))
- **Form Panel:** GroupBox içinde input alanları
- **Butonlar Panel:** 4 adet işlem butonu
- **Data Panel:** DataGridView (CellClick ile otomatik doldurma)

**Kontroller:**
- `txtOgrenciID`, `txtOgrenciAd`, `txtOgrenciSoyad`, `txtFotoYol`
- `cmbKulup` - ComboBox (Kulüp seçimi)
- `btnEkle` - Soru 13
- `btnSil` - Soru 15
- `btnGuncelle` - Soru 16
- `btnEntityStateGoster` - Soru 18
- `dataGridView1` - CellClick event'i ile otomatik doldurma

**Soru 13: Öğrenci Ekleme**
- **Metod:** `btnEkle_Click()`
- **Kod:**
```csharp
TBLOGRENCI yeniOgrenci = new TBLOGRENCI {
    OgrenciAd = txtOgrenciAd.Text,
    OgrenciSoyad = txtOgrenciSoyad.Text,
    OgrenciFoto = string.IsNullOrEmpty(txtFotoYol.Text) ? null : txtFotoYol.Text,
    KulupID = cmbKulup.SelectedValue != null ? (int?)Convert.ToInt32(cmbKulup.SelectedValue) : null
};
db.TBLOGRENCI.Add(yeniOgrenci);
db.SaveChanges();
```
- **Özellikler:**
  - Validation: Ad ve Soyad zorunlu
  - Null kontrolü: Fotoğraf ve Kulüp opsiyonel
  - `Add()` metodu ile entity eklenir
  - `SaveChanges()` ile veritabanına kaydedilir

**Soru 14: DataGridView Otomatik Güncelleme**
- **Metod:** `OgrenciListesiGuncelle()`
- **Kod:**
```csharp
dataGridView1.DataSource = db.TBLOGRENCI
    .Select(o => new {
        o.OgrenciID,
        o.OgrenciAd,
        o.OgrenciSoyad,
        KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüp Yok"
    })
    .ToList();
```
- **Kullanım:** Ekleme, silme, güncelleme sonrası çağrılır
- **Özellikler:** Anonim tip ile kulüp adı gösterilir

**Soru 15: Öğrenci Silme**
- **Metod:** `btnSil_Click()`
- **Kod:**
```csharp
var silinecek = db.TBLOGRENCI.Find(ogrenciID);
if (silinecek == null) {
    MessageBox.Show("Öğrenci bulunamadı!");
    return;
}
// Önce notları sil
var notlar = db.TBLNOTLAR.Where(n => n.OGRENCI == ogrenciID).ToList();
db.TBLNOTLAR.RemoveRange(notlar);
db.TBLOGRENCI.Remove(silinecek);
db.SaveChanges();
```
- **Özellikler:**
  - `Find()` ile öğrenci bulunur
  - Null kontrolü yapılır
  - Cascade delete: Önce notlar silinir
  - `Remove()` ile entity silinir

**Soru 16: Öğrenci Güncelleme**
- **Metod:** `btnGuncelle_Click()`
- **Kod:**
```csharp
var ogrenci = db.TBLOGRENCI.Find(ogrenciID);
ogrenci.OgrenciAd = txtOgrenciAd.Text;
ogrenci.OgrenciSoyad = txtOgrenciSoyad.Text;
ogrenci.OgrenciFoto = txtFotoYol.Text;
ogrenci.KulupID = cmbKulup.SelectedValue != null ? (int?)Convert.ToInt32(cmbKulup.SelectedValue) : null;
db.SaveChanges();
```
- **Özellikler:**
  - `Find()` ile entity bulunur
  - Property'ler direkt güncellenir
  - `SaveChanges()` ile kaydedilir
  - EntityState otomatik `Modified` olur

**Soru 17: Güncelleme Öncesi Varlık Kontrolü**
- **Metod:** `OgrenciVarMi(int ogrenciID)`
- **Kod:**
```csharp
return db.TBLOGRENCI.Any(o => o.OgrenciID == ogrenciID);
```
- **Kullanım:** Güncelleme ve silme öncesi kontrol
- **Özellikler:** `Any()` LINQ metodu ile hızlı kontrol

**Soru 18: EntityState Gösterimi**
- **Metod:** `btnEntityStateGoster_Click()`
- **Kod:**
```csharp
var state = db.Entry(ogrenci).State;
```
- **EntityState Değerleri:**
  - `Unchanged`: Değişmemiş kayıt
  - `Modified`: Değiştirilmiş kayıt (UPDATE)
  - `Added`: Yeni eklenen kayıt (INSERT)
  - `Deleted`: Silinmiş kayıt (DELETE)
  - `Detached`: Bağlantısız entity
- **Açıklama:** Entity Framework'ün entity'lerin durumunu takip etme mekanizması

**Ek Özellikler:**
- `dataGridView1_CellClick()` - DataGridView'den satır seçildiğinde form alanlarını otomatik doldurur
- `Temizle()` - Form alanlarını temizler

---

### 🔹 FormLINQ (LINQ Filtreleme - Arama - Sıralama)

**Dosyalar:**
- `FormLINQ.cs` - İş mantığı
- `FormLINQ.Designer.cs` - UI tasarımı
- `FormLINQ.resx` - Kaynak dosyası

**Amaç:** LINQ filtreleme, arama ve sıralama işlemlerini gösterir (Soru 19-25)

**Tasarım Özellikleri:**
- **Header Panel:** Sarı (Color.FromArgb(241, 196, 15))
- **Arama Panel:** TextBox'lar (Canlı arama için)
- **Butonlar Panel:** 6 adet filtreleme butonu
- **Data Panel:** DataGridView

**Kontroller:**
- `txtOgrenciAd` - Canlı arama (TextChanged event)
- `txtOgrenciID` - ID ile arama
- `btnArtanSirala` - Soru 20
- `btnAzalanSirala` - Soru 21
- `btnIlkUc` - Soru 22
- `btnIdIleGetir` - Soru 23
- `btnAileBaslayan` - Soru 24
- `btnNileBiten` - Soru 25

**Soru 19: TextChanged ile Canlı Filtreleme**
- **Metod:** `txtOgrenciAd_TextChanged()`
- **Kod:**
```csharp
string aramaMetni = txtOgrenciAd.Text;
var sonuc = db.TBLOGRENCI
    .Where(o => o.OgrenciAd.Contains(aramaMetni))
    .Select(o => new {
        o.OgrenciID,
        o.OgrenciAd,
        o.OgrenciSoyad,
        KulupAdi = o.TBLKULUPLER != null ? o.TBLKULUPLER.KULUPAD : "Kulüpsüz"
    })
    .ToList();
dataGridView1.DataSource = sonuc;
```
- **Özellikler:**
  - `Contains()` ile içerik araması
  - Her karakter girişinde otomatik filtreleme
  - Navigation property ile kulüp adı gösterilir

**Soru 20: Ada Göre Artan Sıralama**
- **Metod:** `btnArtanSirala_Click()`
- **Kod:**
```csharp
var ogrenciler = db.TBLOGRENCI
    .OrderBy(o => o.OgrenciAd)
    .Select(o => new { ... })
    .ToList();
```
- **Özellikler:** `OrderBy()` LINQ metodu

**Soru 21: Soyada Göre Azalan Sıralama**
- **Metod:** `btnAzalanSirala_Click()`
- **Kod:**
```csharp
var ogrenciler = db.TBLOGRENCI
    .OrderByDescending(o => o.OgrenciSoyad)
    .Select(o => new { ... })
    .ToList();
```
- **Özellikler:** `OrderByDescending()` LINQ metodu

**Soru 22: İlk 3 Öğrenci (Take)**
- **Metod:** `btnIlkUc_Click()`
- **Kod:**
```csharp
var ogrenciler = db.TBLOGRENCI
    .OrderBy(o => o.OgrenciID)
    .Take(3)
    .Select(o => new { ... })
    .ToList();
```
- **Özellikler:** `Take(3)` ile ilk 3 kayıt alınır

**Soru 23: ID ile Öğrenci Getirme**
- **Metod:** `btnIdIleGetir_Click()`
- **Kod:**
```csharp
int aramaID = Convert.ToInt32(txtOgrenciID.Text);
var ogrenci = db.TBLOGRENCI
    .Where(o => o.OgrenciID == aramaID)
    .Select(o => new { ... })
    .ToList();
```
- **Özellikler:** `Where()` ile ID filtresi, navigation property ile kulüp adı

**Soru 24: "A" ile Başlayan Öğrenciler**
- **Metod:** `btnAileBaslayan_Click()`
- **Kod:**
```csharp
var ogrenciler = db.TBLOGRENCI
    .Where(o => o.OgrenciAd.StartsWith("A"))
    .Select(o => new { ... })
    .ToList();
```
- **Özellikler:** `StartsWith()` string metodu

**Soru 25: "n" ile Biten Öğrenciler**
- **Metod:** `btnNileBiten_Click()`
- **Kod:**
```csharp
var ogrenciler = db.TBLOGRENCI
    .Where(o => o.OgrenciAd.EndsWith("n"))
    .Select(o => new { ... })
    .ToList();
```
- **Özellikler:** `EndsWith()` string metodu

---

### 🔹 FormAggregate (TOPLAM - ORTALAMA - MAX - MIN)

**Dosyalar:**
- `FormAggregate.cs` - İş mantığı
- `FormAggregate.Designer.cs` - UI tasarımı
- `FormAggregate.resx` - Kaynak dosyası

**Amaç:** Aggregate fonksiyonlarını gösterir (Soru 26-28)

**Tasarım Özellikleri:**
- **Header Panel:** Turuncu (Color.FromArgb(230, 126, 34))
- **Butonlar Panel:** 3 adet büyük buton
- **Data Panel:** DataGridView

**Kontroller:**
- `btnSinav1Toplam` - Soru 26
- `btnSinav1Ortalama` - Soru 27
- `btnOrtalamaUzeri` - Soru 28

**Soru 26: SINAV1 Notlarının Toplamı**
- **Metod:** `btnSinav1Toplam_Click()`
- **Kod:**
```csharp
var toplam = db.TBLNOTLAR.Sum(n => n.SINAV1 ?? 0);
MessageBox.Show($"SINAV1 Notları Toplamı: {toplam}", "Toplam");
```
- **Özellikler:**
  - `Sum()` LINQ metodu
  - Null coalescing operator (`??`) ile null kontrolü
  - MessageBox ile sonuç gösterimi

**Soru 27: SINAV1 Notlarının Ortalaması**
- **Metod:** `btnSinav1Ortalama_Click()`
- **Kod:**
```csharp
var ortalama = db.TBLNOTLAR
    .Where(n => n.SINAV1 != null)
    .Average(n => n.SINAV1.Value);
MessageBox.Show($"SINAV1 Notları Ortalaması: {ortalama:F2}", "Ortalama");
```
- **Özellikler:**
  - `Average()` LINQ metodu
  - Null değerler filtrelenir
  - `F2` formatı ile 2 ondalık basamak

**Soru 28: Ortalama Üzeri Not Alan Öğrenciler**
- **Metod:** `btnOrtalamaUzeri_Click()`
- **Kod:**
```csharp
var ortalama = db.TBLNOTLAR.Where(n => n.SINAV1 != null).Average(n => n.SINAV1.Value);
var ogrenciler = db.TBLNOTLAR
    .Where(n => n.SINAV1 != null && n.SINAV1 > ortalama)
    .Select(n => new {
        OgrenciAdi = n.TBLOGRENCI.OgrenciAd + " " + n.TBLOGRENCI.OgrenciSoyad,
        n.SINAV1,
        Ortalama = ortalama
    })
    .ToList();
dataGridView1.DataSource = ogrenciler;
```
- **Özellikler:**
  - Önce ortalama hesaplanır
  - Sonra ortalama üzeri kayıtlar filtrelenir
  - Navigation property ile öğrenci adı getirilir

---

### 🔹 FormDurum (Durum Hesaplama ve Anonim Tipleme)

**Dosyalar:**
- `FormDurum.cs` - İş mantığı
- `FormDurum.Designer.cs` - UI tasarımı
- `FormDurum.resx` - Kaynak dosyası

**Amaç:** Durum hesaplama ve anonim tip kullanımını gösterir (Soru 29-30)

**Tasarım Özellikleri:**
- **Header Panel:** Kırmızı (Color.FromArgb(231, 76, 60))
- **Butonlar Panel:** 2 adet buton
- **Data Panel:** 
  - `dataGridView1` - Tek liste için
  - `splitContainer1` - İki ayrı liste için
    - `dgvGecenler` - Geçen öğrenciler (Yeşil tema)
    - `dgvKalanlar` - Kalan öğrenciler (Kırmızı tema)

**Kontroller:**
- `btnDurumListesi` - Soru 29
- `btnGecenKalan` - Soru 30

**Soru 29: Anonim Tip ile Durum Listesi**
- **Metod:** `btnDurumListesi_Click()`
- **Kod:**
```csharp
var liste = db.TBLNOTLAR
    .Select(n => new {
        Ogrenci = n.TBLOGRENCI.OgrenciAd + " " + n.TBLOGRENCI.OgrenciSoyad,
        n.ORTALAMA,
        Durum = n.DURUM == true ? "GEÇTİ" : "KALDI"
    })
    .ToList();
dataGridView1.DataSource = liste;
```
- **Özellikler:**
  - Anonim tip kullanımı
  - Ternary operator ile durum string'e çevrilir
  - Navigation property ile öğrenci adı getirilir

**Soru 30: Geçen ve Kalan Öğrencileri Ayrı Listeleme**
- **Metod:** `btnGecenKalan_Click()`
- **Kod:**
```csharp
// Geçen öğrenciler
var gecenler = db.TBLNOTLAR
    .Where(n => n.DURUM == true)
    .Select(n => new { ... })
    .ToList();

// Kalan öğrenciler
var kalanlar = db.TBLNOTLAR
    .Where(n => n.DURUM == false)
    .Select(n => new { ... })
    .ToList();

dgvGecenler.DataSource = gecenler;
dgvKalanlar.DataSource = kalanlar;
```
- **Özellikler:**
  - İki ayrı sorgu ile filtreleme
  - İki ayrı DataGridView'e bağlama
  - SplitContainer ile görsel ayrım
  - Renk kodlaması: Yeşil (Geçen), Kırmızı (Kalan)

---

### 🔹 FormGelismis (Gelişmiş: SP/Functions/Transactions)

**Dosyalar:**
- `FormGelismis.cs` - İş mantığı
- `FormGelismis.Designer.cs` - UI tasarımı
- `FormGelismis.resx` - Kaynak dosyası

**Amaç:** Stored Procedure, Function ve Transaction işlemlerini gösterir (Soru 30-45)

**Tasarım Özellikleri:**
- **Header Panel:** Turkuaz (Color.FromArgb(26, 188, 156))
- **TabControl:** 3 sekme
  - **📊 Stored Procedures** (tabSP)
  - **⚙️ Functions** (tabFunctions)
  - **🔄 Transactions** (tabTransactions)
- **Butonlar:** FlowLayoutPanel içinde dinamik oluşturulur
- **Data Panel:** DataGridView

**Kontroller:**
- `tabControl1` - 3 sekme içerir
- `txtOgrenciID`, `txtOgrenciAd`, `txtOgrenciSoyad`, `txtFotoYol`
- `txtSinav1`, `txtSinav2`, `txtSinav3`, `txtNotID`
- `txtMinOrtalama`, `txtMaxOrtalama`
- `cmbKulup`, `cmbDers`
- `chkGecti`, `chkKaldi`
- `dataGridView1` - Tüm sonuçlar için

#### **📊 Stored Procedures Sekmesi (Soru 30-34)**

**Soru 30: SP ile Kontrollü Not Ekleme**
- **Metod:** `btnSPNotEkle_Click()`
- **SP:** `sp_NotEkleKontrollu(@OgrenciID, @DersID, @Sinav1, @Sinav2, @Sinav3)`
- **Kod:**
```csharp
db.Database.ExecuteSqlCommand(
    "EXEC sp_NotEkleKontrollu @OgrenciID, @DersID, @Sinav1, @Sinav2, @Sinav3",
    new SqlParameter("@OgrenciID", ogrenciID),
    new SqlParameter("@DersID", dersID),
    new SqlParameter("@Sinav1", sinav1),
    new SqlParameter("@Sinav2", sinav2),
    new SqlParameter("@Sinav3", sinav3)
);
```
- **Özellikler:**
  - `ExecuteSqlCommand()` ile SP çağrılır
  - `SqlParameter` ile parametreler gönderilir
  - `try-catch` ile SP hataları yakalanır
  - SP içinde duplicate kontrolü yapılır

**Soru 31: SP ile Öğrenci Detay Raporu**
- **Metod:** `btnOgrenciDetay_Click()`
- **SP:** `sp_OgrenciDetayGetir(@OgrenciID)`
- **Kod:**
```csharp
var sonuc = db.Database.SqlQuery<OgrenciDetay>(
    "EXEC sp_OgrenciDetayGetir @OgrenciID",
    new SqlParameter("@OgrenciID", ogrenciID)
).ToList();
dataGridView1.DataSource = sonuc;
```
- **Özellikler:**
  - `SqlQuery<T>()` ile SP sonuçları DTO'ya map edilir
  - `OgrenciDetay` DTO sınıfı kullanılır
  - Öğrenci adı-soyadı, kulüp, dersler, notlar gösterilir

**Soru 32: SP ile Ders Başarı Raporu**
- **Metod:** `btnDersBasariSP_Click()`
- **SP:** `sp_DersBasariRaporu(@DersID)`
- **Kod:**
```csharp
var sonuc = db.Database.SqlQuery<DersBasariRapor>(...).FirstOrDefault();
MessageBox.Show($@"Toplam Öğrenci: {sonuc.ToplamOgrenci}
Geçen: {sonuc.GecenSayisi}
Kalan: {sonuc.KalanSayisi}
Başarı %: {sonuc.BasariYuzdesi:F2}
En Yüksek: {sonuc.EnYuksekOrtalama}
En Başarılı: {sonuc.EnBasariliOgrenci}");
```
- **Özellikler:**
  - `DersBasariRapor` DTO kullanılır
  - MessageBox ile rapor gösterilir
  - Toplam, geçen, kalan, başarı yüzdesi, en yüksek ortalama

**Soru 33: SP ile Not Güncelleme**
- **Metod:** `btnSPNotGuncelle_Click()`
- **SP:** `sp_NotGuncelle(@NotID, @S1, @S2, @S3)`
- **Kod:**
```csharp
var sonuc = db.Database.SqlQuery<TBLNOTLAR>(
    "EXEC sp_NotGuncelle @NotID, @S1, @S2, @S3",
    new SqlParameter("@NotID", notID),
    new SqlParameter("@S1", s1),
    new SqlParameter("@S2", s2),
    new SqlParameter("@S3", s3)
).ToList();
dataGridView1.DataSource = sonuc;
```
- **Özellikler:**
  - SP içinde ORTALAMA ve DURUM otomatik hesaplanır
  - Güncellenmiş kayıt DataGridView'de gösterilir

**Soru 34: Toplu Silme ve Kayıt Sayısı Döndürme**
- **Metod:** `btnTopluSil_Click()`
- **SP:** `sp_TopluSil(@KulupID)`
- **Kod:**
```csharp
var sonuc = db.Database.SqlQuery<int>(
    "EXEC sp_TopluSil @KulupID",
    new SqlParameter("@KulupID", kulupID)
).FirstOrDefault();
MessageBox.Show($"{sonuc} kayıt silindi!");
```
- **Özellikler:**
  - Belirli kulüpteki tüm öğrencilerin notları silinir
  - SP silinen kayıt sayısını döndürür
  - `SqlQuery<int>()` ile scalar değer alınır

#### **⚙️ Functions Sekmesi (Soru 35-40)**

**Soru 35: Scalar Function**
- **Metod:** `btnScalarFunction_Click()`
- **Function:** `fn_GenelBasariPuani(@OgrenciID)`
- **Kod:**
```csharp
var sonuc = db.Database.SqlQuery<decimal>(
    "SELECT dbo.fn_GenelBasariPuani(@OgrenciID)",
    new SqlParameter("@OgrenciID", ogrenciID)
).FirstOrDefault();
MessageBox.Show($"Genel Başarı Puanı: {sonuc:F2}");
```
- **Özellikler:**
  - Scalar function çağrılır
  - `SqlQuery<decimal>()` ile decimal değer alınır
  - Öğrencinin tüm derslerinin genel ortalaması

**Soru 36: Table-Valued Function**
- **Metod:** `btnTVFDersNot_Click()`
- **Function:** `fn_DersNotListesi(@DersID)`
- **Kod:**
```csharp
var sonuc = db.Database.SqlQuery<DersNotListesi>(
    "SELECT * FROM dbo.fn_DersNotListesi(@DersID)",
    new SqlParameter("@DersID", dersID)
).ToList();
dataGridView1.DataSource = sonuc;
```
- **Özellikler:**
  - TVF çağrılır (SELECT * FROM dbo.fn_...)
  - `DersNotListesi` DTO kullanılır
  - Öğrenci adı-soyadı, notlar, ortalama, durum

**Soru 37: Çok Parametreli TVF**
- **Metod:** `btnCokParametreliTVF_Click()`
- **Function:** `fn_NotFiltrele(@Min, @Max, @Ders, @Durum)`
- **Kod:**
```csharp
object dersID = cmbDers.SelectedValue != null ? (object)Convert.ToInt32(cmbDers.SelectedValue) : DBNull.Value;
object durum = chkGecti.Checked ? (object)1 : (chkKaldi.Checked ? (object)0 : DBNull.Value);
var sonuc = db.Database.SqlQuery<NotFiltreSonuc>(...).ToList();
```
- **Özellikler:**
  - Minimum/maksimum ortalama filtresi
  - İsteğe bağlı ders filtresi (DBNull.Value)
  - İsteğe bağlı durum filtresi (Geçti/Kaldı)
  - `NotFiltreSonuc` DTO kullanılır

**Soru 38: Kulüp Başarı Oranı Fonksiyonu**
- **Metod:** `btnKulupDashboard_Click()`
- **Function:** `fn_KulupBasariOrani()`
- **Kod:**
```csharp
var sonuc = db.Database.SqlQuery<KulupBasari>(
    "SELECT * FROM dbo.fn_KulupBasariOrani()"
).ToList();
dataGridView1.DataSource = sonuc;
```
- **Özellikler:**
  - Parametresiz TVF
  - `KulupBasari` DTO kullanılır
  - Kulüp adı, üye sayısı, ortalama başarı, başarı oranı

**Soru 39: Inline TVF - Zayıf Öğrenciler**
- **Metod:** `btnZayifOgrenciler_Click()`
- **Function:** `fn_ZayifOgrenciler()`
- **Kod:**
```csharp
var sonuc = db.Database.SqlQuery<ZayifOgrenci>(
    "SELECT * FROM dbo.fn_ZayifOgrenciler()"
).ToList();
dataGridView1.DataSource = sonuc;
```
- **Özellikler:**
  - Inline TVF kullanımı
  - SINAV1 notu ortalamanın %20 altında olan öğrenciler
  - `ZayifOgrenci` DTO kullanılır

**Soru 40: Öğrenci Not Özeti DTO Mapping**
- **Metod:** `btnOgrenciNotOzet_Click()`
- **Function:** `fn_OgrenciNotOzet(@OgrenciID)`
- **Kod:**
```csharp
var sonuc = db.Database.SqlQuery<OgrenciNotOzetDTO>(...).ToList();
if (sonuc.Any()) {
    var ozet = sonuc.First();
    lblToplamDers.Text = $"Toplam Ders: {ozet.ToplamDers}";
    lblGecenDers.Text = $"Geçen: {ozet.GecenDers}";
    lblKalanDers.Text = $"Kalan: {ozet.KalanDers}";
    lblGenelOrt.Text = $"Genel Ort: {ozet.GenelOrt:F2}";
}
```
- **Özellikler:**
  - `OgrenciNotOzetDTO` DTO kullanılır
  - Label'lara değerler yazılır
  - Toplam ders, geçen, kalan, genel ortalama

#### **🔄 Transactions Sekmesi (Soru 41-45)**

**Soru 41: Çok Adımlı Kayıt Transaction**
- **Metod:** `btnCokAdimliKayit_Click()`
- **Kod:**
```csharp
using (var transaction = db.Database.BeginTransaction())
{
    try {
        // 1. Yeni öğrenci ekle
        var yeniOgrenci = new TBLOGRENCI { ... };
        db.TBLOGRENCI.Add(yeniOgrenci);
        db.SaveChanges();
        
        // 2. Üç farklı ders için not ekle
        var dersler = db.TBLDERSLER.Take(3).ToList();
        foreach (var ders in dersler) {
            var yeniNot = new TBLNOTLAR { ... };
            db.TBLNOTLAR.Add(yeniNot);
        }
        db.SaveChanges();
        transaction.Commit();
    }
    catch {
        transaction.Rollback();
    }
}
```
- **Özellikler:**
  - `BeginTransaction()` ile transaction başlatılır
  - Çok adımlı işlem: Öğrenci ekle → Notlar ekle
  - Hata durumunda `Rollback()`
  - Başarılı durumda `Commit()`
  - `SaveChanges()` her adımda veya sonda çağrılabilir

**Soru 42: TransactionScope ile Toplu Not Güncelleme**
- **Metod:** `btnTopluNotGuncelle_Click()`
- **Kod:**
```csharp
using (var scope = new TransactionScope())
{
    try {
        var guncellenecekNotlar = db.TBLNOTLAR.Take(10).ToList();
        foreach (var not in guncellenecekNotlar) {
            not.SINAV1 = (not.SINAV1 ?? 0) + 5;
            if (not.SINAV1 > 100) not.SINAV1 = 100;
            not.ORTALAMA = (not.SINAV1 + not.SINAV2 + not.SINAV3) / 3.0m;
            not.DURUM = not.ORTALAMA >= 50;
        }
        db.SaveChanges();
        scope.Complete();
    }
    catch { ... }
}
```
- **Özellikler:**
  - `TransactionScope` kullanımı
  - 10 öğrencinin notu toplu güncellenir
  - Hepsi başarılı olursa `Complete()` çağrılır
  - Herhangi biri hata verirse rollback
  - `RequiresNew` ve `Required` farkları açıklanır

**Soru 43: Çok Tablolu Transaction**
- **Metod:** `btnCokTabloTransaction_Click()`
- **Kod:**
```csharp
using (var transaction = db.Database.BeginTransaction())
{
    try {
        // 1. TBLNOTLAR'dan notları sil
        var notlar = db.TBLNOTLAR.Where(n => n.OGRENCI == ogrenciID).ToList();
        db.TBLNOTLAR.RemoveRange(notlar);
        
        // 2. TBLOGRENCI'den öğrenciyi sil
        db.TBLOGRENCI.Remove(ogrenci);
        
        db.SaveChanges();
        transaction.Commit();
    }
    catch {
        transaction.Rollback();
    }
}
```
- **Özellikler:**
  - İki tabloda işlem yapılır
  - Tüm işlemler başarılı olmalı veya hiçbiri yapılmamalı
  - Atomicity garantisi

**Soru 44: Transaction + SP Birlikte Kullanımı**
- **Metod:** `btnTransactionSP_Click()`
- **SP:** `sp_OgrenciTamSil(@OgrenciID)`
- **Kod:**
```csharp
using (var transaction = db.Database.BeginTransaction())
{
    try {
        db.Database.ExecuteSqlCommand(
            "EXEC sp_OgrenciTamSil @OgrenciID",
            new SqlParameter("@OgrenciID", ogrenciID)
        );
        transaction.Commit();
    }
    catch {
        transaction.Rollback();
    }
}
```
- **Özellikler:**
  - SP transaction içinde çağrılır
  - SP başarısız olursa rollback
  - SP içinde: Notları sil → Öğrenciyi sil → Kulüp üye sayısını güncelle

**Soru 45: Transaction + Validation + File Check**
- **Metod:** `btnFotoGuncelle_Click()`
- **Kod:**
```csharp
using (var transaction = db.Database.BeginTransaction())
{
    try {
        // File.Exists ile dosya kontrolü
        if (!string.IsNullOrEmpty(yeniFotoYolu) && !File.Exists(yeniFotoYolu)) {
            throw new FileNotFoundException("Fotoğraf dosyası bulunamadı!", yeniFotoYolu);
        }
        var ogrenci = db.TBLOGRENCI.Find(ogrenciID);
        ogrenci.OgrenciFoto = yeniFotoYolu;
        db.SaveChanges();
        transaction.Commit();
    }
    catch (FileNotFoundException ex) {
        transaction.Rollback();
        MessageBox.Show($"Dosya bulunamadı: {ex.FileName}");
    }
}
```
- **Özellikler:**
  - `File.Exists()` ile dosya varlık kontrolü
  - Dosya yoksa transaction rollback
  - Hem EF hem SQL tarafında validation
  - Exception handling ile hata yakalama

---

## 🗄️ Veritabanı Yapısı

### **dbSinavOgrenci Veritabanı**

#### **TBLKULUPLER Tablosu**
- `KULUPID` (int, Primary Key, Identity)
- `KULUPAD` (nvarchar(50), NOT NULL)

#### **TBLDERSLER Tablosu**
- `DERSID` (int, Primary Key, Identity)
- `DERSAD` (nvarchar(50), NOT NULL)

#### **TBLOGRENCI Tablosu**
- `OgrenciID` (int, Primary Key, Identity)
- `OgrenciAd` (nvarchar(50), NOT NULL)
- `OgrenciSoyad` (nvarchar(50), NOT NULL)
- `OgrenciFoto` (nvarchar(250), NULL)
- `KulupID` (int, NULL, Foreign Key → TBLKULUPLER.KULUPID)

#### **TBLNOTLAR Tablosu**
- `NOTID` (int, Primary Key, Identity)
- `DERS` (int, NOT NULL, Foreign Key → TBLDERSLER.DERSID)
- `OGRENCI` (int, NOT NULL, Foreign Key → TBLOGRENCI.OgrenciID)
- `SINAV1` (int, NULL)
- `SINAV2` (int, NULL)
- `SINAV3` (int, NULL)
- `ORTALAMA` (decimal(5,2), NULL)
- `DURUM` (bit, NULL) - 1=Geçti, 0=Kaldı

### **Stored Procedures**

1. **sp_NotEkleKontrollu** - Duplicate kontrolü ile not ekleme
2. **sp_OgrenciDetayGetir** - Öğrenci detay raporu
3. **sp_DersBasariRaporu** - Ders başarı analizi
4. **sp_NotGuncelle** - Not güncelleme (ortalama ve durum otomatik)
5. **sp_TopluSil** - Toplu silme ve kayıt sayısı döndürme
6. **sp_OgrenciTamSil** - Öğrenci ve tüm kayıtlarını silme

### **Functions**

1. **fn_GenelBasariPuani** (Scalar) - Öğrencinin genel başarı puanı
2. **fn_DersNotListesi** (TVF) - Ders not listesi
3. **fn_NotFiltrele** (TVF) - Çok parametreli filtreleme
4. **fn_KulupBasariOrani** (TVF) - Kulüp başarı oranları
5. **fn_ZayifOgrenciler** (Inline TVF) - Zayıf öğrenciler
6. **fn_OgrenciNotOzet** (TVF) - Öğrenci not özeti

---

## 🎨 Tasarım Özellikleri

### **Renk Paleti (Flat UI Colors)**
- **Mavi:** Color.FromArgb(52, 152, 219) - Temel işlemler
- **Yeşil:** Color.FromArgb(46, 204, 113) - Başarılı işlemler
- **Mor:** Color.FromArgb(155, 89, 182) - CRUD işlemleri
- **Sarı:** Color.FromArgb(241, 196, 15) - LINQ işlemleri
- **Turuncu:** Color.FromArgb(230, 126, 34) - Aggregate işlemleri
- **Kırmızı:** Color.FromArgb(231, 76, 60) - Durum işlemleri
- **Turkuaz:** Color.FromArgb(26, 188, 156) - Gelişmiş işlemler
- **Gri:** Color.FromArgb(149, 165, 166) - Geri butonları

### **UI Bileşenleri**
- **Panel'ler:** Header, Buttons, Data, Search panelleri
- **DataGridView:** 
  - Alternatif satır renkleri
  - Renkli header'lar
  - Full row selection
  - Auto-size columns
- **Butonlar:**
  - Flat style
  - Hover efektleri (MouseEnter/MouseLeave)
  - Renkli arka planlar
- **GroupBox'lar:** Form alanlarını gruplamak için
- **SplitContainer:** İki ayrı liste göstermek için

### **Responsive Tasarım**
- `Dock` ve `Anchor` kullanımı
- `MinimumSize` tanımları
- `AutoSizeColumnsMode.Fill` ile DataGridView sütunları
- Padding ve margin'ler ile düzenli boşluklar

---

## 🔧 Teknik Özellikler

### **Entity Framework 6.4.4**
- **Yaklaşım:** Code First (Manuel entity oluşturma)
- **DbContext:** `dbSinavOgrenciEntities`
- **Fluent API:** İlişkileri yapılandırmak için
- **Navigation Properties:** Otomatik JOIN işlemleri
- **Lazy Loading:** Varsayılan olarak aktif

### **LINQ & Lambda Expressions**
- **Kullanım:** Tüm sorgularda zorunlu
- **Metodlar:**
  - `Where()`, `Select()`, `OrderBy()`, `OrderByDescending()`
  - `Take()`, `Sum()`, `Average()`, `Count()`
  - `Any()`, `FirstOrDefault()`, `ToList()`
- **Anonim Tipler:** `new { ... }` yapısı
- **Lambda Expressions:** `o => o.OgrenciAd.Contains(...)`

### **Stored Procedure Çağrıları**
- **ExecuteSqlCommand:** DML işlemleri için
- **SqlQuery<T>:** SELECT sonuçları için
- **SqlParameter:** Parametreli çağrılar için
- **Exception Handling:** SqlException yakalama

### **Transaction Yönetimi**
- **BeginTransaction:** EF transaction
- **TransactionScope:** Distributed transaction
- **Commit/Rollback:** İşlem kontrolü
- **Nested Transactions:** RequiresNew ve Required

### **DTO Mapping**
- **SqlQuery<T>:** SP ve Function sonuçlarını DTO'ya map etme
- **DTO Sınıfları:** 7 adet DTO sınıfı
- **Type Safety:** Strongly-typed sonuçlar

---

## 📊 Soru Bazında İşlevsellik Özeti

### **Bölüm 1: Temel EF (Soru 1-5)**
✅ DbContext yaşam döngüsü  
✅ Öğrenci listeleme  
✅ Alan gizleme  
✅ EF vs ADO.NET karşılaştırması

### **Bölüm 2: Navigation (Soru 6-12)**
✅ Navigation property kullanımı  
✅ Anonim tip listeleme  
✅ String birleştirme  
✅ JOIN işlemleri  
✅ Üç tablo birleştirme

### **Bölüm 3: CRUD (Soru 13-18)**
✅ Create (Ekleme)  
✅ Read (Okuma)  
✅ Update (Güncelleme)  
✅ Delete (Silme)  
✅ EntityState kavramı

### **Bölüm 4: LINQ (Soru 19-25)**
✅ Canlı filtreleme (TextChanged)  
✅ Sıralama (OrderBy/OrderByDescending)  
✅ Take() kullanımı  
✅ StartsWith/EndsWith filtreleme

### **Bölüm 5: Aggregate (Soru 26-28)**
✅ Sum() toplam  
✅ Average() ortalama  
✅ Koşullu filtreleme

### **Bölüm 6: Durum (Soru 29-30)**
✅ Anonim tip durum listesi  
✅ Geçen/Kalan ayrımı

### **Bölüm 7: Gelişmiş (Soru 30-45)**
✅ Stored Procedures (5 adet)  
✅ Scalar Functions  
✅ Table-Valued Functions (5 adet)  
✅ Transactions (5 senaryo)  
✅ File validation

---

## 🎯 Önemli Notlar

1. **Lambda Expression Zorunluluğu:** Tüm sorgularda lambda expression kullanılmalı
2. **Anonim Tip Kullanımı:** Listeleme işlemlerinde anonim tip tercih edilir
3. **Navigation Property:** JOIN yerine navigation property kullanılır
4. **DbContext Yaşam Döngüsü:** Her form kendi DbContext'ini yönetir
5. **Exception Handling:** SP ve Transaction işlemlerinde zorunlu
6. **DTO Mapping:** SP/Function sonuçları DTO'ya map edilir
7. **Transaction Kullanımı:** Çok adımlı işlemlerde zorunlu

---

## 📝 Sonuç

Bu proje, Entity Framework 6 kullanarak 45 farklı senaryoyu kapsayan kapsamlı bir Windows Forms uygulamasıdır. Temel CRUD işlemlerinden başlayarak, Stored Procedure, Function ve Transaction yönetimine kadar geniş bir yelpazede Entity Framework özelliklerini gösterir.

**Toplam Dosya Sayısı:** ~50+ dosya  
**Toplam Kod Satırı:** ~3000+ satır  
**Form Sayısı:** 8 form  
**DTO Sayısı:** 7 DTO  
**Entity Sayısı:** 4 entity  
**Soru Sayısı:** 45 soru

---

*Rapor Tarihi: 2024*  
*Proje: SinavOgrenciSistemi*  
*Framework: .NET Framework 4.8 + Entity Framework 6.4.4*
