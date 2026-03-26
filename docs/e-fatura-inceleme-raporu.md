# E-Fatura Uygulaması Ön İnceleme Raporu

## Durum Özeti
Bu repoda **"e-fatura" ile ilişkili bir uygulama/modül bulunamadı**. Mevcut çözüm (`ProgrammingWorkshop.sln`) temel algoritma örneklerinden oluşuyor.

## Kanıtlar
- Çözüm altında yer alan proje klasörleri: `algorithms-*`, `two-number-plus`, `agorithms-fibonacci` gibi eğitim amaçlı örnekler.
- Kod tabanında `e-fatura`, `efatura`, `fatura` anahtar kelimeleriyle yapılan aramada eşleşme yok.
- Kökteki `README.md` yalnızca "workshop / Algorithms" içeriği veriyor.

## Bu nedenle şu anki eksik
1. E-fatura için iş alanına ait bir proje/modül yok.
2. E-fatura alan modeli (Invoice, Customer, Tax, LineItem vb.) yok.
3. Entegrasyon katmanları (GİB/e-belge servis adaptörü, XML/UBL-TR üretimi, imzalama) yok.
4. Süreç akışları (taslak, onay, gönderim, iptal/itiraz, hata yönetimi) yok.
5. Gözlemlenebilirlik ve operasyonel kontroller (log, retry, idempotency, audit trail) yok.

## Eklenmesi Gereken Yapı (Önerilen)

### 1) Katmanlı mimari
- `src/EFatura.Domain`: iş kuralları ve domain modelleri
- `src/EFatura.Application`: use-case/service katmanı
- `src/EFatura.Infrastructure`: dış servisler, veri erişimi, kuyruk
- `src/EFatura.Api`: REST API veya entegrasyon endpointleri
- `tests/*`: birim + entegrasyon testleri

### 2) Asgari domain modeli
- `Invoice`
- `InvoiceLine`
- `Customer` (gönderici/alıcı)
- `TaxSummary` (KDV, stopaj, tevkifat senaryoları)
- `EArchive/EInvoice` tip ayrımı

### 3) Kritik teknik gereksinimler
- UBL-TR uyumlu çıktı üretimi
- Mali mühür/e-imza desteği
- Durum makinesi: `Draft -> Approved -> Sent -> Delivered/Rejected`
- Idempotent gönderim (aynı faturanın tekrar gönderimini engelleme)
- Hata senaryolarında retry + dead-letter yaklaşımı

### 4) Operasyonel kalite gereksinimleri
- Audit log (kim, ne zaman, hangi fatura)
- Korelasyon ID ile izlenebilirlik
- Sağlık kontrolleri (external provider health check)
- Konfigürasyon ayrımı (dev/test/prod)

## Sonuç
İstenen "e-fatura uygulaması" bu repoda mevcut değil; dolayısıyla şu aşamada çıkarılabilecek en net bulgu, önce e-fatura için ayrı bir bounded-context/proje yapısının kurulması gerektiği. Bu temel atılmadan işlevsel eksik analizi uygulama seviyesinde yapılamaz.
