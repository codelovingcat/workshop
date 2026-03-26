# Atölye Depo İncelemesi (Mart 2026)

## 1) Mevcut yapının özeti
- Çözüm, birden çok küçük WinForms örneğini tek `ProgrammingWorkshop.sln` altında topluyor.
- Kod tabanı eğitim/demo amaçlı ve proje isimlerinde/klasörlerde yazım tutarsızlıkları var (`agorithms-*`, `algorihms-*`).
- Depoda kaynak koda ek olarak çok sayıda derleme çıktısı (`bin/`, `obj/`) versiyonlanmış durumda.

## 2) Tespit edilen başlıca problemler

### A. Repo hijyeni ve bakım maliyeti
- Derleme çıktıları repoda: `obj` altında 118, `bin` altında 36 dosya var (ölçüm komutu: `rg --files | rg '/obj/' | wc -l`, `rg --files | rg '/bin/' | wc -l`).
- Kök dizinde `.gitignore` yok; bu da aynı problemin devam etmesine neden olur.
- Etki: Gereksiz büyük depo, zor code review, merge çatışmaları.

### B. Hata yönetimi ve giriş doğrulama
- Birçok formda kullanıcı girişleri doğrudan `Convert.ToInt32`/`float.Parse` ile parse ediliyor.
- Geçersiz girişte uygulamalar `FormatException` ile kapanır.
- Etki: Kullanıcı deneyimi kötü, eğitim amaçlı bile olsa kırılgan davranış.

### C. Mantık hataları / doğruluk riskleri
- Asallık kontrolünde sonuç ataması döngü içinde yapılıyor (`algorihms-divisor/Divisor.cs`), bu yanlış/erken karar üretebilir.
- Fibonacci üretiminde state temizlenmeden devam ediyor; ikinci tıklamada seri kaldığı yerden ilerliyor (`agorithms-fibonacci/Fibonacci.cs`).
- Basamak sayısı ekranında sonuç metni sayının güncel (10'a bölünmüş) değerini yazıyor (`algorithms-how-many-digits/HowManys.cs`).
- Etki: Eğitimde yanlış algoritma örneği gösterme riski.

### D. Mimari ve test edilebilirlik
- Algoritmalar doğrudan Form event handler içinde; iş mantığı UI'dan ayrılmamış.
- Çözümde test projesi yok; regresyon kontrolü manuel.
- Etki: Ölçeklenebilirlik düşük, toplu refactor maliyeti yüksek.

## 3) “Düzeltilebilir mi, yeniden mi yazılmalı?”

## Kısa cevap
- **Tamamen yeniden yazma zorunlu değil.**
- **Aşamalı iyileştirme** ile kurtarılabilir.

## Karar
1. **Kısa vadede düzeltilebilir (önerilen):**
   - Repo temizliği (`.gitignore`, `bin/obj` takibinin bırakılması).
   - Tüm girişlerde `TryParse` + kullanıcıya anlaşılır hata mesajı.
   - Bilinen mantık hatalarının tek tek düzeltilmesi.
2. **Orta vadede kısmi yeniden yapılandırma:**
   - Her proje için `Algorithms` sınıfı/servisi oluşturup formdan ayırma.
   - Basit unit test projeleri ekleme.
3. **Tam yeniden yazım sadece şu durumda gerekli:**
   - Hedef, modern .NET (6/8) + MVVM/WPF/MAUI gibi yeni bir mimariye taşımaksa.

## 4) Önerilen uygulama planı

### Faz 1 (1 gün)
- `.gitignore` ekle.
- `bin/` ve `obj/` dosyalarını git takibinden çıkar.
- Klasör/proje isimlerini standardize etmeye yönelik isimlendirme planı çıkar.

### Faz 2 (1–2 gün)
- Tüm formlarda `TryParse` kullanımı.
- Negatif sayı, boş input, taşma (`int` limitleri) kontrolleri.
- Hata mesajlarını ortaklaştırma.

### Faz 3 (2–4 gün)
- Algoritma kodlarını UI'dan ayır.
- Her algoritma için 3–5 temel unit test.
- README'yi proje çalışma adımlarıyla güncelle.

## 5) Risk değerlendirmesi
- Bu haliyle üretim için uygun değil; eğitim demosu olarak çalışır ama hataya açık.
- İyileştirme maliyeti düşük/orta; tam yeniden yazım maliyeti yüksek.
- En iyi ROI: aşamalı refactor + test eklenmesi.
