namespace _04032025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int deger = Topla(3, 5);
            //MessageBox.Show("Toplam : " + deger);

            Ogrenci erdi = new Ogrenci();
            erdi.numara = 100;
            erdi.ad = "Erdi";
            erdi.soyad = "YALÇIN";

            Ogrenci ali = new Ogrenci();
            ali.numara = 101;
            ali.ad = "Ali";
            ali.soyad = "AL";

            MessageBox.Show(erdi.Yaz());
            MessageBox.Show(ali.Yaz());
        }

        public int Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
    }
}
