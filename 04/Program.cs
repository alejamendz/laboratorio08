Console.WriteLine("Ingrese estudiantes: ");
int estudiantes= int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese evaluaciones: ");
int evaluaciones= int.Parse(Console.ReadLine());


double[,] calificaciones = new double[estudiantes, evaluaciones];
double notaMax = 0;
for (int i=0; i<estudiantes; i++)
{
    for(int j=0; j<evaluaciones; j++)
    {
        Console.Write($"Estudiante: {i + 1}, nota: {j + 1}: ");
        calificaciones[i, j] = double.Parse(Console.ReadLine());
        if (calificaciones[i, j] > notaMax)
        {
            notaMax = calificaciones[i, j];
        }
    }
}
Console.WriteLine($"La calificación más alta es: {notaMax}");
