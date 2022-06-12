namespace JuegoCartas.clases
{
    public class Carta
    {
        public int Numero { get; set; }
        public string Palo { get; set; }

        public Carta(int numero, string palo)
        {
            Numero = numero;
            Palo = palo;
        }        
    }
}