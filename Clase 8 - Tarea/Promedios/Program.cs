int filas = 0;
int columnas = 0;

Console.Clear();
Console.WriteLine("-----------------------------------");
Console.WriteLine(" Ingresá la dimensión de la matriz");
Console.WriteLine("-----------------------------------");
Console.WriteLine();

Console.Write("Ingresa la cantidad de filas: ");
filas = int.Parse(Console.ReadLine());

Console.Write("Ingresa la cantidad de columnas: ");
columnas = int.Parse(Console.ReadLine());

//Creamos la matriz
int[,] datos = new int[filas, columnas];

//Creamos el vector de promedios
double[] promedios = new double[columnas];

Console.WriteLine();
Console.WriteLine("-----------------------------------");
Console.WriteLine(" Ingresá los valores de la matriz");
Console.WriteLine("-----------------------------------");

for (int row = 0; row <= datos.GetUpperBound(0); row++)
{
    for (int column = 0; column <= datos.GetUpperBound(1); column++)
    {
        Console.Write($"[{row + 1},{column + 1}] = ");
        datos[row, column] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();
Console.WriteLine("-----------------------------------");
Console.WriteLine(" valores Ingresados");
Console.WriteLine("-----------------------------------");
Console.WriteLine();

for (int row = 0; row <= datos.GetUpperBound(0); row++)
{
    Console.Write("|".PadRight(5));
    for (int column = 0; column <= datos.GetUpperBound(1); column++)
    {
        Console.Write(datos[row, column].ToString().PadRight(10));
        Console.Write("|".PadRight(5));
    }
    Console.WriteLine();
}

for (int column = 0; column <= datos.GetUpperBound(1); column++)
{
    for (int row = 0; row <= datos.GetUpperBound(0); row++)
    {
        promedios[column] += datos[row, column];
    }
    promedios[column] /= (datos.GetUpperBound(0) + 1);
}

Console.WriteLine();
Console.WriteLine("-----------------------------------");
Console.WriteLine(" Promedios");
Console.WriteLine("-----------------------------------");
Console.WriteLine();


Console.Write("|".PadRight(5));
for (int column = 0; column <= datos.GetUpperBound(1); column++)
{
    Console.Write(Math.Round(promedios[column], 2).ToString().PadRight(10));
    Console.Write("|".PadRight(5));
}
Console.WriteLine();
Console.ReadKey();
