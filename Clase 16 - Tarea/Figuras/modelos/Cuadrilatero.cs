namespace Figuras.modelos
{
    public abstract class Cuadrilatero
    {
        private Coordenada[] _coordenadas = new Coordenada[4];

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

    }
}