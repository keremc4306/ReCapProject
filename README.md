# ReCapProject - Kodlama.io
# 7.gün: 
- Entities, DataAccess, Business ve ConsoleUI katmanlarını oluşturdum.
- "Car" adında nesne tanımladım. Sonra Id, BrandId, ColorId, ModelYear, DailyPrice, Description alanlarını ekledim.
- InMemory formatta GetById, GetAll, Add, Update, Delete operasyonlarını yazdım ve consoleda test ettim.

# 8. gün
# Ödev 1
- "Car" nesnesine ek olarak "Brand" ve "Color" nesnelerini ekledim. "Brand" ve "Color" nesnelerine Id ve Name alanlarını ekledim.
- SQL Server alanında "CarRental" adında veritabanı oluşturdum ve içine Cars, Brands, Colors tablolarını oluşturdum.
- Sisteme Generic IEntityRepository altyapısını yazdım.
- Car, Brand ve Color nesneleri için Entity Framework altyapısını yazdım. Sonra GetCarsByBrandId, GetCarsByColorId servislerini yazıp programı Entity Framework'e bağladım.
