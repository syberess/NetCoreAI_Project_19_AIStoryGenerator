# 📖 NetCoreAI Project 19 - AI Story Generator

Bu proje, **.NET Console Application** ile **OpenAI Chat Completions API** kullanarak kullanıcıdan aldığı girdilere göre özgün hikayeler üretir.  
Kullanıcı, hikayenin türünü, ana karakterini, mekanını ve uzunluğunu belirler. Uygulama, giriş-gelişme-sonuç yapısına sahip bir hikaye döndürür.  

---

## 🛠️ Kullanılan Teknolojiler
- .NET 8 / 9 Console Application  
- OpenAI API (Chat Completions - `gpt-3.5-turbo`)  
- HttpClient (API isteği için)  
- System.Text.Json (JSON serialize/deserialize)  

---

## 📂 Proje Yapısı
- `Program.cs` → Kullanıcı girdilerini alır, prompt oluşturur ve OpenAI API’ye gönderir. Dönen hikayeyi konsola yazdırır.  
- `.csproj` → Proje yapılandırma dosyası  

---

## ⚙️ Kurulum ve Çalıştırma
1. Repo’yu klonla:
   git clone https://github.com/kullaniciadiniz/NetCoreAI_Project_19_AIStoryGenerator.git
   cd NetCoreAI_Project_19_AIStoryGenerator
Program.cs içine kendi OpenAI API anahtarını ekle:
private static readonly string apiKey = "YOUR_API_KEY";
Konsol uygulamasını çalıştır:
dotnet run
Konsolda örnek kullanım:
Hikaye Türünü seçiniz(Macera,Korku, Bilim Kurgu, Fantastik, Komedi): Macera
Ana karakteriniz kim: Elif
Hikaye nerede geçiyor: İstanbul
Hikayenin uzunluğu (kısa/orta/uzun): orta

----- AI Tarafında Oluşturulan Hikaye -----
Bir zamanlar İstanbul’un kalabalık sokaklarında Elif adında genç bir kız yaşıyordu...
✨ Özellikler
✔️ Kullanıcıdan hikaye türü, karakter, mekan ve uzunluk alır

✔️ OpenAI API ile özgün hikaye üretir

✔️ Giriş, gelişme, sonuç yapısına sahip hikayeler oluşturur

✔️ Çeşitli türleri (Macera, Korku, Bilim Kurgu, Fantastik, Komedi) destekler

﻿
