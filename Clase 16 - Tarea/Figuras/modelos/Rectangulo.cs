namespace Figuras.modelos
{
    public class Rectangulo : Cuadrilatero
    {
        public Rectangulo(Coordenada[] coordenadas) : base(coordenadas)
        {
        }

        public override double area()
        {
            double lado_AB = Math.Sqrt(Math.Pow((vertice_B.x - vertice_A.x),2) + Math.Pow((vertice_B.y - vertice_A.y),2));
            double lado_BC= Math.Sqrt(Math.Pow((vertice_C.x - vertice_B.x),2) + Math.Pow((vertice_C.y - vertice_B.y),2));
            return Math.Abs(lado_AB * lado_BC);
        }
    }
}