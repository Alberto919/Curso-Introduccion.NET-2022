namespace JuegoCartas.clases
{
    public class Baraja
    {
        public List<Carta> Cartas { get; set; }
        public List<Carta> Monton { get; set; }
        private string[] palos = { "Basto", "Copas", "Espadas", "Oros" };
        private const int TOTAL_CARTAS = 40;
        private int[] ValorCartas = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };

        public Baraja()
        {
            Cartas = new List<Carta>();
            Monton = new List<Carta>();
            for (int numero = 0; numero < ValorCartas.Length; numero++)
            {
                for (int palo = 0; palo < palos.Length; palo++)
                {
                    Cartas.Add(new Carta(ValorCartas[numero], palos[palo]));
                }
            }
        }
        public void Barajar()
        {
            var random = new Random();
            for (int posicion = Cartas.Count - 1; posicion > 0; posicion--)
            {
                var posicionAleatoria = random.Next(posicion + 1);
                var carta = Cartas[posicionAleatoria];
                Cartas[posicionAleatoria] = Cartas[posicion];
                Cartas[posicion] = carta;
            }
        }
        public Carta? SiguienteCarta()
        {
            if (Cartas.Count > 0)
            {                
                var carta = Cartas[0];
                Monton.Add(carta);
                Cartas.RemoveAt(0);
                return carta;
            }
            return null;
        }
        public int CartasDisponibles()
        {
            return Cartas.Count;
        }
        public void DarCartas(int cantidad)
        {
            if (cantidad > Cartas.Count)
            {
                Console.WriteLine("No hay suficientes cartas");
            }
            else
            {
                for (int i = 0; i < cantidad; i++)
                {
                    SiguienteCarta();
                }
            }
        }
        public void CartasMonton()
        {
            var contador = 0;
            foreach (Carta carta in Monton)
            {
                contador++;
                Console.WriteLine(carta.Numero + " de " + carta.Palo);
            }
            if (contador == 0)
            {
                Console.WriteLine("No se saco ninguna carta");
            }
        }
        public void MostrarBaraja()
        {
            var contador = 0;
            foreach (Carta carta in Cartas)
            {
                contador++;
                Console.WriteLine(carta.Numero + " de " + carta.Palo);
            }
            if (contador == 0)
            {
                Console.WriteLine("Se sacarón todas las cartas");
            }
        }
    }
}