namespace Figuras.modelos
{
    public class Trapecio : Cuadrilatero
    {
        public Trapecio(Coordenada[] coordenadas) : base(coordenadas)
        {
        }
        public override double area()
        {
            /* formula del area de Gauss
               para calcular el area usando 
               coordenadas

               area = 1/2*(sumaB - sumaA)
            */
            double sumaA = (vertice_A.x*vertice_B.y)+(vertice_B.x*vertice_C.y)+(vertice_C.x*vertice_D.y)+(vertice_D.x*vertice_A.y);
            double sumaB = (vertice_A.x*vertice_D.y)+(vertice_D.x*vertice_C.y)+(vertice_C.x*vertice_B.y)+(vertice_B.x*vertice_A.y);
            return Math.Abs((sumaB - sumaA) / 2);
        }
        public override bool isValid(){
            return true;
        }
    }
}