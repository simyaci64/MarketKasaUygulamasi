namespace MarketKasaApp
{
    public class Sepet
    {
        public Sepet()
        {

        }
        //ctor oluşturuyoruz.
        public Sepet(string urunAdi, int adet, decimal birimfiyati)
        {
            UrunAdi = urunAdi;
            Adet = adet;
            BirimFiyati = birimfiyati;
            Toplam = birimfiyati * adet;
        }
        //public int Id { get; set; }
        public string? UrunAdi { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyati { get; set; }
        public decimal Toplam { get; set; }
    }
}
