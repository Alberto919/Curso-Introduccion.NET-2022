namespace Figuras.modelos
{
    public abstract class Cuadrilatero
    {
        public static readonly int NUMERO_VERTICES = 4;
        private Coordenada[] _coordenadas;

        public Coordenada vertice_A
        {
            get { return _coordenadas[0]; }
        }

        public Coordenada vertice_B
        {
            get { return _coordenadas[1]; }
        }

        public Coordenada vertice_C
        {
            get { return _coordenadas[2]; }
        }

        public Coordenada vertice_D
        {
            get { return _coordenadas[3]; }
        }
        public Cuadrilatero(Coordenada[] coordenadas)
        {
            _coordenadas = coordenadas;
        }

        public abstract double area();

        public abstract bool isValid();

    }
}