function TeskilatSemasi() {
  // Kart stili - Tekrar kullanmak için
  const kartStili = {
    padding: '15px',
    margin: '5px',
    borderRadius: '5px',
    textAlign: 'center',
    fontSize: '14px',
    fontWeight: 'bold'
  };

  // Farklı renkler için stil objeleri
  const maviAcik = {
    ...kartStili,
    backgroundColor: '#B8E6E6',
    color: '#000'
  };

  const sari = {
    ...kartStili,
    backgroundColor: '#F9E79F',
    color: '#000'
  };

  const mor = {
    ...kartStili,
    backgroundColor: '#D7BDE2',
    color: '#000'
  };

  const yesil = {
    ...kartStili,
    backgroundColor: '#7FD8D8',
    color: '#000'
  };

  const pembe = {
    ...kartStili,
    backgroundColor: '#F5B7B1',
    color: '#000'
  };

  return (
    <>
      {/* NAV - Menü Çubuğu */}
      <nav style={{
        backgroundColor: '#C62828',
        padding: '15px 20px',
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center'
      }}>
        <a href="#" style={{
          color: 'white',
          textDecoration: 'none',
          margin: '0 15px',
          fontSize: '16px'
        }}>
          🏠 Ana Sayfa
        </a>
        <a href="#" style={{
          color: 'white',
          textDecoration: 'none',
          margin: '0 15px',
          fontSize: '16px'
        }}>
          Oluşturulmuş
        </a>
        <a href="#" style={{
          color: 'white',
          textDecoration: 'none',
          margin: '0 15px',
          fontSize: '16px'
        }}>
          Alanlarınız
        </a>
        <a href="#" style={{
          color: 'white',
          textDecoration: 'none',
          margin: '0 15px',
          fontSize: '16px'
        }}>
          Etkinliklerimiz
        </a>
        <a href="#" style={{
          color: 'white',
          textDecoration: 'none',
          margin: '0 15px',
          fontSize: '16px'
        }}>
          Projelerimiz
        </a>
        <a href="#" style={{
          color: 'white',
          textDecoration: 'none',
          margin: '0 15px',
          fontSize: '16px'
        }}>
          İletişim
        </a>
        <a href="#" style={{
          color: 'white',
          textDecoration: 'none',
          margin: '0 15px',
          fontSize: '16px'
        }}>
          Okul Aile Birliği
        </a>
        <a href="#" style={{
          color: 'white',
          textDecoration: 'none',
          margin: '0 15px',
          fontSize: '16px'
        }}>
          Yemekane Bilg.
        </a>
      </nav>

      {/* MAIN - Ana İçerik (Ortalanmış) */}
      <main style={{
        maxWidth: '1200px',
        margin: '0 auto',
        padding: '40px 20px',
        backgroundColor: '#f0f0f0'
      }}>
        {/* Başlık */}
        <h1 style={{
          textAlign: 'center',
          color: '#333',
          marginBottom: '30px',
          fontSize: '32px'
        }}>
          Teşkilat Şeması
        </h1>

        {/* Başkan - En üst */}
        <div style={{marginBottom: '10px'}}>
          <div style={maviAcik}>
            <div>LEVENT KANDEMİR</div>
            <div style={{fontSize: '12px', fontWeight: 'normal'}}>
              OKUL MÜDÜRÜ
            </div>
          </div>
        </div>

        {/* Müdür Yardımcısı */}
        <div style={{marginBottom: '10px'}}>
          <div style={sari}>
            <div>B. GÜLŞIN MUTLU</div>
            <div style={{fontSize: '12px', fontWeight: 'normal'}}>
              MÜDÜR BAŞYARDIMCISI
            </div>
          </div>
        </div>

        {/* 3'lü satır - Mor */}
        <div style={{
          display: 'flex',
          marginBottom: '10px'
        }}>
          <div style={{...mor, flex: 1}}>
            <div>SÜLEYMAN DALCI</div>
            <div style={{fontSize: '12px', fontWeight: 'normal'}}>
              MÜDÜR YARDIMCISI
            </div>
          </div>
          <div style={{...mor, flex: 1}}>
            <div>EMRULLAH ARSLANTAŞ</div>
            <div style={{fontSize: '12px', fontWeight: 'normal'}}>
              MÜDÜR YARDIMCISI
            </div>
          </div>
          <div style={{...mor, flex: 1}}>
            <div>ESTUĞRUL YAŞARPULAT</div>
            <div style={{fontSize: '12px', fontWeight: 'normal'}}>
              MÜDÜR YARDIMCISI
            </div>
          </div>
        </div>

        {/* 3'lü satır - Mor 2 */}
        <div style={{
          display: 'flex',
          marginBottom: '10px'
        }}>
          <div style={{...mor, flex: 1}}>
            <div>HAYDAR DOĞAN</div>
            <div style={{fontSize: '12px', fontWeight: 'normal'}}>
              MÜDÜR YARDIMCISI
            </div>
          </div>
          <div style={{...mor, flex: 1}}>
            <div>HİLAL AL SAEDİ</div>
            <div style={{fontSize: '12px', fontWeight: 'normal'}}>
              MÜDÜR YARDIMCISI
            </div>
          </div>
          <div style={{...mor, flex: 1}}>
            <div>AHMET ŞENOL</div>
            <div style={{fontSize: '12px', fontWeight: 'normal'}}>
              MÜDÜR YARDIMCISI
            </div>
          </div>
        </div>

        {/* 3'lü satır - Açık Mavi */}
        <div style={{
          display: 'flex',
          marginBottom: '10px'
        }}>
          <div style={{...maviAcik, flex: 1}}>
            <div>İSA ATALA</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Muhasebe ve İş Müdürü Tasvirosu Alan Şefi
            </div>
          </div>
          <div style={{...maviAcik, flex: 1}}>
            <div>BÜLENT TOPALOĞLU</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Elektronik-Elektronik Alan Şefi
            </div>
          </div>
          <div style={{...maviAcik, flex: 1}}>
            <div style={{fontSize: '13px'}}>**</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Tasarım Teknolojileri ve İçtihatlarına Alan Şefi
            </div>
          </div>
        </div>

        {/* 3'lü satır - Açık Mavi 2 */}
        <div style={{
          display: 'flex',
          marginBottom: '10px'
        }}>
          <div style={{...maviAcik, flex: 1}}>
            <div>GÜNDAL KOPAN</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Bilişim Teknolojileri Alan Şefi
            </div>
          </div>
          <div style={{...maviAcik, flex: 1}}>
            <div>ADEM ÇETİN</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Motorlu Araçlar Teknolojisi Alan Şefi
            </div>
          </div>
          <div style={{...maviAcik, flex: 1}}>
            <div>DAVUT ÜNEŞİ</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Metal Teknolojisi Alan Şefi
            </div>
          </div>
        </div>

        {/* 3'lü satır - Açık Mavi 3 */}
        <div style={{
          display: 'flex',
          marginBottom: '10px'
        }}>
          <div style={{...maviAcik, flex: 1}}>
            <div>OKTAY BOZKURT</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Rehber Öğretmeni
            </div>
          </div>
          <div style={{...maviAcik, flex: 1}}>
            <div>BEDİYE VECİT AKBAŞ</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Rehber Öğretmeni
            </div>
          </div>
          <div style={{...maviAcik, flex: 1}}>
            <div>SEMA TEKÇE</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Rehber Öğretmeni
            </div>
          </div>
        </div>

        {/* 3'lü satır - Yeşil */}
        <div style={{
          display: 'flex',
          marginBottom: '10px'
        }}>
          <div style={{...yesil, flex: 1}}>
            <div>HASAN KARATEKE</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Beden Eğitimi Öğretmeni
            </div>
          </div>
          <div style={{...yesil, flex: 1}}>
            <div>ALTAY ŞEN</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Beden Eğitimi Öğretmeni
            </div>
          </div>
          <div style={{...yesil, flex: 1}}>
            <div>UĞRAŞ YETKİN</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Beden Eğitimi Öğretmeni
            </div>
          </div>
        </div>

        {/* Tek kişi - Yeşil */}
        <div style={{
          display: 'flex',
          marginBottom: '10px'
        }}>
          <div style={{...yesil, flex: 1, maxWidth: '33%'}}>
            <div>TÜLAY AYDEMİR</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Müzik Öğretmeni
            </div>
          </div>
        </div>

        {/* 3'lü satır - Pembe */}
        <div style={{
          display: 'flex',
          marginBottom: '10px'
        }}>
          <div style={{...pembe, flex: 1}}>
            <div>SEBİN DENİZ</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Resim-İş Öğretmeni
            </div>
          </div>
          <div style={{...pembe, flex: 1}}>
            <div>ERCAN MERT</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Boyahçı Öğretmeni
            </div>
          </div>
          <div style={{...pembe, flex: 1}}>
            <div>AYŞE ULUŞ</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Plak Öğretmeni
            </div>
          </div>
        </div>

        {/* Tek kişi - Pembe */}
        <div style={{
          display: 'flex',
          marginBottom: '10px'
        }}>
          <div style={{...pembe, flex: 1, maxWidth: '33%'}}>
            <div>ŞEVVAL YERLİ</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Finki Öğretmeni
            </div>
          </div>
        </div>

        {/* 2'li satır - Sarı */}
        <div style={{
          display: 'flex',
          marginBottom: '10px'
        }}>
          <div style={{...sari, flex: 1}}>
            <div>ERDAL YERLİ</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Coğrafya Öğretmeni
            </div>
          </div>
          <div style={{...sari, flex: 1}}>
            <div>MEHMET YAKUPOĞLU</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Coğrafya Öğretmeni
            </div>
          </div>
        </div>

        {/* 3'lü satır - Mor Son */}
        <div style={{
          display: 'flex',
          marginBottom: '10px'
        }}>
          <div style={{...mor, flex: 1}}>
            <div>ÖZLEM BEŞER</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Tarih Öğretmeni
            </div>
          </div>
          <div style={{...mor, flex: 1}}>
            <div>KADRİ EFE</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Tarih Öğretmeni
            </div>
          </div>
          <div style={{...mor, flex: 1}}>
            <div>DEMET KOCAKOÇ</div>
            <div style={{fontSize: '11px', fontWeight: 'normal'}}>
              Tarih Öğretmeni
            </div>
          </div>
        </div>
      </main>
    </>
  );
}

export default TeskilatSemasi;
