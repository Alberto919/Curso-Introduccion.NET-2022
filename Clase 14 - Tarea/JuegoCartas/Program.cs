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
    Console.WriteLine("2. Siguiente carta");
    Console.WriteLine("3. Cartas disponibles");    
    Console.WriteLine("4. Dar cartas");
    Console.WriteLine("5. Cartas del monton");
    Console.WriteLine("6. Mostrar baraja");
    Console.WriteLine("7. Salir");
    Console.WriteLine();  
    Console.WriteLine("Ingresá una opción: ");
    var opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:        
            baraja.Barajar();
            Console.WriteLine("Barajada");
            break;
        case 2:
            var carta = baraja.SiguienteCarta();
            if (carta == null)
            {
                Console.WriteLine("No hay cartas");
            }
            else
            {
                Console.WriteLine($"Carta: {carta.Numero} de {carta.Palo}");
            }            
            break;
        case 3:
            Console.WriteLine($"Cartas disponibles: {baraja.CartasDisponibles()}");
            break;
        case 4:
            Console.WriteLine("Ingresá la cantidad de cartas a dar: ");
            var cantidad = int.Parse(Console.ReadLine());
            baraja.DarCartas(cantidad);
            break;
        case 5:
            baraja.CartasMonton();
            break;
        case 6:
            baraja.MostrarBaraja();
            break;
    }

    if(opcion == 7){
        Console.WriteLine("Fin del juego!");
        break;
    }    
    Console.WriteLine("Presione una tecla para continuar...");
    Console.ReadLine();
}