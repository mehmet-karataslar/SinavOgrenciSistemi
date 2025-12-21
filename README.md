# 📚 Sınav Öğrenci Sistemi

<div align="center">

![.NET Framework](https://img.shields.io/badge/.NET-Framework%204.8-512BD4?style=for-the-badge&logo=dotnet)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-6.4.4-FF6B00?style=for-the-badge&logo=.net)
![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-CC2927?style=for-the-badge&logo=microsoft-sql-server)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Desktop-0078D4?style=for-the-badge&logo=windows)

**Gelişmiş Entity Framework Örneği ile Öğrenci ve Not Yönetim Sistemi**

[Özellikler](#-özellikler) • [Kurulum](#-kurulum) • [Kullanım](#-kullanım) • [Proje Yapısı](#-proje-yapısı)

</div>

---

## 📋 İçindekiler

- [Genel Bakış](#-genel-bakış)
- [Özellikler](#-özellikler)
- [Teknolojiler](#-teknolojiler)
- [Veritabanı Yapısı](#-veritabanı-yapısı)
- [Kurulum](#-kurulum)
- [Kullanım](#-kullanım)
- [Proje Yapısı](#-proje-yapısı)
- [Özelliklerin Detayları](#-özelliklerin-detayları)
- [Geliştirici Notları](#-geliştirici-notları)

---

## 🎯 Genel Bakış

**Sınav Öğrenci Sistemi**, Entity Framework 6 kullanılarak geliştirilmiş kapsamlı bir Windows Forms uygulamasıdır. Sistem, öğrenci bilgileri, dersler, notlar ve kulüp yönetimini tek bir platformda toplayarak, modern veritabanı yönetim tekniklerini ve LINQ sorgulama yeteneklerini pratik olarak gösterir.

Bu proje, **45 soruluk gelişmiş seviye bir Entity Framework ödevi** olarak tasarlanmış ve aşağıdaki konuları kapsamaktadır:

- ✅ Temel Entity Framework kullanımı
- ✅ Navigation Property ve ilişkisel sorgular
- ✅ CRUD (Create, Read, Update, Delete) işlemleri
- ✅ LINQ filtreleme, arama ve sıralama
- ✅ Aggregate fonksiyonlar (SUM, AVG, MAX, MIN)
- ✅ Stored Procedure kullanımı
- ✅ Scalar ve Table-Valued Functions
- ✅ Transaction yönetimi

---

## ✨ Özellikler

### 🔹 Temel İşlemler
- **Öğrenci Yönetimi**: Öğrenci ekleme, silme, güncelleme ve listeleme
- **Ders Yönetimi**: Ders bilgilerini görüntüleme ve yönetme
- **Not Yönetimi**: Sınav notlarını girme, güncelleme ve görüntüleme
- **Kulüp Yönetimi**: Öğrenci-kulüp ilişkilerini yönetme

### 🔹 Gelişmiş Sorgulama
- **LINQ Sorguları**: Lambda expression ile filtreleme ve arama
- **Navigation Property**: İlişkili tablolar arası veri çekme
- **Anonim Tipler**: Dinamik veri yapıları ile esnek sorgular
- **Canlı Arama**: TextChanged olayı ile anlık filtreleme

### 🔹 Raporlama ve Analiz
- **Başarı Analizi**: Ders bazında başarı raporları
- **Durum Hesaplama**: Geçti/Kaldı durumunu otomatik hesaplama
- **İstatistiksel Veriler**: Ortalama, toplam, maksimum, minimum değerler
- **Kulüp Performansı**: Kulüp bazında başarı oranı analizi

### 🔹 Veritabanı İşlemleri
- **Stored Procedures**: Kontrollü veri ekleme ve güncelleme
- **Functions**: Scalar ve Table-Valued fonksiyonlar
- **Transactions**: Çok adımlı işlemlerde veri bütünlüğü
- **Hata Yönetimi**: Try-catch blokları ile güvenli işlemler

---

## 🛠 Teknolojiler

| Teknoloji | Versiyon | Açıklama |
|-----------|----------|----------|
| **.NET Framework** | 4.8 | Uygulama çerçevesi |
| **Entity Framework** | 6.4.4 | ORM (Object-Relational Mapping) |
| **SQL Server** | 2019+ | Veritabanı sunucusu |
| **Windows Forms** | - | GUI framework |
| **LINQ** | - | Veri sorgulama dili |
| **C#** | 7.0+ | Programlama dili |

---

## 🗄 Veritabanı Yapısı

### Tablolar

#### 📌 TBLKULUPLER
Öğrencilerin bağlı olduğu kulüpler tablosu.

| Sütun | Tip | Açıklama |
|-------|-----|----------|
| `KULUPID` | INT (PK) | Kulüp kimliği |
| `KULUPAD` | NVARCHAR(50) | Kulüp adı |

#### 📌 TBLDERSLER
Ders listesi tablosu.

| Sütun | Tip | Açıklama |
|-------|-----|----------|
| `DERSID` | INT (PK) | Ders kimliği |
| `DERSAD` | NVARCHAR(50) | Ders adı |

#### 📌 TBLOGRENCI
Öğrenci bilgileri tablosu.

| Sütun | Tip | Açıklama |
|-------|-----|----------|
| `OgrenciID` | INT (PK) | Öğrenci kimliği |
| `OgrenciAd` | NVARCHAR(50) | Öğrenci adı |
| `OgrenciSoyad` | NVARCHAR(50) | Öğrenci soyadı |
| `OgrenciFoto` | NVARCHAR(250) | Fotoğraf yolu |
| `KulupID` | INT (FK) | Kulüp referansı |

#### 📌 TBLNOTLAR
Sınav notları ve durum bilgisi tablosu.

| Sütun | Tip | Açıklama |
|-------|-----|----------|
| `NOTID` | INT (PK) | Not kaydı kimliği |
| `DERS` | INT (FK) | Ders referansı |
| `OGRENCI` | INT (FK) | Öğrenci referansı |
| `SINAV1` | INT | 1. Sınav notu |
| `SINAV2` | INT | 2. Sınav notu |
| `SINAV3` | INT | 3. Sınav notu |
| `ORTALAMA` | DECIMAL(5,2) | Hesaplanan ortalama |
| `DURUM` | BIT | Geçti (1) / Kaldı (0) |

### İlişkiler

```
TBLKULUPLER (1) ────< (N) TBLOGRENCI
TBLOGRENCI (1) ────< (N) TBLNOTLAR
TBLDERSLER (1) ────< (N) TBLNOTLAR
```

---

## 🚀 Kurulum

### Gereksinimler

1. **Visual Studio 2019 veya üzeri**
2. **.NET Framework 4.8**
3. **SQL Server 2019 veya üzeri**
4. **Entity Framework 6.4.4** (NuGet ile yüklenecek)

### Adım Adım Kurulum

#### 1️⃣ Veritabanını Oluşturma

```sql
-- DatabaseScript.sql dosyasını SQL Server Management Studio'da çalıştırın
-- Veya aşağıdaki komutu kullanın:
```

```bash
sqlcmd -S localhost -i DatabaseScript.sql
```

#### 2️⃣ Projeyi Klonlama

```bash
git clone git@github.com:mehmet-karataslar/SinavOgrenciSistemi.git
cd SinavOgrenciSistemi
```

#### 3️⃣ Connection String'i Güncelleme

`SinavOgrenciSistemi/App.config` dosyasında connection string'i düzenleyin:

```xml
<connectionStrings>
  <add name="dbSinavOgrenciEntities" 
       connectionString="metadata=res://*/Models.dbSinavOgrenciEntities.csdl|res://*/Models.dbSinavOgrenciEntities.ssdl|res://*/Models.dbSinavOgrenciEntities.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=YOUR_SERVER;initial catalog=dbSinavOgrenci;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" 
       providerName="System.Data.EntityClient" />
</connectionStrings>
```

#### 4️⃣ NuGet Paketlerini Yükleme

Visual Studio'da:
```
Tools → NuGet Package Manager → Package Manager Console
```

```powershell
Update-Package -reinstall EntityFramework
```

#### 5️⃣ Projeyi Derleme

```bash
# Visual Studio'da
Build → Build Solution (Ctrl+Shift+B)
```

---

## 💻 Kullanım

### Ana Menü

Proje çalıştırıldığında **FormMain** ana menü olarak açılır. Buradan şu modüllere erişilebilir:

| Buton | Form | Açıklama |
|-------|------|----------|
| 🔵 **Temel EF** | FormTemelEF | Temel Entity Framework işlemleri |
| 🔵 **Navigation** | FormNavigation | İlişkisel tablo sorguları |
| 🔵 **CRUD** | FormCRUD | Create, Read, Update, Delete |
| 🔵 **LINQ** | FormLINQ | Filtreleme ve sıralama |
| 🔵 **Aggregate** | FormAggregate | Toplam, ortalama, max, min |
| 🔵 **Durum** | FormDurum | Durum hesaplama ve raporlama |
| 🔵 **Gelişmiş** | FormGelismis | SP, Function, Transaction |

### Örnek Kullanım Senaryoları

#### 📝 Öğrenci Ekleme
1. **FormCRUD** formunu açın
2. Öğrenci adı, soyadı ve fotoğraf yolunu girin
3. Kulüp seçin (opsiyonel)
4. **Ekle** butonuna tıklayın

#### 🔍 Öğrenci Arama
1. **FormLINQ** formunu açın
2. Arama kutusuna öğrenci adını yazın
3. Sonuçlar anlık olarak filtrelenir

#### 📊 Başarı Raporu
1. **FormDurum** formunu açın
2. **Durum Listesi** butonuna tıklayın
3. Geçti/Kaldı durumlarını görüntüleyin

---

## 📁 Proje Yapısı

```
SinavOgrenciSistemi/
│
├── 📄 DatabaseScript.sql          # Veritabanı oluşturma scripti
├── 📄 README.md                   # Bu dosya
│
├── 📂 SinavOgrenciSistemi/        # Ana proje klasörü
│   ├── 📂 Models/                 # Entity Framework modelleri
│   │   ├── dbSinavOgrenciEntities.cs
│   │   ├── TBLOGRENCI.cs
│   │   ├── TBLNOTLAR.cs
│   │   ├── TBLDERSLER.cs
│   │   └── TBLKULUPLER.cs
│   │
│   ├── 📂 DTOs/                   # Data Transfer Objects
│   │   ├── DersBasariRapor.cs
│   │   ├── OgrenciDetay.cs
│   │   ├── OgrenciNotOzetDTO.cs
│   │   └── ...
│   │
│   ├── 📂 Forms/                  # Windows Forms
│   │   ├── FormMain.cs            # Ana menü
│   │   ├── FormTemelEF.cs         # Soru 1-5
│   │   ├── FormNavigation.cs      # Soru 6-12
│   │   ├── FormCRUD.cs            # Soru 13-18
│   │   ├── FormLINQ.cs            # Soru 19-25
│   │   ├── FormAggregate.cs       # Soru 26-28
│   │   ├── FormDurum.cs           # Soru 29-30
│   │   └── FormGelismis.cs        # Soru 30-45
│   │
│   ├── App.config                 # Yapılandırma dosyası
│   ├── Program.cs                 # Program giriş noktası
│   └── SinavOgrenciSistemi.csproj # Proje dosyası
│
└── 📄 EFOdevCozumleri.cs          # Referans kod örnekleri
```

---

## 🔍 Özelliklerin Detayları

### 1️⃣ Temel Entity Framework (Soru 1-5)

- **DbContext Yaşam Döngüsü**: Form seviyesinde context yönetimi
- **Veri Listeleme**: TBLOGRENCI, TBLDERSLER tablolarını listeleme
- **Sütun Gizleme**: DataGridView'de belirli sütunları gizleme
- **ADO.NET vs EF**: İki yaklaşımın karşılaştırması

### 2️⃣ Navigation & İlişkili Sorgular (Soru 6-12)

- **Navigation Property**: İlişkili tablolara erişim
- **Join İşlemleri**: Multiple table join
- **Anonim Tipler**: Dinamik veri yapıları
- **Öğrenci-Not-Ders**: Üç tabloyu birleştirme

### 3️⃣ CRUD İşlemleri (Soru 13-18)

- **Create**: Yeni öğrenci ekleme
- **Read**: Öğrenci listeleme ve arama
- **Update**: Öğrenci bilgilerini güncelleme
- **Delete**: Öğrenci silme
- **EntityState**: Entity durum yönetimi

### 4️⃣ LINQ Filtreleme (Soru 19-25)

- **Contains**: Kısmi eşleşme
- **StartsWith/EndsWith**: Başlangıç/bitiş kontrolü
- **OrderBy/OrderByDescending**: Sıralama
- **Take**: İlk N kayıt
- **TextChanged Event**: Canlı filtreleme

### 5️⃣ Aggregate Fonksiyonlar (Soru 26-28)

- **Sum**: Toplam hesaplama
- **Average**: Ortalama hesaplama
- **Max/Min**: Maksimum/Minimum değerler
- **Filtreleme**: Ortalama üzeri kayıtlar

### 6️⃣ Durum Hesaplama (Soru 29-30)

- **Ternary Operator**: Durum hesaplama
- **Gruplama**: Geçen/Kalan öğrenciler
- **SplitContainer**: İki ayrı liste görünümü

### 7️⃣ Gelişmiş İşlemler (Soru 30-45)

#### Stored Procedures
- `sp_NotEkleKontrollu`: Tekrar kayıt kontrolü
- `sp_OgrenciDetayGetir`: Öğrenci detay raporu
- `sp_DersBasariRaporu`: Ders bazında analiz
- `sp_NotGuncelle`: Not güncelleme
- `sp_TopluSil`: Toplu silme işlemi

#### Functions
- `fn_GenelBasariPuani`: Scalar function
- `fn_DersNotListesi`: Table-valued function
- `fn_NotFiltrele`: Çok parametreli TVF
- `fn_KulupBasariOrani`: Kulüp analizi
- `fn_ZayifOgrenciler`: Inline TVF

#### Transactions
- **TransactionScope**: Çok adımlı işlemler
- **Rollback/Commit**: Veri bütünlüğü
- **File Validation**: Dosya kontrolü ile transaction

---

## 🎓 Geliştirici Notları

### LINQ & Lambda Expression Zorunluluğu

Bu projede **tüm veri erişim işlemleri** LINQ ve Lambda Expression kullanılarak yapılmıştır. Aşağıdaki yaklaşımlar **yasaktır**:

❌ Klasik döngüler (`for`, `foreach`, `while`)
❌ ADO.NET manuel işlemleri (`SqlCommand`, `SqlDataAdapter`)
❌ `DataTable` üzerinden manuel veri işleme
❌ Anonymous method (`delegate { }`)

✅ LINQ sorguları
✅ Lambda expression (`o => o.OgrenciAd.Contains("A")`)
✅ Anonim tipler (`new { ... }`)
✅ Navigation property

### Örnek Kod Yapısı

```csharp
// ✅ DOĞRU KULLANIM
var liste = db.TBLOGRENCI
    .Where(o => o.OgrenciAd.Contains("A"))
    .OrderBy(o => o.OgrenciSoyad)
    .Select(o => new { o.OgrenciAd, o.OgrenciSoyad })
    .ToList();

// ❌ YANLIŞ KULLANIM
var liste = db.TBLOGRENCI.ToList();
var sonuc = new List<object>();
foreach(var o in liste)
{
    if(o.OgrenciAd.Contains("A"))
        sonuc.Add(o);
}
```

### DbContext Yaşam Döngüsü

Her formda tek bir `DbContext` örneği kullanılır ve form kapanırken `Dispose` edilir:

```csharp
public partial class FormCRUD : Form
{
    dbSinavOgrenciEntities db = new dbSinavOgrenciEntities();
    
    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        db.Dispose();
        base.OnFormClosed(e);
    }
}
```

---

## 📊 Proje İstatistikleri

- **Toplam Soru Sayısı**: 45
- **Form Sayısı**: 7
- **Veritabanı Tablosu**: 4
- **Stored Procedure**: 5
- **Function**: 5
- **DTO Sınıfı**: 6

---

## 🤝 Katkıda Bulunma

Bu proje eğitim amaçlı geliştirilmiştir. Önerileriniz ve geri bildirimleriniz için issue açabilirsiniz.

---

## 📝 Lisans

Bu proje eğitim amaçlı geliştirilmiştir. Akademik kullanım için uygundur.

---

## 👨‍💻 Geliştirici

**Mehmet Karataşlar**

- GitHub: [@mehmet-karataslar](https://github.com/mehmet-karataslar)
- Proje: [SinavOgrenciSistemi](https://github.com/mehmet-karataslar/SinavOgrenciSistemi)

---

<div align="center">

**⭐ Projeyi beğendiyseniz yıldız vermeyi unutmayın! ⭐**

Made with ❤️ using Entity Framework and Windows Forms

</div>

