# Speech-to-Text Desktop App

Bu proje, **C# Windows Forms** kullanılarak geliştirilmiş bir **gerçek zamanlı sesli konuşmayı metne çevirme** uygulamasıdır. Uygulama, [Vosk](https://alphacephei.com/vosk/) kütüphanesini kullanarak hem Türkçe hem İngilizce konuşmaları tanıyabilir.

---

## Özellikler

- Gerçek zamanlı ses tanıma (16 kHz mono)
- Türkçe ve İngilizce destek
- Sesli tanım sonuçlarını canlı olarak `TextBox` içinde gösterme
- Tanınan metni `.txt` dosyası olarak kaydetme
- Başlat/Durdur düğmeleri ile kolay kontrol
- Basit ve kullanıcı dostu arayüz

---

## Gereksinimler

- .NET Framework veya .NET Core (Windows Forms destekleyen bir sürüm)
- NAudio kütüphanesi
- Vosk kütüphanesi ve ilgili modeller:
  - Türkçe: `vosk-model-small-tr-0.3`
  - İngilizce: `vosk-model-small-en-us-0.15`

---

## Kurulum

1. Projeyi bilgisayarınıza klonlayın veya indirin:

```bash
git clone <repository-url>
```

2. Visual Studio’da projeyi açın.

3. NuGet Package Manager üzerinden gerekli paketleri yükleyin:

```bash
Install-Package NAudio
Install-Package Vosk
```
4. vosk-model-small-tr-0.3 ve vosk-model-small-en-us-0.15 modellerini indirip, proje dizinine kopyalayın.

5. Projeyi derleyin ve çalıştırın.

---

## Kullanım

1. Uygulamayı başlatın.

2. Dil seçimini yapın (Türkçe veya İngilizce).

3. Start düğmesine basarak dinlemeyi başlatın.

4. Konuşma sırasında metin TextBox’ta görünecektir.

5. İşiniz bittiğinde Stop düğmesine basın.

6. Save düğmesine basarak metni masaüstüne kaydedebilirsiniz.

---

## Dikkat Edilmesi Gerekenler

-Mikrofon cihazınızın doğru seçildiğinden emin olun (waveIn.DeviceNumber).

-Model dosyaları projede belirtilen dizinde olmalıdır, aksi takdirde uygulama hata verebilir.

-GPU desteği varsa, Vosk GPU ile daha hızlı çalışabilir.

---

## Lisans

Bu proje MIT Lisansı ile lisanslanmıştır. İstediğiniz gibi kullanabilir, değiştirebilir ve dağıtabilirsiniz.

---

## İletişim

Sorularınız veya önerileriniz için [e-posta veya Github profiliniz] üzerinden iletişime geçebilirsiniz.
