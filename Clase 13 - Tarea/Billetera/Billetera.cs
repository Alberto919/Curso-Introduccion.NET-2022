namespace Billeteras
{
    public class Billetera
    {
        public int BilleteDe10 { get; set; }
        public int BilleteDe20 { get; set; }
        public int BilleteDe50 { get; set; }
        public int BilleteDe100 { get; set; }
        public int BilleteDe200 { get; set; }
        public int BilleteDe500 { get; set; }
        public int BilleteDe1000 { get; set; }

        public void VaciarBilletera()
        {
            BilleteDe10 = 0;
            BilleteDe20 = 0;
            BilleteDe50 = 0;
            BilleteDe100 = 0;
            BilleteDe200 = 0;
            BilleteDe500 = 0;
            BilleteDe1000 = 0;
        }
        public decimal Total()
        {
            return BilleteDe10 * 10 + BilleteDe20 * 20 + BilleteDe50 * 50 + BilleteDe100 * 100 + BilleteDe200 * 200 + BilleteDe500 * 500 + BilleteDe1000 * 1000;
        }

        public Billetera Combinar(Billetera billetera)
        {
            var billeteraNueva = new Billetera()
            {
                BilleteDe10 = BilleteDe10 + billetera.BilleteDe10,
                BilleteDe20 = BilleteDe20 + billetera.BilleteDe20,
                BilleteDe50 = BilleteDe50 + billetera.BilleteDe50,
                BilleteDe100 = BilleteDe100 + billetera.BilleteDe100,
                BilleteDe200 = BilleteDe200 + billetera.BilleteDe200,
                BilleteDe500 = BilleteDe500 + billetera.BilleteDe500,
                BilleteDe1000 = BilleteDe1000 + billetera.BilleteDe1000
            };
            return billeteraNueva;
        }

        public void MostrarBilletera()
        {
            Console.WriteLine("BilleteDe10: " + BilleteDe10);
            Console.WriteLine("BilleteDe20: " + BilleteDe20);
            Console.WriteLine("BilleteDe50: " + BilleteDe50);
            Console.WriteLine("BilleteDe100: " + BilleteDe100);
            Console.WriteLine("BilleteDe200: " + BilleteDe200);
            Console.WriteLine("BilleteDe500: " + BilleteDe500);
            Console.WriteLine("BilleteDe1000: " + BilleteDe1000);
        }
    }
}