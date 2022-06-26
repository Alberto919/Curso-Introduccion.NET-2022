namespace Figuras.modelos
{
    public class Cuadrado : Cuadrilatero
    {
        public Cuadrado(Coordenada[] coordenadas) : base(coordenadas)
        {
        }

        public override double area()
        {
            double lado_AB = Math.Sqrt(Math.Pow((vertice_B.x - vertice_A.x), 2) + Math.Pow((vertice_B.y - vertice_A.y), 2));
            return lado_AB * lado_AB;
        }
    }
}