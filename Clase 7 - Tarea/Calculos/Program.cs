const int ARRAY_LENGHT = 10;
int[] numeroIngresados = new int[ARRAY_LENGHT];
int suma = 0;
int mayor = 0;
int menor = 0;
float promedio = 0;

for (int i = 0; i < ARRAY_LENGHT; i++)
{
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine($"Ingresa {ARRAY_LENGHT} valores");
    Console.WriteLine("---------------------------------");
    Console.Write($"valor {i+1}: ");
    numeroIngresados[i] = int.Parse(Console.ReadLine());       
}

Console.Clear();
Console.WriteLine("---------------------------------");
Console.WriteLine("Números ingresados");
Console.WriteLine("---------------------------------");

// Inicializo las variables
menor = numeroIngresados[0];
mayor = numeroIngresados[0];

for (int i = 0; i < ARRAY_LENGHT; i++)
{
    suma = suma + numeroIngresados[i];
    if (mayor < numeroIngresados[i]){
        mayor = numeroIngresados[i];
    }
    if (menor > numeroIngresados[i]){
        menor = numeroIngresados[i];
    } 
    Console.WriteLine($"número[{i+1}] = {numeroIngresados[i]}");
}

//Calculo el promedio
promedio = (float)suma / (float)ARRAY_LENGHT;

Console.WriteLine("---------------------------------");
Console.WriteLine($"Suma total     : {suma}");
Console.WriteLine($"El mayor es    : {mayor}");
Console.WriteLine($"El menor es    : {menor}");
Console.WriteLine($"El promedio es : {promedio}");
Console.WriteLine("---------------------------------");