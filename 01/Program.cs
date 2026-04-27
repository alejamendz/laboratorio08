Console.WriteLine("Ingrese la cantidad de zonas (filas): ");
int zonas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de días (columnas): ");
int diasT = int.Parse(Console.ReadLine());

double[,] temp = new double[zonas, diasT];

for (int i = 0; i < zonas; i++)
{
    for (int j = 0; j < diasT; j++)
    {
        Console.Write($"Zona {i + 1}, Día {j + 1}: ");
        temp[i, j] = double.Parse(Console.ReadLine());
    }
}






