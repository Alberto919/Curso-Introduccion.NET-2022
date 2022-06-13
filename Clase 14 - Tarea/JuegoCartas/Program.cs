using JuegoCartas.clases;


Baraja baraja = new Baraja();

while (true)
{
    Console.Clear();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("         Juego de cartas");
    Console.WriteLine("---------------------------------");
    Console.WriteLine();
    Console.WriteLine("1. Barajar");
    Console.WriteLine("2. Mostrar siguiente carta");
    Console.WriteLine("3. Mostrar cartas disponibles");
    Console.WriteLine("4. Dar cartas");
    Console.WriteLine("5. Mostrar cartas del monton");
    Console.WriteLine("6. Mostrar baraja");
    Console.WriteLine("7. Salir");
    Console.WriteLine();
    Console.Write("Ingresá una opción: ");
    var opcion = int.Parse(Console.ReadLine());
    Console.WriteLine();

    switch (opcion)
    {
        case 1:
            baraja.Barajar();
            Console.WriteLine("Maso barajado");
            break;
        case 2:
            baraja.SiguienteCarta();
            break;
        case 3:
            Console.WriteLine($"Cartas disponibles: {baraja.CartasDisponibles()}");
            break;
        case 4:
            Console.Write("Ingresá la cantidad de cartas a dar: ");
            var cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine();
            baraja.DarCartas(cantidad);
            break;
        case 5:
            baraja.CartasMonton();
            break;
        case 6:
            baraja.MostrarBaraja();
            break;
    }

    if (opcion == 7)
    {
        Console.WriteLine("Fin del juego!");
        break;
    }
    Console.Write("\nPresione una tecla para continuar...");
    Console.ReadLine();
}