Console.WriteLine("Inicio del Programa");

//Variables
int numero, suma = 0;

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Numero {i}:");
    numero = Convert.ToInt32(Console.ReadLine());
    suma = suma + numero;
}

Console.WriteLine($"La suma es: {suma}");
Console.WriteLine("\nFin del Programa");