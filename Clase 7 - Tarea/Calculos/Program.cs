const int ARRAY_LENGHT = 10;
int[] numeroIngresados = new int[ARRAY_LENGHT];
int suma = 0;
int mayor = 0;
int menor = 0;
float promedio = 0;

for (int i = 0; i < ARRAY_LENGHT; i++)
{
    Console.Clear();
    Console.WriteLine($"Ingresa {ARRAY_LENGHT} valores");
    Console.Write($"valor {i}: ");
    numeroIngresados[i] = int.Parse(Console.ReadLine());
    suma += numeroIngresados[i];
    if (mayor < numeroIngresados[i]){
        mayor = numeroIngresados[i];
    }
    if (menor > numeroIngresados[i]){
        menor = numeroIngresados[i];
    }
    promedio = suma / ARRAY_LENGHT;
}

Console.WriteLine("Números ingresados:");
for (int i = 0; i < ARRAY_LENGHT; i++)
{
    Console.WriteLine($"número[{i}] = {numeroIngresados[i]}");
}
Console.WriteLine($"Suma total     : {suma}");
Console.WriteLine($"El mayor es    : {mayor}");
Console.WriteLine($"El menor es    : {menor}");
Console.WriteLine($"El promedio es : {promedio}");