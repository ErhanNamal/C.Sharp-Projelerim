App.js için
export default function TeskilatSemasi() {
  // Artık inline stil objelerine ihtiyacımız yok

  return (
    <>
      {/* NAV - Menü Çubuğu */}
      <nav className="nav-cubugu">
        <a href="#">
          🏠 Ana Sayfa
        </a>
        <a href="#">
          Okulumuz
        </a>
        <a href="#">
          Alanlarınız
        </a>
        <a href="#">
          Etkinliklerimiz
        </a>
        <a href="#">
          Projelerimiz
        </a>
        <a href="#">
          İletişim
        </a>
        <a href="#">
          Okul Aile Birliği
        </a>
        <a href="#">
          Yemekane Bilg.
        </a>
      </nav>

      {/* MAIN - Ana İçerik (Ortalanmış) */}
      <main className="main-icerik">
        {/* Başlık */}
        <h1 className="ana-baslik">
          Teşkilat Şeması
        </h1>

        {/* Başkan - En üst - TEK KART */}
        <div className="satir-stili">
          <div className="kart-stili mavi-acik tek-kart">
            <div>LEVENT KANDEMİR</div>
            <div className="kart-unvan">
              OKUL MÜDÜRÜ
            </div>
          </div>
        </div>

        {/* Müdür Başyardımcısı - TEK KART */}
        <div className="satir-stili">
          <div className="kart-stili sari yuzde50Kart">
            <div>B. GÜLŞIN MUTLU</div>
            <div className="kart-unvan">
              MÜDÜR BAŞYARDIMCISI
            </div>
          </div>
        </div>

        {/* 3'lü satır - Mor - Müdür Yardımcıları İLK 3 */}
        <div className="satir-stili">
          <div className="kart-stili mor">
            <div>SÜLEYMAN DALCI</div>
            <div className="kart-unvan">
              MÜDÜR YARDIMCISI
            </div>
          </div>
          <div className="kart-stili mor">
            <div>EMRULLAH ARSLANTAŞ</div>
            <div className="kart-unvan">
              MÜDÜR YARDIMCISI
            </div>
          </div>
          <div className="kart-stili mor">
            <div>ESTUĞRUL YAŞARPULAT</div>
            <div className="kart-unvan">
              MÜDÜR YARDIMCISI
            </div>
          </div>
        </div>

        {/* 3'lü satır - Mor - Müdür Yardımcıları SON 3 */}
        <div className="satir-stili">
          <div className="kart-stili mor">
            <div>HAYDAR DOĞAN</div>
            <div className="kart-unvan">
              MÜDÜR YARDIMCISI
            </div>
          </div>
          <div className="kart-stili mor">
            <div>HİLAL AL SAEDİ</div>
            <div className="kart-unvan">
              MÜDÜR YARDIMCISI
            </div>
          </div>
          <div className="kart-stili mor">
            <div>AHMET ŞENOL</div>
            <div className="kart-unvan">
              MÜDÜR YARDIMCISI
            </div>
          </div>
        </div>

        {/* 3'lü satır - Açık Mavi - Alan Şefleri İLK 3 */}
        <div className="satir-stili">
          <div className="kart-stili mavi-acik">
            <div>İSA ATALA</div>
            <div className="kart-unvan alan-sefi-unvan">
              Mobilya ve İç Mekan Tasarım Alan Şefi
            </div>
          </div>
          <div className="kart-stili mavi-acik">
            <div>BÜLENT TOPALOĞLU</div>
            <div className="kart-unvan alan-sefi-unvan">
              Elektronik-Elektronik Alan Şefi
            </div>
          </div>
          <div className="kart-stili mavi-acik">
            <div style={{fontSize: '13px'}}>**</div> {/* Bu özel inline stili korudum */}
            <div className="kart-unvan alan-sefi-unvan">
              Tesisat Teknolojisi ve İklimlendirme Alan Şefi
            </div>
          </div>
        </div>

        {/* 3'lü satır - Açık Mavi - Alan Şefleri SON 3 */}
        <div className="satir-stili">
          <div className="kart-stili mavi-acik">
            <div>GÜRDAL KOPAN</div>
            <div className="kart-unvan alan-sefi-unvan">
              Bilişim Teknolojileri Alan Şefi
            </div>
          </div>
          <div className="kart-stili mavi-acik">
            <div>ADEM ÇETİN</div>
            <div className="kart-unvan alan-sefi-unvan">
              Motorlu Araçlar Teknolojisi Alan Şefi
            </div>
          </div>
          <div className="kart-stili mavi-acik">
            <div>DAVUT ÜNEŞİ</div>
            <div className="kart-unvan alan-sefi-unvan">
              Metal Teknolojisi Alan Şefi
            </div>
          </div>
        </div>

        {/* 3'lü satır - Açık Mavi - Rehber Öğretmenler */}
        <div className="satir-stili">
          <div className="kart-stili mavi-acik">
            <div>OKTAY BOZKURT</div>
            <div className="kart-unvan alan-sefi-unvan">
              Rehber Öğretmeni
            </div>
          </div>
          <div className="kart-stili mavi-acik">
            <div>BEHİYE YİĞİT AKBAŞ</div>
            <div className="kart-unvan alan-sefi-unvan">
              Rehber Öğretmeni
            </div>
          </div>
          <div className="kart-stili mavi-acik">
            <div>SEMA TEKÇE</div>
            <div className="kart-unvan alan-sefi-unvan">
              Rehber Öğretmeni
            </div>
          </div>
        </div>

        {/* 3'lü satır - Yeşil - Beden Eğitimi 3 */}
        <div className="satir-stili">
          <div className="kart-stili yesil">
            <div>HASAN KARATEKE</div>
            <div className="kart-unvan alan-sefi-unvan">
              Beden Eğitimi Öğretmeni
            </div>
          </div>
          <div className="kart-stili yesil">
            <div>ALTAY ŞEN</div>
            <div className="kart-unvan alan-sefi-unvan">
              Beden Eğitimi Öğretmeni
            </div>
          </div>
          <div className="kart-stili yesil">
            <div>UĞRAŞ YETKİN</div>
            <div className="kart-unvan alan-sefi-unvan">
              Beden Eğitimi Öğretmeni
            </div>
          </div>
        </div>

        {/* Tek kişi - Yeşil - Müzik */}
        <div className="satir-stili">
          <div className="kart-stili yesil tek-kart">
            <div>TÜLAY AYDEMİR</div>
            <div className="kart-unvan alan-sefi-unvan">
              Müzik Öğretmeni
            </div>
          </div>
        </div>

        {/* 3'lü satır - Pembe */}
        <div className="satir-stili">
          <div className="kart-stili pembe">
            <div>SEBİN DENİZ</div>
            <div className="kart-unvan alan-sefi-unvan">
              Resim-İş Öğretmeni
            </div>
          </div>
          <div className="kart-stili pembe">
            <div>ERCAN MERT</div>
            <div className="kart-unvan alan-sefi-unvan">
              Boyahçı Öğretmeni
            </div>
          </div>
          <div className="kart-stili pembe">
            <div>AYŞE ULUŞ</div>
            <div className="kart-unvan alan-sefi-unvan">
              Plak Öğretmeni
            </div>
          </div>
        </div>

        {/* Tek kişi - Pembe */}
        <div className="satir-stili">
          <div className="kart-stili pembe tek-kart">
            <div>ŞEVVAL YERLİ</div>
            <div className="kart-unvan alan-sefi-unvan">
              Finki Öğretmeni
            </div>
          </div>
        </div>

        {/* 2'li satır - Sarı - 2 kişi */}
        {/* Not: iki-kart-satir sınıfını bu div'e ekleyerek 2 kartlık düzeni sağladık. */}
        <div className="satir-stili iki-kart-satir">
          <div className="kart-stili sari">
            <div>ERDAL YERLİ</div>
            <div className="kart-unvan alan-sefi-unvan">
              Coğrafya Öğretmeni
            </div>
          </div>
          <div className="kart-stili sari">
            <div>MEHMET YAKUPOĞLU</div>
            <div className="kart-unvan alan-sefi-unvan">
              Coğrafya Öğretmeni
            </div>
          </div>
          {/* Üçüncü kart boş kalacak, bu yüzden bir div daha eklemedik. */}
        </div>

        {/* 3'lü satır - Mor - Tarih */}
        <div className="satir-stili">
          <div className="kart-stili mor">
            <div>ÖZLEM BEŞER</div>
            <div className="kart-unvan alan-sefi-unvan">
              Tarih Öğretmeni
            </div>
          </div>
          <div className="kart-stili mor">
            <div>KADRİ EFE</div>
            <div className="kart-unvan alan-sefi-unvan">
              Tarih Öğretmeni
            </div>
          </div>
          <div className="kart-stili mor">
            <div>DEMET KOCAKOÇ</div>
            <div className="kart-unvan alan-sefi-unvan">
              Tarih Öğretmeni
            </div>
          </div>
          <div className="kart-stili mor">
            <div>CAHİT ÇELİK</div>
            <div className="kart-unvan alan-sefi-unvan">
              Tarih Öğretmeni
            </div>
          </div>
        </div>
      </main>
    </>
  );
}





App.css için 
body {
  background-color: #e0e0e0;
  margin: 0;
  padding: 0;
  font-family: Arial, sans-serif;
}

.nav-cubugu {
  background-color: #C62828;
  padding: 15px 20px;
  text-align: center;
}

.nav-cubugu a {
  color: white;
  text-decoration: none;
  margin: 0 15px;
  font-size: 16px;
  transition: color 0.3s;
}

.nav-cubugu a:hover {
  color: #ffccbc;
}

.main-icerik {
  width: 1200px;
  margin: 0 auto;
  padding: 40px 20px;
  background-color: #f0f0f0;
  box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
}

.ana-baslik {
  text-align: center;
  color: #333;
  margin-bottom: 30px;
  font-size: 32px;
}

.satir-stili {
  margin-bottom: 10px;
  text-align: center;
  font-size: 0;
}

.kart-stili {
  padding: 15px;
  margin: 5px;
  border-radius: 5px;
  text-align: center;
  font-size: 14px;
  font-weight: bold;
  width: calc(33.333% - 10px);
  display: inline-block;
  vertical-align: top;
  box-sizing: border-box;
}

.kart-unvan {
  font-size: 12px;
  font-weight: normal;
  margin-top: 3px;
}

.mavi-acik {
  background-color: #B8E6E6;
  color: #000;
}

.sari {
  background-color: #F9E79F;
  color: #000;
}

.mor {
  background-color: #D7BDE2;
  color: #000;
}

.yesil {
  background-color: #7FD8D8;
  color: #000;
}

.pembe {
  background-color: #F5B7B1;
  color: #000;
}

.tek-kart {
  width: calc(100% - 10px);
}

.yuzde50Kart {
  width: calc(70% - 10px);
}

.iki-kart-satir .kart-stili {
  width: calc(50% - 10px);
}

.kart-unvan.alan-sefi-unvan {
  font-size: 11px;
}
