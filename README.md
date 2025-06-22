Muhtarlık Tebligat Sistemi
Proje Hakkında

Muhtarlıklar için evrak takibi, kişi ve firma yönetimi sağlayan Windows Forms tabanlı bir uygulama.
SQLite veritabanı kullanır.
MVP (Model-View-Presenter) mimarisi ile tasarlanmıştır.
CRUD işlemleri, arama, güncelleme ve silme özellikleri eksiksiz.
Öne Çıkan Özellikler

    MVP Mimarisi: Katmanlı yapı ile temiz kod ve kolay bakım.

    SQLite: Hafif, kolay taşınabilir ve dosya tabanlı veritabanı.

    Esnek Veri Yönetimi: Kişi, Firma, Evrak türleri ve Sokak yönetimi.

    Gelişmiş Veri Girişi: ComboBox ve BindingList kullanımı ile kullanıcı dostu arayüz.

    Hata Yakalama: Veri doğrulama ve hatalar için kapsamlı try-catch blokları.

    Singleton View: Tek form örneği ile yönetim kolaylığı.

Mimari & Katmanlar

    Model: Veri nesneleri (DocumentModel, PersonModel, CompanyModel, vb.)

    View: Formlar ve arayüz, IDocumentView gibi arayüzler ile soyutlanmış.

    Presenter: İş mantığı ve View ile Model arasındaki iletişimi sağlar.

    Repository: SQLite sorguları ve veri erişimi.

Kurulum

    Gereksinimler:

        .NET Framework (veya .NET 5/6+ uyumluluğu)

        SQLite kütüphaneleri
        Benim kullandığım tüm paketler 
        {
            bcrypt.net-next\4.0.3\
            microsoft.data.sqlclient\6.0.1\
            system.data.sqlite.core\1.0.119\
            system.configuration.configurationmanager\9.0.2\
            system.componentmodel.annotations\5.0.0\
        }

        Visual Studio Community (WinForms için)

    Projeyi Klonla:

    git clone https://github.com/kullaniciadi/muhtarlik-tebligat.git
    cd muhtarlik-tebligat

    Bağımlılıkları Yükle:

        NuGet üzerinden SQLite ve gerekli paketleri restore edin.

    Veritabanı:

        Proje dizininde database.sqlite dosyasını oluşturun veya var olan veritabanını kullanın.

        Gerekli tablolar ve view’lar sql/init.sql dosyasından oluşturulabilir.

    Projeyi Aç ve Çalıştır:

        Visual Studio’da projeyi açıp Start tuşuna basın.

Kullanım

    Ana ekranda kayıtlı evraklar listelenir.

    Yeni evrak eklemek için Yeni Doküman butonunu kullanın.

    Kişi veya firma seçimi ve ilgili alanlar dinamik olarak güncellenir.

    Arama kutusuyla kayıtlar filtrelenebilir.

    Güncelleme, silme işlemleri için kayıt seçip ilgili butonları kullanın.

    Tarih alanları opsiyoneldir, tarih seçimi checkbox ile kontrol edilir.

Sorun Giderme & İpuçları

    Casting hatası: Veri tabanı ve model alanlarının tam eşleştiğinden emin olun. Null kontrollerini ihmal etmeyin.

    ComboBox görünmeme sorunu: Visible property ve data binding kontrol edilmeli.

    UpdateDate checkbox sorunu: Form açılırken checkbox varsayılan değerini doğru ayarlayın.

    Veritabanı bağlantı sorunları: Connection string doğru ve erişilebilir olmalı.

Katkıda Bulunmak İster misiniz?

    Forklayın

    Yeni branch açın (git checkout -b feature/ozellik)

    Commit yapın (git commit -m 'Yeni özellik ekledim')

    Pushlayın (git push origin feature/ozellik)

    Pull Request açın

Lisans

sanırım olacak... sanırım
