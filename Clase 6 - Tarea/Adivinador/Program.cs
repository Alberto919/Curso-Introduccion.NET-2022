int numeroIngresado = 0;
int intentos = 0;
const int limiteIntentos = 5;
bool adivino = false;
int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
Console.Clear();
Console.WriteLine($"Adivina el número secreto, tenes {limiteIntentos} intentos!");
while ((intentos < limiteIntentos) && adivino == false)
{
    intentos++;        
    Console.Write("Ingresá un número: ");
    numeroIngresado = int.Parse(Console.ReadLine());
    if(numeroIngresado == numeroSecreto){
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era:  {numeroSecreto}");
        Console.WriteLine($"Lo has logrado en {intentos} intentos!!");
        adivino = true;
    }
    if(numeroIngresado < numeroSecreto){
        Console.WriteLine($"El número ingresado es menor al número secreto");
    }
    if(numeroIngresado > numeroSecreto){
        Console.WriteLine($"El número ingresado es mayor al número secreto");
    }
    if(intentos == limiteIntentos){
        Console.WriteLine($"Superaste el limite de intentos, el número secreto es {numeroSecreto}");
    }
    Console.WriteLine("--------------------------");
}



