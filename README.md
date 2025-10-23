# Unit3D_RoboBot_PowerOrb
Oyun Programlama Sınavı Öncesi Uygulama Sınavı Senaryosu
HİKÂYE:
	Uzak bir gezegende, enerjiyle dolu 3 güç küresi (Power Orbs) havada süzülüyor.
	Dünya’daki enerji krizini çözmek için bu kürelerin yere indirilip toplanması gerekiyor.
	Sen, uzay robotunu (RoboBot) kontrol eden geliştiricisin. 
Görevin:
	Sahneyi kur
	Yerçekimini kontrol ederek küreleri düşür
	Robotu hareket ettirerek kürelere ulaş
	Her şeyi oyun gibi sun
Zaman daralıyor. Küreleri düşür, gücü kurtar!!!
UYULMASI GEREKEN GÖREV ADIMLARI: 
1. SAHNEYİ OLUŞTUR (10 Puan) 
o	Bir Plane ekle. Adı: "Floor" olsun.
o	1 adet Sphere (Küre) ekle. Prefab adımında bunu prefab yapmak için kullan.
o	1 adet Capsule ekle. Adı: "RoboBot" olsun (Oyuncu karakteri).
o	Küreleri yerden yükseğe yerleştir (havada duruyormuş gibi).
2. PREFAB (10 Puan) 
o	Eklediğiniz Sphere’i (Küre) Prefab yapın.
o	Bu prefab’tan 2 PowerOrb’u oluşturun ve sahneye ekleyin.
o	Güç kürelerinin adları: "PowerOrb1", "PowerOrb2", "PowerOrb3" olsun.
o	İlgili script prefab atanmış şekilde olsun.
3. MATERIAL - GÖRSEL FARKLILIK (10 Puan)
o	Her PowerOrb’a farklı renklerde Material uygulayın (mavi, yeşil, kırmızı).
o	RoboBot’a bir Texture uygulayın (metal, taş, kumaş gibi). 
o	Zemine basit bir Material verin (taş, kum vs.)
4. TRANSFORM DÜZENLEMELERİ (5 Puan)
o	RoboBot yere temas edecek şekilde yerleştirilmiş olacak.
o	Küreler farklı X/Y/Z pozisyonlarında, yukarıda olmalı.
o	Kürelerin boyutu 1.5 kat daha büyük yap. (Prefab içinde uygula)
o	Plane boyutu 8 kat daha büyük yap.
3. PHYSICS & COLLIDER (10 Puan)
o	Tüm Sphere ve Capsule objelerine uygun Collider ekleyin.
o	Sphere’lere Rigidbody ekleyin. Ama gravity pasif (useGravity = false) olacak şekilde başlasın.
o	Capsule’a da Rigidbody eklensin ama gravity açık kalsın. 
5.YERÇEKİMİ KONTROLÜ (25 Puan)
Klavye üzerindeki “G” tuşuna basıldığında Güç Kürelerinin (Power Orbs) yerçekimi etkisi açılıp kapanmalıdır.
o	“G” tuşuna basıldığında useGravity özelliğini aktif/pasif hale getir.
o	Kodunu OrbKontrol.cs dosyasına yaz ve PowerOrb prefab’ına ekle.
Script 1: OrbKontrol.cs
using UnityEngine;
public class OrbKontrol : MonoBehaviour
{
    …………………………………

    void Awake()
    {
        …………………………………..
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            ………………………………………………………            
        }
    }
}
6. ROBOBOT HAREKETİ (10 Puan) 
RoboBot karakterinin sahnede yön tuşlarıyla (↑ ↓ ← →) veya W, A, S, D tuşlarıyla hareket etmesini sağlayan bir kontrol sistemi oluştur. RoboBot, Güç Küreleri’ne doğru ilerleyebilmeli ve sağa-sola serbestçe hareket edebilmelidir.
o	Unity’de RoboBot karakterine bir Rigidbody veya Transform tabanlı hareket ekle.
o	Input.GetAxis("Horizontal") ve Input.GetAxis("Vertical") komutlarını kullanarak klavye girişlerini al.
o	Bu girdilerle karakterin pozisyonunu güncelle.
o	Hareket hızını ayarlamak için hareketHizi isminde bir değişken tanımla.
o	Kodunu RoboKontrol.cs dosyasına yaz ve RoboBot nesnesine ekle.
Script 2: RoboKontrol.cs
using UnityEngine;

public class RoboKontrol : MonoBehaviour
{
    ………………………………………..

    void Update()
    {
        ………………………….
    }
}
8. GÜÇ KÜRELERİNİ TOPLAMA (15 Puan)
RoboBot sahnede bulunan kırmızı, yeşil ve mavi güç kürelerini toplamalıdır. Bir küre alındığında: Küre yok olmalı, hangi kürenin toplandığı Console’a yazdırılmalıdır.
o	Her küreye Tag ekle (MaviKure, YesilKure, KirmiziKure).
o	Kürelerin Collider bileşenlerinde Is Trigger = true olarak ayarla.
o	Kürelere çarpınca hangi kürenin toplandığını Console yaz. Küreyi yok et. 
o	Kodunu KureToplayici.cs dosyasına yaz ve RoboBot nesnesine ekle.

Script 2: KureToplayici.cs
using UnityEngine;

public class KureToplayici : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ………………………………………………
    }
}

9. ÜCRETSİZ 3D MODEL EKLEME (10 Puan) 
o	İnternetten ücretsiz bir 3D model indirin (örneğin: kutu, ağaç, çanak, enerji paneli).
o	Sahnede dekoratif olarak kullanın.
o	Oyunun atmosferine katkı sağlamalı. 
