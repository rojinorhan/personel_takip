# 👥 Personel Takip Otomasyon Sistemi

**Personel Takip Otomasyon Sistemi**, personel bilgilerinin merkezi bir yapı üzerinden yönetilmesini sağlayan, **.NET MAUI** ve **ASP.NET Core Web API** teknolojileri kullanılarak geliştirilmiş bir masaüstü/mobil uygulama projesidir.

Uygulama; yöneticilerin personel kayıtlarını görüntülemesine, eklemesine, güncellemesine, silmesine ve aramasına olanak sağlayacak şekilde tasarlanmıştır.

---

## 📌 Proje Hakkında

Bu proje, işletmelerde çalışan personellerin bilgilerinin daha düzenli ve kontrollü bir şekilde takip edilmesini amaçlamaktadır.

Uygulama iki temel bölümden oluşmaktadır:

* 🖥️ **PersonelTakipOtonomSistemi** → .NET MAUI istemci uygulaması
* 🌐 **PersonelTakipOtomasyonuApı** → ASP.NET Core Web API

MAUI uygulaması kullanıcı arayüzünü ve kullanıcı işlemlerini gerçekleştirirken, Web API tarafı personel verilerinin yönetilmesini ve veritabanı işlemlerini gerçekleştirir.

---

## ✨ Özellikler

### 🔐 Kullanıcı Girişi

* Yönetici girişi
* Personel girişi
* Kullanıcı tipine göre farklı menülere yönlendirme

### 👨‍💼 Yönetici İşlemleri

Yönetici paneli üzerinden:

* 👁️ Personel görüntüleme
* ➕ Personel ekleme
* 🔄 Personel güncelleme
* 🗑️ Personel silme
* 🔎 Personel arama

işlemleri gerçekleştirilebilir.

### 📋 Personel Bilgileri

Sistemde personellere ait aşağıdaki bilgilerin takip edilmesi amaçlanmıştır:

* Personel ID
* Ad
* Soyad
* Doğum tarihi
* TC Kimlik No
* Telefon numarası
* İşe başlama tarihi
* Departman
* Pozisyon
* E-posta
* Şifre

---

## 🖼️ Uygulama Görselleri
### 🔐 Giriş Ekranı

Uygulamanın başlangıç ekranında kullanıcı, sistemde gerçekleştireceği işleme göre **Yönetici Login** veya **Personel Login** seçeneklerinden birini seçerek giriş yapabilir.

<img width="1536" height="1024" alt="Giriş Ekranı" src="https://github.com/user-attachments/assets/fa3afef4-8c38-42ac-9d77-7e24517fb447" />

---

### 👨‍💼 Yönetici Menüsü

Yönetici giriş yaptıktan sonra karşısına **Yönetici Menüsü** gelmektedir. Bu ekran üzerinden personel yönetimiyle ilgili işlemlere hızlı bir şekilde erişilebilir.

Yönetici menüsünde;

* 👁️ **Personel Görüntüle**
* ➕ **Personel Ekle**
* 🔄 **Personel Güncelle**
* 🗑️ **Personel Sil**
* 🔎 **Personel Ara**

işlemleri gerçekleştirilebilir.

<img width="1536" height="1024" alt="Yönetici Menüsü" src="https://github.com/user-attachments/assets/eb3c7357-3dcf-452a-a6d1-90216d2030e8" />


> **Not:** Görselleri GitHub'da göstermek için `images` klasörü oluşturup ekran görüntülerini sırasıyla `anaekran.png` ve `personel-goruntule.png` isimleriyle ekleyebilirsin.

---

## 🏗️ Proje Mimarisi

Proje temel olarak istemci ve API katmanlarından oluşmaktadır:

```text
personel_takip
│
├── PersonelTakipOtonomSistemi
│   └── PersonelTakipOtonomSistemi
│       ├── Dtos
│       ├── Platforms
│       ├── Properties
│       ├── Resources
│       ├── Services
│       ├── Views
│       ├── App.xaml
│       ├── AppShell.xaml
│       ├── MauiProgram.cs
│       └── PersonelTakipOtonomSistemi.csproj
│
├── PersonelTakipOtomasyonuApı
│   └── PersonelTakipOtomasyonuApı
│       ├── Dtos
│       ├── Efcore
│       ├── Migrations
│       ├── Models
│       ├── Properties
│       ├── Services
│       ├── Program.cs
│       ├── appsettings.json
│       └── PersonelTakipOtomasyonuApı.csproj
│
└── README.md
```

---

## 🛠️ Kullanılan Teknolojiler

### Frontend / Client

* **C#**
* **.NET 8**
* **.NET MAUI**
* **XAML**
* REST API

MAUI projesi .NET 8 kullanılarak hazırlanmış olup Android, iOS, MacCatalyst ve Windows hedeflerini destekleyecek şekilde yapılandırılmıştır.

### Backend

* **C#**
* **ASP.NET Core Web API**
* **.NET 8**
* **Entity Framework Core**
* **SQL Server**
* **Swagger / OpenAPI**

API projesi .NET 8 üzerinde çalışmakta; Entity Framework Core, SQL Server ve Swagger paketlerini kullanmaktadır.

---

## 🗄️ Veritabanı

Veritabanı işlemleri API tarafında **Entity Framework Core** aracılığıyla gerçekleştirilmektedir.

Projede:

* Entity Framework Core
* SQL Server
* EF Core Migrations

kullanılmıştır.

Veritabanı bağlantı ayarları API projesindeki:

```text
appsettings.json
```

dosyası üzerinden yapılandırılabilir.

> Güvenlik nedeniyle gerçek veritabanı kullanıcı adı, şifre veya bağlantı bilgilerinin GitHub'a yüklenmemesi önerilir.

---

## 🔌 API Yapısı

Web API, MAUI uygulaması ile veritabanı arasında iletişim sağlayan katmandır.

Genel yapı:

```text
MAUI Uygulaması
       │
       ▼
   REST API
       │
       ▼
Entity Framework Core
       │
       ▼
   SQL Server
```

Bu yapı sayesinde kullanıcı arayüzü ile veritabanı işlemleri birbirinden ayrılmıştır.

API içerisinde DTO, Model, EF Core, Migration ve Service klasörleri bulunmaktadır.

---

## 🚀 Kurulum

### 1. Repoyu Klonla

```bash
git clone https://github.com/rojinorhan/personel_takip.git
```

### 2. Projeyi Aç

Projeyi **Visual Studio** ile açın.

Solution dosyaları ilgili proje klasörleri içerisinde bulunmaktadır.

### 3. API'yi Yapılandır

API projesinde:

```text
appsettings.json
```

dosyasındaki SQL Server bağlantı ayarlarını kendi veritabanınıza göre düzenleyin.

### 4. Veritabanını Oluştur

Entity Framework Core Migration'larını kullanarak veritabanını oluşturun/güncelleyin.

Örnek:

```bash
dotnet ef database update
```

### 5. API'yi Çalıştır

API projesini başlatın.

Swagger arayüzü üzerinden API endpoint'lerini kontrol edebilirsiniz.

### 6. MAUI Uygulamasını Çalıştır

MAUI projesini başlangıç projesi olarak seçerek uygulamayı çalıştırın.

---

## 📱 Uygulama Akışı

```text
             ┌─────────────────┐
             │    Ana Ekran    │
             └────────┬────────┘
                      │
            ┌─────────┴─────────┐
            │                   │
            ▼                   ▼
     Yönetici Login       Personel Login
            │                   │
            ▼                   ▼
     Yönetici Menü        Personel Menü
            │
     ┌──────┼──────┬────────┬────────┐
     ▼      ▼      ▼        ▼        ▼
 Görüntüle Ekle Güncelle   Sil      Ara
```

---

## 🎨 Arayüz

Uygulamanın arayüzü XAML kullanılarak hazırlanmıştır.

Ana ekranda mor tonlar ve altın renkli detaylar kullanılırken, yönetici panelinde personel yönetim işlemlerine hızlı erişim sağlayan butonlar bulunmaktadır.

Personel görüntüleme ekranında ise personel bilgileri düzenli bir liste yapısı içerisinde gösterilmektedir.

---

## 📂 Önemli Klasörler

| Klasör       | Açıklama                             |
| ------------ | ------------------------------------ |
| `Views`      | Uygulamanın XAML ekranları           |
| `Dtos`       | Veri transfer nesneleri              |
| `Services`   | Servis ve API iletişim işlemleri     |
| `Models`     | Veritabanı modelleri                 |
| `Efcore`     | Entity Framework Core yapıları       |
| `Migrations` | Veritabanı migration dosyaları       |
| `Resources`  | Görsel, font ve uygulama kaynakları  |
| `Platforms`  | Platforma özel MAUI yapılandırmaları |

---

## 🎯 Projenin Amacı

Bu projenin temel amacı, personel bilgilerinin manuel yöntemler yerine dijital ortamda yönetilmesini sağlamaktır.

Sistem sayesinde:

* Personel kayıtları merkezi olarak yönetilebilir.
* Personel bilgilerine hızlı şekilde ulaşılabilir.
* Personel bilgileri güncellenebilir.
* Gereksiz veya hatalı kayıtlar silinebilir.
* Personel arama işlemleri kolaylaştırılabilir.
* Kullanıcı rollerine göre farklı ekranlar sunulabilir.

---

## 🔮 Geliştirilebilecek Özellikler

Projenin ilerleyen sürümlerinde aşağıdaki özellikler eklenebilir:

* 📊 Dashboard ve istatistik ekranı
* 🔐 Daha gelişmiş kullanıcı yetkilendirme
* 🔑 JWT tabanlı kimlik doğrulama
* 🔒 Şifrelerin güvenli şekilde hash'lenmesi
* 📸 Personel profil fotoğrafı
* 📄 PDF/Excel personel raporu
* 🔎 Gelişmiş filtreleme
* 📅 İzin ve vardiya takibi
* 📧 E-posta bildirimleri
* 🌙 Dark Mode
* 📱 Daha gelişmiş mobil responsive tasarım

---

## 👩‍💻 Geliştirici

**Rojin Orhan**

GitHub:
https://github.com/rojinorhan

Proje:
https://github.com/rojinorhan/personel_takip

---

## 📄 Lisans

Bu proje eğitim ve geliştirme amacıyla hazırlanmıştır.
