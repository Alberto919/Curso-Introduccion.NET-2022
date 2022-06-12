using Billeteras;

var random = new Random();

Console.Clear();
Console.WriteLine("----------------------------------------------");
Console.WriteLine("              Billetera A");
Console.WriteLine("----------------------------------------------");

var billeteraA = new Billetera()
{
    BilleteDe10 = random.Next(0, 10),
    BilleteDe20 = random.Next(0, 10),
    BilleteDe50 = random.Next(0, 10),
    BilleteDe100 = random.Next(0, 10),
    BilleteDe200 = random.Next(0, 10),
    BilleteDe500 = random.Next(0, 10),
    BilleteDe1000 = random.Next(0, 10)
};

billeteraA.MostrarBilletera();
Console.WriteLine($"Total: {billeteraA.Total()}");

Console.WriteLine();
Console.WriteLine("----------------------------------------------");
Console.WriteLine("              Billetera B");
Console.WriteLine("----------------------------------------------");

var billeteraB = new Billetera()
{
    BilleteDe10 = random.Next(0, 10),
    BilleteDe20 = random.Next(0, 10),
    BilleteDe50 = random.Next(0, 10),
    BilleteDe100 = random.Next(0, 10),
    BilleteDe200 = random.Next(0, 10),
    BilleteDe500 = random.Next(0, 10),
    BilleteDe1000 = random.Next(0, 10)
};

billeteraB.MostrarBilletera();
Console.WriteLine($"Total: {billeteraB.Total()}");

Console.WriteLine();
Console.WriteLine("----------------------------------------------");
Console.WriteLine("              Billetera Combinada");
Console.WriteLine("----------------------------------------------");

var billeteraCombinada = billeteraA.Combinar(billeteraB);

billeteraCombinada.MostrarBilletera();
billeteraA.VaciarBilletera();
billeteraB.VaciarBilletera();
Console.WriteLine($"Total: {billeteraCombinada.Total()}");
Console.WriteLine();
Console.WriteLine("----------------------------------------------");
Console.WriteLine($"Billetera A - Total: {billeteraA.Total()}");
Console.WriteLine($"Billetera B - Total: {billeteraB.Total()}");
Console.WriteLine("----------------------------------------------");