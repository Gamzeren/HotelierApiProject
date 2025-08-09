# 💖🏨 Kurumsal Otel Rezervasyon RESTful API Projesi 🏨💖
## 🚀 Proje Hakkında
Bu proje, REST mimarisi prensiplerine tamamen uygun olarak geliştirilmiş, kurumsal standartlarda bir RESTful API uygulamasıdır.
Tüm backend işlemleri API üzerinden yönetilir ve frontend ile iletişim yalnızca API çağrıları aracılığıyla sağlanır.

Projede stateless (durumsuz) mimari esas alınmıştır, yani sunucu her isteği birbirinden bağımsız olarak işler ve önceki isteklerle ilgili hiçbir durumu saklamaz. ♻️
## ✨ Projenin Temel Özellikleri
### 1️⃣ REST Prensiplerine Uygunluk
HTTP metodları ile kaynaklar üzerinde CRUD işlemleri yapılır:

🔹**GET** 🔎 → Veri okuma <br>
🔹**POST** ✨ → Yeni veri ekleme <br>
🔹**PUT / PATCH** 🖊️ → Veri güncelleme <br>
🔹**DELETE** 🗑️ → Veri silme <br>

**URL yapısı kaynak odaklıdır.** Örneğin: /api/rooms/1234 → “rooms” oda kaynağını, “1234” ise ilgili odanın ID’sini temsil eder.
### 2️⃣ 6 Katmanlı Kurumsal Mimari
Projede katmanlı mimari kullanılarak kodun bakımı, yönetimi ve sürdürülebilirliği artırılmıştır:
| Katman               | Açıklama |
|----------------------|----------|
| **API Layer 🌐**     | REST API endpoint’lerinin tanımlandığı katman. |
| **Business Layer ⚙️**| İş kuralları ve validasyonların bulunduğu katman. |
| **Data Access Layer 💾** | Veritabanı CRUD operasyonlarının yapıldığı katman. |
| **Entity Layer 📦**  | Tüm entity modellerinin tanımlandığı katman. |
| **Presentation Layer 🖥️** | Kullanıcı arayüzünün bulunduğu katman. |

### 3️⃣ API Test & Dokümantasyon
- **Swagger** 📑 → Tüm CRUD operasyonları için interaktif API dokümantasyonu
- **Postman** 📬 → API çağrılarını test etme

### 4️⃣ Kimlik Doğrulama & Yetkilendirme
- **ASP.NET Identity** 🔐 ile kullanıcı hesap yönetimi  
- **Rol tabanlı yetkilendirme** 🎭

### 5️⃣ Entity Listesi
`About 📝`, `AppRole 🛡️`, `AppUser 👩‍💼`, `Booking 📅`, `Contact 📞`,  
`Guest 🧳`, `MessageCategory 🗂️`, `Room 🏠`, `SendMessage ✉️`,  
`Service 🛎️`, `Staff 👥`, `Subscribe 📧`, `Testimonial 💬`, `Worklocation 📍`

### 6️⃣-1️⃣6️⃣ Öne Çıkan Teknolojiler
- **AutoMapper** 🔄 → DTO ↔ Entity dönüşümleri
- **SOLID & Clean Code** 🧹
- **[Authorize] / [AllowAnonymous]** ile erişim kontrolü
- **Rapid API** ⚡ → Instagram, LinkedIn, Twitter takipçi verileri
- **Dosya İşlemleri** 📁 → Upload & Download
- **AJAX** 🔄 → Sayfa yenilemeden veri gönderme/alma
- **FluentValidation** ✔️
- **MailKit + SMTP** 📧 → Otomatik e-posta
- **Razor Pages + ViewComponent** 🧩
- **Repository Design Pattern**
- **Özel Entity Metotları** (Rezervasyon durumu, Dashboard istatistikleri)

## 🛠️ Admin Paneli Özellikleri
- Personel, referanslar, hizmetler, odalar, misafirler, roller vb. için CRUD
- Rezervasyon durumları otomatik **“Onay Bekliyor”** ⏳
- Güncelleme sonrası otomatik mail bildirimi 📩
- Mesaj yönetimi 💬
- Dosya yönetimi 📷📄

## 👩‍💼 Kullanıcı Paneli Özellikleri
- Otel bilgileri, odalar, hizmetler, yorumlar, ekip bilgisi
- Mail bülteni aboneliği 📧
- Rezervasyon 📅
- İletişim formu 📨
- Kayıt olma & giriş yapma 🔐

## 🔐 Ekstra Güvenlik
- **JWT** 🔏 ile API güvenliği
- **Rapid API** ile dinamik veri

## 🎉 Teşekkürler
Bu proje, **temiz, sürdürülebilir ve ölçeklenebilir** yapısıyla kurumsal standartlarda geliştirilmiştir. 💼💖

## 🖼️ Proje Görselleri

### 💝 UI 

<img width="1313" height="850" alt="Image" src="https://github.com/user-attachments/assets/c2e1cedf-00bd-4355-9ad7-a746451ebe07" />

<img width="1313" height="661" alt="Image" src="https://github.com/user-attachments/assets/c85c03e5-fa01-47e8-a72a-91f332978737" />

<img width="818" height="865" alt="Image" src="https://github.com/user-attachments/assets/942f9521-cce0-422c-a81d-36a9728fb78f" />

<img width="820" height="858" alt="Image" src="https://github.com/user-attachments/assets/4d8ac59d-9a0c-47c3-a25c-7ac66e3d2baa" />

<img width="1098" height="753" alt="Image" src="https://github.com/user-attachments/assets/e8aa4c03-e3db-49c2-a2a3-8392d56824c7" />

<img width="1098" height="551" alt="Image" src="https://github.com/user-attachments/assets/6296011c-545e-4d1b-9073-66e65c7864f1" />

### 📱 Admin Paneli

<img width="692" height="563" alt="Image" src="https://github.com/user-attachments/assets/3f3d1356-1bb2-457e-b785-efea2f775898" />

<img width="1873" height="913" alt="Image" src="https://github.com/user-attachments/assets/e3579d7a-0efe-453a-ab8a-c892d01959de" />

<img width="1498" height="257" alt="Image" src="https://github.com/user-attachments/assets/835aa494-d9ed-4ca8-a526-27301e4c81d3" />

<img width="1878" height="912" alt="Image" src="https://github.com/user-attachments/assets/df3658d7-6b74-44f0-ad37-ad2b5132c890" />

<img width="1873" height="643" alt="Image" src="https://github.com/user-attachments/assets/722adef3-87de-4e86-ab9e-c7bed19a5bed" />

<img width="1875" height="582" alt="Image" src="https://github.com/user-attachments/assets/f56ab5ba-8d0d-460b-8e42-f09cfd626a24" />

<img width="1883" height="592" alt="Image" src="https://github.com/user-attachments/assets/dc4fac95-8c17-49a0-9bcb-7638e28781b2" />

<img width="1881" height="873" alt="Image" src="https://github.com/user-attachments/assets/1714d691-9629-48f1-a4bb-2464a808e7b0" />

#### 📥 Mesajlar Gelen Kutusu
<img width="1880" height="913" alt="Image" src="https://github.com/user-attachments/assets/6f51a090-9c2f-422e-ab60-ed2f726b5eb8" />

#### 📤 Mesajlar Giden Kutusu
<img width="1877" height="691" alt="Image" src="https://github.com/user-attachments/assets/440bf9fa-54c8-4796-9281-f91f2d1fc46d" />

#### 💌 Mesajlar Yeni Mesaj Oluştur
<img width="1871" height="837" alt="Image" src="https://github.com/user-attachments/assets/fb990501-5e1a-4846-a7a2-8306b06b0b10" />

<img width="1873" height="638" alt="Image" src="https://github.com/user-attachments/assets/4d376a99-4e8f-4c1c-b3d5-8601ebe947e0" />

<img width="1881" height="792" alt="Image" src="https://github.com/user-attachments/assets/fb8ac315-b5d5-4204-b5f2-152a4a3cbe05" />

#### 🎁 Roller
<img width="1875" height="617" alt="Image" src="https://github.com/user-attachments/assets/20555952-086b-4433-98d0-309869969f44" />

#### 🎀 Rol Atamaları
<img width="297" height="395" alt="Image" src="https://github.com/user-attachments/assets/163c2aa7-cb7c-435b-bab1-45687326b152" />

<img width="1173" height="921" alt="Image" src="https://github.com/user-attachments/assets/90496689-80dc-4725-abb4-3d5ef625a742" />

<img width="557" height="890" alt="Image" src="https://github.com/user-attachments/assets/1c7c9ec7-1619-4e2f-87f1-f169478d2698" />

![Image](https://github.com/user-attachments/assets/c6e34717-a075-419d-91d8-367be0a0186c)

<img width="682" height="528" alt="Image" src="https://github.com/user-attachments/assets/f4b968a7-7299-4c0e-9ad6-14e1c9c53d1d" />
