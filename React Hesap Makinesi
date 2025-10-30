import { useState } from "react";

function AritmetikUygulamasi() {
  const [ilkSayi, setIlkSayi] = useState("");
  const [islem, setIslem] = useState("");
  const [ikinciSayi, setIkinciSayi] = useState("");
  const [sonuc, setSonuc] = useState("");

  // Sayı seçimi
  const sayiSec = (sayi) => {
    if (islem === "") {
      setIlkSayi(ilkSayi + sayi);
    } else {
      setIkinciSayi(ikinciSayi + sayi);
    }
  };

  // İşlem seçimi
  const islemSec = (seciliIslem) => {
    if (ilkSayi !== "") {
      setIslem(seciliIslem);
    }
  };

  // Hesapla
  const hesapla = () => {
    const a = Number(ilkSayi);
    const b = Number(ikinciSayi);
    let sonucDegeri = "";

    if (islem === "+") sonucDegeri = a + b;
    else if (islem === "-") sonucDegeri = a - b;
    else if (islem === "×") sonucDegeri = a * b;
    else if (islem === "÷") {
      sonucDegeri = b !== 0 ? (a / b).toFixed(3) : "Tanımsız";
    }

    setSonuc(sonucDegeri);
  };

  // Sıfırla
  const sifirla = () => {
    setIlkSayi("");
    setIslem("");
    setIkinciSayi("");
    setSonuc("");
  };

  // Buton stili
  const butonStil = {
    width: "60px",
    height: "40px",
    margin: "5px",
    fontSize: "16px",
    borderRadius: "5px",
    cursor: "pointer",
  };

  return (
    <div
      style={{
        textAlign: "center",
        marginTop: "50px",
        backgroundColor: "#f4f4f4",
        borderRadius: "10px",
        width: "260px",
        marginLeft: "auto",
        marginRight: "auto",
        padding: "20px",
        boxShadow: "0 0 10px #ccc",
      }}
    >
      <h2>🧮 Aritmetik İşlem Uygulaması</h2>

      <div
        style={{
          backgroundColor: "white",
          padding: "10px",
          margin: "10px",
          borderRadius: "5px",
          border: "1px solid #ddd",
        }}
      >
        <strong>
          {ilkSayi} {islem} {ikinciSayi}
        </strong>
      </div>

      {/* Sayı Butonları numpad düzeninde */}
      <div style={{ display: "inline-block" }}>
        <div>
          <button style={butonStil} onClick={() => sayiSec(7)}>7</button>
          <button style={butonStil} onClick={() => sayiSec(8)}>8</button>
          <button style={butonStil} onClick={() => sayiSec(9)}>9</button>
        </div>
        <div>
          <button style={butonStil} onClick={() => sayiSec(4)}>4</button>
          <button style={butonStil} onClick={() => sayiSec(5)}>5</button>
          <button style={butonStil} onClick={() => sayiSec(6)}>6</button>
        </div>
        <div>
          <button style={butonStil} onClick={() => sayiSec(1)}>1</button>
          <button style={butonStil} onClick={() => sayiSec(2)}>2</button>
          <button style={butonStil} onClick={() => sayiSec(3)}>3</button>
        </div>
        <div>
          <button style={butonStil} onClick={() => sayiSec(0)}>0</button>
        </div>
      </div>

      {/* İşlem Butonları */}
      <div style={{ marginTop: "10px" }}>
        <button
          onClick={() => islemSec("+")}
          style={{ ...butonStil, backgroundColor: "#3498db", color: "white" }}
        >
          +
        </button>
        <button
          onClick={() => islemSec("-")}
          style={{ ...butonStil, backgroundColor: "#3498db", color: "white" }}
        >
          -
        </button>
        <button
          onClick={() => islemSec("×")}
          style={{ ...butonStil, backgroundColor: "#3498db", color: "white" }}
        >
          ×
        </button>
        <button
          onClick={() => islemSec("÷")}
          style={{ ...butonStil, backgroundColor: "#3498db", color: "white" }}
        >
          ÷
        </button>
      </div>

      {/* Hesapla ve Sıfırla */}
      <div style={{ marginTop: "15px" }}>
        <button
          onClick={hesapla}
          style={{
            backgroundColor: "#2ecc71",
            color: "white",
            padding: "10px 20px",
            border: "none",
            borderRadius: "5px",
            marginRight: "10px",
            cursor: "pointer",
          }}
        >
          Hesapla
        </button>

        <button
          onClick={sifirla}
          style={{
            backgroundColor: "#e74c3c",
            color: "white",
            padding: "10px 20px",
            border: "none",
            borderRadius: "5px",
            cursor: "pointer",
          }}
        >
          Sıfırla
        </button>
      </div>

      {/* Sonuç kutusu */}
      <input
        type="text"
        readOnly
        value={sonuc}
        placeholder="Sonuç burada..."
        style={{
          marginTop: "15px",
          width: "80%",
          padding: "8px",
          fontSize: "16px",
          textAlign: "center",
          borderRadius: "5px",
          border: "1px solid #aaa",
          outline: "none",
          backgroundColor: "#e8e8e8",
        }}
      />
    </div>
  );
}

export default AritmetikUygulamasi;
