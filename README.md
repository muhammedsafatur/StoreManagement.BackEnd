# StoreManagement.BackEnd

Bu proje, bir mağaza yönetim sisteminin arka uç (backend) uygulamasıdır. .NET 6 platformunda C# programlama dili kullanılarak geliştirilmiştir. ASP.NET Core Web API kullanmaktadır ve SQL Server veritabanı ile çalışmaktadır. Entity Framework Core ORM kullanılmıştır.

## İçindekiler

- [Açıklama](#açıklama)
- [Teknolojiler](#teknolojiler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [Katkıda Bulunma](#katkıda-bulunma)
- [Lisans](#lisans)
- [İletişim](#iletişim)

## Açıklama

Bu proje, mağaza envanterini yönetmek, satışları takip etmek, müşteri bilgilerini saklamak ve diğer mağaza yönetimi işlevlerini otomatikleştirmek için tasarlanmıştır. Temel amacı, mağaza operasyonlarını daha verimli ve düzenli hale getirmektir.

## Teknolojiler

Bu proje aşağıdaki teknolojiler kullanılarak geliştirilmiştir:

- .NET 8
- C#
- Entity Framework Core
- SQL Server
- ASP.NET Core Web API
- Swashbuckle.AspNetCore (Swagger için)

## Kurulum

Projeyi çalıştırmak için aşağıdaki adımları izleyin:

1. Bu depoyu yerel makinenize klonlayın:

    ```bash
    git clone https://github.com/muhammedsafatur/StoreManagement.BackEnd.git
    ```

2. Proje dizinine gidin:

    ```bash
    cd StoreManagement.BackEnd
    ```

3. .NET 8 SDK'sının yüklü olduğundan emin olun. Yüklü değilse, [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download) adresinden indirebilirsiniz.

4. Gerekli bağımlılıkları yükleyin:

    ```bash
    dotnet restore
    ```

5. `appsettings.json` dosyasını açın ve `ConnectionStrings` bölümündeki veritabanı bağlantı dizesini kendi SQL Server örneğinize göre yapılandırın:

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=StoreManagementDb;User Id=YOUR_USER_ID;Password=YOUR_PASSWORD;Trusted_Connection=False;MultipleActiveResultSets=true"
      }
    }
    ```

    `YOUR_SERVER_NAME`, `YOUR_USER_ID` ve `YOUR_PASSWORD` değerlerini kendi bilgilerinizle değiştirin.

6. Veritabanı migrasyonlarını uygulayın:

    ```bash
    dotnet ef database update
    ```

7.Projeyi başlatın:

    ```bash
    dotnet run
    ```

## Kullanım

Proje başlatıldıktan sonra, API'ye `http://localhost:5000` (veya HTTPS için `https://localhost:5001`) adresinden erişilebilir. API dokümantasyonuna `http://localhost:5000/swagger` adresinden erişebilirsiniz.

### Örnek API Uç Noktaları:

- `GET /api/products`: Tüm ürünleri listeler.
- `POST /api/products`: Yeni bir ürün ekler. (Buraya daha fazla uç nokta ve açıklamalarını ekleyin.)

## Katkıda Bulunma

Projeye katkıda bulunmak isterseniz, lütfen aşağıdaki adımları izleyin:

1. Projeyi fork edin.
2. Kendi branch'inizi oluşturun (`git checkout -b feature/yeni-ozellik`).
3. Değişikliklerinizi commit edin (`git commit -m 'Yeni özellik eklendi'`).
4. Branch'inizi push edin (`git push origin feature/yeni-ozellik`).
5. Bir pull request açın.

## Lisans

MIT Lisansı

## İletişim

muhammedsafatur@outlook.com
