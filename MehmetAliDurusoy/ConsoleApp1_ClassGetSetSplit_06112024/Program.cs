/*
Sınav konuları
get,set
mehmet ali 12345678901 bunu ada,soyada ve tc e bölecek
*/

Bilgi kimlik  = new Bilgi("mehmet ali 12345678901");
Bilgi kimlik1 = new Bilgi("mehmet ali durusoy 12345678901");
Bilgi kimlik2 = new Bilgi("ahmet ibrahim efe sarısoy 12345678901");

Console.WriteLine($"{kimlik.adSoyad} | TC NO: {kimlik.tcno}");
Console.WriteLine("------------------------------------------");
Console.WriteLine($"{kimlik1.adSoyad} | TC NO: {kimlik1.tcno}");
Console.WriteLine("------------------------------------------");
Console.WriteLine($"{kimlik2.adSoyad} | TC NO: {kimlik2.tcno}");

class Bilgi
{
    public Bilgi() { }

    public Bilgi(string x, string y, string z)
    {
        _ad = x;
        _soyad = y;
        _tcno = z;
    }

    public Bilgi(string bilgi)
    {
        string[] _bilgi = bilgi.Split(' ');

        _ad = _bilgi[0];

        if (_bilgi.Length >= 4)
        {
            _ad += " " + _bilgi[1];

            for (int i = 1; i < _bilgi.Length - 2; i++)
            {
                Console.WriteLine($"{i} | {_bilgi.Length - 2} | {(_bilgi.Length - 2) + i} | {_bilgi.Length - 1}");
            }

            _soyad = _bilgi[_bilgi.Length - 2];
        } else { _soyad = _bilgi[1]; }

        _tcno = _bilgi[_bilgi.Length - 1];
    }

    private string _ad;
    private string _soyad;
    private string _tcno;

    public string tcno
    {
        get => _tcno;
        set
        {
            if (value.Length == 11)
            {
                _tcno = value;
            }
            else
            {
                _tcno = "00000000000";
                Console.WriteLine("girilen TC NO HATALI !!!!!");
            }
        }
    }

    public string ad
    {
        get { return _ad; }
        set { _ad = value.ToUpper(); }
    }

    public string soyad
    {
        get => _soyad;
        set => _soyad = value.ToUpper();
    }

    public string adSoyad
    {
        get => _ad + " " + _soyad;
    }
}
