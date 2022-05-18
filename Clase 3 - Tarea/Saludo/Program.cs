string NombreIngresado = string.Empty;
const string SI = "S";
const string NO = "N";
string Continuar = SI;

while (Continuar == SI)
{    
    while (NombreIngresado.Length == 0)
    {
        Console.Clear();
        Console.Write("Ingresá tu nombre: ");
        NombreIngresado = Console.ReadLine();
        Console.WriteLine(String.Format("¡Hola {0}!", NombreIngresado));
    }
    
    Console.Write("Querés continuar (S/N): ");
    Continuar = Console.ReadLine().ToUpper();

    if (Continuar == NO)
    {
        Console.Write("Programa finalizado correctamente");
    }
    else if (Continuar != SI)
    {
        Console.Write("Opcion no valida");
        Continuar = NO;
    }
    NombreIngresado = string.Empty;
}
