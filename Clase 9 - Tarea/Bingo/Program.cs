﻿const int FILAS = 3;
const int COLUMNAS = 9;
const int NUMEROS_CARTON = 15;
int[,] values = new int[FILAS, COLUMNAS];

Console.Clear();
Console.WriteLine("----------------------------------------------");
Console.WriteLine("              Cartón de Bingo");
Console.WriteLine("----------------------------------------------");

//Generar los valores del bingo
var random = new Random();
var contadorNumeros = 0;

while (contadorNumeros != NUMEROS_CARTON)
{
    values = new int[FILAS, COLUMNAS];
    contadorNumeros = 0;
    for (int col = 0; col < COLUMNAS; col++)
    {
        var filaA = random.Next(0, 3);
        var filaB = random.Next(0, 3);
        var salir = false;

        int aleatorioA = random.Next((col == 0 ? 1 : col * 10), (col + 1) * 10);
        int aleatorioB = 0;

        salir = false;
        while (!salir)
        {
            aleatorioB = random.Next((col == 0 ? 1 : col * 10), (col + 1) * 10);
            if (aleatorioA != aleatorioB)
            {
                if (aleatorioA > aleatorioB)
                {
                    var aux = aleatorioA;
                    aleatorioA = aleatorioB;
                    aleatorioB = aux;
                }
                salir = true;
            }
        }

        values[filaA, col] = aleatorioA;
        contadorNumeros++;
        if ((filaB != filaA) && (contadorNumeros < 15))
        {
            contadorNumeros++;
            values[filaB, col] = aleatorioB;
        }
    }
}


//Graficamos el bingo generado
Console.WriteLine();
Console.WriteLine("╔════╦════╦════╦════╦════╦════╦════╦════╦════╗");

for (int row = 0; row < FILAS; row++)
{
    for (int col = 0; col < COLUMNAS; col++)
    {
        var contenido = (values[row, col].ToString().Length == 1 ? "0" + values[row, col].ToString() : values[row, col].ToString());
        Console.Write("║ " + (contenido == "00" ? "▓▓" : contenido) + " ");
    }

    Console.WriteLine("║");

    if (row < 2)
    {
        Console.WriteLine("╠════╬════╬════╬════╬════╬════╬════╬════╬════╣");
    }
    else
    {
        Console.WriteLine("╚════╩════╩════╩════╩════╩════╩════╩════╩════╝");
    }
}
Console.WriteLine();