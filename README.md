# ReCapProject - Kodlama.io (Back end)
# 7.gün: 
- Entities, DataAccess, Business ve ConsoleUI katmanlarını oluşturdum.
- "Car" adında nesne tanımladım. Sonra Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekledim.
- InMemory formatta GetById, GetAll, Add, Update, Delete operasyonlarını yazdım ve consoleda test ettim.

# 8. gün
- "Car" nesnesine ek olarak "Brand" ve "Color" nesnelerini ekledim. "Brand" ve "Color" nesnelerine Id ve Name alanlarını ekledim.
- SQL Server alanında "CarRental" adında veritabanı oluşturdum ve içine Cars, Brands, Colors tablolarını oluşturdum.
- Sisteme Generic IEntityRepository altyapısını yazdım.
- Car, Brand ve Color nesneleri için Entity Framework altyapısını yazdım. Sonra GetCarsByBrandId, GetCarsByColorId servislerini yazıp programı Entity Framework'e bağladım.

# 9. gün
- CarRental Projesinde Core katmanını oluşturdum.
- IEntity, IDto, IEntityRepository, EfEntityRepositoryBase dosyalarını ekledim.
- Car, Brand, Color sınıflarınız için tüm CRUD operasyonlarını yazdım.
- Car, Brand, Model nesneleri için GetAll, GetById, Insert, Update, Delete metotlarını test ettim.

# 10. gün
- Core katmanında Results yapılandırması yaptım.
- 'Users' adında Kullanıcılar tablosu oluşturdum. Id, FirstName, LastName, Email, Password sütunlarını oluşturdum.
- 'Customers' adında Müşteriler tablosu oluşturdum. UserId, CompanyName sütunlarını oluşturdum.
*****Kullanıcılar ve Müşteriler tablolarını ilişkilendirdim.
- Arabanın kiralanma bilgisini tutan veritabanı tablosunu oluşturdum.

# 11. gün
- WebAPI katmanını oluşturdum.
- Business katmanındaki tüm servislerin Api karşılığını yazdım ve Postman'de test ettim.

**Ek olarak backend tarafında Autofac desteği, FluentValidation desteği, AOP desteği ekledim. JWT entegrasyonu uyguladım.
**Cache, Transaction ve Performance aspectlerini ekledim.
