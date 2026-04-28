Console.WriteLine("Ingrese estudiantes: ");
int estudiantes = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese dias ");
int dias = int.Parse(Console.ReadLine());


int[,] asist = new int[estudiantes, dias];

for (int i = 0; i < estudiantes; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write($"Estudiante {i}, Día {j}: ");
        asist[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.Write("Seleccione el estudiante ");
int sel = int.Parse(Console.ReadLine());

Console.Write("Registro: ");
for (int j = 0; j <dias; j++)
{
    if (asist[sel, j] == 1)
    {
        Console.Write("Presente ");
    }
    else
    {
        Console.Write("Ausente ");
    }
}
Console.WriteLine();