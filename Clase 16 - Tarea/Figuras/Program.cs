using Figuras.modelos;

Coordenada[] vertices = new Coordenada[Cuadrilatero.NUMERO_VERTICES];
Cuadrilatero figura;


void loadCoordenadas()
{
    Console.WriteLine();
    for (int vertice = 0; vertice < Cuadrilatero.NUMERO_VERTICES; vertice++)
    {
        var coordenada = new Coordenada();
        Console.Write($"Ingrese la coordenada x del vertice {vertice + 1}: ");
        coordenada.x = int.Parse(Console.ReadLine());
        Console.Write($"Ingrese la coordenada y del vertice {vertice + 1}: ");
        coordenada.y = int.Parse(Console.ReadLine());
        vertices[vertice] = coordenada;
    }
}

void mostrarCoordenadas(string figura)
{
    Console.Clear();
    Console.WriteLine();
    Console.WriteLine($"Coordenadas de los vertices del {figura}:");
     Console.WriteLine();
    for (int vertice = 0; vertice < Cuadrilatero.NUMERO_VERTICES; vertice++)
    {
        Console.WriteLine($"Vertice {vertice + 1}: ({vertices[vertice].x}, {vertices[vertice].y})");
    }
    Console.WriteLine();
}

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("        Calculo del Area");
    Console.WriteLine("---------------------------------");
    Console.WriteLine();
    Console.WriteLine("1. Trapecio");
    Console.WriteLine("2. Rectangulo");
    Console.WriteLine("3. Cuadrado");
    Console.WriteLine("4. Salir");
    Console.WriteLine();
    Console.Write("Ingresá una opción: ");
    var opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
            loadCoordenadas();
            figura = new Trapecio(vertices);
            mostrarCoordenadas("trapecio");
            Console.WriteLine($"El area del trapecio es: {figura.area()}");
            break;
        case 2:
            loadCoordenadas();
            figura = new Rectangulo(vertices);
            if(figura.isValid())
            {
                mostrarCoordenadas("rectangulo");
                Console.WriteLine($"El area del rectangulo es: {figura.area()}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Las coordenadas ingresadas no se corresponden a un rectangulo");
            }
            break;
        case 3:
            loadCoordenadas();
            figura = new Cuadrado(vertices);
            if(figura.isValid())
            {
                mostrarCoordenadas("cuadrado");
                Console.WriteLine($"El area del cuadrado es: {figura.area()}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Las coordenadas ingresadas no se corresponden a un cuadrado");
            }
            break;
    }

    if (opcion == 4)
    {
        Console.WriteLine("Exit");
        break;
    }
    Console.Write("\nPresione una tecla para continuar...");
    Console.ReadLine();
}