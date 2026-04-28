Console.WriteLine("Ingrese numero de jugadores ");
int jugadores = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese numero de niveles");
int niveles = int.Parse(Console.ReadLine());

int[,] scores = new int[jugadores, niveles];
int topScore = 0;

for (int i = 0; i < jugadores; i++)
{
    for (int j = 0; j < niveles; j++)
    {
        Console.Write($"Jugador {i + 1}, Nivel {j + 1}: ");
        scores[i, j] = int.Parse(Console.ReadLine());
        if (scores[i, j] > topScore)
        {
            topScore = scores[i, j];
        }
    }
}
Console.WriteLine($"El puntaje mas alto: {topScore}");