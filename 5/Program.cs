Console.Write("Filas del estante: ");
int filas = int.Parse(Console.ReadLine());

Console.Write("Columnas del estante: ");
int columnas = int.Parse(Console.ReadLine());

int[,] inventario = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write($"Posicion [{i},{j}]: ");
        inventario[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.Write("Ccantidad que se va buscar: ");
int buscar = int.Parse(Console.ReadLine());
bool encontrado = false;

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        if (inventario[i, j] == buscar)
        {
            Console.WriteLine($"Esta en: {i}, {j}");
            encontrado = true;
        }
    }
}
if (!encontrado)
{
    Console.WriteLine("El valor no existe en el inventario.");
}