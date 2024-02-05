# TCMB Döviz Verileri Web API

Bu proje, .NET Framework kullanılarak Türkiye Cumhuriyet Merkez Bankası (TCMB) döviz verilerini listeleyen bir Web API'yi içermektedir. Ayrıca, Swagger UI kullanılarak API dokümantasyonu sağlanmıştır.

## Proje Detayları

- **Teknolojiler:** .NET Framework, C#
- **API Dokümantasyonu:** Swagger UI

## Nasıl Başlatılır

1. Proje dosyalarını bilgisayarınıza indirin.
2. Visual Studio veya tercih ettiğiniz bir IDE ile projeyi açın.
3. Projeyi derleyin ve çalıştırın.
4. Tarayıcıda `http://localhost:{port}/swagger` adresine giderek Swagger UI'yi görüntüleyin.

## API Endpoints

Aşağıda, projenin sağladığı temel API endpoint'lerinden bazıları bulunmaktadır:

- `GET /api/dovizler`: Tüm döviz verilerini listeler.
- `GET /api/dovizler/{dovizKodu}`: Belirli bir dövizin bilgilerini getirir.

Detaylı API dokümantasyonu için [Swagger UI](http://localhost:{port}/swagger) adresini ziyaret edebilirsiniz.



## Lisans

Bu proje [MIT lisansı](LICENSE) altında lisanslanmıştır. Detaylı bilgi için lisans dosyasını kontrol edebilirsiniz.
