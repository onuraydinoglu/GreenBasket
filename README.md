# GreenBasket E-Ticaret Projesi

## Proje Özeti
GreenBasket, bir e-ticaret web uygulaması olarak tasarlanmış ve **ASP.NET Core MVC** mimarisi kullanılarak geliştirilmiştir. Bu proje, kullanıcıların ürünleri görüntüleyebileceği, alışveriş yapabileceği ve yönetici paneli üzerinden ürün ve kategori yönetimi gerçekleştirebileceği kapsamlı bir e-ticaret platformudur.

## Kullanılan Teknolojiler
- **ASP.NET Core MVC**: Web uygulaması framework'ü
- **C#**: Programlama dili
- **Repository Pattern**: Veri erişim katmanı için kullanılan tasarım deseni
- **ViewComponents**: Tekrar kullanılabilir UI bileşenleri

## Proje Yapısı

### Controllers (Denetleyiciler):
- **AdminController**:
  - Yönetici paneli işlemleri
  - Kategori ve ürün yönetimi (CRUD işlemleri)
- **CategoriesController**:
  - Kategori listeleme
  - Ürün detayları görüntüleme
  - Kategori bazlı ürün filtreleme
- **HomeController**:
  - Ana sayfa görüntüleme
  - Kategoriler ve ürünlerin listelenmesi
- **MyCardController**:
  - Alışveriş sepeti işlemleri
- **UsersController**:
  - Kullanıcı işlemleri (kayıt, giriş, profil yönetimi)
  - Adres ve ödeme bilgileri yönetimi

### ViewComponents (Görünüm Bileşenleri):
- **DashboardHeader**: Yönetici paneli üst menü bileşeni
- **DashboardNav**: Yönetici paneli navigasyon bileşeni
- **ProductsList**: Ürün listesi bileşeni
- **UserNav**: Kullanıcı navigasyon bileşeni

### Routing (Yönlendirme):
- **Özel URL Yapılandırmaları**:
  - `/product/{url}`: Ürün detay sayfaları için
  - `/category/{url}`: Kategori listeleme sayfaları için
  - Varsayılan route: `{controller=Home}/{action=Index}/{id?}`

## Projenin Amacı

### E-Ticaret Platformu:
- Ürün ve kategori yönetimi
- Kullanıcı hesap yönetimi
- Alışveriş sepeti işlevselliği

### Yönetim Paneli:
- Ürün ve kategori CRUD işlemleri
- Sipariş takibi
- Kullanıcı yönetimi

### Kullanıcı Deneyimi:
- Kolay navigasyon
- Kategori bazlı ürün filtreleme
- Detaylı ürün görüntüleme
- Güvenli ödeme işlemleri

## Geliştirme Önerileri
- **Veritabanı Entegrasyonu**:
  - Şu anda Repository Pattern ile statik veri kullanılıyor.
  - **Entity Framework Core** ile gerçek veritabanı entegrasyonu yapılabilir.
- **Güvenlik**:
  - Authentication ve Authorization eklenebilir.
  - JWT veya Cookie tabanlı kimlik doğrulama implementasyonu yapılabilir.
- **API Desteği**:
  - RESTful API endpoints eklenebilir.
  - Mobil uygulama desteği sağlanabilir.
- **Ödeme Entegrasyonu**:
  - Payment gateway entegrasyonu yapılabilir.
  - Güvenli ödeme işlemleri sağlanabilir.

## Özet
GreenBasket, temel bir e-ticaret altyapısı sunmakta ve geliştirmeye açık bir yapıda tasarlanmıştır. Veri erişimi için **Repository Pattern**, tekrar kullanılabilir UI bileşenleri için **ViewComponents** kullanılmıştır. **CRUD** operasyonları ve routing işlemleri başarıyla uygulanmış olup, gelecekteki geliştirmeler için sağlam bir temel sunmaktadır.
