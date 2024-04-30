namespace MarketKasaApp
{
    public partial class Form1 : Form
    {
        decimal toplam = 0;

        List<Sepet> sepetim = new List<Sepet>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SepetToplami();
        }

        private void btnCocoCola_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet("Coca Cola", 1, 17);

            sepetim.Add(sepet);
            SepetiGoster();

        }

        void SepetiGoster()
        {
            dG1.DataSource = "";
            dG1.DataSource = sepetim;
            SepetToplami();
        }

        void SepetToplami()
        {
            toplam = 0;
            foreach (var item in sepetim)
            {
                toplam += item.Toplam;
            }
            lbToplam.Text = string.Format("{0:C2}", toplam);
        }
        private void btnFanta_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet();
            sepet.UrunAdi = "Fanta";
            sepet.Adet = 1;
            sepet.BirimFiyati = 18;
            sepet.Toplam = sepet.Adet * sepet.BirimFiyati;
            sepetim.Add(sepet);

            SepetiGoster();

        }

        private void btnDondurma_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet("Dondurma", 1, 20);

            sepetim.Add(sepet);
            SepetiGoster();
        }

        private void btnDomates_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet("Domates", 1, 17);

            sepetim.Add(sepet);
            SepetiGoster();
        }

        private void btnBiber_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet("Biber", 1, 17);

            sepetim.Add(sepet);
            SepetiGoster();
        }

        private void btnPatlican_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet("Patlican", 1, 17);

            sepetim.Add(sepet);
            SepetiGoster();
        }

        private void btnBuskivi_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet("Büskivi", 1, 25);

            sepetim.Add(sepet);
            SepetiGoster();
        }

        private void btnCikilota_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet("Çikilota", 1, 10);

            sepetim.Add(sepet);
            SepetiGoster();
        }

        private void btnCay_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet("Çay", 1, 50);

            sepetim.Add(sepet);
            SepetiGoster();

        }

        private void btnSeker_Click(object sender, EventArgs e)
        {
            Sepet sepet = new Sepet("Þeker", 1, 25);

            sepetim.Add(sepet);
            SepetiGoster();

        }
    }
}
