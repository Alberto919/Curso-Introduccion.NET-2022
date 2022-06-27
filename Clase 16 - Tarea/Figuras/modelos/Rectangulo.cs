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

        public override bool isValid()
        { 
            double lado_AB = Math.Sqrt(Math.Pow((vertice_B.x - vertice_A.x), 2) + Math.Pow((vertice_B.y - vertice_A.y), 2));
            double lado_BC = Math.Sqrt(Math.Pow((vertice_C.x - vertice_B.x), 2) + Math.Pow((vertice_C.y - vertice_B.y), 2));
            double lado_CD = Math.Sqrt(Math.Pow((vertice_D.x - vertice_C.x), 2) + Math.Pow((vertice_D.y - vertice_C.y), 2));
            double lado_DA = Math.Sqrt(Math.Pow((vertice_A.x - vertice_D.x), 2) + Math.Pow((vertice_A.y - vertice_D.y), 2));
            return (lado_AB == lado_CD && lado_BC == lado_DA);
        }
    }
}