Console.WriteLine("Ingrese numero de maquinas: ");
int maquinas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese numero de turnos ");
int turnos = int.Parse(Console.ReadLine());

int[,] prod = new int[maquinas, turnos];
int prodTotal = 0;

for (int i = 0; i < maquinas; i++)
{
    for (int j = 0; j < turnos; j++)
    {
        Console.Write($"Máquina {i + 1}, Turno {j + 1}: ");
        prod[i, j] = int.Parse(Console.ReadLine());
        prodTotal += prod[i, j];
    }
}
Console.WriteLine($"Producción total de la fábrica: {prodTotal} unidades.");