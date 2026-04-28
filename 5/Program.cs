Console.WriteLine("Filas del estante: ");
int filas = int.Parse(Console.ReadLine());

Console.WriteLine("Columnas del estante: ");
int columnas = int.Parse(Console.ReadLine());

int[,] inventario = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.WriteLine($"Posicion [{i},{j}]: ");
        inventario[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Ccantidad que se va buscar: ");
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