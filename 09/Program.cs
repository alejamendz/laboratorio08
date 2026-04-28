Console.WriteLine("Ingrese las filas de la matriz");
int filas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese las columnas de la matriz: ");
int columnas= int.Parse(Console.ReadLine());

string[,] matriz = new string[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write($"Error en [{i},{j}]: ");
        matriz[i, j] = Console.ReadLine();
    }
}

Console.WriteLine("Error a buscar: ");
string buscaErr = Console.ReadLine();

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        if (matriz[i, j] == buscaErr)
        {
            Console.WriteLine($"Error '{buscaErr}' esta en: {i},{j}");
        }
    }
}