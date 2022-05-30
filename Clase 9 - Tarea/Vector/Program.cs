int longitud = 0;

Console.Clear();
Console.WriteLine("-----------------------------------");
Console.WriteLine(" Ingresá la longitud del vector");
Console.WriteLine("-----------------------------------");
Console.WriteLine();

longitud = int.Parse(Console.ReadLine());

//Creamos el vector
int[] vector = new int[longitud];

var numeroRamdom = new Random();

//Llenar el vector con datos aleatorios
for (int i = 0; i < longitud; i++)
{
    vector[i] = numeroRamdom.Next(0, 100);
}
Console.WriteLine();
Console.WriteLine("-----------------------------------");
Console.WriteLine(" Vector resultante");
Console.WriteLine("-----------------------------------");
Console.WriteLine();
for (int i = 0; i < longitud; i++)
{
    Console.WriteLine($"vector[{i}]: {vector[i]}");
}

var aux = 0;
for (int i = 0; i < longitud; i++)
{
    if (i < (longitud/2))
    {
        aux = vector[i];
        vector[i] = vector[(longitud - 1) - i];
        vector[(longitud - 1) - i] = aux;
    }
}
Console.WriteLine();
Console.WriteLine("-----------------------------------");
Console.WriteLine(" Vector resultante invertido");
Console.WriteLine("-----------------------------------");
Console.WriteLine();

for (int i = 0; i < longitud; i++)
{
    Console.WriteLine($"vector[{i}]: {vector[i]}");
}


