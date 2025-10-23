# Unit3D_RoboBot_PowerOrb

# 🪐 Unity Oyun Programlama Uygulama Sınavı

![RoboBot](ReadMeImages/robo_bot.svg)
![PowerOrb1](ReadMeImages/power_orb.svg)
![PowerOrb2](ReadMeImages/power_orb.svg)
![PowerOrb3](ReadMeImages/power_orb.svg)

---

## 🎮 HİKÂYE

> Uzak bir gezegende, enerjiyle dolu **3 güç küresi (Power Orbs)** havada süzülüyor.  
> Dünya’daki enerji krizini çözmek için bu kürelerin yere indirilip toplanması gerekiyor.  
> Sen, uzay robotunu (**RoboBot**) kontrol eden geliştiricisin.

🧠 **Görevin:**
- Sahneyi kur  
- Yerçekimini kontrol ederek küreleri düşür  
- Robotu hareket ettirerek kürelere ulaş  
- Her şeyi oyun gibi sun  

Zaman daralıyor... **Küreleri düşür, gücü kurtar! ⚡**

---

## 🧩 GÖREV ADIMLARI

### 1. SAHNEYİ OLUŞTUR (10 Puan)
- `Plane` ekle → Adı: **Floor**
- `Sphere` ekle → Prefab oluşturmak için kullanılacak
- `Capsule` ekle → Adı: **RoboBot**
- Küreleri yerden yükseğe yerleştir (havada süzülüyor gibi)

---

### 2. PREFAB (10 Puan)
- Sphere’i Prefab yap  
- Prefab’tan **3 PowerOrb** oluştur:
  - `PowerOrb1`, `PowerOrb2`, `PowerOrb3`
- İlgili script prefab’a atanmış olmalı

---

### 3. MATERIAL – GÖRSEL FARKLILIK (10 Puan)
- Her **PowerOrb** farklı renkte olmalı (mavi, yeşil, kırmızı)
- **RoboBot** için metal/taş/kumaş benzeri bir texture
- Zemine basit bir material (taş, kum vb.)

---

### 4. TRANSFORM DÜZENLEMELERİ (5 Puan)
- **RoboBot** yere temas edecek şekilde yerleştir
- **Küreler** farklı X/Y/Z konumlarında, yüksekte olmalı
- Kürelerin boyutu ×1.5 (Prefab içinde uygula)
- Plane boyutu ×8

---

### 5. PHYSICS & COLLIDER (10 Puan)
- Tüm objelere uygun `Collider` ekle
- `Sphere` objelerinde `Rigidbody` eklenecek, **useGravity = false**
- `RoboBot`’ta `Rigidbody` olacak, **useGravity = true**

---

### 6. YERÇEKİMİ KONTROLÜ (25 Puan)
**Amaç:** “G” tuşuna basıldığında Power Orbs’un yerçekimi aktif/pasif hale gelmeli.

📄 `OrbKontrol.cs`
```csharp
using UnityEngine;

public class OrbKontrol : MonoBehaviour
{
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            rb.useGravity = !rb.useGravity;
        }
    }
}
```

Prefab’a bu script’i eklemeyi unutma!

---

### 7. ROBOBOT HAREKETİ (10 Puan)
RoboBot, yön tuşları veya **W, A, S, D** ile hareket etmeli.

📄 `RoboKontrol.cs`
```csharp
using UnityEngine;

public class RoboKontrol : MonoBehaviour
{
    public float hareketHizi = 5f;

    void Update()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 hareket = new Vector3(yatay, 0, dikey) * hareketHizi * Time.deltaTime;
        transform.Translate(hareket, Space.World);
    }
}
```

---

### 8. GÜÇ KÜRELERİNİ TOPLAMA (15 Puan)
- Her küreye Tag ekle:
  - `MaviKure`, `YesilKure`, `KirmiziKure`
- Collider → **Is Trigger = true**
- Çarpışma olduğunda Console’a yazdır ve küreyi yok et.

📄 `KureToplayici.cs`
```csharp
using UnityEngine;

public class KureToplayici : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Toplanan Küre: " + other.tag);
        Destroy(other.gameObject);
    }
}
```

---

### 9. ÜCRETSİZ 3D MODEL EKLEME (10 Puan)
- İnternetten ücretsiz bir model indir (örnek: ağaç, enerji paneli, çanak)
- Sahnede dekoratif olarak kullan
- Oyunun atmosferine katkı sağlamalı 🌌

---

## 💾 DOSYA YAPISI ÖNERİSİ
```
Assets/
├── Scripts/
│   ├── OrbKontrol.cs
│   ├── RoboKontrol.cs
│   └── KureToplayici.cs
├── Prefabs/
│   ├── PowerOrb.prefab
│   └── RoboBot.prefab
├── Materials/
│   ├── Mavi.mat
│   ├── Yesil.mat
│   └── Kirmizi.mat
└── Models/
    └── Dekor.obj
```

---

## 🧠 PUAN DAĞILIMI
| Görev | Puan |
|:--|--:|
| Sahne Kurulumu | 10 |
| Prefab | 10 |
| Material | 10 |
| Transform | 5 |
| Physics & Collider | 10 |
| Yerçekimi Kontrolü | 25 |
| RoboBot Hareketi | 10 |
| Küre Toplama | 15 |
| 3D Model Ekleme | 10 |
| **Toplam** | **100** |

---

📘 **Unity Oyun Programlama Sınavı Senaryosu**
🛠️ **Konu:** Fizik, Input, Prefab, Collider, Script ve Tag kullanımı  
💡 **Amaç:** Temel oyun mekaniği oluşturma ve kontrol sistemi geliştirme
